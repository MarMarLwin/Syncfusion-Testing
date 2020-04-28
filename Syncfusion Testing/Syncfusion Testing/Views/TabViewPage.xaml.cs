using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syncfusion_Testing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabViewPage : ContentPage
    {
        public TabViewPage()
        {
            InitializeComponent();
        }

		private void tabView_SelectionChanged(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
		{
			var selectedIndex = e.Index;
		}
	}
	public class ContactInfo
	{
		public string Name { get; set; }
		public long Number { get; set; }
	}

	public class ContactsViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<ContactInfo> contactList;
		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<ContactInfo> ContactList
		{
			get { return contactList; }
			set { contactList = value; }
		}
		public ContactsViewModel()
		{
			ContactList = new ObservableCollection<ContactInfo>();
			ContactList.Add(new ContactInfo { Name = "Aaron", Number = 7363750 });
			ContactList.Add(new ContactInfo { Name = "Adam", Number = 7323250 });
			ContactList.Add(new ContactInfo { Name = "Adrian", Number = 7239121 });
			ContactList.Add(new ContactInfo { Name = "Alwin", Number = 2329823 });
			ContactList.Add(new ContactInfo { Name = "Alex", Number = 8013481 });
			ContactList.Add(new ContactInfo { Name = "Alexander", Number = 7872329 });
			ContactList.Add(new ContactInfo { Name = "Barry", Number = 7317750 });
		}
	}

}