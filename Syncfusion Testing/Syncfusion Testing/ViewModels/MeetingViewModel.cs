using Syncfusion_Testing.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Syncfusion_Testing.ViewModels
{
    public class MeetingViewModel
    {
      
        public ObservableCollection<Meeting> Meetings { get; set; }
        public MeetingViewModel()
        {
            Random random = new Random();
            Meetings = new ObservableCollection<Meeting>();
            Meetings.Add(new Meeting("Customer Meet"));
        }
    }
}
