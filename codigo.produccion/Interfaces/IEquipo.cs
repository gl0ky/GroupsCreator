using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo.produccion.Interfaces
{
    public interface IEquipo
    {
        string Nombre { get; }
        List<string> Estudiantes { get; }
        void AgregarParticipantes(string estudiante);
        List<string> Temas { get; set; }
    }
}
