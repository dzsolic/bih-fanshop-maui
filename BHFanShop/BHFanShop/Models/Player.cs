using System;
using System.Collections.Generic;
using System.Text;

namespace BHFanShop.Models
{
    class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }
        public string Photo { get; set; }

        public class SquadResponse { public List<SquadData> Response { get; set; } }
        public class SquadData { public List<Player> Players { get; set; } }
    }
}
