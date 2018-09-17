using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Core.Domain.CuentasBancarias
{
    public class CuentaAhorro : CuentaBancaria
    {
        public override string Consignar(decimal valor, string ciudad, DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public override string Retirar(decimal valor, string ciudad, DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public override string Trasladar(decimal valor, string ciudad, DateTime fecha, IServicioFinanciero destino)
        {
            throw new NotImplementedException();
        }
    }
}
