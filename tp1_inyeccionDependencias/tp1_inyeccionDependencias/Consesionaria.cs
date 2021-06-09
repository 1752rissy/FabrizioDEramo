using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_inyeccionDependencias
{
    class Consesionaria
    {
        private readonly FCA _FCA;


        public String Nombreconsecionaria { get; set; }

        public Consesionaria (FCA fca)
        {
            _FCA = fca;
        }

        public double InformarFiananciacion(Vehiculo vehiculo)
        {
           double informeValor = vehiculo.precio + _FCA.FinanciarVehiculo(vehiculo);

            return informeValor;

        }

    }
}
