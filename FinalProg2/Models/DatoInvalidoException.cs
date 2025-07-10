using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class DatoInvalidoException:ApplicationException
    {
        public DatoInvalidoException() : base("Dato inválido") { }
        public DatoInvalidoException(string mensaje) : base(mensaje) { }
        public DatoInvalidoException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
