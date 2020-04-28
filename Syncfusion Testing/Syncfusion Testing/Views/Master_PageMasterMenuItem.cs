using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion_Testing.Views
{

    public class Master_PageMasterMenuItem
    {
        public Master_PageMasterMenuItem()
        {
            TargetType = typeof(Master_PageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}