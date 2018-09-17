using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Core.Domain
{
    public interface IServicioFinanciero
    {
        string Consignar(decimal valor, string ciudad, DateTime fecha);
        string Retirar(decimal valor, string ciudad, DateTime fecha);
        string Trasladar(decimal valor, string ciudad, DateTime fecha, IServicioFinanciero destino);
    }
}
