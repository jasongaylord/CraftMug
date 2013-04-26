using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CraftMug.Core.BeerMapping;
using Microsoft.Phone.Tasks;

namespace CraftMug.Phone
{
    public partial class LocationDetails : PhoneApplicationPage
    {
        public string LocationId { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            LocationId = NavigationContext.QueryString["id"];

            DisplayData();
        }


        public LocationDetails()
        {
            InitializeComponent();

            // Get the Location ID
            //LocationId = NavigationContext.QueryString["id"];
        
            //DisplayData();
        }

        private void DisplayData()
        {
            // Get the locations saved in state
            var locations = PhoneApplicationService.Current.State["BeerLocations"] as LocCity;

            // Display the data
            var location = locations.location.Where(w => w.id == int.Parse(LocationId)).Single<LocCityLocation>();

            // Top part
            locationType.Text = location.status;
            locationName.Text = location.name;

            // Next section
            phoneNumber.Content = location.phone;
            address.Content = location.street + "\n" + location.city + ", " + location.state + " " + location.zip;

            //firstimage
            //imagecount
            //overall
        }

        private void DialLocation(object sender, System.Windows.Input.GestureEventArgs e)
        {
            PhoneCallTask task = new PhoneCallTask();
            task.PhoneNumber = phoneNumber.Content.ToString();
            task.Show();
        }

        private void MapLocation(object sender, System.Windows.Input.GestureEventArgs e)
        {
            BingMapsTask task = new BingMapsTask();
            task.SearchTerm = address.Content.ToString().Replace("\n",", ");
            task.Show();
        }
    }
}