﻿using Syncfusion_Testing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syncfusion_Testing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.BusyIndicator, Title="BusyIndicator" },
                new HomeMenuItem {Id = MenuItemType.Chart, Title="Chart" },
                new HomeMenuItem {Id = MenuItemType.RichTextEditor, Title="RichTextEditor" },
                new HomeMenuItem {Id = MenuItemType.Schedule, Title="Schedule" },
                new HomeMenuItem{Id=MenuItemType.TabView,Title="TabView"},
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                
                if(RootPage!=null)
                 await RootPage.NavigateFromMenu(id);
                else
                {
                    MainPage main = new MainPage();
                    await main.NavigateFromMenu(id);
                }

            };
        }

    }
}