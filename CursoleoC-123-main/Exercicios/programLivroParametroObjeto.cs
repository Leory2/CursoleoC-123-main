using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso_C_
{
    public class Dados
    {
        public List<Aluno> Alunos { get; set; }
        public List<Servico> Servicos { get; set; }
        public List<ServicoPrestado> ServicosPrestados { get; set; }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Aluno(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

    public class Servico
    {
        public string Nome { get; set; }

        public Servico(string nome)
        {
            Nome = nome;
        }
    }

    public class ServicoPrestado
    {
        public string AlunoCpf { get; set; }
        public string ServicoNome { get; set; }
        public DateTime DataPrestacao { get; set; }
    }
}   
