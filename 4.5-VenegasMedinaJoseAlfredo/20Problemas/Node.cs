using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Node //Clase Node para nodos en arbol binario
    {
        public int item;  //Dato del nodo

        public Node leftc; //Propiedades de izquierda y derecha

        public Node rightc;

        public void Display() //Display

        {
            Console.Write("[");

            Console.Write(item);

            Console.Write("]");

        }
    }
}
