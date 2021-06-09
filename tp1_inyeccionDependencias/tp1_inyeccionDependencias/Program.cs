using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_inyeccionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            FCA fca = new FCA();
            Consesionaria consesionaria = new Consesionaria(fca);
            Cliente cliente = new Cliente(consesionaria);

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Modelo= "Corsa";
            vehiculo.patente = "HRO 112";
            vehiculo.precio = 120000.00;

            Console.WriteLine("El modelo del vehiculo es:" +vehiculo.Modelo);
            Console.WriteLine("La patente del vehiculo es:" + vehiculo.patente);
            Console.WriteLine("La financiacion del vehiculo es de:" + cliente.AveriguarFinanciacion(vehiculo));
            Console.ReadLine();

        }
    }
}
