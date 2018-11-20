using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CaminosMinimos
    {
        public string AlgoritmoFloyd(long[,] matrizAdyacencia) //Metodo para imprimir los vertices relacionados
        {
            
            int vertices = 7;
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
                    if(matrizAdyacencia[i,j] != 1000000000) //Si el numero es muy grande, no habra relacion entre esos vertices
                    {
                        if(i != j)
                        {
                            if(caminos[i,j].Equals(""))
                            {
                                caminitos += "De (" + (i + 1) + "--->" + (j + 1) + ") Irse por... (" + (i + 1) + ", " + (j + 1) + ") \n";
                            }
                            else
                            {
                                caminitos += "De (" + (i + 1) + "--->" + (j + 1) + ") Irse por... (" + (i + 1) + ", " + caminos[i,j] + ", " + (j + 1) + ") \n";
                            }
                        }
                    }
                }
            }

            //Regresemaos los resultados
            return "La Matriz de Caminos Mas Cortos Entre los diferentes vertices es: \n" + cadena + 
                "\nLos diferentes caminos mas cortos entre vertices son: \n" + caminitos;
        }

        public string CaminosR(int i, int k, string[,] caminosAuxiliares, string caminoRecorrido) //Este metodo recursivo nos ayuda a seguir el camino donde los vertices relacionados pasan
        {
            if(caminosAuxiliares[i,k].Equals(""))
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

        //Codigo basado en: 
        //https: //www.youtube.com/watch?v=xK0ShW9G-Ts&t=0s&index=50&list=PLCLpAU8VN0j4RGemFfybZrWoSX57NbEq9
    }
}
