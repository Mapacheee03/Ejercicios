using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Matrices
    { 
       public void Bidimensional3x3()
       {
            //Declarar la variable
            int[,] Matriz = new int[3, 3];
            //Aqui llenaras la matriz con los valores del 1 al 9.
            int valor = 1;
            for(int fila = 0; fila < 3; fila++)
            {
                for(int columna=0; columna < 3; columna++)
                {
                    Matriz[fila, columna]= valor;
                    valor++;
                }               
            }
            //Aqui se imprimira en la consola.
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columnb = 0; columnb < 3; columnb++)
                {
                    Console.Write(Matriz[fila, columnb] + "\t");
                }
                Console.WriteLine();
            }
       }
        public void Bidimensional2x2()
        {
            //declarar la matriz 2x2
            string[,] Matriz = new string[2, 2];
            //llenar la matriz con nombres de colores.
            Matriz[0, 0] = "ROJO";
            Matriz[0, 1] = "VERDE";
            Matriz[1, 0] = "MORADO";
            Matriz[1, 1] = "AZUL";
            //Imprimir la matriz
            for(int fila = 0; fila < 2; fila++)
            {
                for(int columna = 0; columna < 2; columna++)
                {
                    Console.Write(Matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Bidimensional4x3()
        {
            double[,] Matriz = new double[4, 3];

            double valor = 2.0;
            for(int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Matriz[fila, columna] = valor;
                    valor+=1.0;
                }
            }
            //calcular la suma
            double suma = 0.0;
            for(int fila = 0;fila < 4; fila++)
            {
                for(int columna=0; columna < 3; columna++)
                {
                    suma += Matriz[fila, columna];
                }
            }
            //imprimir en la consola
            Console.WriteLine("Matriz:");
            for(int fila = 0;fila<4; fila++)
            {
                for(int columna=0; columna < 3; columna++)
                {
                    Console.Write(Matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            //imprimir la suma de los elementos
            Console.WriteLine("Suma de los elementos de la matriz: "+ suma);
        }
        public void Bidimensional2x4()
        {
            char[,] Matriz = new char[2, 4];

            char Letra = 'A';
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Matriz[fila, columna] = Letra;
                    Letra++;
                }
            }
            //Imprimir la matriz
            Console.WriteLine("Matriz:");
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write(Matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
