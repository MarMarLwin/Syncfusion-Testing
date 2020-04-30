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
    public partial class FacebookLogin : ContentPage
    {       
        public FacebookLogin()
        {
            InitializeComponent();
            
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacebookProfilePage());
        }
    }
}