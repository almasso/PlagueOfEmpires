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
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 1,
                Nombre = "Expansion 2",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 2,
                Nombre = "Expansion 3",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 3,
                Nombre = "Expansion 4",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 4,
                Nombre = "Expansion 5",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 5,
                Nombre = "Expansion 6",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 6,
                Nombre = "Expansion 5",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 7,
                Nombre = "Expansion 6",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_2.jpg",
                Ancho = 110,
                Alto = 110
            },
            new Mod()
            {
                Id = 8,
                Nombre = "Expansion 7",
                Descripcion = "Some text regarding this expansion",
                Activado = false,
                Imagen = "./Assets/virus_dlc_3.jpg",
                Ancho = 110,
                Alto = 110
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

    public class Structure
    {
        public int Id { get; set; }

        public string Imagen { get; set; }

        public Structure() { }
    }

    public class StructureModel
    {
        public static List<Structure> Structures = new List<Structure>()
        {
            new Structure()
            {
                Id = 0,
                Imagen = "./Assets/biblioteca.jpg"
            },
            new Structure()
            {
                Id = 1,
                Imagen = "./Assets/muro.jpg"
            },
            new Structure()
            {
                Id = 2,
                Imagen = "./Assets/taller.jpg"
            },
            new Structure()
            {
                Id = 3,
                Imagen = "./Assets/catedral.jpg"
            },
            new Structure()
            {
                Id = 4,
                Imagen = "./Assets/banco.jpg"
            },
            new Structure()
            {
                Id = 5,
                Imagen = "./Assets/fabrica.jpg"
            },
            new Structure()
            {
                Id = 6,
                Imagen = "./Assets/estadio.jpg"
            },
            new Structure()
            {
                Id = 7,
                Imagen = "./Assets/biblioteca.jpg"
            },
            new Structure()
            {
                Id = 8,
                Imagen = "./Assets/muro.jpg"
            },
            new Structure()
            {
                Id = 9,
                Imagen = "./Assets/taller.jpg"
            },
            new Structure()
            {
                Id = 10,
                Imagen = "./Assets/catedral.jpg"
            },
            new Structure()
            {
                Id = 11,
                Imagen = "./Assets/banco.jpg"
            },
            new Structure()
            {
                Id = 12,
                Imagen = "./Assets/fabrica.jpg"
            },
            new Structure()
            {
                Id = 13,
                Imagen = "./Assets/estadio.jpg"
            },
            new Structure()
            {
                Id = 14,
                Imagen = "./Assets/banco.jpg"
            },
            new Structure()
            {
                Id = 15,
                Imagen = "./Assets/fabrica.jpg"
            }
        };
        
        public static IList<Structure> GetAllStructures()
        {
            return Structures;
        }

        public static Structure GetStructureById(int id)
        {
            return Structures[id];
        }
    }
}
