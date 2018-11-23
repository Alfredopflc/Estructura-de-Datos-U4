using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Opc
    {
        Arbol arbol = new Arbol();
        Tree tree = new Tree();
        Tree tree2 = new Tree();

        public void Opcion (int opc)
        {
            if (opc == 1) //Ejercicio 1
            {
                Console.WriteLine("\t\n Ejercicio 1");
                Console.WriteLine();
                Nodo raiz = arbol.Insertar("Ganador", null); //Aqui se crea un arbol con los 25 participantes y sus respectivos partidos

                Nodo Nodo1 = arbol.Insertar("1", raiz);
                Nodo Nodo2 = arbol.Insertar("20", raiz);

                Nodo Nodo3 = arbol.Insertar("1", Nodo1);
                Nodo Nodo4 = arbol.Insertar("7", Nodo1);
                Nodo Nodo5 = arbol.Insertar("18", Nodo2);
                Nodo Nodo6 = arbol.Insertar("20", Nodo2);

                Nodo Nodo7 = arbol.Insertar("1", Nodo3);
                Nodo Nodo8 = arbol.Insertar("4", Nodo3);
                Nodo Nodo9 = arbol.Insertar("7", Nodo4);
                Nodo Nodo10 = arbol.Insertar("12", Nodo4);
                Nodo Nodo11 = arbol.Insertar("18", Nodo5);
                Nodo Nodo12 = arbol.Insertar("20", Nodo6);
                Nodo Nodo13 = arbol.Insertar("25", Nodo6);

                Nodo Nodo14 = arbol.Insertar("1", Nodo7);
                Nodo Nodo15 = arbol.Insertar("4", Nodo8);
                Nodo Nodo16 = arbol.Insertar("6", Nodo8);
                Nodo Nodo17 = arbol.Insertar("7", Nodo9);
                Nodo Nodo18 = arbol.Insertar("9", Nodo9);
                Nodo Nodo19 = arbol.Insertar("12", Nodo10);
                Nodo Nodo20 = arbol.Insertar("14", Nodo10);
                Nodo Nodo21 = arbol.Insertar("16", Nodo11);
                Nodo Nodo22 = arbol.Insertar("18", Nodo11);
                Nodo Nodo23 = arbol.Insertar("20", Nodo12);
                Nodo Nodo24 = arbol.Insertar("22", Nodo12);
                Nodo Nodo25 = arbol.Insertar("23", Nodo13);
                Nodo Nodo26 = arbol.Insertar("25", Nodo13);

                Nodo Nodo27 = arbol.Insertar("1", Nodo14);
                Nodo Nodo28 = arbol.Insertar("2", Nodo14);
                Nodo Nodo29 = arbol.Insertar("3", Nodo15);
                Nodo Nodo30 = arbol.Insertar("4", Nodo15);
                Nodo Nodo31 = arbol.Insertar("5", Nodo16);
                Nodo Nodo32 = arbol.Insertar("6", Nodo16);
                Nodo Nodo33 = arbol.Insertar("7", Nodo17);
                Nodo Nodo34 = arbol.Insertar("8", Nodo17);
                Nodo Nodo35 = arbol.Insertar("9", Nodo18);
                Nodo Nodo36 = arbol.Insertar("10", Nodo18);
                Nodo Nodo37 = arbol.Insertar("11", Nodo19);
                Nodo Nodo38 = arbol.Insertar("12", Nodo19);
                Nodo Nodo39 = arbol.Insertar("13", Nodo20);
                Nodo Nodo40 = arbol.Insertar("14", Nodo20);
                Nodo Nodo41 = arbol.Insertar("15", Nodo21);
                Nodo Nodo42 = arbol.Insertar("16", Nodo21);
                Nodo Nodo43 = arbol.Insertar("17", Nodo22);
                Nodo Nodo44 = arbol.Insertar("18", Nodo22);
                Nodo Nodo45 = arbol.Insertar("19", Nodo23);
                Nodo Nodo46 = arbol.Insertar("20", Nodo23);
                Nodo Nodo47 = arbol.Insertar("21", Nodo24);
                Nodo Nodo48 = arbol.Insertar("22", Nodo24);
                Nodo Nodo49 = arbol.Insertar("23", Nodo25);
                Nodo Nodo50 = arbol.Insertar("24", Nodo25);
                Nodo Nodo51 = arbol.Insertar("25", Nodo26);

                arbol.ImprimirArbol(raiz); //Se imprime el arbol 

                int ganados = arbol.Nivel(raiz);
                int partidos = arbol.Partidos(raiz);

                Console.WriteLine("\nPartidos jugados por el ganador: {0}", ganados); //Los partidos jugados son equivalentes al numero de niveles del arbol
                Console.WriteLine("Cantidad de partidos jugados: {0}", partidos); //Se uso el metodo Partidos que ve que nodos tienen dos hijos, y asi contar el numero de partidos realizados
                Console.WriteLine("Cantidad de latas abiertas: {0}", partidos); //Al igual que el numero de latas, ya que se abre solo una por partido
                Console.WriteLine("Sets posibles: {0}", (partidos * 5)); //el nuero de sets maximos seran de 5 por juego, ya que pueden quedar 3-2, asi que solo se multiplica por 5

            }

            if (opc == 2) //Ejercicio 2, NO LOGRADO :c
            {
                Console.WriteLine("\t\n Ejercicio 2");
                Console.WriteLine("EJERCICIO NO LOGRADO");
                Console.WriteLine("Cartas Totales: 195310");
                Console.WriteLine("Cartas en los ultimos 3 Domingos: 193750");
            }

            if (opc == 3) //Ejercicio 3
            {
                Console.WriteLine("\t\n Ejercicio 3");
                Console.WriteLine();
                Console.WriteLine("\tArbol normal: \n"); //Primero se construye el arbol que genera la impresion como se pide
                Nodo raiz = arbol.Insertar("a(4)", null);
                Nodo b = arbol.Insertar("b(2)", raiz);
                Nodo c = arbol.Insertar("c(8)", raiz);
                Nodo d = arbol.Insertar("d(1)", b);
                Nodo e = arbol.Insertar("e(3)", b);
                Nodo f = arbol.Insertar("f(6)", c);
                Nodo g = arbol.Insertar("g(10)", c);
                Nodo h = arbol.Insertar("h(5)", f);
                Nodo i = arbol.Insertar("i(7)", f);
                Nodo j = arbol.Insertar("j(9)", g);
                Nodo k = arbol.Insertar("k(11)", g);

                arbol.ImprimirArbol(raiz); //Se imprime el arbol
                tree.Insert(4); //Se usan valores para representar las letras y asi que sean acomodadas
                tree.Insert(2);
                tree.Insert(8);
                tree.Insert(1);
                tree.Insert(3);
                tree.Insert(6);
                tree.Insert(10);
                tree.Insert(5);
                tree.Insert(7);
                tree.Insert(9);
                tree.Insert(11);
                Console.WriteLine("\nd,e,b,h,i,f,j,k,g,c,a");
                Console.WriteLine("\nInorden:");
                tree.Inorder(tree.ReturnRoot()); //Se acomodan por el metodo Inorder
                Console.WriteLine("\n\n");

                Console.WriteLine("\tArbol con altura 3\n"); //Se construye el arbol, pero con una altura de 3
                raiz = arbol.Insertar("a(7)", null);
                b = arbol.Insertar("b(3)", raiz);
                c = arbol.Insertar("c(6)", raiz);
                d = arbol.Insertar("d(1)", b);
                e = arbol.Insertar("e(2)", b);
                f = arbol.Insertar("f(4)", c);
                g = arbol.Insertar("g(5)", c);
                arbol.ImprimirArbol(raiz);

                tree2.Insert(7); //Se usan valores para representar las letras y asi que sean acomodadas
                tree2.Insert(3);
                tree2.Insert(6);
                tree2.Insert(1);
                tree2.Insert(2);
                tree2.Insert(4);
                tree2.Insert(5);
                
                Console.WriteLine("\nd,e,b,f,g,c,a");
                Console.WriteLine("\nInorden:");
                tree.Inorder(tree2.ReturnRoot()); //Se acomodan por el metodo Inorder
            }

            if (opc == 4) //Ejercicio 4
            {
                Console.WriteLine("\t\n Ejercicio 4");
                Console.WriteLine();
                Nodo raiz = arbol.Insertar("Banana(1)", null); //Se construye el arbol de forma alfabetica
                Nodo nada = arbol.Insertar("", raiz);
                Nodo Melocoton = arbol.Insertar("Melocoton(5)", raiz);
                Nodo Manzana = arbol.Insertar("Manzana(4)", Melocoton);

                Nodo Coco = arbol.Insertar("Coco(2)", Manzana);
                Nodo nada4 = arbol.Insertar("", Manzana);
                Nodo nada2 = arbol.Insertar("", Coco);
                Nodo Mango = arbol.Insertar("Mango(3)", Coco);
                Nodo Pera = arbol.Insertar("Pera(7)", Melocoton);
                Nodo Papaya = arbol.Insertar("Papaya(6)", Pera);

                arbol.ImprimirArbol(raiz); //Se imprime el arbol             
                tree.Insert(1); //Se construye un arbol binario para ayudar a acomodar los datos 
                tree.Insert(5);
                tree.Insert(4);
                tree.Insert(7);
                tree.Insert(2);
                tree.Insert(3);
                tree.Insert(6);
                Console.WriteLine("\nInorden:");
                tree.Inorder(tree.ReturnRoot()); //Se imprime con el metodo Inorder
            }

            if (opc == 5) //Ejercicio 5
            {
                Console.WriteLine("\t\n Ejercicio 5");
                Console.WriteLine();
                Nodo raiz = arbol.Insertar("Econologia(4)", null); //Se construye un arbol con las palabras asignadas
                Nodo cam = arbol.Insertar("Campanologia(3)", raiz);
                Nodo fre = arbol.Insertar("Frenologia(5)", raiz);
                Nodo al = arbol.Insertar("Alquimia(1)", cam);
                Nodo nada1 = arbol.Insertar("", al);
                Nodo ast = arbol.Insertar("Astrologia(2)", al);
                Nodo nada2 = arbol.Insertar("", fre);
                Nodo orn = arbol.Insertar("Ornitologia(8)", fre);
                Nodo ic = arbol.Insertar("Ictionologia(6)", orn);
                Nodo nada3 = arbol.Insertar("", ic);
                Nodo lim = arbol.Insertar("Limnologia(7)", ic);

                arbol.ImprimirArbol(raiz); //Se imprime el arbol  
                tree.Insert(4); //Arbol binario para acomodar las palabras
                tree.Insert(5);
                tree.Insert(3);
                tree.Insert(8);
                tree.Insert(6);
                tree.Insert(7);
                tree.Insert(1);
                tree.Insert(2);

                Console.WriteLine("\nInorden:");
                tree.Inorder(tree.ReturnRoot()); //Se imprimen con el metodo Inorder
            }

            if (opc == 6) //Ejercicio 6
            {
                Console.WriteLine("\t\n Ejercicio 6");
                Console.WriteLine();
                Nodo raiz = arbol.Insertar("salta(5)", null); //Se crea un arbol con las palabras acomodadas alfabeticamente
                Nodo zo = arbol.Insertar("zorro(3)", raiz);
                Nodo pe = arbol.Insertar("perro(8)", raiz);
                Nodo ra = arbol.Insertar("rapido(2)", zo);
                Nodo ma = arbol.Insertar("marron(4)", zo);
                Nodo El = arbol.Insertar("El(1)", ra);
                Nodo el = arbol.Insertar("el(7)", pe);
                Nodo so = arbol.Insertar("sobre(6)", el);
                Nodo per = arbol.Insertar("perezoso(9)", pe);
                
                arbol.ImprimirArbol(raiz); //Se imprime el arbol

                tree.Insert(5); //Se inicia un arbol binario para acomodar los datos
                tree.Insert(3);
                tree.Insert(8);
                tree.Insert(2);
                tree.Insert(4);
                tree.Insert(7);
                tree.Insert(9);
                tree.Insert(1);
                tree.Insert(6);

                Console.WriteLine("\nEl rápido zorro marrón salta sobre el perro perezoso");
                tree.Inorder(tree.ReturnRoot()); //Se imprimen con el metodo Inorder
            }

            if (opc == 7) //Ejercicio 7
            {
                Console.WriteLine("\t\n Ejercicio 7");
                Console.WriteLine();
                ArbolTexto AT = new ArbolTexto(); //Se inicia un objeto tipo ArbolTexto

                AT.Insertar("j"); //Al insertar las letras, las acomodara por orden alfabetico 
                AT.Insertar("f");
                AT.Insertar("j");
                AT.Insertar("c");
                AT.Insertar("i");
                AT.Insertar("p");
                AT.Insertar("a");
                AT.Insertar("e");
                AT.Insertar("m");
                AT.Insertar("p");
                AT.Insertar("k");
                AT.Insertar("o");
                AT.Insertar("q");
                AT.Insertar("p");
                AT.Insertar("u");

                AT.Caminos(); //Se llama al metodo Caminos para encontrar el camino a las hojas
                AT.ImprimirCaminos(); //Se llama al metodo ImprimirCaminos representados por 0 y 1 a los ultimos datos
            }

            if (opc == 8) //Ejercicio 8
            {
                Console.WriteLine("\t\n Ejercicio 8");
                Console.WriteLine();
                tree.Insert(-1); //Simplemente se agregan los valores y el metodo inorder los acomodara
                tree.Insert(0);
                tree.Insert(2);
                tree.Insert(-2);
                tree.Insert(3);
                tree.Insert(6);
                tree.Insert(-3);
                tree.Insert(5);
                tree.Insert(1);
                tree.Insert(4);
                tree.Inorder(tree.ReturnRoot());

                Console.WriteLine();
                tree2.Insert(-1);
                tree2.Insert(7);
                tree2.Insert(4);
                tree2.Insert(11);
                tree2.Insert(5);
                tree2.Insert(-8);
                tree2.Insert(15);
                tree2.Insert(-3);
                tree2.Insert(-2);
                tree2.Insert(6);
                tree2.Insert(10);
                tree2.Insert(3);
                tree2.Inorder(tree2.ReturnRoot());
            }

            if (opc == 9) //Ejercicio 9
            {
                CaminosMinimos Ruta = new CaminosMinimos(); //Se inicia objeto de la clase CaminosMinimos

                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5
                Console.WriteLine("\t\n Ejercicio 9");
                Console.WriteLine();
                Console.WriteLine("\nA)");
                long[,] MatrizA = //Se crea una matriz con los valores relacionados
                { { 0, 999999999, 999999999, 999999999, 1 },//a
                  { 1, 0, 1, 999999999, 999999999 }, //b
                  { 999999999, 999999999, 0, 999999999 , 999999999 }, //c
                  { 999999999, 1, 1, 0, 1 }, //d
                  { 999999999,1, 999999999,999999999,0 }}; //e

                //Objeto de la clase

                Console.WriteLine("\n\tNOTA: a = 1, b = 2, c = 3, d = 4, e = 5 \n");
                Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizA,5)); //Se manda a llamar el algoritmofloyd para encontrar esos caminos

               
                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6
                Console.WriteLine("\nB)"); 
                long[,] MatrizB = //Se crea una matriz con los valores relacionados
                { { 999999999, 999999999, 999999999, 999999999, 999999999, 1 }, //a
                  { 1, 999999999, 999999999, 999999999, 999999999, 999999999 }, //b
                  { 999999999, 1, 999999999, 1 , 999999999, 999999999}, //c
                  { 999999999, 999999999, 999999999, 999999999, 1, 999999999 }, //d
                  { 999999999,1,1,999999999,999999999,1 }, //e
                  { 999999999,999999999,999999999,999999999,999999999,999999999} }; //f

                Console.WriteLine("\n\tNOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6 \n");
                Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizB, 6)); //Se manda a llamar el algoritmofloyd para encontrar esos caminos

                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g =  7, h = 8, i = 9
                Console.WriteLine("\nC)");
                long[,] MatrizC = //Se crea una matriz con los valores relacionados
                { { 999999999, 999999999, 1,  999999999, 999999999, 999999999, 999999999, 999999999, 1 }, //a
                  { 1, 999999999, 1, 999999999, 999999999, 999999999, 999999999, 1, 999999999 }, //b
                  { 999999999, 999999999, 999999999, 999999999 , 999999999, 999999999, 999999999, 999999999, 999999999},//c
                  { 999999999, 1, 1, 999999999, 1, 999999999, 999999999, 999999999, 999999999 },//d
                  { 999999999,999999999, 999999999, 1, 999999999,999999999,999999999,999999999, 999999999}, //e
                  { 999999999,999999999,999999999,1,1,999999999, 1, 999999999, 999999999}, //f
                  { 999999999, 999999999, 1, 1, 999999999, 999999999, 999999999, 999999999, 999999999 },//g
                  { 999999999, 999999999, 999999999, 999999999, 999999999, 1, 1, 999999999, 1 }, //h
                  { 1, 999999999, 999999999, 999999999, 999999999, 999999999, 1, 999999999, 999999999 } }; //i

                Console.WriteLine("\n\tNOTA: a = 1, b = 2, c = 3, d = 4, e = 5, f = 6 \n");
                Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizC, 9)); //Se manda a llamar el algoritmofloyd para encontrar esos caminos
            }

            if (opc == 10) //Ejercicio 10
            {
                CaminosMinimos CM = new CaminosMinimos(); //Se inicia objeto de la clase CaminosMinimos
                //NOTA: a = 1, b = 2, c = 3, d = 4, e = 5
                Console.WriteLine("\t\n Ejercicio 10");
                Console.WriteLine();

                long[,] MatrizA = //Se crea una matriz con los valores relacionados
                { { 999999999, 1, 999999999, 1, 999999999 }, //a
                  { 1, 999999999, 999999999, 999999999, 1 }, //b
                  { 999999999, 1, 999999999, 999999999 , 999999999 }, //c
                  { 1, 999999999, 999999999, 999999999, 999999999 }, //d
                  { 999999999, 999999999, 1, 1,999999999 }}; //e

                Console.WriteLine("ab y ad son circuitos"); 

                CM.Circuitos(MatrizA, 1); //Se manda a llamar al metodo circuitos
                CM.Circuitos(MatrizA, 2);
                CM.Circuitos(MatrizA, 3);
                CM.Circuitos(MatrizA, 4);
            }
        }
    }
}
