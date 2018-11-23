using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Tree //Arbol binario
    {
        public Node root; //Raiz

        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int id) //Metodo para insertar nodos
        {
            Node newNode = new Node();

            newNode.item = id;

            if (root == null)

                root = newNode;
            else
            {
                Node current = root;
                Node parent;

                while (true) //Si el valor es menor se acomodara a la izquierda, si es mayor a la derecha del nodo 
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }

                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }

        

        public void Preorder(Node Root) //Metodo para imprimir arbol en Preorden
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.leftc);
                Preorder(Root.rightc);
            }
        }

        public void Inorder(Node Root) //Metodo para imprimir arbol en Enorden
        {
            if (Root != null)
            {
                Inorder(Root.leftc);
                Console.Write(Root.item + " ");
                Inorder(Root.rightc);
            }
        }


        public void Postorder(Node Root) //Metodo para imprimir arbol en Postorden
        {
            if (Root != null)
            {
                Postorder(Root.leftc);
                Postorder(Root.rightc);
                Console.Write(Root.item + " ");
            }
        }
    }
}
