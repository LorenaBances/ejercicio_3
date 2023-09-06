using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, correctas, monto;
            Console.WriteLine("ingrese la edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de adivinanzas correctas:");
            correctas = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
                if (correctas < 3)
                {
                    monto = 50;
                }
                else
                {
                    monto = 80;
                }
                monto = monto + edad * 5;
                monto = monto + correctas * 2;
            }
            else
            {
                if (correctas < 3)
                {
                    monto = 30;
                }
                else
                {
                    monto = 50;
                }
                monto = monto + edad * 5;
                monto = monto + correctas * 2;
            }
            Console.WriteLine("El monto final es :" + monto);
            correctas = Convert.ToInt32(Console.ReadLine());
        }
    }
}
