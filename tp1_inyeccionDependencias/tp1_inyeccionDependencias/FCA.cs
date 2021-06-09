using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_inyeccionDependencias
{
    class FCA
    { 
        public String EntidadFinanciera;


        public double FinanciarVehiculo( Vehiculo vehiculo)
        {
            double financiacion = (vehiculo.precio * 55) / 100;
            return financiacion;
        }
    }
}
