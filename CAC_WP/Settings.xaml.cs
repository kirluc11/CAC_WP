using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace CAC_WP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                e.Handled = true;
                Frame.GoBack();
            }
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "de-AT")
            {
                btChangeToGerman.IsEnabled = false;
            }
            else
            {
                btChangeToEnglish.IsEnabled = false;
            }


            tbBTinfo.TextWrapping = TextWrapping.WrapWholeWords;
            tbBTinfo.FontSize = 25;
            tbBTinfo.TextAlignment = TextAlignment.Center;
            tbBTinfo.VerticalAlignment = VerticalAlignment.Center;
        }

        private async void onToGerman(object sender, RoutedEventArgs e)
        {
            MessageDialog m = new MessageDialog("Wir schließen die App jetzt.\nNach einem Neustart ist die Sprache geändert.", "Bis bald!");
            m.Commands.Add(new UICommand("schließen"));
            m.Commands.Add(new UICommand("abbrechen"));
            var result = await m.ShowAsync();
            if (result.Label == "schließen")
            {
                Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "de-AT";
                Application.Current.Exit();
            }
            else
            {
                return;
            }
        }

        private async void onToEnglish(object sender, RoutedEventArgs e)
        {
            MessageDialog m = new MessageDialog("We close the app now.\nAfter restarting you'll see the new language.", "See you soon!");
            m.Commands.Add(new UICommand("close"));
            m.Commands.Add(new UICommand("cancel"));
            var result=await m.ShowAsync();
            if(result.Label == "close")
            {
                Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";
                Application.Current.Exit();
            }
            else
            {
                return;
            }
        }

        private async void onOpenBTSettings(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings-bluetooth:"));
        }
    }
}
