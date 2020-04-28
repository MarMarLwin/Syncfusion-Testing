using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Syncfusion_Testing.Models
{
    public class Meeting
    {
        public string EventName { get; set; }
       /* public DateTime From { get; set; }
        public DateTime To { get; set; }*/
        public Color Color { get; set; }
        public Meeting(String evName)
        {
            this.EventName = evName;
    }
    }

    
}

