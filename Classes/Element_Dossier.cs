using System.Collections.Generic;

namespace GestionMines.Classes
{
    public class Element_Dossier
    {
        public int id { get; set; }
        public string nom_dossier { get; set; }
        public bool isExist { get; set; }
        //les Relation avec autre classes
        public List<Permis> Les_Permis { get; set; }
    }
}
