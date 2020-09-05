using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4_Opciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa te deja elegir las opciones deseada

            double  num1, num2, resultado;
            int opcion;

            Console.WriteLine("MENU DE OPCIONES  :");
            Console.WriteLine("1 . [S- Sumar] ");
            Console.WriteLine("2.  [R-Restar] ");
            Console.WriteLine("3.  [S-Salir] ");
            Console.WriteLine("Digite la opcion deseada");

            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:Console.Write("Digite el valor del primer numero   : ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite el valor del segundo numero     : ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("El resultado es :  {0} + {1} = {2}", num1, num2 ,(num1+num2));
                    
                    break;

                case 2:
                    Console.Write("Digite el valor del primer numero   :");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite el valor del segundo numero  :");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("El resultado es :  {0} - {1} = {2}", num1, num2, (num1 - num2));

                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa");
                    break;

                    
                        default: Console.WriteLine("El valor introducido no es valido");
                    break;

                   


            }
            Console.ReadKey();
            
        }
    }
}
