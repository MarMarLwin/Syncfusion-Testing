using System;
using System.Collections.Generic;
using System.Text;

namespace Syncfusion_Testing.Models
{
    public enum MenuItemType
    {  TabView,
        BusyIndicator,
        Chart,
        RichTextEditor,
        Schedule,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
