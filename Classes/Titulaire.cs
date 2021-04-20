using System.Collections.Generic;

namespace GestionMines.Classes
{
    public class Titulaire
    {

        public int id { get; set; }
        public string Nom_Societe { get; set; }
        public string Nom_Demandeur { get; set; }
        public string status_Demandeur { get; set; }
        public string Raison_Social { get; set; }
        public string Numero_Cnss { get; set; }
        public string Registre_Commerce { get; set; }
        public string Taxe_Prof{ get; set; }
        public string Nom_Site { get; set; }
        public string Election_Domicile { get; set; }
        public int Effictif { get; set; }
        public List<Permis> Lest_Permis { get; set; }
    }
}
