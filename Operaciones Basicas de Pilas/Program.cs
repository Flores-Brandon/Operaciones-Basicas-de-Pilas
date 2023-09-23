using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Basicas_de_Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackWithArray pila = new StackWithArray(5); // Tamaño de la pila: 5 elementos

            Console.WriteLine("Operaciones de Pila:");

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);

            Console.WriteLine("Elemento superior de la pila: " + pila.Peek()); // Debe imprimir 5

            Console.WriteLine("Pop de la pila: " + pila.Pop()); // Debe imprimir 5
            Console.WriteLine("Elemento superior de la pila después del Pop: " + pila.Peek()); // Debe imprimir 4

            pila.Push(6);
            Console.WriteLine("Nuevo elemento superior de la pila: " + pila.Peek()); // Debe imprimir 6
        }
        class StackWithArray
        {
            private int[] arreglo;
            private int top;
            private int capacidad;

            public StackWithArray(int capacidad)
            {
                this.capacidad = capacidad;
                arreglo = new int[capacidad];
                top = -1; // Inicialmente, la pila está vacía
            }

            public void Push(int elemento)
            {
                if (top < capacidad - 1)
                {
                    arreglo[++top] = elemento;
                }
                else
                {
                    Console.WriteLine("Error: Pila llena.");
                }
            }

            public int Pop()
            {
                if (top >= 0)
                {
                    return arreglo[top--];
                }
                else
                {
                    Console.WriteLine("Error: Pila vacía.");
                    return -1;
                }
            }

            public int Peek()
            {
                if (top >= 0)
                {
                    return arreglo[top];
                }
                else
                {
                    Console.WriteLine("Error: Pila vacía.");
                    return -1;
                }
            }
        }
    }
}
