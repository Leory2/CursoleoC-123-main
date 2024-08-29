using CursoCSharp;
using CursoCSharp.Guia;
using CursoleoC_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CursoleoC_
{
  /* 1. Crie uma consulta LINQ para encontrar todos os nomes das pessoas que têm o nome
  começando com a letra &#39;A&#39; e que têm mais de 25 anos.*/
    
  public class Exercicio1
  {
    public void ExibirConsulta() 
    { 
        var pessoas = new List<PessoasLinq> 
        { 
         new PessoasLinq{nome = "Rodrigo", idade = 20},
         new PessoasLinq{nome = "Arthur", idade = 30},
         new PessoasLinq{nome = "Marcos", idade = 30},
         new PessoasLinq{nome = "Thiago", idade = 50},
         new PessoasLinq{nome = "Lia", idade = 15},
         new PessoasLinq{nome = "zeze", idade = 20},
         new PessoasLinq{nome = "suh", idade = 16},
         new PessoasLinq{nome = "Ruan", idade = 25},
         new PessoasLinq{nome = "Leo", idade = 20},
         new PessoasLinq{nome = "Abigail", idade = 60},
         new PessoasLinq{nome = "Davi", idade = 65},
        };
            var pessoasInicioAmomeMaiorque25 = pessoas.Where(p => p.nome.StartsWith("A") && p.idade > 25);
           
            foreach(var pessoa in pessoasInicioAmomeMaiorque25) 
            {
                Console.WriteLine($"o nome da pessoa é:{pessoa.nome}, e a idade da pessoa é:{pessoa.idade}");
            
            }
    }
  } 
  public class PessoasLinq 
  {
        public string? nome;
        public int? idade;
    }
    /*2.Adicione uma lista de produtos com propriedades Nome e Preço. Faça uma consulta
        LINQ para encontrar os produtos cujo preço é superior à média de todos os produtos.*/
    public class Produtos
    {
        public string? nome;
        public double? preco;
    }
    public class Exercicio2
    {
        public void Leo()
        {
            var Produtos = new List<Produtos>
            {
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
             new Produtos{nome = "Arroz", preco = 20.0},
            };
            var precoMedia = Produtos.Average(p =>  p.preco);
            var precoSuperiorMedia = Produtos.Where(p => p.preco > precoMedia);
            
            foreach (var produto in precoSuperiorMedia) 
            { 
             Console.WriteLine(produto.nome, produto.preco);
            
            }
        }

    }
    /*3. Utilizando a lista de pessoas, crie uma consulta LINQ para listar o nome das pessoas
    em ordem alfabética reversa.*/

}

    