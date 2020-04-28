using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Syncfusion_Testing.Models;

namespace Syncfusion_Testing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            // MasterBehavior = MasterBehavior.Popover;

            //Detail = new NavigationPage(new TabViewPage());
            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
           // MenuPages.Add((int)MenuItemType.BusyIndicator, new NavigationPage(new BusyIndicator()));

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.BusyIndicator:
                        MenuPages.Add(id, new NavigationPage(new BusyIndicator()));
                        break;
                    case (int)MenuItemType.TabView:
                        MenuPages.Add(id, new NavigationPage(new TabViewPage()));
                        break;
                    case (int)MenuItemType.RichTextEditor:
                        MenuPages.Add(id, new NavigationPage(new RichTextEditor()));
                        break;
                    case (int)MenuItemType.Chart:
                        MenuPages.Add(id, new NavigationPage(new ChartTabbedPage()));
                        break;
                    case (int)MenuItemType.Schedule:
                        MenuPages.Add(id, new NavigationPage(new Schedule()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemDetailPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(50);

                IsPresented = false;
            }
        }
    }

   
}