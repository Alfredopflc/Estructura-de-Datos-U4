﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializamos nuestra matriz, basado en nuestro 
            long[,] MatrizA = 
            { { 1, 1, 999999999, 999999999, 999999999, 999999999, 999999999 },
            {1,999999999, 1, 999999999, 999999999, 999999999,1 },
            {999999999, 1, 999999999, 1, 999999999, 999999999, 1 },
            {999999999, 999999999, 1, 999999999, 1, 1, 999999999 },
            {999999999, 999999999, 999999999, 1, 999999999, 1, 999999999, },
            {999999999, 999999999, 999999999, 1, 1, 999999999, 1 },
            {999999999, 1, 1, 999999999, 999999999, 1, 999999999, }};

            //Objeto de la clase
            CaminosMinimos Ruta = new CaminosMinimos();
            Console.WriteLine(Ruta.AlgoritmoFloyd(MatrizA));
            Console.ReadKey();

            //Codigo basado en: 
            //https: //www.youtube.com/watch?v=xK0ShW9G-Ts&t=0s&index=50&list=PLCLpAU8VN0j4RGemFfybZrWoSX57NbEq9
        }
    }
}