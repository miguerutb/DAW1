using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fecha correcta, año bisiesto
            try
            {
                Fecha fecha1 = new Fecha(4, 12, 2012);

                Console.WriteLine("Fecha 1: " + fecha1.ToString());

                if (fecha1.esBisiesto())
                    Console.WriteLine("El año " + fecha1.Anyo + " es bisiesto");
                else
                    Console.WriteLine("El año " + fecha1.Anyo + " no es bisiesto");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //Fecha correcta, año no bisiesto
            try
            {
                Fecha fecha2 = new Fecha(4, 10, 2013);

                Console.WriteLine("Fecha 2: " + fecha2.ToString());

                if (fecha2.esBisiesto())
                    Console.WriteLine("El año " + fecha2.Anyo + " es bisiesto");
                else
                    Console.WriteLine("El año " + fecha2.Anyo + " no es bisiesto");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Fecha con valores incorrectos
            try
            {
                Fecha fecha3 = new Fecha(4, 13, -4);
                Console.WriteLine("Fecha 3: " + fecha3.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Fecha con asignación incorrecta de valores erroneos
            try
            {
                Fecha fecha4 = new Fecha();
                fecha4.Dia = 67;
                fecha4.Mes = 80;
                fecha4.Anyo = 3678;
                Console.WriteLine("Fecha 4: " + fecha4.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
