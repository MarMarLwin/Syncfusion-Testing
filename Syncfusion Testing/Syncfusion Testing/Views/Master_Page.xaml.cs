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
    public partial class Master_Page : MasterDetailPage
    {
        public Master_Page()
        {
            InitializeComponent();
            // MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage(new ChartTabbedPage());
            bind_menu_link();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Master_PageMasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            //MasterPage.ListView.SelectedItem = null;
        }

        void bind_menu_link()
        {
            List<MenuItems> the_menu_list = new List<MenuItems>();

            the_menu_list.Add(new MenuItems { OptionName = MenuItemType.BusyIndicator.ToString(), OptionCode = MenuItemType.BusyIndicator.ToString(),iconImage="star.png" });
            the_menu_list.Add(new MenuItems { OptionName = MenuItemType.Chart.ToString(), OptionCode = MenuItemType.Chart.ToString(), iconImage = "star.png" });
            the_menu_list.Add(new MenuItems { OptionName = MenuItemType.Schedule.ToString(), OptionCode = MenuItemType.Schedule.ToString(), iconImage = "star.png" });
            the_menu_list.Add(new MenuItems { OptionName = MenuItemType.RichTextEditor.ToString(), OptionCode = "RichTextEditor", iconImage = "star.png" });
            the_menu_list.Add(new MenuItems { OptionName = MenuItemType.TabView.ToString(), OptionCode = MenuItemType.TabView.ToString(), iconImage = "star.png" });
            BindableLayout.SetItemsSource(MenuList, the_menu_list);

        }

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Alert!", "Are yor sure want to exit?", "Yes", "No");
                if (result)
                {
                    //System.Threading.Thread.CurrentThread.Abort();
                    //base.OnBackButtonPressed();
                    System.Environment.Exit(0);
                }
            });
            return true;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var args = (TappedEventArgs)e;
            var OptionName = args.Parameter;
            switch (OptionName.ToString())
            {
                case "BusyIndicator":
                    {
                        Detail = new NavigationPage(new BusyIndicator());
                        IsPresented = false;
                    }
                    break;
                case "Chart":
                    {
                        Detail = new NavigationPage(new ChartTabbedPage());
                        IsPresented = false;
                    }
                    break;
                case "RichTextEditor":
                    {
                        Detail = new NavigationPage(new RichTextEditor());
                        IsPresented = false;
                    }
                    break;
                case "Schedule":
                    {
                        Detail = new NavigationPage(new Schedule());
                        IsPresented = false;
                    }
                    break;
                case "TabView":
                    {
                        Detail = new NavigationPage(new TabViewPage());
                        IsPresented = false;
                    }
                    break;

            }
        }

        public class MenuItems
        {
            public string OptionName { get; set; }
            public string OptionCode { get; set; }
            public string iconImage { get; set; }
        }

    }
}