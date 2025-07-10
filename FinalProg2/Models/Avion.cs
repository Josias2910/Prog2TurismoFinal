using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Avion:Transporte
    {
        private string numeroVuelo;

        public Avion(string numeroVuelo, Destino destino)
        {
            this.numeroVuelo = numeroVuelo;
            this.destino = destino;
        }
        public override double Precio()
        {
            return destino.GetPrecio() * 1.23 * 1.27;
        }
        public override string Descripcion()
        {
            return $"{numeroVuelo};{destino.GetDescripcion()}";
        }
        public override string ToString()
        {
            return $"{numeroVuelo};{destino.GetDescripcion()}";
        }
    }
}
