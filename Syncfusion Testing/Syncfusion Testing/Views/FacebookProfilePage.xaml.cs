using Syncfusion_Testing.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syncfusion_Testing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookProfilePage : ContentPage
    {
        private string ClientId = "229968058337796";
        public FacebookProfilePage()
        {
            InitializeComponent();
            var apiRequest =
               "https://www.facebook.com/dialog/oauth?client_id="
               + ClientId
               + "&display=popup&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";

            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebViewOnNavigated;

            Content = webView;
        }
        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {

            var accessToken = ExtractAccessTokenFromUrl(e.Url);

            if (accessToken != "")
            {
                var vm = BindingContext as FacebookViewmodel;

                await vm.SetFacebookUserProfileAsync(accessToken);

                Content = MainStackLayout;
            }
        }

        [Obsolete]
        private string ExtractAccessTokenFromUrl(string url)
        {
            //if (url.Contains("access_token") && url.Contains("&expires_in="))
            //{
            //    var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");

            //    if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
            //    {
            //        at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");
            //    }

            //    var accessToken = at.Remove(at.IndexOf("&expires_in="));

            //    return accessToken;
            //}

            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var at = url.Replace("https://web.facebook.com/connect/login_success.html?_rdc=1&_rdr#access_token=", "");

                if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
                {
                    at = url.Replace("https://web.facebook.com/connect/login_success.html?_rdc=1&_rdr#access_token=", "");
                }

                var accessToken = at.Remove(at.IndexOf("&data_access_expiration_time="));

                return accessToken;
            }
            return string.Empty;
        }
    }
}