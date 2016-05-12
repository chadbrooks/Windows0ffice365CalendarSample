using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WindowsCalendarSample.Helpers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsCalendarSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Developer code - if you haven't registered the app yet, we warn you. 
            if (!App.Current.Resources.ContainsKey("ida:ClientId"))
            {
                MessageDialogHelper.ShowDialogAsync("To run this sample, you must register it with Office 365. You can do that through the 'Add | Connected services' dialog in Visual Studio. See Readme for more info", "Oops - App not registered with Office 365");
            }

            // Set up the binding for the Signin button
            this.DataContext = App.CurrentUser;
        }

        private void TextControls_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.CalendarBody = txtBody.Text;
            App.Location = txtLocation.Text;
            App.Attendees = txtAttendees.Text;
            App.EventName = txtEventName.Text;
            App.DurationInMinutes = txtDurationInMinutes.Text;
        }
    }
}
