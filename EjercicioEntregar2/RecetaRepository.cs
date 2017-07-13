using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        public static List<Receta> listaAlimentos= new List<Receta>();

        public void Create(Receta receta)
        {
            if (listaAlimentos.Contains(receta))
            {
                listaAlimentos.Add(receta);
            }
        }
    }
}
 