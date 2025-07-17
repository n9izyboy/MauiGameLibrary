using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.Models
{
    public class GameInfo
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string GameType { get; set; }

        public int Genre { get; set; }

        public string AgeRestriction { get; set; }

        public bool Multiplayer { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime YearPublished { get; set; }
    }
}
