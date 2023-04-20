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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activado { get; set; }
        public string Imagen { get; set; }

        public int Ancho { get; set; }

        public int Alto { get; set; }

        public Mod() { }
    }

    public class ModModel
    {
        public static List<Mod> Mods = new List<Mod>()
        {
            new Mod()
            {
                Id = 0,
                Nombre = "More Virus Expansion",
                Descripcion = "This expansion adds 6 new types of virus, along with some new core functionality for the game.",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
            },
            new Mod()
            {
                Id = 1,
                Nombre = "Expansion 2",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
            },
            new Mod()
            {
                Id = 2,
                Nombre = "Expansion 3",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
            },
            new Mod()
            {
                Id = 3,
                Nombre = "Expansion 4",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
            },
            new Mod()
            {
                Id = 4,
                Nombre = "Expansion 5",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
            },
            new Mod()
            {
                Id = 5,
                Nombre = "Expansion 6",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
            },
            new Mod()
            {
                Id = 6,
                Nombre = "Expansion 5",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
            },
            new Mod()
            {
                Id = 7,
                Nombre = "Expansion 6",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
            },
            new Mod()
            {
                Id = 8,
                Nombre = "Expansion 7",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
            },
        };

        public static IList<Mod> GetAllMods()
        {
            return Mods;
        }

        public static Mod GetModById(int id)
        {
            return Mods[id];
        }
    }
}
