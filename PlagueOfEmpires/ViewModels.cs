using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace PlagueOfEmpires
{
    public class VMMod : Mod
    {
        public Image img;
        public VMMod(Mod mod)
        {
            Id = mod.Id;
            Nombre = mod.Nombre;
            Descripcion = mod.Descripcion;
            Activado = mod.Activado;
            Imagen = mod.Imagen;
        }
    }
}
