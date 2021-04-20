using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GestionMines.Classes;

namespace GestionMines
{
    public class ProjetMinesDBContext:DbContext
    {
        public DbSet<Permis> Les_Permis { get; set; }
        public DbSet<Titulaire> Titulaires { get; set; }
        public DbSet<Etat_Permis> Etats_Permis { get; set; }
        public DbSet<Type_Permis> Types_Permis { get; set; }
        public DbSet<Observation> Observations { get; set; }
        public DbSet<Element_Dossier> Elements_Dossiers { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Borne> bornes { get; set; }
        public DbSet<Point_Pivot> Point_Pivots { get; set; }
        public DbSet<Carte> Cartes { get; set; }
        public DbSet<Commune> Communes{ get; set; }
        public DbSet<Caidat> Caidats { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
