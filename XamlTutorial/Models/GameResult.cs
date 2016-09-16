using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlTutorial.Models
{
    public class GameResult
    {
        public string Id { get; set; }

        public GameDesc Game { get; set; }

        public PlayerDesc Player { get; set; }

        public float BuyIn { get; set; }

        public float CashOut { get; set; }
    }
}
