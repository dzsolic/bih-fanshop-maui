using BHFanShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BHFanShop.Services
{
    public static class PlayerData
    {
        public static ObservableCollection<Player> ATeam = new ObservableCollection<Player>
        {
            new Player { Name = "Edin Džeko", Club = "Fenerbahče", Position = "Napad" },
            new Player { Name = "Ermedin Demirović", Club = "Stuttgart", Position = "Napad" },
            new Player { Name = "Amar Dedić", Club = "Salzburg", Position = "Odbrana" }
        };
        public static ObservableCollection<Player> U21Team = new ObservableCollection<Player>
        {
            new Player { Name = "Tarik Muharemović", Club = "Sassuolo", Position = "Odbrana" },
            new Player { Name = "Ivan Bašić", Club = "Orenburg", Position = "Vezni" }
        };
        public static ObservableCollection<Player> WomenTeam = new ObservableCollection<Player>
        {
            new Player { Name = "Milena Nikolić", Club = "Basel", Position = "Napad" },
            new Player { Name = "Melisa Hasanbegović", Club = "Al-Ula", Position = "Odbrana" }
        };
    }
}
