using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMines.Classes
{
    public class Carte
    {
        public int Id { get; set; }
        public string Nom_carte { get; set; }
        public List<Area> Areas { get; set; }
    }
}
