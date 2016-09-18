using System;
using System.Collections.Generic;

namespace XamlTutorial.Models
{
    public class GameDesc
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public List<PlayerDesc> Players { get; set; }

        public string Room { get; set; }

        public DateTime StartTime { get; set; }

        public string Description
        {
            get
            {
                return $"{Room} - {StartTime}";
            }
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
