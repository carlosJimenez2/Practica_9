using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9
{
    class Faltas : IDatos
    {
        private string nombre;
        private double clavetrabajador;
        private string fecha;
        private double numerodedias;


        public Faltas()
        {
            nombre = "";
            clavetrabajador = 0.00;
            fecha = "";
            numerodedias = 0.0;
        }

        public Faltas(string nom, double ct, string date, double numd)
        {
            nombre = nom ;
            clavetrabajador = ct;
            fecha = date;
            numerodedias = numd;
 


        }

        public void muestraDiasconfaltas()
        {
            Console.WriteLine("El trabajador {0}", nombre);
            Console.WriteLine("Con la clave: {0}", getclavetrabajador());
            Console.WriteLine("y fecha: {0}", fecha);
            Console.WriteLine("Tiene: {0} faltas acumuladas", numerodedias);
            Console.WriteLine("    ");

        }
        public double getclavetrabajador()
        {
            return clavetrabajador;
        }
    }
}
