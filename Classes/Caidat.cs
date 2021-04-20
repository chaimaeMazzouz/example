using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMines.Classes
{
    public class Caidat
    {
        public int Id { get; set; }
        public string Nom_Caidat { get; set; }
        public Province Province { get; set; }
        public List<Commune> Communes { get; set; }
    }
}
