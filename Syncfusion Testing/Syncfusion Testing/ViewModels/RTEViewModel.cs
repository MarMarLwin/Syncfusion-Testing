using Syncfusion.XForms.RichTextEditor;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace Syncfusion_Testing.ViewModels
{
    public class RTEViewModel : INotifyPropertyChanged
    {
        Stream boogalooFontStream, handleeFontStream, kaushanFontStream, pinyonFontStream, robotoFontStream;
        public ICommand FontCommand { get; set; }
        public ICommand ImageCommand { get; set; }

        public RTEViewModel()
        {
            var assembly = Assembly.GetAssembly(Application.Current.GetType());
#if COMMONSB
            boogalooFontStream = assembly.GetManifestResourceStream("SampleBrowser.Samples.RichTextEditor.Fonts.Boogaloo.ttf");
            handleeFontStream = assembly.GetManifestResourceStream("SampleBrowser.Samples.RichTextEditor.Fonts.Handlee.ttf");
            kaushanFontStream = assembly.GetManifestResourceStream("SampleBrowser.Samples.RichTextEditor.Fonts.Kaushan Script.ttf");
            pinyonFontStream = assembly.GetManifestResourceStream("SampleBrowser.Samples.RichTextEditor.Fonts.Pinyon Script.ttf");
            robotoFontStream = assembly.GetManifestResourceStream("SampleBrowser.Samples.RichTextEditor.Fonts.Roboto-Regular.ttf");
#else
            boogalooFontStream = assembly.GetManifestResourceStream("SampleBrowser.SfRichTextEditor.Fonts.Boogaloo.ttf");
            handleeFontStream = assembly.GetManifestResourceStream("SampleBrowser.SfRichTextEditor.Fonts.Handlee.ttf");
            kaushanFontStream = assembly.GetManifestResourceStream("SampleBrowser.SfRichTextEditor.Fonts.Kaushan Script.ttf");
            pinyonFontStream = assembly.GetManifestResourceStream("SampleBrowser.SfRichTextEditor.Fonts.Pinyon Script.ttf");
            robotoFontStream = assembly.GetManifestResourceStream("SampleBrowser.SfRichTextEditor.Fonts.Roboto-Regular.ttf");
#endif
            ImageCommand = new Command<object>(LoadImage);
            FontCommand = new Command<object>(LoadFonts);
        }

        void LoadFonts(object obj)
        {
            FontButtonClickedEventArgs fontEventArgs = (obj as FontButtonClickedEventArgs);
            if (!fontEventArgs.FontStreamCollection.ContainsKey("Boogaloo"))
                fontEventArgs.FontStreamCollection.Add("Boogaloo", boogalooFontStream);
            if (!fontEventArgs.FontStreamCollection.ContainsKey("Handlee"))
                fontEventArgs.FontStreamCollection.Add("Handlee", handleeFontStream);
            if (!fontEventArgs.FontStreamCollection.ContainsKey("Kaushan Script"))
                fontEventArgs.FontStreamCollection.Add("Kaushan Script", kaushanFontStream);
            if (!fontEventArgs.FontStreamCollection.ContainsKey("Pinyon Script"))
                fontEventArgs.FontStreamCollection.Add("Pinyon Script", pinyonFontStream);
        }

        void LoadImage(object obj)
        {
            ImageInsertedEventArgs imageInsertedEventArgs = (obj as ImageInsertedEventArgs);
            this.GetImage(imageInsertedEventArgs);
        }

        async void GetImage(ImageInsertedEventArgs imageInsertedEventArgs)
        {
            //using (Stream imageStream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync())
            //{
            //    if (imageStream != null)
            //    {
            //        Syncfusion.XForms.RichTextEditor.ImageSource imageSource = new Syncfusion.XForms.RichTextEditor.ImageSource();
            //        imageSource.ImageStream = imageStream;
            //        imageInsertedEventArgs.ImageSourceCollection.Add(imageSource);
            //    }
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
