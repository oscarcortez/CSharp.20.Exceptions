using Models;
using System;

namespace ConsoleApp4Exceptions
{
    class Program
    {
        /// <summary>
        /// Es un evento que ocurre durante la ejecucion de un programa y que interrumpe el flujo normal de la operacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.Division(25, 0);
            Console.ReadKey();
        }

        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }


    }
}
