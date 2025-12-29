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
            new Player { Name = "Nikola Vasilj", Club = "FC St. Pauli", Position = "Golman", Image="vasilj.jpeg" },
            new Player { Name = "Martin Zlomislić", Club = "HNK Rijeka", Position = "Golman" },
            new Player { Name = "Osman Hadžikić", Club = "Slaven Belupo", Position = "Golman" },

            new Player { Name = "Tarik Muharemović", Club = "US Sassuolo", Position = "Štoper" },
            new Player { Name = "Sead Kolašinac", Club = "Atalanta BC", Position = "Štoper" },
            new Player { Name = "Adrian Leon Barišić", Club = "FC Basel 1893", Position = "Štoper" },
            new Player { Name = "Nikola Katić", Club = "FC Schalke 04", Position = "Štoper" },
            new Player { Name = "Dennis Hadžikadunić", Club = "UC Sampdoria", Position = "Štoper" },
            new Player { Name = "Nihad Mujakić", Club = "Eyüpspor", Position = "Štoper" },

            new Player { Name = "Emir Karić", Club = "SK Sturm Graz", Position = "Lijevi bek" },
            new Player { Name = "Amar Dedić", Club = "SL Benfica", Position = "Desni bek" },
            new Player { Name = "Arjan Malić", Club = "SK Sturm Graz", Position = "Desni bek" },

            new Player { Name = "Amir Hadžiahmetović", Club = "Hull City", Position = "Zadnji vezni" },
            new Player { Name = "Ivan Šunjić", Club = "Pafos FC", Position = "Zadnji vezni" },
            new Player { Name = "Dženis Burnić", Club = "Karlsruher SC", Position = "Zadnji vezni" },

            new Player { Name = "Benjamin Tahirović", Club = "Bröndby IF", Position = "Vezni" },
            new Player { Name = "Armin Gigović", Club = "BSC Young Boys", Position = "Vezni" },
            new Player { Name = "Ivan Bašić", Club = "FC Astana", Position = "Vezni" },
            new Player { Name = "Dario Šarić", Club = "Antalyaspor", Position = "Vezni" },

            new Player { Name = "Amar Memić", Club = "FC Viktoria Plzen", Position = "Desno krilo" },

            new Player { Name = "Kerim Alajbegović", Club = "Red Bull Salzburg", Position = "Lijevo krilo" },
            new Player { Name = "Esmir Bajraktarević", Club = "PSV Eindhoven", Position = "Desno krilo" },

            new Player { Name = "Haris Tabaković", Club = "Borussia Mönchengladbach", Position = "Napadač" },
            new Player { Name = "Samed Baždar", Club = "Real Zaragoza", Position = "Napadač" },
            new Player { Name = "Edin Džeko", Club = "ACF Fiorentina", Position = "Napadač" }

        };
        public static ObservableCollection<Player> U21Team = new ObservableCollection<Player>
        {
            new Player { Name = "Mladen Jurkaš", Club = "FK Borac Banja Luka", Position = "Golman" },
            new Player { Name = "Tarik Karić", Club = "FK Velež Mostar", Position = "Golman" },
            new Player { Name = "Sanin Mušija", Club = "FK Sarajevo", Position = "Golman" },

            new Player { Name = "Nidal Čelik", Club = "RC Lens", Position = "Štoper" },
            new Player { Name = "Anes Čardaklija", Club = "GAIS", Position = "Štoper" },
            new Player { Name = "Nermin Mujkić", Club = "FK Sarajevo", Position = "Štoper" },
            new Player { Name = "Luka Mikulić", Club = "HŠK Posušje", Position = "Štoper" },
            new Player { Name = "Haris Berbić", Club = "FK Borac Banja Luka", Position = "Štoper" },
            new Player { Name = "Amar Ibrisimović", Club = "FC Schalke 04 U19", Position = "Štoper" },

            new Player { Name = "Filip Taraba", Club = "NK Istra 1961", Position = "Desni bek" },
            new Player { Name = "Senad Mustafić", Club = "SK Sturm Graz II", Position = "Desni bek" },

            new Player { Name = "Albin Omić", Club = "FK Loznica", Position = "Zadnji vezni" },

            new Player { Name = "Muhamed Buljubašić", Club = "Çaykur Rizespor", Position = "Vezni" },
            new Player { Name = "Niko Kovač", Club = "US Lecce", Position = "Vezni" },
            new Player { Name = "Emin Kujović", Club = "1. FC Köln", Position = "Vezni" },

            new Player { Name = "Nedim Keranović", Club = "FK Rudar Prijedor", Position = "Ofanzivni vezni" },

            new Player { Name = "Aldin Mešić", Club = "FK Velež Mostar", Position = "Lijevo krilo" },
            new Player { Name = "Amar Milak", Club = "FK Velež Mostar", Position = "Lijevo krilo" },
            new Player { Name = "Benjamin Džanović", Club = "Eintracht Frankfurt U19", Position = "Lijevo krilo" },

            new Player { Name = "Matej Šakota", Club = "HŠK Zrinjski Mostar", Position = "Desno krilo" },
            new Player { Name = "Borna Filipović", Club = "HŠK Zrinjski Mostar", Position = "Desno krilo" },

            new Player { Name = "Aleksandar Kahvić", Club = "NK Domžale", Position = "Napadač" },
            new Player { Name = "Hamza Jaganjac", Club = "FK Željezničar Sarajevo", Position = "Napadač" },
            new Player { Name = "Stefan Marčetić", Club = "FK Borac Banja Luka", Position = "Napadač" }

        };
        public static ObservableCollection<Player> WomenTeam = new ObservableCollection<Player>
        {
            new Player { Name = "Almina Hodžić", Club = "Fatih Vatan Spor", Position = "Golman" },
            new Player { Name = "Iman Dumanjić", Club = "Giresun", Position = "Golman" },
            new Player { Name = "Somea Položen", Club = "Sparta Prag", Position = "Golman" },

            new Player { Name = "Nina Brnić", Club = "Hajduk Split", Position = "Odbrana" },
            new Player { Name = "Samra Muhić", Club = "Arna Bjørnar", Position = "Odbrana" },
            new Player { Name = "Emma Veletanlić", Club = "Kolding IF", Position = "Odbrana" },
            new Player { Name = "Melisa Hasanbegović", Club = "Al-Ula", Position = "Odbrana" },
            new Player { Name = "Đula Velagić", Club = "SFK 2000", Position = "Odbrana" },
            new Player { Name = "Gloria Slišković", Club = "Napoli", Position = "Odbrana" },
            new Player { Name = "Ena Šabanagić", Club = "Panathinaikos", Position = "Odbrana" },
            new Player { Name = "Lana Radulović", Club = "Spartak", Position = "Odbrana" },
            new Player { Name = "Aldina Hamzić", Club = "RB Salzburg", Position = "Odbrana" },
            new Player { Name = "Marija Milinković", Club = "Inter Milan", Position = "Odbrana" },
            new Player { Name = "Nikolina Milović", Club = "Giresun", Position = "Odbrana" },
            new Player { Name = "Vina Crnoja", Club = "RB Salzburg", Position = "Odbrana" },
            new Player { Name = "Andrea Ćule", Club = "Emina Mostar", Position = "Odbrana" },
            new Player { Name = "Andrea Grebenar", Club = "ŽNK Hajduk", Position = "Odbrana" },

            new Player { Name = "Elma Husić", Club = "Emina Mostar", Position = "Vezni" },
            new Player { Name = "Nina Garibija", Club = "IF Djurgården", Position = "Vezni" },
            new Player { Name = "Milica Denda", Club = "Emina Mostar", Position = "Vezni" },
            new Player { Name = "Marija Aleksić", Club = "Beşiktaş", Position = "Vezni" },
            new Player { Name = "Ema Paljević", Club = "Nantes", Position = "Vezni" },
            new Player { Name = "Minela Gačanica", Club = "PAOK", Position = "Vezni" },

            new Player { Name = "Sofija Krajšumović", Club = "CSKA Moscow", Position = "Napadač" },
            new Player { Name = "Milena Nikolić", Club = "Basel", Position = "Napadač" }

        };
    }
}
