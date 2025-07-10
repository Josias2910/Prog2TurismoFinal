using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Turismo
    {
        private Destino destino;
        private List<Paquete> listaPaquetes = new List<Paquete>();
        private List<Destino> listaDestinos = new List<Destino>();
        public Turismo(Destino destino)
        {
            this.destino = destino;
        }
        public void AgregarPaquete(Paquete paquete)
        {
            listaPaquetes.Add(paquete);
        }
        public void AgregarDestino(Destino d)
        {
            listaDestinos.Add(d);
        }
        public List<Destino> GetDestinos()
        {
            return listaDestinos;
        }
        public void OrdenarPaquetesPorDestino()
        {
            listaPaquetes.Sort();
        }
        public string[] MostrarPaquetesOrdenados()
        {
            OrdenarPaquetesPorDestino();
            List<string> resumen = new List<string>();
            foreach(Paquete p in listaPaquetes)
            {
                resumen.Add(p.ToString());
            }
            return resumen.ToArray();
        }
    }
}
