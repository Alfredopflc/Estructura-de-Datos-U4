using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class CaminosMinimos
    {
        public string AlgoritmoFloyd(long[,] matrizAdyacencia, int valor) //Metodo para imprimir los vertices relacionados
        {

            int vertices = valor;
            // long[,] matrizAdyacencia = Matriz;
            //int[] a = new int[10];

            //Matrices auxiliares
            string[,] caminos = new string[vertices, vertices];
            string[,] caminosAuxiliares = new string[vertices, vertices];
            string caminoRecorrido = "", cadena = "", caminitos = "";
            float temporal1, temporal2, temporal3, temporal4, minimo;

            //Inicializando las matrices caminos y caminosAuxiliares
            for (int i = 0; i < vertices; i++) //Se llenan las matrices sin nada
            {
                for (int j = 0; j < vertices; j++)
                {
                    caminos[i, j] = "";
                    caminosAuxiliares[i, j] = "";
                }
            }

            for (int k = 0; k < vertices; k++) //encuentra la ruta minima entre dos vertices
            {
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        temporal1 = matrizAdyacencia[i, j];
                        temporal2 = matrizAdyacencia[i, k];
                        temporal3 = matrizAdyacencia[k, j];
                        temporal4 = temporal2 + temporal3;

                        //Encontrando al Minimo
                        minimo = Math.Min(temporal1, temporal4);
                        if (temporal1 != temporal4)
                        {
                            if (minimo == temporal4)
                            {
                                caminoRecorrido = "";
                                caminosAuxiliares[i, j] = k + "";
                                caminos[i, j] = CaminosR(i, k, caminosAuxiliares, caminoRecorrido) + (k + 1);
                            }
                        }
                        matrizAdyacencia[i, j] = (long)minimo;
                    }
                }
            }

            //Agregando el camino minimo a cadena
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    cadena = cadena + "[" + matrizAdyacencia[i, j] + "]";
                }
                cadena = cadena + "\n";
            }

            //////////////////////////////////////////////////////////

            //Utilizamos este for para imprimir de manera ordenada
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (matrizAdyacencia[i, j] != 1000000000) //Si el numero es muy grande, no habra relacion entre esos vertices
                    {
                        if (i != j)
                        {
                            if (caminos[i, j].Equals(""))
                            {
                                caminitos += "De (" + (i + 1) + "--->" + (j + 1) + ") Irse por... (" + (i + 1) + ", " + (j + 1) + ") \n";
                            }
                            else
                            {
                                caminitos += "De (" + (i + 1) + "--->" + (j + 1) + ") Irse por... (" + (i + 1) + ", " + caminos[i, j] + ", " + (j + 1) + ") \n";
                            }
                        }
                    }
                }
            }

            //Regresemaos los resultados
            return  "\nLos diferentes caminos mas cortos entre vertices son: \n" + caminitos;
        }

        public string CaminosR(int i, int k, string[,] caminosAuxiliares, string caminoRecorrido) //Este metodo recursivo nos ayuda a seguir el camino donde los vertices relacionados pasan
        {
            if (caminosAuxiliares[i, k].Equals(""))
            {
                return "";
            }
            else
            {
                //Recursividad
                caminoRecorrido += CaminosR(i, int.Parse(caminosAuxiliares[i, k].ToString()), caminosAuxiliares, caminoRecorrido) + (int.Parse(caminosAuxiliares[i, k].ToString()) + 1) + ", ";
                return caminoRecorrido;
            }
        }
        
        public void Circuitos(long[,] ma, int x) //Metodo para encontrar los circuitos
        {
            
            if( x == 1)
            {
                if (ma[0, 1] == 1) //Verifica si los nodos estan relacionados, si lo estan, los imprime
                    Console.Write("a b");

                if (ma[1, 4] == 1)
                    Console.Write(" e");

                if (ma[4, 2] == 1)
                    Console.Write(" c");

                if (ma[2, 1] == 1)
                    Console.Write(" b");

                Console.WriteLine();
            }

            if( x == 2)
            {
                if (ma[0, 3] == 1) //Verifica si los nodos estan relacionados, si lo estan, los imprime
                    Console.Write("a d");

                if (ma[3, 0] == 1)
                    Console.Write(" a");

                if (ma[0, 3] == 1)
                    Console.Write(" d");

                if (ma[3, 0] == 1)
                    Console.Write(" a");

                Console.WriteLine();
            }

            if( x == 3) //Verifica si los nodos estan relacionados, si lo estan, los imprime
            {
                if (ma[0, 3] == 1)
                    Console.Write("a d");

                if (ma[3, 1] == 1)
                    Console.Write(" b");

                if (ma[1, 4] == 1)
                    Console.Write(" e");

                if (ma[4, 0] == 1)
                    Console.Write(" a");

                Console.WriteLine("\nNo es posible completarlo ya que no existe conexion entre b y d" );
                Console.WriteLine();
            }

            if (x == 4) //Verifica si los nodos estan relacionados, si lo estan, los imprime
            {
                if (ma[0, 1] == 1)
                    Console.Write("a b");

                if (ma[1, 4] == 1)
                    Console.Write(" e");

                if (ma[4, 2] == 1)
                    Console.Write(" c");

                if (ma[2, 1] == 1)
                    Console.Write(" b");

                if (ma[1, 3] == 1)
                    Console.Write(" d");

                if (ma[3, 0] == 1)
                    Console.Write(" a");

                Console.WriteLine("\nNo es posible completarlo ya que no existe conexion entre b y d");
                Console.WriteLine();
            }

        }
    }
}
