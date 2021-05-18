using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo.produccion.Interfaces
{
    public interface IEquipoConstructor
    {
        List<string> Estudiantes { get; set; }
        List<string> Temas { get; set; }
        List<IEquipo> Equipos { get; set; }
        void ObtenerEstudiantes(string rutaArchivoEstudiantes);
        void ObtenerTemas(string rutaArchivosTemas);
        void ObtenerEquipos(int cantidaEquipos);
        void AsignarTemas();
    }
}
