using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMines.Classes
{
    public class Area
    {
        public int Id { get; set; }
        public double Superficie { get; set; }
        public double Abscisse { get; set; }
        public double Ordonnee { get; set; }
        public char Dir_Est_ouest { get; set; }
        public char dir_nord_sud { get; set; }
        public double dis_e_o { get; set; }
        public double dis_n_s { get; set; }
        public int zone { get; set; }
        //les relations
        public List<Permis> Les_Permis { get; set; }
        public List<Borne> Bornes { get; set; }
        public Carte Carte { get; set; }
        public Point_Pivot Point_Pivot { get; set; }
        public Commune Commune { get; set; }
    }
}
