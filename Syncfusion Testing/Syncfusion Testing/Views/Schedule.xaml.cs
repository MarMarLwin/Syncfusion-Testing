using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syncfusion_Testing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Schedule : ContentPage
{
    public Schedule()
    {
        InitializeComponent();
            //schedule.ScheduleView = ScheduleView.WorkWeekView;
            ////Create new instance of WorkWeekViewSettings
            //WorkWeekViewSettings workWeekViewSettings = new WorkWeekViewSettings();
            //workWeekViewSettings.TimeSlotBorderColor = Color.Aqua;
            //workWeekViewSettings.VerticalLineColor = Color.Blue;
            //workWeekViewSettings.TimeSlotColor = Color.Yellow;
            //workWeekViewSettings.TimeSlotBorderStrokeWidth = 5;
            //workWeekViewSettings.VerticalLineStrokeWidth = 5;
            //schedule.WorkWeekViewSettings = workWeekViewSettings;

            schedule.ScheduleView = ScheduleView.WorkWeekView;

            //Create new instance of NonAccessibleBlock
            NonAccessibleBlock nonAccessibleBlock = new NonAccessibleBlock();
            //Create new instance of NonAccessibleBlocksCollection
            NonAccessibleBlocksCollection nonAccessibleBlocksCollection = new NonAccessibleBlocksCollection();
            WorkWeekViewSettings workWeekViewSettings = new WorkWeekViewSettings();
            nonAccessibleBlock.StartTime = 13;
            nonAccessibleBlock.EndTime = 14;
            nonAccessibleBlock.Text = "LUNCH";
            nonAccessibleBlock.Color = Color.GreenYellow;
            nonAccessibleBlocksCollection.Add(nonAccessibleBlock);
            workWeekViewSettings.NonAccessibleBlocks = nonAccessibleBlocksCollection;

            //Create new instance of SelectionStyle
            SelectionStyle selectionStyle = new SelectionStyle();
            selectionStyle.BackgroundColor = Color.Red;
            selectionStyle.BorderColor = Color.Black;
            selectionStyle.BorderThickness = 5;
            selectionStyle.BorderCornerRadius = 5;
            schedule.SelectionStyle = selectionStyle;


        }
}
}