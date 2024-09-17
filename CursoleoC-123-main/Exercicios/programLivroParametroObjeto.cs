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
        public int Id { get; set; }

        private int nextId = 1;

        public Aluno(string nome, string cpf, int id)
        {
            Nome = nome;
            Cpf = cpf;
            Id = id;
        }
    }

    public class Servico
    {
        public string Nome { get; set; }

        public int Id { get; set; }

        public Servico(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }
    }

    public class ServicoPrestado
    {
        public string AlunoCpf { get; set; }
        public string ServicoNome { get; set; }
       
        public int ServicoId { get; set; }
        public DateTime DataPrestacao { get; set; }
    }
}   
