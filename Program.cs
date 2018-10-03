using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Faltas Trabajador1 = new Faltas("Jimenez Arellano Carlos", 314104326 ,"02/10/2018", 2);
            Faltas Trabajador2 = new Faltas("INGRESE NOMBRE QUE MAS LE GUSTE", 123456789, "02/10/2018", 3);

            Trabajador1.muestraDiasconfaltas();
            Trabajador2.muestraDiasconfaltas();

            Console.ReadLine();
        }
    }
}
