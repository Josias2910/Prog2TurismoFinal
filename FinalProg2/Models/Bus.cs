using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Bus:Transporte
    {
        private string patente;
        private int clase;

        public Bus(string patente, int clase, Destino destino)
        {
            this.patente = patente;
            this.clase = clase;
            this.destino = destino;
        }

        public override double Precio()
        {
            return destino.GetPrecio() * 1.21;
        }
        public override string Descripcion()
        {
            return $"{patente};{clase};{destino.GetDescripcion()}";
        }
        public override string ToString()
        {
            return $"{patente};{clase};{destino.GetDescripcion()}";
        }
    }
}
