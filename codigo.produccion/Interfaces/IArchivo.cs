using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo.produccion.Interfaces
{
    public interface IArchivo
    {
        string Leer(string ruta);
        List<string> Lineas { get; set; }
    }
}
