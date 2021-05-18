using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo.produccion.Utilidad
{
    public interface IUtilidad
    {
        List<int> AsignarAleatoriamente<A, B>(List<A> listA, List<B> listaB);
    }
    public class Utilidad : IUtilidad
    {
        public List<int> AsignarAleatoriamente<A,B>(List<A> listaA , List<B> listaB)
        {
            if (listaA.Count < listaB.Count)
            {
                throw new System.Exception("La lista A no puede ser menor que la b");
            }
            var random = new Random();
            var listaIndicesA = new List<int>();

            var indicesListaB = generaIndiceDisponibles(listaB.Count);
            listaA.ForEach(elemento =>
            {
                if (indicesListaB.Count == 0)
                {
                    indicesListaB = generaIndiceDisponibles(listaB.Count);
                }
                var vr = random.Next(0, listaIndicesA.Count);
                listaIndicesA.Add(indicesListaB[vr]);
                indicesListaB.RemoveAt(vr);
            });
            return listaIndicesA;
        }

        private List<int> generaIndiceDisponibles(int cantidad)
        {
            var indices = new List<int>();
            for (int indice = 0; indice < cantidad; indice++)
            {
                indices.Add(indice);
            }
            return indices;
        }
    }
}
