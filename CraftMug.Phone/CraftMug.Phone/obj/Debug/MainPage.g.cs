﻿#pragma checksum "C:\My Files\Personal\Projects - Applications\CraftMug\CraftMug.Phone\CraftMug.Phone\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B32F24F9BE14AB5943E4592D37E9E1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace CraftMug.Phone {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton AppBar_Location;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel LogoPanel;
        
        internal System.Windows.Controls.Image Logo;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox locationList;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/CraftMug.Phone;component/MainPage.xaml", System.UriKind.Relative));
            this.AppBar_Location = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("AppBar_Location")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.LogoPanel = ((System.Windows.Controls.StackPanel)(this.FindName("LogoPanel")));
            this.Logo = ((System.Windows.Controls.Image)(this.FindName("Logo")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.locationList = ((System.Windows.Controls.ListBox)(this.FindName("locationList")));
        }
    }
}

