using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace PlagueOfEmpires
{
    public class VMMod : Mod
    { 
        public static SolidColorBrush GetSolidColorBrush(string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(a, r, g, b));
            return myBrush;
        }

        public bool Desactivado;
        public SolidColorBrush ellipseC;
        public SolidColorBrush ellipseStroke;
        public Symbol s;
        public VMMod(Mod mod)
        {
            Id = mod.Id;
            Nombre = mod.Nombre;
            Descripcion = mod.Descripcion;
            Activado = mod.Activado;
            Desactivado = !mod.Activado;
            Imagen = mod.Imagen;
            Alto = mod.Alto;
            Ancho = mod.Ancho;

            if(Desactivado)
            {
                ellipseC = GetSolidColorBrush("#FFff5d55");
                ellipseStroke = GetSolidColorBrush("#FF5e0202");
                s = Symbol.Cancel;
            }
            else if(Activado)
            {
                ellipseC = GetSolidColorBrush("#FF92d36e");
                ellipseStroke = GetSolidColorBrush("#FF243e16");
                s = Symbol.Accept;
            }
        }
    }

    public class VMStructure : Structure
    {
        public VMStructure(Structure structure)
        {
            Id = structure.Id;
            Imagen = structure.Imagen;
        }
    }
}
