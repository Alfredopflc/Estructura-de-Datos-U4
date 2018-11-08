using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado(); //Se cre un arbol binario llamado abo
            abo.Insertar(100); //Ingresa los elementos este primer elemento sera nuestra raiz
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);

            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();
            Console.ReadKey();

            //Este ejemplo simplemente se le agregan elementos a un arbol binario y los imprime en postorden, inorden y preorden
            //basandome en como imprimimos los elementos durante este ejemplo.
            //          100
            //        /     \
            //      50       150
            //    /    \
            //  25      75
        }
    }
}
