using System;
using System.Collections.Generic;
using System.Text;

namespace Syncfusion_Testing.ViewModels
{
    public class MonthDemand
    {
        public MonthDemand(string demand, double year2010, double year2011)
        {

            this.Demand = demand;

            this.Year2010 = year2010;

            this.Year2011 = year2011;

        }

        public string Demand { get; set; }

        public double Year2010 { get; set; }

        public double Year2011 { get; set; }
    }
}
