using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlTutorial.Models
{
    public class GameResult
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public GameDesc Game { get; set; }

        public PlayerDesc Player { get; set; }

        public float BuyIn { get; set; }

        public float CashOut { get; set; }

        public float Delta
        {
            get
            {
                return CashOut - BuyIn;
            }
        }

        public string GameDescription
        {
            get
            {
                return $"{Player.Name} - {Game.StartTime}";
            }
        }

        public string WinningsDescription
        {
            get
            {
                return $"${Delta} (Buy In: ${BuyIn}, Cash Out: ${CashOut})";
            }
        }
    }
}
