using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class GameNight
    {
        public string Organizer { get; set; }
        public string Adress { get; set; }
        public List<string> Players { get; set; } = new List<string>();
        public int MaxAtendees { get; set; }
        public DateTime DateAndTime { get; set; }
        public List<string> Reviews { get; set; } = new List<string>();
        public List<BoardGame> PlayedBoardGame { get; set; } = new List<BoardGame>();
        public List<string> Food { get; set; } = new List<string>();
    }
}
