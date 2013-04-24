using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CraftMug.Phone
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();

            City.Text = PhoneApplicationService.Current.State["City"].ToString();
            State.Text = PhoneApplicationService.Current.State["State"].ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            PhoneApplicationService.Current.State["City"] = City.Text;
            PhoneApplicationService.Current.State["State"] = State.Text;

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}