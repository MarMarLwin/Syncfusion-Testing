using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion_Testing.Services;
using Syncfusion_Testing.Views;

namespace Syncfusion_Testing
{
    public partial class App : Application
    {
        private String databasePath=string.Empty;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
           // MainPage = new MainPage();
            //MainPage = new NavigationPage(new BusyIndicator());
            MainPage = new NavigationPage(new TabletTestPage());
        }

        public App(String databasepath)
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            // MainPage = new NavigationPage(new BusyIndicator());
            MainPage = new NavigationPage(new TabletTestPage());
            this.databasePath = databasepath;
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
