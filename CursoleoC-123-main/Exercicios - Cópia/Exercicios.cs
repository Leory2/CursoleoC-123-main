using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CursoleoC_.Exercicios
{
    public static class ExerciciosXD
    {
        //Exercício 2

        //Questão: Crie um programa em C# que solicite ao usuário dois números inteiros e
        //calcule a soma desses números. Exiba o resultado com uma mensagem que informe a
        //soma dos dois números.

        //public static void EntradaSaida()
        //{

        // int? num1;
        // int? num2;
        // int? soma;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = int.Parse(Console.ReadLine());

        // soma = num1+num2;

        // Console.WriteLine($"A soma dos dois números digitados é: {soma}");
        //}

        //Questão: Peça ao usuário para inserir dois números inteiros e calcule a diferença entre
        //o primeiro e o segundo número. Exiba o resultado com uma mensagem que informe a
        //subtração.

        //public static void EntradaSaida()
        //{

        // int? num1;
        // int? num2;
        // int? sub;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = int.Parse(Console.ReadLine());

        // sub = num1-num2;

        // Console.WriteLine($"A subtração dos dois números digitados é: {sub}");
        //}

        //Questão: Solicite ao usuário para inserir dois números inteiros e calcule a
        //multiplicação desses números. Exiba o resultado com uma mensagem que informe a
        //multiplicação.

        //public static void EntradaSaida()
        //{
        // int? num1;
        // int? num2;
        // int? mult;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = int.Parse(Console.ReadLine());

        // mult = num1*num2;

        // Console.WriteLine($"A multiplicação dos dois números digitados é: {mult}");
        //}

        //Questão: Peça ao usuário para inserir dois números inteiros e calcule a divisão do
        //primeiro número pelo segundo. Exiba o resultado com uma mensagem que informe a
        //divisão. Inclua tratamento para divisão por zero.

        //public static void EntradaSaida()
        //{

        // int? num1;
        // int? num2;
        // int? div;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = int.Parse(Console.ReadLine());

        // if (num2 == 0 || num1 == 0)
        // {
        //     Console.WriteLine($"Os números não podem ser zero.");
        // }
        // else
        // {
        // div = num1/num2;

        // Console.WriteLine($"A divisão dos dois números digitados é: {div}");
        // }
        //}

        //Questão: Solicite ao usuário para inserir dois números inteiros e calcule o resto da
        //divisão do primeiro número pelo segundo. Exiba o resultado com uma mensagem que
        //informe o resto da divisão.

        //public static void EntradaSaida()
        //{

        // int? num1;
        // int? num2;
        // int? resto;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = Convert.ToInt32(Console.ReadLine());

        // resto = num1 % num2;

        // Console.WriteLine($"O resto da divisão dos dois números digitados é: {resto}");
        //}

        //Questão: Solicite ao usuário para inserir dois números inteiros e calcule o resto da
        //divisão do primeiro número pelo segundo. Exiba o resultado com uma mensagem que
        //informe o resto da divisão.

        //public static void EntradaSaida()
        //{

        // int? num1;
        // int? num2;
        // int? resto;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = Convert.ToInt32(Console.ReadLine());

        // resto = num1 % num2;

        // Console.WriteLine($"O resto da divisão dos dois números digitados é: {resto}");
        //}

        //Questão: Peça ao usuário para inserir um número inteiro e, em seguida, exiba o
        //número incrementado em 1. Utilize o operador de incremento ++.

        //public static void EntradaSaida()
        //{

        // int? num1;

        // Console.WriteLine("Digite um número inteiro: ");
        // num1 = Convert.ToInt32(Console.ReadLine());

        // num1++;

        // Console.WriteLine($"O número digitado incrementado é: {num1}");
        //}

        //Questão: Solicite ao usuário para inserir um número inteiro e exiba o mesmo número
        //decrementado em 1. Utilize o operador de decremento --.

        //public static void EntradaSaida()
        //{
        // int? num1;

        // Console.WriteLine("Digite um número inteiro: ");
        // num1 = Convert.ToInt32(Console.ReadLine());

        // num1--;

        // Console.WriteLine($"O número digitado decrementado é: {num1}");
        //}

        //Questão: Crie um programa que solicite ao usuário para inserir dois números inteiros e
        //calcule a média desses números. Exiba a média com uma mensagem informativa.

        //public static void EntradaSaida()
        //{
        // int? num1;
        // int? num2;
        // int? media;

        // Console.WriteLine("Digite o primeiro número: ");
        // num1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // num2 = Convert.ToInt32(Console.ReadLine());

        // media = (num1 + num2)/2;

        // Console.WriteLine($"A média dos dois números digitados é: {media}");
        //}

        //Questão: Peça ao usuário para inserir três números inteiros e calcule a soma dos dois
        //primeiros números e, em seguida, subtraia o terceiro número do resultado. Exiba o
        //resultado com uma mensagem explicativa.

        //public static void entradasaida()
        //{
        //    int? num1;
        //    int? num2;
        //    int? num3;
        //    int? resul;

        //    Console.WriteLine("digite o primeiro número: ");
        //    num1 = Convert.Toint32(console.readline());

        //    Console.WriteLine("digite o segundo número: ");
        //    num2 = Convert.Toint32(console.readline());

        //    Console.WriteLine("digite o terceiro número: ");
        //    num3 = Convert.ToInt32(console.readline());

        //    resul = (num1 + num2) - num3;

        //    Console.WriteLine($"a soma dos dois primeiros números digitados subtraída pelo terceiro é: {resul}");
        //}

        //Questão: Solicite ao usuário dois números inteiros e calcule o quadrado do primeiro
        //número somado ao segundo número. Exiba o resultado com uma mensagem
        //explicativa.

        //public static void EntradaSaida()
        //{

        //    int? num1;
        //    int? num2;
        //    int? resul;

        //    Console.WriteLine("Digite o primeiro número: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Digite o segundo número: ");
        //    num2 = Convert.ToInt32(Console.ReadLine());

        //    resul = (num1 * num1) + num2);

        //    Console.WriteLine($"O quadrado do primeiro número somado ao segundo número é: {resul}");
        //}

        //Questão: Crie um programa que solicite ao usuário para inserir um valor e exiba o
        //dobro desse valor e a metade desse valor. Utilize operadores aritméticos para fazer os
        //cálculos.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? dobro;
        //    int? metade;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    dobro = num1 * 2;
        //    metade = num1 / 2;

        //    Console.WriteLine($"O dobro do valor digitado é: {dobro} e a metade no valor digitado é: {metade}");
        //}

        //Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
        //expressão (a + b) * (a - b). Exiba o resultado com uma mensagem informativa.

        //public static void EntradaSaida()
        //{
        //    int? numA;
        //    int? numB;
        //    int? resul;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    numA = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Insira um número inteiro: ");
        //    numB = Convert.ToInt32(Console.ReadLine());

        //    resul = (numA + numB) * (numA - numB);

        //    Console.WriteLine($"(número1 + número2) * (número1 - número2) = {resul}");
        //}

        //Questão: Solicite ao usuário para inserir dois números inteiros e calcule a soma do
        //quadrado do primeiro número com o quadrado do segundo número.Exiba o resultado
        //com uma mensagem explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? num2;
        //    int? resul;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //   Console.WriteLine("Insira um número inteiro: ");
        //    num2 = Convert.ToInt32(Console.ReadLine());

        //    resul = (num1 * num1) + (num2 * num2);

        //    Console.WriteLine($"A soma do quadrado do primeiro número com o quadrado do segundo número é: {resul}");
        //}

        //Questão: Crie um programa que solicite ao usuário para inserir um número inteiro e
        //calcule o valor do número ao cubo.Exiba o resultado com uma mensagem explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? resul;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    resul = num1 * num1 * num1;

        //    Console.WriteLine($"O valor do número digitado ao cubo é: {resul}");
        //}

        //Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
        //expressão a * (b + a) / b.Exiba o resultado com uma mensagem informativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? num2;
        //    int? resul;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num2 = Convert.ToInt32(Console.ReadLine());

        //    resul = num1 * (num2 + num1);

        //    Console.WriteLine($"Número1 * (número2 + número1) = {resul}");
        //}

        //Questão: Solicite ao usuário para inserir um número inteiro e calcule o quadrado da
        //diferença entre o número e 5. Exiba o resultado com uma mensagem explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? resul;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    resul = (num1-5)*(num1 - 5);

        //    Console.WriteLine($"O quadrado da diferença entre o número digitado e o número 5 é: {resul}");
        //}

        //Questão: Crie um programa que solicite ao usuário dois números inteiros e calcule a
        //média aritmética entre eles.Exiba a média com uma mensagem explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? num2;
        //    int? resul;

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Insira um número inteiro: ");
        //    num2 = Convert.ToInt32(Console.ReadLine());

        //    resul = (num1 + num2) / 2;

        //    Console.WriteLine($"A média aritmética dos números digitados é: {resul}");
        //}

        //Questão: Peça ao usuário para inserir um valor em reais e calcule o valor em dólares,
        //assumindo uma taxa de câmbio fixa de 5.0 reais por dólar.Exiba o resultado com uma
        //mensagem explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? resul;

        //    Console.WriteLine("Insira um valor em reais: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    resul = num1/5;

        //    Console.WriteLine($"O valor digitado convertido para dólar é: {resul}");
        //}

        //Questão: Solicite ao usuário para inserir a quantidade de dias e calcule a quantidade
        //total de horas.Exiba o resultado com uma mensagem explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? resul;

        //    Console.WriteLine("Insira a quantidade de dias: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    resul = (num1 * 24);

        //    Console.WriteLine($"A quantidade de dias digitados corresponde a {resul} horas");
        //}

        //Questão: Crie um programa que peça ao usuário para inserir a quantidade de horas e
        //minutos e calcule o total em minutos.Exiba o resultado com uma mensagem
        //explicativa.

        //public static void EntradaSaida()
        //{
        //    int? num1;
        //    int? num2;
        //    int? resul;

        //    Console.WriteLine("Insira a quantidade de horas: ");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Insira a quantidade de minutos: ");
        //    num2 = Convert.ToInt32(Console.ReadLine());

        //    resul = (num1*60) + num2;

        //    Console.WriteLine($"As horas digitadas convertidas para minutos corresponde a {resul} minutos");
        //}




    }
}
