using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Nodo
    {
        private string dato; //Dato que guardara el nodo, en este caso un string

        private Nodo hijo;  //Referencia a hijo y hermano
        private Nodo hermano;

        public string Dato { get { return dato; } set { dato = value; } } //Propiedades
        public Nodo Hijo { get { return hijo; } set { hijo = value; } }
        public Nodo Hermano { get { return hermano; } set { hermano = value; } }

        public Nodo() //Constructor
        {
            dato = "";
            hijo = null; //Se inicia como null para no tener referencias al inicio
            hermano = null;
        }
    }
}
