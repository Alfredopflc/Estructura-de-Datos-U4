using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class ArbolTexto
    {
        NodoTexto raiz; //Se crea Nodo raiz y lista tipo string
        List<string> caminos;

        public ArbolTexto()
        {
            raiz = null;
        }

        public void Insertar(string dato) //Metodo para insertar nodos tipo string
        {
            NodoTexto nuevo;
            nuevo = new NodoTexto();
            nuevo.dato = dato;
            nuevo.i = null;
            nuevo.d = null;

            if (raiz == null)
            {
                raiz = nuevo;
            }

            else
            {
                NodoTexto val = null, comp;
                comp = raiz;

                while (comp != null) //Se comparara si la primera letra es mayor o menor dependiendo de su numero correspondiente en ascci
                {
                    val = comp;
                    if (Convert.ToInt32(dato[0]) < Convert.ToInt32(comp.dato[0]))
                        comp = comp.i;

                    else
                        comp = comp.d;
                }

                if (Convert.ToInt32(dato[0]) < Convert.ToInt32(val.dato[0]))
                    val.i = nuevo;

                else
                    val.d = nuevo;
            }
        }
        
        public void Caminos() //Guarda los datos en una lista
        {
            caminos = new List<string>();
            Caminos(raiz, "");
        }

        public void Caminos(NodoTexto comp, string cam) //Metodo para imprimir los resultados y caminos de cada hoja
        {
            if (comp != null)
            {
                if (comp.i == null && comp.d == null)
                {
                    cam = cam + " es el camino de: " + comp.dato;
                    caminos.Add(cam);
                }

                Caminos(comp.i, cam + "0");
                Caminos(comp.d, cam + "1");
            }
        }

        public void ImprimirCaminos() //Metodo para mostrar los elementos guardados en la lista
        {
            foreach (string item in caminos)
            {
                Console.WriteLine(item);
            }
        }
    }
}