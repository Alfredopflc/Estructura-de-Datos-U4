using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Arbol
    {
        private Nodo raiz; //Nodo raiz
        private Nodo trabajo;
        private int i = 0;
        int altura = 1, nivel = 0, partidos = 0;
        List<string> Lista = new List<string>();

        public Arbol() //Constructor de la clase
        {
            raiz = new Nodo(); //Instancia el nodo raiz
        }

        public Nodo Insertar(string pDato, Nodo pNodo) //Metodo para insertar elementos al nodo. (Dato, el nodo donde se va a insertar)
        {
            //Si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if (pNodo == null)
            {
                raiz = new Nodo();
                raiz.Dato = pDato;
                //No hay hijo
                raiz.Hijo = null;
                //No hay hermano
                raiz.Hermano = null;

                return raiz;
            }

            //Verificamos si no tiene hijo, si es asi, insertamos el dato como hijo
            if (pNodo.Hijo == null)
            {
                Nodo temp = new Nodo();
                temp.Dato = pDato;
                //Conectamos el nuevo nodo como hijo
                pNodo.Hijo = temp;

                return temp;
            }

            else //Ya tiene hijo, tenemos que insertarlo como hermano
            {
                trabajo = pNodo.Hijo; //Sera el primer hijo
                //Avanzamos hasta el ultimo hermano
                while (trabajo.Hermano != null) //Buscamos al ultimo hermano
                {
                    trabajo = trabajo.Hermano;
                }

                Nodo temp = new Nodo(); //Nodo temporal
                temp.Dato = pDato;
                trabajo.Hermano = temp; //Se conecta el ultimo hermano con el nuevo nodo

                return temp;
            }
        }

        public void Imprimir(Nodo pNodo) //Se imprime en Preorden (Nodo al cual queremos hacer la transversa)
        {
            if (pNodo == null) //Caso base, nodo que no existe
                return;

            //for (int n = 0; n < i; n++) //Se agrega para diferenciar en que nivel estan los nodos
            //    Console.Write("  ");

            Console.Write(pNodo.Dato); //Se imprime el dato

            if (pNodo.Hijo != null)
            {
                i++; //Contador para saber que profundidad existe
                Imprimir(pNodo.Hijo); //Se vuelve a llamar al mismo metodo
                i--; //Contador vueelve al valor anterior
            }

            if (pNodo.Hermano != null) //Si existe hermano hara su transversa
                Imprimir(pNodo.Hermano);
        }

        public void ImprimirArbol(Nodo pNodo) //Se imprime en Preorden (Nodo al cual queremos hacer la transversa)
        {
            if (pNodo == null) //Caso base, nodo que no existe
                return;

            for (int n = 0; n < i; n++) //Se agrega para diferenciar en que nivel estan los nodos
                Console.Write("-");

            Console.WriteLine(pNodo.Dato); //Se imprime el dato

            if (pNodo.Hijo != null)
            {
                i++; //Contador para saber que profundidad existe
                ImprimirArbol(pNodo.Hijo); //Se vuelve a llamar al mismo metodo
                i--; //Contador vueelve al valor anterior
            }

            if (pNodo.Hermano != null) //Si existe hermano hara su transversa
                ImprimirArbol(pNodo.Hermano);
        }

        public void Post(Nodo pNodo) //Se imprime en Preorden (Nodo al cual queremos hacer la transversa)
        {
            if (pNodo == null) //Caso base, nodo que no existe
                return;

            

            if (pNodo.Hijo != null)
            {            
                Post(pNodo.Hijo); //Se vuelve a llamar al mismo metodo               
            }

            Console.Write(pNodo.Dato + " "); //Se imprime el dato

            if (pNodo.Hermano != null) //Si existe hermano hara su transversa
            {
                Post(pNodo.Hermano);
                
            }
        }

        public void Enorden(Nodo pNodo) //Este metodo imprime los valores en Enorden
        {
            if (pNodo == null)
                return;

            if (pNodo.Hijo != null)
            {
                Enorden(pNodo.Hijo);             
            }

            Console.Write(pNodo.Dato);                   
        }

        public int Nivel(Nodo pNodo) //Metodo Altura
        {
            //Cada vez que detecte que un nodo tiene un hijo, se le sumara 1 a la variable altura y a su vez
            //Se usa recursividad para volver a usar el metodo hasta que encuentre el ultimo nodo sin hijos
            if (pNodo.Hijo != null)
            {
                Nivel(pNodo.Hijo);
                nivel++;
            }

            return nivel;

        }

        public int Partidos(Nodo pNodo) //Metodo para calcular numero de partidos
        {
            if (pNodo.Hijo != null && pNodo.Hermano != null) //Si existe un nodo con hijo y hermano, entonces sera un partido
            {
                partidos++; //Se le sumara 1
                Partidos(pNodo.Hijo); //Usaremos recursividad con cada hijo y hermano
                Partidos(pNodo.Hermano);
            }

            else if (pNodo.Hijo != null) //si es hijo no es nulo, pero el hermano si
            {
                Partidos(pNodo.Hijo); //entonces buscara si hay otro partido con recursividad
            }

            else if(pNodo.Hermano != null) //Si tiene hermano, lo usara como recursivo igualmente
            {
                Partidos(pNodo.Hermano);
            }

            return partidos * 2; //se regresa el numero de partidos
        }
    }
}
