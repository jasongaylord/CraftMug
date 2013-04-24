using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CraftMug.Core;
using CraftMug.Core.Nokia;
using CraftMug.Core.BeerMapping;
using CraftMug.Core.Utilities;

namespace CraftMug.Phone
{
    public partial class MainPage : PhoneApplicationPage
    {
        GeoLocation location;
        Map map;
        BeerListings beer;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Change images based on theme
            if (!App.IsDarkTheme)
            {
                Logo.Source = new BitmapImage(new Uri("/Images/PhoneLogo-300-Dark.png", UriKind.Relative));
            }

            // Loads the resources
            StyleController.Initialize((FrameworkElement)this, App.Current.Resources);

            // Seed the GeoCoordinates in case the GeoCoordinateWatcher cannot work
            if (!PhoneApplicationService.Current.State.ContainsKey("GeoCoordinate"))
            {
                // TODO Seed these coordinates into the Location class
                GeoCoordinate coordNewYorkCity = new GeoCoordinate();
                coordNewYorkCity.Latitude = 40.7142;
                coordNewYorkCity.Longitude = -74.0064;
                PhoneApplicationService.Current.State["GeoCoordinate"] = coordNewYorkCity;
            }

            // If the City and State aren't in the Application State
            if (!PhoneApplicationService.Current.State.ContainsKey("State"))
            {
                location = new GeoLocation();
                location.StartWatching(GeoPositionAccuracy.Default);
                location.CoordinateChanged += location_CoordinateChanged;
            }
            else
            {
                PopulateBeerLocations();
            }
        }

        private void location_CoordinateChanged(object sender, EventArgs e)
        {
            var current = location.CurrentLocation;
            map = new Map();
            map.PlaceDetailsObtained += map_PlaceDetailsObtained;
            map.GetPlaceDetails(current.Latitude.ToString(), current.Longitude.ToString());
        }

        private void map_PlaceDetailsObtained(object sender, EventArgs e)
        {
            var address = map.PlaceDetails.address;

            PhoneApplicationService.Current.State["City"] = address.city;
            PhoneApplicationService.Current.State["State"] = address.stateCode;
            
            PopulateBeerLocations();
        }

        private void PopulateBeerLocations()
        {
            beer = new BeerListings();
            beer.LocationsRetrieved += beer_LocationsRetrieved;
            beer.GetBeerPlaces(PhoneApplicationService.Current.State["City"].ToString(), PhoneApplicationService.Current.State["State"].ToString());
        }

        private void beer_LocationsRetrieved(object sender, EventArgs e)
        {
            var locations = beer.LocationsByCity.location;

            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                locationList.ItemsSource = locations;
            });
        }

        private void Location_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/LocationSetting.xaml", UriKind.RelativeOrAbsolute));
        }

        private void OpenLocationDetails(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LocationDetails.xaml?id=", UriKind.RelativeOrAbsolute));
        }
    }
}