using System;
using System.Collections.Generic;

namespace XamlTutorial.Models
{
    public class GameDesc
    {
        public string Id { get; set; }

        public List<PlayerDesc> Players { get; set; }

        public string Room { get; set; }

        public DateTime StartTime { get; set; }
    }
}
