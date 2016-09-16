﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamlTutorial.Models;

namespace XamlTutorial.ViewModels
{
    public class PlayerListViewModel
    {
        public ObservableCollection<PlayerDesc> Players { get; set; }

        public PlayerListViewModel()
        {
            Players = new ObservableCollection<PlayerDesc>();

            Players.Add(new PlayerDesc() { FirstName = "Dave", LastName = "Koenig" });
        }
    }
}
