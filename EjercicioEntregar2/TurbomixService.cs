using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class TurbomixService : ITurbomixService
    {
        public IBascula Bascula { get; set; }
        public ICocina Cocina { get; set; }

        public TurbomixService(IBascula _Bascula, ICocina _Cocina)
        {
            this.Bascula = _Bascula;
            this.Cocina = _Cocina;
        }

        public Plato PrepararPlato(Alimento mAlimento1, Alimento mAlimento2)
        {
            float Peso1 = Bascula.Pesar(mAlimento1);
            float Peso2 = Bascula.Pesar(mAlimento2);
            Cocina.Calentar(mAlimento1, mAlimento2);

            return new Plato(mAlimento1, mAlimento2);
        }

    }
}
