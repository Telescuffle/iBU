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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace iBU
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Hamburger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            if (Home.IsSelected)
            {
                Test.Text = "Home";
            }

            else if (SelectProfile.IsSelected)
            {
                Test.Text = "Select Profile";
            }

            else if (PersonalDetails.IsSelected)
            {
                Test.Text = "Personal Details";
            }

            else if (PersonalAlerts.IsSelected)
            {
                Test.Text = "Personal Alerts";
            }

            else if (Feedback.IsSelected)
            {
                Test.Text = "Feedback";
            }

            else if (Share.IsSelected)
            {
                Test.Text = "Share";
            }

            else if (About.IsSelected)
            {
                Test.Text = "About";
            }

            else if (Terms.IsSelected)
            {
                Test.Text = "Terms";
            }

            else if (LogOut.IsSelected)
            {
                Test.Text = "Log Out";
            }
            */

            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchBar.IsPaneOpen = !SearchBar.IsPaneOpen;
        }
    }
}
