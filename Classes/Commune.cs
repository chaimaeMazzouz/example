using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMines.Classes
{
    public class Commune
    {
        public int Id { get; set; }
        public string Nom_Commune { get; set; }
        public Caidat Caidat { get; set; }
        public List<Area> Areas { get; set; }
    }
}
