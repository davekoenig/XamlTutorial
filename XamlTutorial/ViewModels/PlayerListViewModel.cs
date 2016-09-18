using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamlTutorial.Models;

namespace XamlTutorial.ViewModels
{
    public class PlayerListViewModel
    {
        public ObservableCollection<PlayerDesc> Players { get; set; }

        public ObservableCollection<GameDesc> Games { get; set; }

        public ObservableCollection<GameResult> Results { get; set; }

        public PlayerListViewModel()
        {
            Players = new ObservableCollection<PlayerDesc>();

            Games = new ObservableCollection<GameDesc>();

            Results = new ObservableCollection<GameResult>();
        }
    }
}
