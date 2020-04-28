using Syncfusion_Testing.Models;
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
public partial class BusyIndicator : ContentPage
{
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
       
        public BusyIndicator()
    {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
          //  MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            //await Navigation.PopToRootAsync();
            // await Navigation.PopAsync();
            //Application.Current.MainPage = new NavigationPage(new MainPage());
            await Navigation.PushAsync(new Master_Page());
            //await NavigationPage
        }
        //public async Task NavigateFromMenu(int id)
        //{
        //    if (!MenuPages.ContainsKey(id))
        //    {
        //        switch (id)
        //        {
        //            case (int)MenuItemType.BusyIndicator:
        //                MenuPages.Add(id, new NavigationPage(new BusyIndicator()));
        //                break;
        //            case (int)MenuItemType.TabView:
        //                MenuPages.Add(id, new NavigationPage(new TabViewPage()));
        //                break;
        //            case (int)MenuItemType.RTE:
        //                MenuPages.Add(id, new NavigationPage(new RichTextEditor()));
        //                break;
        //            case (int)MenuItemType.Chart:
        //                MenuPages.Add(id, new NavigationPage(new ChartTabbedPage()));
        //                break;
        //            case (int)MenuItemType.Schedule:
        //                MenuPages.Add(id, new NavigationPage(new Schedule()));
        //                break;
        //            case (int)MenuItemType.Browse:
        //                MenuPages.Add(id, new NavigationPage(new ItemDetailPage()));
        //                break;
        //            case (int)MenuItemType.About:
        //                MenuPages.Add(id, new NavigationPage(new AboutPage()));
        //                break;
        //        }
        //    }

        //    var newPage = MenuPages[id];

        //    if (newPage != null && Detail != newPage)
        //    {
        //        Detail = newPage;

        //        if (Device.RuntimePlatform == Device.Android)
        //            await Task.Delay(50);

        //        IsPresented = false;
        //    }
        //}
    //}
}
}