using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class BoardGame
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public bool Is18Plus { get; set; }
        public string Photo { get; set; }
        public TypeGame TypeGame { get; set; }
    }

    public enum Genre
    {
        Strategie,
        Avontuur,
        Familie,
        Kaart,
        Coöperatief,
        Abstract
    }

    public enum TypeGame
    {
        Bordspel,
        Kaartspel,
        Dobbelspel,
        Rollenspel,
        Partyspel
    }

}
