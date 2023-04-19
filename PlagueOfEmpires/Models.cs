using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagueOfEmpires
{
    public class Mod
    {
        public enum estado {Activado, Desactivado};

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public estado Estado { get; set; }

        public Mod() { }
    }
}
