using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class Cliente
    {
        private string nombre;
        private long cuit;
        private long telefono;
        private long tarjetaCredito;

        public Cliente(string nombre, string cuitStr, long telefono, string tarjetaCreditoStr)
        {
            if (String.IsNullOrWhiteSpace(cuitStr))
            {
                throw new DatoInvalidoException("El cuit no puede estar vacio");
            }
            if (!Regex.IsMatch(cuitStr, @"^\d{11}$"))
            {
                throw new DatoInvalidoException("CUIL inválido: debe contener exactamente 11 dígitos numéricos.");
            }
            if (String.IsNullOrWhiteSpace(tarjetaCreditoStr))
            {
                throw new DatoInvalidoException("El número de tarjeta de crédito no puede estar vacío.");
            }
            if (!Regex.IsMatch(tarjetaCreditoStr, @"^\d{16}$"))
            {
                throw new DatoInvalidoException("Tarjeta inválida: debe contener exactamente 16 dígitos numéricos.");
            }

            this.nombre = nombre;
            cuit = Convert.ToInt64(cuitStr);
            this.telefono = telefono;
            tarjetaCredito = Convert.ToInt64(tarjetaCreditoStr);
        }

        public override string ToString()
        {
            return $"{nombre};{cuit};{telefono};{tarjetaCredito}";
        }
    }
}
