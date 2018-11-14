using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Arbol arbol = new Arbol(); //Creamos objeto arbol

            Console.Write("Ingrese que arbol quiere analizar: \nA) = 1 \nB) = 2 \nC) = 3 \nR = "); //Menu
            opc = int.Parse(Console.ReadLine());

            if (opc == 1) //Si elige 1, arbol a)
            {
                Nodo raiz = arbol.Insertar("E", null); //Nodo raiz

                arbol.Insertar("F", raiz);
                Nodo n = arbol.Insertar("A", raiz);
                arbol.Insertar("B", n);
                arbol.Insertar("C", n);
                arbol.Insertar("D", n);

                Console.WriteLine();
                arbol.Imprimir(raiz); //Mandamos a llamar al Metodo imprimir para mostar el arbol en orden
               
                Console.WriteLine("Altura del arbol: {0}", arbol.Altura2(raiz)); //Metodo para calcular altura
                Console.WriteLine("Numero de Niveles: {0}", arbol.Nivel2(raiz)); //Metodo para calcular nivel
                arbol.Recorrido(opc); //Imprime recorrido mas largo

                //arbol.Recorrido(raiz);
                //arbol.Imprimir2();
            }

            if (opc == 2) //Si elige 2, arbol b)
            {
                Nodo raiz = arbol.Insertar("C", null);  //Nodo raiz
                Nodo n = arbol.Insertar("A", raiz);
                Nodo j = arbol.Insertar("B", n);
                arbol.Insertar("E", j);
                
                arbol.Insertar("G", raiz);
                arbol.Insertar("F", raiz);
                arbol.Insertar("D", raiz);

                Console.WriteLine();
                arbol.Imprimir(raiz); //Mandamos a llamar al Metodo imprimir para mostar el arbol en orden
                Console.WriteLine("Altura del arbol: {0}", arbol.Altura2(raiz)); //Metodo para calcular altura
                Console.WriteLine("Numero de Niveles: {0}", arbol.Nivel2(raiz)); //Metodo para calcular nivel
                arbol.Recorrido(opc); //Imprime recorrido mas largo

                //arbol.Recorrido(raiz);
                //arbol.Imprimir2();
            }

            if(opc == 3) //Si elige 2, arbol b)
            {
                Nodo raiz = arbol.Insertar("K", null); //Nodo raiz
                arbol.Insertar("B", raiz);
                Nodo d = arbol.Insertar("D", raiz);
                Nodo i = arbol.Insertar("I", d);
                arbol.Insertar("J", i);

                Nodo e = arbol.Insertar("E", d);
                Nodo g = arbol.Insertar("G", e);
                arbol.Insertar("H", g);
                arbol.Insertar("F", e);

                arbol.Insertar("C", raiz);
                arbol.Insertar("A", raiz);

                Console.WriteLine();
                arbol.Imprimir(raiz); //Mandamos a llamar al Metodo imprimir para mostar el arbol en orden
                Console.WriteLine("Altura del arbol: {0}", arbol.Altura2(raiz)-1); //Metodo para calcular altura
                Console.WriteLine("Numero de Niveles: {0}", arbol.Nivel2(raiz)-1); //Metodo para calcular nivel
                arbol.Recorrido(opc); //Imprime recorrido mas largo

                //arbol.Recorrido(raiz); arbol.Recorrido(raiz);
                //arbol.Imprimir2();
            }           

            Console.ReadKey();
            //Codigo basado en: 
            //https://www.youtube.com/watch?v=90qdczicwxw&fbclid=IwAR29A69kZL2_cgGyZkioN3cPq_GYO97PeYNOKpgIL_Mz0MZ7IssbUkIzZks
        }
    }
}
