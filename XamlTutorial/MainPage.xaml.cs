﻿using System;
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
using XamlTutorial.Models;
using XamlTutorial.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlTutorial
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public PlayerListViewModel ViewModel;

        public MainPage()
        {
            this.InitializeComponent();

            this.ViewModel = new PlayerListViewModel();
            this.DataContext = this.ViewModel;
        }

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            var player = new PlayerDesc()
            {
                FirstName = FirstNameBox.Text,
                LastName = LastNameBox.Text
            };

            this.ViewModel.Players.Add(player);
        }
    }
}
