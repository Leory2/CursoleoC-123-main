using CursoCSharp;
using CursoleoC_.Exercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CursoleoC_
{
   public class Pessoa6969
    {
        /* 1. Classe e Instanciação Básica
           Crie uma classe chamada Pessoa com as propriedades Nome e Idade.Adicione um construtor
           que inicialize essas propriedades e um método Falar que imprima uma mensagem dizendo
           &quot; Olá, meu nome é[Nome] e eu tenho[Idade] anos.&quot;. Em seguida, crie uma instância da classe
           Pessoa, defina os valores das propriedades e chame o método Falar.*/

        public string? Nome;
        public int? Idade;

        public Pessoa6969(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public void Falar() 
        {
            Console.WriteLine($"Olá, meu nome é{Nome} e eu tenho{Idade}");
        
        }
   }
    /*Crie uma classe Calculadora com um método Soma que recebe dois parâmetros inteiros e
     retorna a soma deles.Adicione também um método Subtracao que realiza a subtração de dois
     números.Instancie a classe Calculadora, use os métodos para fazer algumas operações e exiba
     os resultados.*/
    public class Calculadora 
    { 
        public int Soma(int a, int b) 
        {
            return a + b;
        }
        public int Subtracao(int a, int b) 
        { 
         return a - b;
        }
    }
    /*3. Encapsulamento e Propriedades
    Crie uma classe Carro com as propriedades Modelo, Ano e Preco.Utilize propriedades
    automáticas para encapsular essas informações. Adicione um método ExibirInfo que exiba os
    detalhes do carro.Instancie a classe Carro, defina valores para as propriedades e chame o
    método ExibirInfo.*/
    public class Carro
    {
        private string? Modelo { get; set; }
        private int? Ano { get; set; }
        private double? Preco { get; set; }

        public Carro(string modelo, int ano, double preco)
        {
         this.Preco = preco;
         this.Modelo = modelo;
         this.Ano = ano; 
        }
        public void ExibirInfo() 
        {
            Console.WriteLine($"O modelo do carro é{Modelo}");
            Console.WriteLine($"O modelo do carro é{Modelo}");
            Console.WriteLine($"O modelo do carro é{Modelo}");
        }
    }
    /*4. Métodos Estáticos
    Crie uma classe Matematica com um método estático Fatorial que calcula o fatorial de um
    número inteiro não-negativo.O método deve retornar o resultado.Utilize o método Fatorial
    para calcular o fatorial de alguns números e exiba os resultados.*/
    public class Matematica
    {
        public static void Fatorial(int numero)
        {    
           
            if (numero < 0) 
            {
                Console.WriteLine("O número é negativo");
            }
            int result = 1;
            for (int i = 1; i <= numero; i++) 
            { 
             result *= i;   
            }
           Console.WriteLine(result); 
        }
    }
    /*5. Construtores Sobrecarrregados
     Crie uma classe Retangulo com propriedades Largura e Altura.Implemente dois construtores:
     um que aceita largura e altura como parâmetros e outro que usa valores padrão(largura e
     altura de 1). Adicione um método CalcularArea que retorna a área do retângulo.Instancie a
     classe Retangulo usando ambos os construtores e exiba a área calculada.*/
    public class Retangulo
    {

        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public Retangulo() : this(1.0, 1.0) 
        {
        }

       
        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }

    /* 6. Métodos de Instância e Estáticos
    Crie uma classe Pessoa com um método de instância AumentarIdade que incrementa a idade
    da pessoa e um método estático CriarPessoa que cria uma nova instância de Pessoa com idade
    inicial de 0. Instancie a classe usando o método estático e chame o método AumentarIdade.*/
    public class Pessoa90
    {
       
        public int Idade { get; private set; }

      
        private Pessoa90(int idade)
        {
            Idade = idade;
        }


        public void AumentarIdade()
        {
            Idade++;
        }

      
        public static Pessoa CriarPessoa()
        {
            return new Pessoa90(0);
        }
    }

}
