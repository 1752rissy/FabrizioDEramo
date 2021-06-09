using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_inyeccionDependencias
{
    class Cliente
    {
        private readonly Consesionaria _consesionaria;
        public  string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }

        public Cliente (Consesionaria consesionaria)
        {
            _consesionaria = consesionaria;
        }


        public double AveriguarFinanciacion (Vehiculo vehiculo)
        {
            return _consesionaria.InformarFiananciacion(vehiculo);

        }


    }
}
