﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoleoC_NullableTypesDemo
{
    internal class _23_Nullable
    {
        public class NullableTypesDemo
        {
            // Exemplo de um tipo nullable (int?)
            public int? Numero { get; set; }

            // Exemplo de uso do operador de coalescência nula (??)
            public int ObterValorOuPadrao()
            {
                // Se Numero for null, retorna 0, caso contrário, retorna o valor de Numero
                return Numero ?? 0;
            }

            // Exemplo de Nullable<T> explicitamente
            public Nullable<bool> EstaCompleto { get; set; }

            public void ExibirValores()
            {
                Console.WriteLine($"Numero: {Numero}");
                Console.WriteLine($"EstaCompleto: {EstaCompleto}");
            }

            public void ExplicarConceitos()
            {
                Console.WriteLine("=== Nullable Types ===");
                Console.WriteLine("Em C#, tipos de valor (como int, bool, etc.) normalmente não podem ser null.");
                Console.WriteLine("Mas, com Nullable Types, podemos permitir que esses tipos de valor sejam null.");
                Console.WriteLine("Por exemplo, 'int?' é um tipo nullable que pode conter um valor int ou null.");

                Console.WriteLine("\n=== Operador de Coalescência Nula (??) ===");
                Console.WriteLine("O operador ?? permite fornecer um valor padrão se a expressão anterior for null.");
                Console.WriteLine("Por exemplo, 'Numero ?? 0' retorna 0 se Numero for null, caso contrário, retorna o valor de Numero.");

                Console.WriteLine("\n=== Nullable<T> ===");
                Console.WriteLine("Nullable<T> é uma estrutura que suporta tipos anuláveis, onde T é o tipo de valor subjacente.");
                Console.WriteLine("Por exemplo, 'Nullable<bool>' é equivalente a 'bool?'.");
            }
        }
        public class Recursao
        {
            // Método para calcular o fatorial de um número usando recursão
            public int CalcularFatorial(int numero)
            {
                if (numero <= 1)
                    return 1; // Caso base: fatorial de 0 ou 1 é 1
                else
                    return numero * CalcularFatorial(numero - 1); // Chamada recursiva
            }

            // Método para calcular a sequência de Fibonacci até um determinado termo usando recursão
            public int CalcularFibonacci(int termo)
            {
                if (termo == 0)
                    return 0; // Caso base: Fibonacci de 0 é 0
                else if (termo == 1)
                    return 1; // Caso base: Fibonacci de 1 é 1
                else
                    return CalcularFibonacci(termo - 1) + CalcularFibonacci(termo - 2); // Chamada recursiva
            }

            // Método para demonstrar o conceito de recursão
            public void DemonstrarRecursao()
            {
                Console.WriteLine("Fatorial de 5: " + CalcularFatorial(5));
                Console.WriteLine("Fibonacci do 6º termo: " + CalcularFibonacci(6));
            }
        }
    }
}
