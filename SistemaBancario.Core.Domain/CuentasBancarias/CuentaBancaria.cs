using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Core.Domain.CuentasBancarias
{
    public abstract class CuentaBancaria : IServicioFinanciero
    {
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; }

        public abstract string Consignar(decimal valor, string ciudad, DateTime fecha);
        public abstract string Retirar(decimal valor, string ciudad, DateTime fecha);
        public abstract string Trasladar(decimal valor, string ciudad, DateTime fecha, IServicioFinanciero destino);
    }
}
