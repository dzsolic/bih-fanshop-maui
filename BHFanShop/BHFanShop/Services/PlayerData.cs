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
            new Player { Name = "Nikola Vasilj", Club = "FC St. Pauli", Position = "Golman", Image = "vasilj.jpeg" },
            new Player { Name = "Martin Zlomislić", Club = "HNK Rijeka", Position = "Golman", Image = "zlomslic.jpeg" },
            new Player { Name = "Osman Hadžikić", Club = "Slaven Belupo", Position = "Golman", Image = "hadzikic.jpeg" },

            new Player { Name = "Tarik Muharemović", Club = "US Sassuolo", Position = "Štoper", Image = "muharemovic.jpeg" },
            new Player { Name = "Sead Kolašinac", Club = "Atalanta BC", Position = "Štoper", Image = "kolasinac.jpeg" },
            new Player { Name = "Adrian Leon Barišić", Club = "FC Basel 1893", Position = "Štoper", Image = "barisic.jpeg" },
            new Player { Name = "Nikola Katić", Club = "FC Schalke 04", Position = "Štoper", Image = "katic.jpeg" },
            new Player { Name = "Dennis Hadžikadunić", Club = "UC Sampdoria", Position = "Štoper", Image = "hadzikadunic.jpeg" },
            new Player { Name = "Nihad Mujakić", Club = "Eyüpspor", Position = "Štoper", Image = "mujakic.jpeg" },

            new Player { Name = "Emir Karić", Club = "SK Sturm Graz", Position = "Lijevi bek", Image = "karic.jpeg" },
            new Player { Name = "Amar Dedić", Club = "SL Benfica", Position = "Desni bek", Image = "dedic.jpeg" },
            new Player { Name = "Arjan Malić", Club = "SK Sturm Graz", Position = "Desni bek", Image = "malic.jpeg" },

            new Player { Name = "Amir Hadžiahmetović", Club = "Hull City", Position = "Zadnji vezni", Image = "hadziahmetovic.jpeg" },
            new Player { Name = "Ivan Šunjić", Club = "Pafos FC", Position = "Zadnji vezni", Image = "sunjic.jpeg" },
            new Player { Name = "Dženis Burnić", Club = "Karlsruher SC", Position = "Zadnji vezni", Image = "burnic.jpeg" },

            new Player { Name = "Benjamin Tahirović", Club = "Bröndby IF", Position = "Vezni", Image = "tahirovic.jpeg" },
            new Player { Name = "Armin Gigović", Club = "BSC Young Boys", Position = "Vezni", Image = "gigovic.jpeg" },
            new Player { Name = "Ivan Bašić", Club = "FC Astana", Position = "Vezni", Image = "basic.jpeg" },
            new Player { Name = "Dario Šarić", Club = "Antalyaspor", Position = "Vezni", Image = "saric.jpeg" },

            new Player { Name = "Amar Memić", Club = "FC Viktoria Plzen", Position = "Desno krilo", Image = "memic.jpeg" },

            new Player { Name = "Kerim Alajbegović", Club = "Red Bull Salzburg", Position = "Lijevo krilo", Image = "alajbegovic.jpeg" },
            new Player { Name = "Esmir Bajraktarević", Club = "PSV Eindhoven", Position = "Desno krilo", Image = "bajraktarevic.jpeg" },

            new Player { Name = "Haris Tabaković", Club = "Borussia Mönchengladbach", Position = "Napadač", Image = "tabakovic.jpeg" },
            new Player { Name = "Samed Baždar", Club = "Real Zaragoza", Position = "Napadač", Image = "bazdar.jpeg" },
            new Player { Name = "Edin Džeko", Club = "ACF Fiorentina", Position = "Napadač", Image = "dzeko.jpeg" }


        };
        public static ObservableCollection<Player> U21Team = new ObservableCollection<Player>
        {
            new Player { Name = "Mladen Jurkaš", Club = "FK Borac Banja Luka", Position = "Golman", Image = "notfound.jpeg" },
            new Player { Name = "Tarik Karić", Club = "FK Velež Mostar", Position = "Golman", Image = "notfound.jpeg" },
            new Player { Name = "Sanin Mušija", Club = "FK Sarajevo", Position = "Golman", Image = "musija.jpeg" },

            new Player { Name = "Nidal Čelik", Club = "RC Lens", Position = "Štoper", Image = "celik.jpeg" },
            new Player { Name = "Anes Čardaklija", Club = "GAIS", Position = "Štoper", Image = "cardaklija.jpeg" },
            new Player { Name = "Nermin Mujkić", Club = "FK Sarajevo", Position = "Štoper", Image = "mujkic.jpeg" },
            new Player { Name = "Luka Mikulić", Club = "HŠK Posušje", Position = "Štoper", Image = "mikulic.jpeg" },
            new Player { Name = "Haris Berbić", Club = "FK Borac Banja Luka", Position = "Štoper", Image = "notfound.jpeg" },
            new Player { Name = "Amar Ibrisimović", Club = "FC Schalke 04 U19", Position = "Štoper", Image = "ibrisimovic.jpeg" },

            new Player { Name = "Filip Taraba", Club = "NK Istra 1961", Position = "Desni bek", Image = "notfound.jpeg" },
            new Player { Name = "Senad Mustafić", Club = "SK Sturm Graz II", Position = "Desni bek", Image = "mustafic.jpeg" },

            new Player { Name = "Albin Omić", Club = "FK Loznica", Position = "Zadnji vezni", Image = "omic.jpeg" },

            new Player { Name = "Muhamed Buljubašić", Club = "Caykur Rizespor", Position = "Vezni", Image = "buljubasic.jpeg" },
            new Player { Name = "Niko Kovač", Club = "US Lecce", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Emin Kujović", Club = "1. FC Köln", Position = "Vezni", Image = "kujovic.jpeg" },

            new Player { Name = "Nedim Keranović", Club = "FK Rudar Prijedor", Position = "Ofanzivni vezni", Image = "keranovic.jpeg" },

            new Player { Name = "Aldin Mešić", Club = "FK Velež Mostar", Position = "Lijevo krilo", Image = "mesic.jpeg" },
            new Player { Name = "Amar Milak", Club = "FK Velež Mostar", Position = "Lijevo krilo", Image = "notfound.jpeg" },
            new Player { Name = "Benjamin Džanović", Club = "Eintracht Frankfurt U19", Position = "Lijevo krilo", Image = "dzanovic.jpeg" },

            new Player { Name = "Matej Šakota", Club = "HŠK Zrinjski Mostar", Position = "Desno krilo", Image = "sakota.jpeg" },
            new Player { Name = "Borna Filipović", Club = "HŠK Zrinjski Mostar", Position = "Desno krilo", Image = "notfound.jpeg" },

            new Player { Name = "Aleksandar Kahvić", Club = "NK Domžale", Position = "Napadač", Image = "kahvic.jpeg" },
            new Player { Name = "Hamza Jaganjac", Club = "FK Željezničar Sarajevo", Position = "Napadač", Image = "jaganjac.jpeg" },
            new Player { Name = "Stefan Marčetić", Club = "FK Borac Banja Luka", Position = "Napadač", Image = "notfound.jpeg" }


        };
        public static ObservableCollection<Player> WomenTeam = new ObservableCollection<Player>
        {
            new Player { Name = "Almina Hodžić", Club = "Fatih Vatan Spor", Position = "Golman", Image = "notfound.jpeg"},
            new Player { Name = "Iman Dumanjić", Club = "Giresun", Position = "Golman" , Image = "notfound.jpeg"},
            new Player { Name = "Somea Položen", Club = "Sparta Prag", Position = "Golman" , Image = "notfound.jpeg"},

            new Player { Name = "Nina Brnić", Club = "Hajduk Split", Position = "Odbrana" , Image = "notfound.jpeg"},
            new Player { Name = "Samra Muhić", Club = "Arna Bjørnar", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Emma Veletanlić", Club = "Kolding IF", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Melisa Hasanbegović", Club = "Al-Ula", Position = "Odbrana" , Image = "notfound.jpeg"},
            new Player { Name = "Đula Velagić", Club = "SFK 2000", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Gloria Slišković", Club = "Napoli", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Ena Šabanagić", Club = "Panathinaikos", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Lana Radulović", Club = "Spartak", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Aldina Hamzić", Club = "RB Salzburg", Position = "Odbrana" , Image = "notfound.jpeg"},
            new Player { Name = "Marija Milinković", Club = "Inter Milan", Position = "Odbrana" , Image = "notfound.jpeg"},
            new Player { Name = "Nikolina Milović", Club = "Giresun", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Vina Crnoja", Club = "RB Salzburg", Position = "Odbrana" , Image = "notfound.jpeg"},
            new Player { Name = "Andrea Ćule", Club = "Emina Mostar", Position = "Odbrana" , Image = "notfound.jpeg"},
            new Player { Name = "Andrea Grebenar", Club = "ŽNK Hajduk", Position = "Odbrana" , Image = "notfound.jpeg"},

            new Player { Name = "Elma Husić", Club = "Emina Mostar", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Nina Garibija", Club = "IF Djurgården", Position = "Vezni" , Image = "notfound.jpeg"},
            new Player { Name = "Milica Denda", Club = "Emina Mostar", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Marija Aleksić", Club = "Beşiktaş", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Ema Paljević", Club = "Nantes", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Minela Gačanica", Club = "PAOK", Position = "Vezni", Image = "notfound.jpeg" },

            new Player { Name = "Sofija Krajšumović", Club = "CSKA Moscow", Position = "Napadač", Image = "notfound.jpeg" },
            new Player { Name = "Milena Nikolić", Club = "Basel", Position = "Napadač", Image = "notfound.jpeg" }

        };
        public static ObservableCollection<Player> U17Team = new ObservableCollection<Player>
        {
            new Player { Name = "Meris Gradaščević", Club = "Eintracht Frankfurt U19", Position = "Golman", Image = "notfound.jpeg" },
            new Player { Name = "Ibrahim Zahirović", Club = "FK Sarajevo Academy U19", Position = "Golman", Image = "notfound.jpeg" },

            new Player { Name = "Tarik Ćirak", Club = "SpVgg Unterhaching U19", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Miljan Kecman", Club = "FK Borac Banja Luka U19", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Luka Vulin", Club = "Union Berlin U17", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Dragan Predojević", Club = "FK Borac Banja Luka U17", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Aleksandar Šarčević", Club = "FK Sloga Meridian U19", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Mahir Fejzić", Club = "FK Željezničar Sarajevo U17", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Amil Muminović", Club = "FK Sarajevo Academy U17", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Stefan Šešlija", Club = "FK Radnik Bijeljina U17", Position = "Odbrana", Image = "notfound.jpeg" },
            new Player { Name = "Mak Košpo", Club = "FK Željezničar Sarajevo U17", Position = "Odbrana", Image = "notfound.jpeg" },

            new Player { Name = "Lovre Lovrinović", Club = "NK Lokomotiva Zagreb U17", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Mak Pita", Club = "FK Sarajevo Academy U17", Position = "Vezni", Image = "notfound.jpeg" },
            new Player { Name = "Luka Radić", Club = "Eintracht Frankfurt U17", Position = "Vezni", Image = "notfound.jpeg" },

            
            new Player { Name = "Andrija Pejaković", Club = "Crvena Zvezda U17", Position = "Napadač", Image = "notfound.jpeg" },
            new Player { Name = "Vedad Husović", Club = "FK Sarajevo Academy U17", Position = "Napadač", Image = "notfound.jpeg" },
            new Player { Name = "Matej Deket", Club = "FK Borac Banja Luka U19", Position = "Napadač", Image = "notfound.jpeg" },
            new Player { Name = "Damjan Jović", Club = "FK Vojvodina Novi Sad U17", Position = "Napadač", Image = "notfound.jpeg" },
            new Player { Name = "Aldian Korora", Club = "FK Željezničar Sarajevo U19", Position = "Napadač", Image = "notfound.jpeg" }
        };

    }
}
