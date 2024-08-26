using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharp
{
    //public static class Exercicios2
    //{
    //Arrays
    //public static void EntradaSaida()
    //{

    //    //1. Criando e Inicializando um Array
    //    //Crie um array de inteiros chamado numeros com capacidade para 5 elementos.
    //    //Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.

    //    int[] numeros ={ 2, 4, 6, 8, 10 };

    //    for (int i = 0; i < numeros.Length; i++)
    //    {
    //        Console.WriteLine($"Elemento {i} do array numeros: {numeros[i]}");
    //    }

    //}

    //public static void EntradaSaida()
    //{

    //    //2. Acessando Elementos de um Array
    //    //Dado o array int[] valores = { 1, 3, 5, 7, 9 };, imprima o terceiro
    //    //elemento do array.


    //    int[] valores = { 1, 3, 5, 7, 9 };

    //    Console.WriteLine($"Terceiro elemento de valores: {valores[2]}");

    //}

    //public static void EntradaSaida()
    //{

    //    //3. Alterando Valores em um Array
    //    //Crie um array de strings chamado nomes com os valores  "Ana", "Bruno",
    //    //"Carla". Mude o valor de "Bruno" para "Beto" e depois imprima todos os
    //    //elementos do array.

    //    string[] nomes = { "Ana", "Bruno", "Carla" };

    //    for (int n = 0; n < nomes.Length; n++)
    //    {
    //        if (nomes[n] == "Bruno") 
    //        {
    //            nomes[n] = "Beto";
    //        }
    //    }

    //    for (int n = 0; n < nomes.Length; n++)
    //    {
    //        Console.WriteLine(nomes[n]);
    //    }

    //public static void EntradaSaida()
    //{

    ////4. Calculando a Soma dos Elementos de um Array
    ////Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6.
    ////Calcule e imprima a soma de todos os elementos do array.

    //    int[] notas = { 7, 8, 9, 10, 6 };
    //    int soma = 0;

    //    for (int i = 0; i < notas.Length; i++)
    //    {
    //      soma += notas[i];
    //    }

    //Console.WriteLine($"A soma de todos os itens do array é igual a: {soma}");
    //}

    //public static void EntradaSaida()
    //{

    ////5. Procurando um Elemento em um Array
    ////Dado o array int[] numeros = { 5, 10, 15, 20, 25 };, escreva um código
    ////que verifique se o número 15 está presente no array e imprima uma mensagem
    ////confirmando.

    //    int[] numeros = { 5, 10, 15, 20, 25 };

    //for (int n = 0; n < numeros.Length; n++)
    //{
    //    if (numeros[n] == 15)
    //    {
    //        Console.WriteLine("O número 15 está presente na lista");
    //    }

    //}

    //}


    //List
    //public static void EntradaSaida()
    //{

    ////1. Criando e Adicionando Elementos em uma List
    ////Crie uma List<string>; chamada frutas. Adicione as frutas "Maçã",
    ////"Banana", "Laranja"; e imprima todos os elementos da lista.

    //List<string> frutas = new List<string>();

    //frutas.Add("Maçã");
    //frutas.Add("Banana");
    //frutas.Add("Laranja");

    //foreach (string fruta in frutas)
    //{
    //    Console.WriteLine(fruta);
    //}

    //}

    // public static void EntradaSaida()
    //{

    ////2. Removendo um Elemento de uma List
    ////Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5.
    ////Remova o número 3 da lista e depois imprima os elementos restantes.

    //List<int> valores = new List<int> { 1, 2, 3, 4, 5 };

    //valores.Remove(3);

    //foreach (int valor in valores)
    //{
    //    Console.WriteLine(valor);
    //}

    //}

    //public static void EntradaSaida()
    //{

    //    //3. Acessando um Elemento Específico em uma List
    //    //Dada a List<string> chamada cidades = new List<string> {"São
    //    //Paulo", "Rio de Janeiro", "Belo Horizonte"}, imprima a segunda
    //    //cidade da lista.

    //    List<string> cidades = new List<string> { "São Paulo", "Rio de Janeiro", "Belo Horizonte" };

    //    Console.WriteLine(cidades[1]);

    //}

    //public static void EntradaSaida()
    //{

    //    //4. Contando Elementos em uma List
    //    //Crie uma List <string> chamada animais e adicione os valores "Cachorro",
    //    //"Gato", "Coelho". Escreva um código que imprima quantos elementos
    //    //existem na lista.

    //    List<string> animais = new List<string>();

    //    animais.Add("Cachorro");
    //    animais.Add("Gato");
    //    animais.Add("Coelho");

    //    int quant = animais.Count;

    //    Console.WriteLine($"A lista tem {quant} elementos.");

    //}
    //}

    //Escopo de Variáveis

    //public class Exercicios2

    //{
    //public void CalculaSoma(int n1, int n2)
    //{

    //    //1. Variável Local em um Método
    //    //Escreva um método chamado CalculaSoma que declare uma variável local int
    //    //soma e calcule a soma de dois números passados como parâmetros. A variável
    //    //soma deve estar acessível apenas dentro deste método.
    //    int soma = n1 + n2;


    //    Console.WriteLine(soma);

    //}
    //}

    //    //2. Variável Global em uma Classe
    //    //Crie uma classe chamada Carro com uma variável global string marca. No
    //    //método Main, instancie um objeto Carro, defina a marca do carro como
    //    //"Toyota" e imprima a marca.
    //    int soma = n1 + n2;

    //string marca = "Toyota";

    //public void Mostrar()
    //{
    //    Console.WriteLine(marca);
    //}

    //string nome = "";

    //public void Mostrar()
    //{
    //    string nome = "";
    //    Console.WriteLine(nome);
    //    Console.WriteLine(this.nome);

    //}

    //3. Conflito de Escopo
    //Escreva um método onde você declare uma variável local com o mesmo nome
    //de uma variável global da classe.Mostre como acessar ambas as variáveis no
    //mesmo método.

    //public void Mostrar()
    //{
    //    Console.WriteLine(marca);
    //}

    //string nome = "";

    //public void Mostrar()
    //{
    //    string nome = "";
    //    Console.WriteLine(nome);
    //    Console.WriteLine(this.nome);

    //}

    //4. Variável Local dentro de um Bloco Condicional
    //Escreva um código onde uma variável int x seja declarada dentro de um bloco
    //if. Tente acessar essa variável fora do bloco if e observe o que acontece.

    //public void Mostrar()
    //{

    //    if (true)
    //    {
    //        int x = 0;
    //    }

    //    // Console.WriteLine(x);
    //}

    //5. Alterando o Valor de uma Variável Global
    //Crie uma variável global int contador em uma classe.No método Main, altere
    //o valor de contador dentro de um loop for e depois imprima o valor final de
    //contador.

    //public void Mostrar()
    //{
    //    string nome = "";
    //    Console.WriteLine(nome);
    //    Console.WriteLine(this.nome);

    //}

    //6.  Capturando uma Exceção de Conversão de Tipo
    //Tente converter uma string não numérica para um inteiro usando int.Parse.
    //Use try-catch para capturar a exceção e imprima uma mensagem apropriada.

    //public void Mostrar()
    //{
    //    try
    //    {
    //        string nome = "Rodrigo";
    //        int numParse = int.Parse(nome); // Isso lançará uma exceção
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message); // Este bloco será executado
    //    }
    //}

    //7.  Lançando Exceções
    //Escreva um método que recebe um número inteiro. Se o número for negativo,
    //lance uma ArgumentException.Capture a exceção no método Main e imprima
    //uma mensagem apropriada.

    //public void Mostrar()
    //{
    //    try
    //    {
    //        int n = -1;
    //        if (n < 0)
    //        {
    //            throw new Exception("Erro personalizado: Numero negativo.");
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message); // Este bloco será executado
    //    }
}


    

