using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMines.Classes
{
    public class Etat_Permis
    {
        public int Id { get; set; }
        public string Etat { get; set; }
        //les relations
        public List<Permis> Les_Permis { get; set; }
    }
}
