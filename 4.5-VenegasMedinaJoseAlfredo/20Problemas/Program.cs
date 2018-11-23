using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Program
    {
        static void Main(string[] args)
        {           
            int opc = 0, op = 0; //Inicializo variable de seleccion
            Opc O = new Opc(); //Objeto de clase Opc

            do
            {
                Console.Clear();
                Console.Write("Ingrese numero del problema \nR = "); //Menu
                opc = int.Parse(Console.ReadLine());

                Console.Clear();
                O.Opcion(opc); //Llamo al metodo Opcion

                Console.Write("\n\nDesea iniciar otro programa? \n1 = Si \n2 = No \nR = "); //Ciclo
                op = int.Parse(Console.ReadLine());

            } while (op == 1);

            Console.ReadKey();
        }
    }
}
