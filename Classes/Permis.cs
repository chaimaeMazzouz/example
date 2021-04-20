using System;
using System.Collections.Generic;

namespace GestionMines.Classes
{
    public class Permis
    {
        public int Id { get; set; }
        public int Num_Demmande { get; set; }
        public int Num_Permis{ get; set; }
        public DateTime Date_Depot { get; set; }
        public double Investisement_Projet { get; set; }
        public string Occupation_Temporaire { get; set; }
        public DateTime Date_Institition { get; set; }
        public DateTime Echeance { get; set; }
        public double Investisement_Realise { get; set; }
        public bool Inscription_Conservation { get; set; }
        public DateTime Date_Depart_CRI { get; set; }
        public DateTime Date_Retour_CRI { get; set; }
        public DateTime Date_Decision { get; set; }
        public DateTime Date_Enquete { get; set; }
        public DateTime Date_Rapot { get; set; }
        //les relation avec lui meme
        public List<Permis> Chevauchements { get; set; }
        public Permis Ex_Permis { get; set; }
        public List<Permis> Licence_Permis { get; set; }
        //les relation avec autres classes
        public Etat_Permis Etat_Permis { get; set; }
        public Type_Permis Type_Permis { get; set; }
        public Area Area { get; set; }
        public Titulaire Titulaire { get; set; }
        public List<Element_Dossier> Les_Element_Dossier { get; set; }
        public List<Observation> Observations { get; set; }
    }
}