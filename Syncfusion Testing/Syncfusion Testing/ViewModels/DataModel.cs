using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Syncfusion_Testing.ViewModels
{
    public class DataModel
    {
        public ObservableCollection<ChartDataPoint> HighTemperature { get; set; }
        public ObservableCollection<MonthDemand> Demands { get; set; }
        public DataModel()
        {

            Demands = new ObservableCollection<MonthDemand>();

            Demands.Add(new MonthDemand("Jan", 42, 27));
            Demands.Add(new MonthDemand("Feb", 44, 28));
            Demands.Add(new MonthDemand("Mar", 53, 35));
            Demands.Add(new MonthDemand("Apr", 64, 44));
            Demands.Add(new MonthDemand("May", 75, 54));
            Demands.Add(new MonthDemand("Jun", 83, 63));
            Demands.Add(new MonthDemand("Jul", 87, 68));
            Demands.Add(new MonthDemand("Aug", 84, 66));
            Demands.Add(new MonthDemand("Sep", 78, 59));
            Demands.Add(new MonthDemand("Oct", 67, 48));
            Demands.Add(new MonthDemand("Nov", 55, 38));
            Demands.Add(new MonthDemand("Dec", 45, 29));
        }
    }
}
