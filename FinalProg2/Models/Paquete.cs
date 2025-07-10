using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Paquete:IComparable
    {
        private DateTime fechaHora;
        private Cliente cliente;
        private Destino destino;
        private List<Transporte> listaTransportes = new List<Transporte>();
        public Paquete(Cliente cliente, Destino destino)
        {
            this.fechaHora = DateTime.Now;
            this.cliente = cliente;
            this.destino = destino;
        }

        public void AgregarTransporte(Transporte t)
        {
            listaTransportes.Add(t);
        }
        public double PrecioTotal()
        {
            double precioTotal = 0;
            foreach(Transporte t in listaTransportes)
            {
                precioTotal += t.Precio();
            }
            return precioTotal;
        }
        public override string ToString()
        {
            return $"{destino};{fechaHora};{cliente};{PrecioTotal()}";
        }
        public int CompareTo(object obj)
        {
            Paquete p = obj as Paquete;
            if (p != null)
            {
                return this.destino.CompareTo(p.destino);
            }
            return -1;
        }
    }
}
