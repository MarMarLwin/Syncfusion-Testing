using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syncfusion_Testing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master_PageMaster : ContentPage
    {
        public ListView ListView;

        public Master_PageMaster()
        {
            InitializeComponent();

            BindingContext = new Master_PageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class Master_PageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Master_PageMasterMenuItem> MenuItems { get; set; }

            public Master_PageMasterViewModel()
            {
                MenuItems = new ObservableCollection<Master_PageMasterMenuItem>(new[]
                {
                    new Master_PageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new Master_PageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new Master_PageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new Master_PageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new Master_PageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}