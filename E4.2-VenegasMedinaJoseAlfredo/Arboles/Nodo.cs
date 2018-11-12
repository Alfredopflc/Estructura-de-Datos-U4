using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    public class Nodo
    {
        private string dato; //Dato que guardara el nodo, en este caso un string

        private Nodo hijo;  //Referencia a hijo y hermano
        private Nodo hermano;

        public string Dato { get => dato; set => dato = value; } //Propiedades
        public Nodo Hijo { get => hijo; set => hijo = value; }
        public Nodo Hermano { get => hermano; set => hermano = value; }

        public Nodo() //Constructor
        {
            dato = ""; 
            hijo = null; //Se inicia como null para no tener referencias al inicio
            hermano = null;
        }
    }
}
