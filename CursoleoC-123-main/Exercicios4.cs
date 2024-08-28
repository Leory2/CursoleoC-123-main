using CursoCSharp.Exercicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoleoC_
{
    internal class Exercicios4
    {
        /* Exercício: Declare uma variável de cada um dos seguintes tipos usando var e
         atribua a elas valores apropriados.Depois, exiba o tipo da variável usando
         GetType() para confirmar a inferência do tipo.*/

        public void Var123() 
        {
            var numero = 10;
            var nome = "Leo";
            var estudando = true;
            var letra = 'x';
            
            Console.WriteLine($"var numero:{numero.GetType()}");
            Console.WriteLine($"var nome:{nome.GetType()}");
            Console.WriteLine($"var estudando:{estudando.GetType()}");
            Console.WriteLine($"var letra:{letra.GetType()}");

        }
        /*   Exercício: Crie uma lista de inteiros e use um método LINQ para ordenar a lista
             em ordem crescente.Declare a variável que armazena o resultado usando var.*/

        public void MostrarLista()
        {
            List<int> numeros = new List<int>{5, 2, 1, 3, 4};
            var mostraLista = numeros.OrderBy( n => n ).ToList();
            foreach (var numero in mostraLista)
            {
                Console.WriteLine($" ordenados:{numero}");
            }
        }
            /*Exercício: Declare uma variável var para um tipo complexo, 
            como um Dictionary ou uma instância de uma classe personalizada.
            Mostre como a inferência de tipo funciona com tipos mais complexos.*/
            
        public class Exer4
        {
           
            char letra; 
            List<string> palavrasComletra = new List<string> { };
            public void Exercicio3()
            {
                var dictionary = new Exer4();
                {
                    letra = 'A';
                    palavrasComletra = new List<string> {"Abacate","Andar","Amar"};
                        
                }

                Console.WriteLine($"Tipo complexo:{dictionary.GetType()}");
            }
            /*  Exercício: Crie um tipo anônimo usando var para armazenar informações de
                uma pessoa(nome e idade) e exiba essas informações.*/

            public void Exercicio4() 
            {
                var pessoa = new
                {
                    Nome = "Leo",                                     
                    Idade = 19
                };
                Console.WriteLine($"O nome da pessoa é{pessoa.Nome} A idade da pessoa é {pessoa.Idade}");
            }
           
        
        }
       
    }
}
