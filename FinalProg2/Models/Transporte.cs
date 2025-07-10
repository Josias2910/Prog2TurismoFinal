using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal abstract class Transporte
    {
        protected Destino destino;
        public abstract double Precio();
        public abstract string Descripcion();
    }
}
