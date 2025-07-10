using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Destino:IComparable
    {
        private int codigo;
        private string descripcion;
        private double precioSinImpuestos;

        public Destino(int codigo, string descripcion, double precioSinImpuestos)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioSinImpuestos = precioSinImpuestos;
        }

        public double GetPrecio()
        {
            return precioSinImpuestos;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
        public override string ToString()
        {
            return $"{codigo};{descripcion};{precioSinImpuestos}";
        }
        public int CompareTo(object obj)
        {
            Destino d = obj as Destino;
            if (d != null)
            {
                return this.descripcion.CompareTo(d.descripcion);
            }
            return -1;
        }
    }
}
