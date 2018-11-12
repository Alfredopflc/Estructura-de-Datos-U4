using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        private Nodo raiz; //Nodo raiz
        private Nodo trabajo; 
        private int i = 0; 
        int altura = 1, nivel = 0;
        List<string> Lista = new List<string> ();

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
                while(trabajo.Hermano != null) //Buscamos al ultimo hermano
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

            for (int n = 0; n < i; n++) //Se agrega para diferenciar en que nivel estan los nodos
                Console.Write("  ");

            Console.WriteLine(pNodo.Dato); //Se imprime el dato

            if(pNodo.Hijo != null)
            {
                i++; //Contador para saber que profundidad existe
                Imprimir(pNodo.Hijo); //Se vuelve a llamar al mismo metodo
                i--; //Contador vueelve al valor anterior
            }

            if (pNodo.Hermano != null) //Si existe hermano hara su transversa
                Imprimir(pNodo.Hermano);
        }

        ////

        public int Altura2(Nodo pNodo)
        {

            if (pNodo.Hijo != null)
            {
                Altura2(pNodo.Hijo);
                altura++;
            }

            if (pNodo.Hermano != null)
                Altura2(pNodo.Hermano);
            
            return altura;

        }

        public int Altura(Nodo pNodo)
        {
            Altura2(pNodo);
            return altura;
        }

        public int Nivel2(Nodo pNodo)
        {
            if (pNodo.Hijo != null)
            {
                Nivel2(pNodo.Hijo);
                nivel++;
            }

            if (pNodo.Hermano != null)
                Nivel2(pNodo.Hermano);

            return nivel;
        }

        public int Nivel(Nodo pNodo)
        {
            Nivel2(pNodo);
            return nivel;
        }

        public void Recorrido(Nodo pNodo)
        {
            if (pNodo.Hijo != null)
            {
                Lista.Add(pNodo.Dato);
                Recorrido(pNodo.Hijo);
            }

            if (pNodo.Hermano != null)
            {
                Lista.Add(pNodo.Hermano.Dato);
                Recorrido(pNodo.Hermano);
            }
        }

        public void Imprimir2()
        {
            foreach(var item in Lista)
            {
                Console.Write(item);
            }
        }
    }
}
