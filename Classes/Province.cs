using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMines.Classes
{
    public class Province
    {
        public int Id { get; set; }
        public string Nom_Province { get; set; }
        public string code_Province { get; set; }
        public Region Region { get; set; }
        public List<Caidat> Caidats { get; set; }
    }
}
