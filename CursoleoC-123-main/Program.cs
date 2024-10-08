﻿using Curso_C_;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;


/* class Program
  {
      static void Main(string[] args)
      {
          // Inicializaç ão de objetos
          Biblioteca biblioteca = new Biblioteca();
          Garagem garagem = new Garagem();
          Usuario usuario = new Usuario("João Silva", "12345678900");
          Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

          // Loop do menu principal
          int opcao = 0;
          do
          {
              Console.Clear(); // Limpa a tela para uma melhor organização visual
              Console.WriteLine("==============================================");
              Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
              Console.WriteLine("==============================================\n");
              Console.WriteLine("1. Biblioteca de Livros");
              Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
              Console.WriteLine("0. Sair");
              Console.WriteLine("==============================================");
              Console.Write("Escolha uma opção: ");
              opcao = int.Parse(Console.ReadLine());

              switch (opcao)
              {
                  case 1:
                      MenuBiblioteca(biblioteca, usuario);
                      break;
                  case 2:
                      MenuVeiculos(garagem, cliente);
                      break;
                  case 0:
                      Console.WriteLine("\nSaindo do programa...");
                      break;
                  default:
                      Console.WriteLine("\nOpção inválida, tente novamente.");
                      break;
              }
          } while (opcao != 0);
      }

      static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
      {
          int opcao = 0;
          do
          {
              Console.Clear();
              Console.WriteLine("==============================================");
              Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
              Console.WriteLine("==============================================\n");
              Console.WriteLine("1. Adicionar Livro");
              Console.WriteLine("2. Listar Livros");
              Console.WriteLine("3. Emprestar Livro");
              Console.WriteLine("4. Devolver Livro");
              Console.WriteLine("5. Exibir Livros Emprestados");
              Console.WriteLine("0. Voltar");
              Console.WriteLine("==============================================");
              Console.Write("Escolha uma opção: ");
              opcao = int.Parse(Console.ReadLine());

              switch (opcao)
              {
                  case 1:
                      AdicionarLivro(biblioteca);
                      break;
                  case 2:
                      biblioteca.ListarLivros();
                      break;
                  case 3:
                      EmprestarLivro(biblioteca, usuario);
                      break;
                  case 4:
                      DevolverLivro(biblioteca, usuario);
                      break;
                  case 5:
                      usuario.ExibirLivrosEmprestados();
                      break;
                  case 0:
                      Console.WriteLine("\nVoltando ao menu principal...");
                      break;
                  default:
                      Console.WriteLine("\nOpção inválida, tente novamente.");
                      break;
              }
              Console.WriteLine("\nPressione qualquer tecla para continuar...");
              Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
          } while (opcao != 0);
      }

      static void MenuVeiculos(Garagem garagem, Cliente cliente)
      {
          int opcao = 0;
          do
          {
              Console.Clear();
              Console.WriteLine("==============================================");
              Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
              Console.WriteLine("==============================================\n");
              Console.WriteLine("1. Adicionar Veículo");
              Console.WriteLine("2. Listar Veículos");
              Console.WriteLine("3. Comprar Veículo");
              Console.WriteLine("4. Vender Veículo");
              Console.WriteLine("5. Exibir Veículos Comprados");
              Console.WriteLine("0. Voltar");
              Console.WriteLine("==============================================");
              Console.Write("Escolha uma opção: ");
              opcao = int.Parse(Console.ReadLine());

              switch (opcao)
              {
                  case 1:
                      AdicionarVeiculo(garagem);
                      break;
                  case 2:
                      ListarVeiculos(garagem);
                      break;
                  case 3:
                      ComprarVeiculo(garagem, cliente);
                      break;
                  case 4:
                      VenderVeiculo(garagem);
                      break;
                  case 5:
                      cliente.ExibirVeiculosComprados();
                      break;
                  case 0:
                      Console.WriteLine("\nVoltando ao menu principal...");
                      break;
                  default:
                      Console.WriteLine("\nOpção inválida, tente novamente.");
                      break;
              }
              Console.WriteLine("\nPressione qualquer tecla para continuar...");
              Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
          } while (opcao != 0);
      }

      static void AdicionarLivro(Biblioteca biblioteca)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
          Console.WriteLine("==============================================");
          Console.Write("Digite o título do livro: ");
          string titulo = Console.ReadLine();
          Console.Write("Digite o autor do livro: ");
          string autor = Console.ReadLine();
          Console.Write("Digite o ano de publicação: ");
          int ano = int.Parse(Console.ReadLine());
          Console.Write("Digite o número de páginas: ");
          int paginas = int.Parse(Console.ReadLine());

          Livro livro = new Livro(titulo, autor, ano, paginas);
          biblioteca.AdicionarLivro(livro);
          Console.WriteLine("\nLivro adicionado com sucesso!");
      }

      static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
          Console.WriteLine("==============================================");
          Console.Write("Digite o título do livro a ser emprestado: ");
          string titulo = Console.ReadLine();
          Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
          if (livro != null)
          {
              usuario.EmprestarLivro(livro, biblioteca);
              Console.WriteLine("\nLivro emprestado com sucesso!");
          }
          else
          {
              Console.WriteLine("\nLivro não encontrado no acervo.");
          }
      }

      static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
          Console.WriteLine("==============================================");
          Console.Write("Digite o título do livro a ser devolvido: ");
          string titulo = Console.ReadLine();
          Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
          if (livro != null)
          {
              usuario.DevolverLivro(livro, biblioteca);
              Console.WriteLine("\nLivro devolvido com sucesso!");
          }
          else
          {
              Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
          }
      }

      static void AdicionarVeiculo(Garagem garagem)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
          Console.WriteLine("==============================================");
          Console.Write("Digite a marca do veículo: ");
          string marca = Console.ReadLine();
          Console.Write("Digite o modelo do veículo: ");
          string modelo = Console.ReadLine();
          Console.Write("Digite o ano do veículo: ");
          int ano = int.Parse(Console.ReadLine());
          Console.Write("Digite a quilometragem do veículo: ");
          int quilometragem = int.Parse(Console.ReadLine());

          Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
          garagem.AdicionarVeiculo(veiculo);
          Console.WriteLine("\nVeículo adicionado com sucesso!");
      }

      static void ListarVeiculos(Garagem garagem)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
          Console.WriteLine("==============================================");
          var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

          if (veiculos.Count == 0)
          {
              Console.WriteLine("\nNenhum veículo disponível.");
          }
          else
          {
              foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
              {
                  veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
              }
          }
      }

      static void ComprarVeiculo(Garagem garagem, Cliente cliente)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
          Console.WriteLine("==============================================");
          Console.Write("Digite o modelo do veículo a ser comprado: ");
          string modelo = Console.ReadLine();
          Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
          if (veiculo != null)
          {
              cliente.ComprarVeiculo(veiculo, garagem);
              Console.WriteLine("\nVeículo comprado com sucesso!");
          }
          else
          {
              Console.WriteLine("\nVeículo não encontrado.");
          }
      }

      static void VenderVeiculo(Garagem garagem)
      {
          Console.Clear();
          Console.WriteLine("==============================================");
          Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
          Console.WriteLine("==============================================");
          Console.Write("Digite o modelo do veículo a ser vendido: ");
          string modelo = Console.ReadLine();
          Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
          if (veiculo != null)
          {
              garagem.VenderVeiculo(veiculo);
              Console.WriteLine("\nVeículo vendido com sucesso!");
          }
          else
          {
              Console.WriteLine("\nVeículo não encontrado.");
          }
      }
  }
}
 */

// Instância de Cachorro
//Cachorro cachorro = new Cachorro("Rex");
//cachorro.ExibirInformacoes();
//cachorro.FazerSom();
//cachorro.ExplicarHeranca();

// Instância de Gato
//Gato gato = new Gato("Mimi");
//gato.ExibirInformacoes();
//gato.FazerSom();
//gato.ExplicarHeranca();

/*

// Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();*/

/*// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();*/
// Criando um objeto Carro, que inclui a criação de um Motor

/*Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/

/*// Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/
// Criando funcionários
/*FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();*/
/*AnimalAbs cachorro = new CachorroAbs("Rex");
AnimalAbs gato = new GatoAbs("Mimi");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();*/
// Criando instâncias de classes que implementam a interface
/*IAnimal cachorro = new CachorroInter("Rex");
IAnimal gato = new GatoInter("Mimi");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();*/

/*var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
exp.ExplicarPolimorfismo();*/



/*namespace BibliotecaVeiculos
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Biblioteca biblioteca = new Biblioteca();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca();
                        break;
                    case 2:
                        MenuUsuarios();
                        break;
                    case 0:
                        SalvarDados(); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        biblioteca.ObterLivros().ForEach(livro => livro.ExibirDetalhes());
                        break;
                    case 3:
                        EmprestarLivro();
                        break;
                    case 4:
                        DevolverLivro();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuUsuarios()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR USUÁRIOS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Remover Usuário");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        RemoverUsuario();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO USUÁRIO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do usuário: ");
            string cpf = Console.ReadLine();

            // Verificar se o CPF já existe
            if (usuarios.Any(u => u.Cpf == cpf))
            {
                Console.WriteLine("\nUsuário com este CPF já existe.");
                return;
            }

            Usuario usuario = new Usuario(nome, cpf);
            usuarios.Add(usuario);
            Console.WriteLine("\nUsuário adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarUsuarios();
        }

        static void ListarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\ususarios.json";
            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Usuarios != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE USUÁRIOS CADASTRADOS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Usuarios.Count == 0)
                        {
                            Console.WriteLine("\nNenhum usuário cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Usuarios.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {dados.Usuarios[i].Nome} - CPF: {dados.Usuarios[i].Cpf}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de usuários está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }
        }

        static void RemoverUsuario()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < usuarios.Count)
            {
                usuarios.RemoveAt(indice);
                Console.WriteLine("\nUsuário removido com sucesso!");
                SalvarUsuarios(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void AdicionarLivro()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
            SalvarLivros(); // Atualiza o arquivo após adicionar livro
        }

        static void EmprestarLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá emprestar o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.EmprestarLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após emprestar livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void DevolverLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá devolver o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.DevolverLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após devolver livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void CarregarDados()
        {
            // Carregar usuários
            string caminhoUsuarios = @"C:\\Users\\Aluno Noite\\Downloads\\CursoleoC-123-main\\CursoleoC-123-main\\ususarios.json";
            if (File.Exists(caminhoUsuarios))
            {
                string json = File.ReadAllText(caminhoUsuarios);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        usuarios = dados.Usuarios;
                        Console.WriteLine("Usuários carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos usuários: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de usuários não encontrado.");
            }

            // Carregar livros
            string caminhoLivros = @"C:\Users\Professor\Desktop\Conteudo do Curso Tecnico\Curso C#\livros.json";
            if (File.Exists(caminhoLivros))
            {
                string json = File.ReadAllText(caminhoLivros);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        biblioteca = new Biblioteca();
                        foreach (var livro in dados.Livros)
                        {
                            biblioteca.AdicionarLivro(livro);
                        }
                        Console.WriteLine("Livros carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos livros: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de livros não encontrado.");
            }

            // Carregar empréstimos (se necessário para inicializar estado)
            string caminhoEmprestimos = @"C:\Users\Professor\Desktop\Conteudo do Curso Tecnico\Curso C#\emprestimos.json";
            if (File.Exists(caminhoEmprestimos))
            {
                string json = File.ReadAllText(caminhoEmprestimos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null && dados.Emprestimos != null)
                    {
                        foreach (var emprestimo in dados.Emprestimos)
                        {
                            // Aqui você pode adicionar lógica para processar empréstimos carregados
                        }
                        Console.WriteLine("Empréstimos carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos empréstimos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de empréstimos não encontrado.");
            }
        }

        static void SalvarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\ususarios.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = usuarios,
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Usuários salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar usuários: {ex.Message}");
            }
        }

        static void SalvarLivros()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\livros.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = biblioteca.ObterLivros(),
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Livros salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar livros: {ex.Message}");
            }
        }

        static void SalvarEmprestimos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\emprestimos.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = usuarios.SelectMany(u => u.LivrosEmprestados.Select(l => new Emprestimo
                    {
                        UsuarioCpf = u.Cpf,
                        LivroTitulo = l.Titulo,
                        DataEmprestimo = DateTime.Now // Aqui seria ideal colocar a data real do empréstimo
                    })).ToList()
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Empréstimos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar empréstimos: {ex.Message}");
            }
        }

        static void SalvarDados()
        {
            SalvarUsuarios();
            SalvarEmprestimos();
            SalvarLivros();
        }
    }

    public class Dados
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Livro> Livros { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}
}*/


namespace GerenciamentoEducacao
{
    class Program
    {
        static List<Aluno> alunos = new List<Aluno>();
        static List<Servico> servicos = new List<Servico>();
        static List<ServicoPrestado> servicosPrestados = new List<ServicoPrestado>();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();

              
                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ *********************************************************** ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("║ *********************************************************** ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****             Autor do sistema: Leo                 *****║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****             Versão do sistema: 1.0                *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Console.WriteLine($"║*****             Data: {dataAtual}             *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ *********************************************************** ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****           1. Gerenciar Alunos                     *****║");
                Console.WriteLine("║*****           2. Gerenciar Serviços                   *****║");
                Console.WriteLine("║*****           3. Gerenciar Serviços por Aluno         *****║");
                Console.WriteLine("║*****                0. Sair                            *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("║ *********************************************************** ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                    ╔═══════════════════╗");
                Console.WriteLine("                    ║ Digite uma opção: ║");
                Console.WriteLine("                    ╚═══════════════════╝");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuAlunos();
                        break;
                    case 2:
                        MenuServicos();
                        break;
                    case 3:
                        MenuServicosPorAluno();
                        break;
                    case 0:
                        SalvarDados(); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }


        static void MenuAlunos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ *********************************************************** ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("║ *********************************************************** ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****                GERENCIAR ALUNOS                   *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****        1. Adicionar Aluno                        *****║");
                Console.WriteLine("║*****        2. Listar Alunos                          *****║");
                Console.WriteLine("║*****        3. Remover Aluno                          *****║");
                Console.WriteLine("║*****        4. Procurar Aluno por Id                  *****║");
                Console.WriteLine("║*****        0. Voltar                                 *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                    ╔═══════════════════╗");
                Console.WriteLine("                    ║ Digite uma opção: ║");
                Console.WriteLine("                    ╚═══════════════════╝");

               

                // Converte a tecla pressionada para um número
                bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);
               
               
                    switch (opcao)
                    {
                        case 1:
                            AdicionarAluno();
                            break;
                        case 2:
                            ListarAlunos();
                            break;
                        case 3:
                            RemoverAlunoPorId();
                            break;
                        case 4:
                            ProcurarAlunoPorIdMenu();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            return; // Encerra o método MenuAlunos e retorna ao menu principal
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
             
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (true); // Mantém o loop até que o usuário selecione a opção 0 ou pressione Esc
        }

        static void MenuServicos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ *********************************************************** ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("║ *********************************************************** ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****            GERENCIAR SERVIÇOS                    *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****        1. Adicionar Serviço                     *****║");
                Console.WriteLine("║*****        2. Listar Serviços                       *****║");
                Console.WriteLine("║*****        3. Remover Serviço                       *****║");
                Console.WriteLine("║*****        0. Voltar                                *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                    ╔═══════════════════╗");
                Console.WriteLine("                    ║ Digite uma opção: ║");
                Console.WriteLine("                    ╚═══════════════════╝");

                // Captura e valida a opção
                bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);
               
                    switch (opcao)
                    {
                        case 1:
                            AdicionarServico();
                            break;
                        case 2:
                            ListarServicos();
                            break;
                        case 3:
                            RemoverServico();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            return; // Sai do menu de serviços
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }


        static void MenuServicosPorAluno()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                // Cabeçalho do Menu
                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ *********************************************************** ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("║ *********************************************************** ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║*****           GERENCIAR SERVIÇOS POR ALUNO             *****║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;

                // Opções do Menu
                Console.WriteLine("║*****        1. Associar Serviço a Aluno                *****║");
                Console.WriteLine("║*****        2. Listar Serviços de um Aluno              *****║");
                Console.WriteLine("║*****        0. Voltar                                   *****║");

                // Rodapé do Menu
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                    ╔═══════════════════╗");
                Console.WriteLine("                    ║ Digite uma opção: ║");
                Console.WriteLine("                    ╚═══════════════════╝");

                // Entrada de opção do usuário
                bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

                if (entradaValida)
                {
                    switch (opcao)
                    {
                        case 1:
                            AssociarServicoAAluno();
                            break;
                        case 2:
                            ListarServicosPorAluno();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida, tente novamente.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarAluno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            // Cabeçalho do Menu
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****                ADICIONAR NOVO ALUNO                *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            // Entrada dos dados do aluno
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            // Validação do nome
            if (string.IsNullOrWhiteSpace(nome) || !nome.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("\nNome do aluno inválido. O nome deve conter apenas letras.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite o CPF do aluno: ");
            string cpf = Console.ReadLine();

            // Validação do CPF
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                Console.WriteLine("\nCPF inválido. O CPF deve conter 11 dígitos e ser composto apenas por números.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite o Id do aluno: ");
            int id;

            // Validação do ID (aceita apenas números)
            bool idValido = int.TryParse(Console.ReadLine(), out id);
            if (!idValido)
            {
                Console.WriteLine("\nID inválido. O ID deve ser composto apenas por números.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            // Verificação de duplicidade
            if (alunos.Any(a => a.Id == id))
            {
                Console.WriteLine("\nAluno com este ID já existe.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            if (alunos.Any(a => a.Cpf == cpf))
            {
                Console.WriteLine("\nAluno com este CPF já existe.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            // Criação e adição do aluno
            Aluno aluno = new Aluno(nome, cpf, id);
            alunos.Add(aluno);
            Console.WriteLine("\nAluno adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarAlunos();

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }



        // Método para obter a entrada do usuário, com suporte para cancelamento


        static void ListarAlunos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            // Cabeçalho do Menu
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****             LISTA DE ALUNOS CADASTRADOS            *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            if (alunos.Count == 0)
            {
                Console.WriteLine("\nNenhum aluno cadastrado.");
            }
            else
            {
                // Formatação tabular dos alunos
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔═══════╦══════════════════════════════════════╦══════════════╦════════════╗");
                Console.WriteLine("║ Nº    ║ Nome do Aluno                        ║ CPF          ║ ID do Aluno║");
                Console.WriteLine("╠═══════╬══════════════════════════════════════╬══════════════╬════════════╣");

                foreach (var aluno in alunos)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                   Console.WriteLine($"║ {alunos.IndexOf(aluno) + 1,-5} ║ {aluno.Nome,-35}  ║ {aluno.Cpf,-12 } ║  {aluno.Id,-10}║");
                }
                Console.WriteLine("╚═══════╩══════════════════════════════════════╩══════════════╩════════════╝");
            }

            // Pausa para permitir que o usuário veja a mensagem antes de continuar
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RemoverAlunoPorId()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****             REMOVER ALUNO POR ID                  *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            // Listar alunos antes da remoção
            ListarAlunos();
            Console.Write("\nDigite o ID do aluno a ser removido: ");

            // Verificar entrada do usuário
            if (alunos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNenhum aluno cadastrado no sistema.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nID inválido. Por favor, insira um número inteiro positivo.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Buscar o aluno pelo ID
            Aluno aluno = alunos.FirstOrDefault(a => a.Id == id);

            if (aluno != null)
            {
                alunos.Remove(aluno);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAluno removido com sucesso!");
                Console.ForegroundColor = ConsoleColor.White;
                SalvarAlunos(); // Atualiza o arquivo após remoção
            }
           
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAluno não encontrado com este ID.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static void AdicionarServico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****             ADICIONAR NOVO SERVIÇO                *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite o nome do serviço: ");
            string nome = Console.ReadLine();

            // Verificar se o nome do serviço não está vazio
            if (string.IsNullOrWhiteSpace(nome) || !nome.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("\nNome do aluno inválido. O nome deve conter apenas letras.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite o ID do serviço: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nID inválido. Por favor, insira um número inteiro positivo.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }


            // Verificar se o ID já existe
            if (servicos.Any(s => s.Id == id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nJá existe um serviço com este ID.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            Servico servico = new Servico(nome, id);
            servicos.Add(servico);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nServiço adicionado com sucesso!");
            Console.ForegroundColor = ConsoleColor.White;

            SalvarServicos(); // Atualiza o arquivo após adicionar o serviço
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static void ListarServicos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ **********     SISTEMA DE GERENCIAMENTO DE ESCOLA  ******** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ **********     LISTA DE SERVIÇOS CADASTRADOS       *********║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");

            if (servicos.Count == 0)
            {
                Console.WriteLine("\nNenhum serviço cadastrado.");
            }
            else
            {
                // Cabeçalho da tabela
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔═══════╦══════════════════════════════════════╗");
                Console.WriteLine("║ ID    ║ Nome do Serviço                      ║");
                Console.WriteLine("╠═══════╬══════════════════════════════════════╝");

                // Listar serviços de forma tabular
                foreach (var servico in servicos)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    // Ajuste para garantir o alinhamento da tabela
                    Console.WriteLine($"║ {servico.Id,-5} ║ {servico.Nome,-35}  ║");
                }

                // Rodapé da tabela
                Console.WriteLine("╚═══════╩══════════════════════════════════════╝");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static void ProcurarAlunoPorIdMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****           PROCURAR ALUNO POR ID                  *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite o ID do aluno: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nID inválido. Por favor, insira um número inteiro positivo.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }


            Aluno aluno = ProcurarAlunoPorId(id);

            if (aluno != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nAluno encontrado: Nome: {aluno.Nome}, CPF: {aluno.Cpf}, ID: {aluno.Id}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAluno não encontrado.");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static Aluno ProcurarAlunoPorId(int id)
        {
            return alunos.FirstOrDefault(a => a.Id == id);
        }


        static void RemoverServico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****           REMOVER SERVIÇO POR ID                   *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            // Listar serviços para o usuário escolher
            ListarServicos();

            // Solicitar o ID do serviço a ser removido
            Console.Write("\nDigite o ID do serviço a ser removido: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nID inválido. Por favor, insira um número inteiro positivo.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }


            // Buscar o serviço pelo ID
            Servico servico = servicos.FirstOrDefault(s => s.Id == id);

            if (servico != null)
            {
                servicos.Remove(servico);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nServiço removido com sucesso!");
                SalvarServicos(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nServiço não encontrado com este ID.");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static void AssociarServicoAAluno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ *********************************************************** ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|==========   SISTEMA DE GERENCIAMENTO DE ESCOLA  ============|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ *********************************************************** ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║*****      ASSOCIAÇÃO DE SERVIÇOS A ALUNO                *****║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;

            // Verificar se há alunos cadastrados
            if (alunos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNão há alunos cadastrados no sistema.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            // Listar alunos e solicitar ID
            ListarAlunos();
            Console.Write("\nDigite o ID do aluno: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nID inválido. Por favor, insira um número inteiro positivo.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Buscar o aluno pelo ID
            Aluno aluno = alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAluno não encontrado com este ID.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Verificar se há serviços cadastrados
            if (servicos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNão há serviços cadastrados no sistema.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            // Listar serviços e solicitar ID
            ListarServicos();
            Console.Write("\nDigite o ID do serviço: ");
            if (!int.TryParse(Console.ReadLine(), out int servicoId) || servicoId <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nID inválido. Por favor, insira um número inteiro positivo.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Buscar o serviço pelo ID
            Servico servico = servicos.FirstOrDefault(s => s.Id == servicoId);

            if (servico == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nServiço não encontrado com este ID.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Criar e adicionar o serviço prestado
            ServicoPrestado servicoPrestado = new ServicoPrestado
            {
                AlunoCpf = aluno.Cpf,
                ServicoNome = servico.Nome,
                DataPrestacao = DateTime.Now
            };
            servicosPrestados.Add(servicoPrestado);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nServiço associado ao aluno com sucesso!");
            SalvarServicosPrestados(); // Atualiza o arquivo após associação

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static void ListarServicosPorAluno()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ **********     SERVIÇOS ASSOCIADOS A UM ALUNO      ********* ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            // Listar alunos e solicitar ID
            ListarAlunos();
            Console.Write("\nDigite o ID do aluno: ");
            int alunoId = int.Parse(Console.ReadLine());

            // Buscar o aluno pelo ID
            Aluno aluno = alunos.FirstOrDefault(a => a.Id == alunoId);

            if (aluno != null)
            {
                // Filtrar os serviços prestados para este aluno
                var servicosPorAluno = servicosPrestados.Where(sp => sp.AlunoCpf == aluno.Cpf).ToList();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"║ ****     SERVIÇOS DO ALUNO: {aluno.Nome.ToUpper()}      ****║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                if (servicosPorAluno.Count == 0)
                {
                    Console.WriteLine("\nNenhum serviço associado a este aluno.");
                }
                else
                {
                    // Cabeçalho da tabela
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("╔═══════╦══════════════════════════════════════╦═════════════════════╗");
                    Console.WriteLine("║  ID   ║ Nome do Serviço                      ║ Data da Prestação   ║");
                    Console.WriteLine("╠═══════╬══════════════════════════════════════╬═════════════════════╣");

                    // Listar serviços prestados ao aluno de forma tabular
                    for (int i = 0; i < servicosPorAluno.Count; i++)
                    {
                        var servicoPrestado = servicosPorAluno[i];
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"║ {servicoPrestado.ServicoId,-5} ║ {servicoPrestado.ServicoNome,-36} ║ {servicoPrestado.DataPrestacao:dd/MM/yyyy,-17} ║");
                    }

                    // Rodapé da tabela
                    Console.WriteLine("╚═══════╩══════════════════════════════════════╩═════════════════════╝");
                }
            }
            else
            {
                Console.WriteLine("\nAluno não encontrado com este ID.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
        }


        static void CarregarDados()
        {
            // Carregar alunos
            string caminhoAlunos = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\ususarios.json";
            if (File.Exists(caminhoAlunos))
            {
                string json = File.ReadAllText(caminhoAlunos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        alunos = dados.Alunos ?? new List<Aluno>();
                        Console.WriteLine("Alunos carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos alunos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de alunos não encontrado.");
            }

            // Carregar serviços
            string caminhoServicos = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\livros.json";
            if (File.Exists(caminhoServicos))
            {
                string json = File.ReadAllText(caminhoServicos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        servicos = dados.Servicos ?? new List<Servico>();
                        Console.WriteLine("Serviços carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos serviços: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de serviços não encontrado.");
            }

            // Carregar serviços prestados
            string caminhoServicosPrestados = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\livros.json";
            if (File.Exists(caminhoServicosPrestados))
            {
                string json = File.ReadAllText(caminhoServicosPrestados);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        servicosPrestados = dados.ServicosPrestados ?? new List<ServicoPrestado>();
                        Console.WriteLine("Serviços prestados carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos serviços prestados: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de serviços prestados não encontrado.");
            }
        }

        static void SalvarAlunos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\ususarios.json";

            try
            {
                var dados = new Dados
                {
                    Alunos = alunos,
                    Servicos = new List<Servico>(), // Lista vazia
                    ServicosPrestados = new List<ServicoPrestado>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Alunos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar alunos: {ex.Message}");
            }
        }

        static void SalvarServicos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\livros.json";

            try
            {
                var dados = new Dados
                {
                    Alunos = new List<Aluno>(), // Lista vazia
                    Servicos = servicos,
                    ServicosPrestados = new List<ServicoPrestado>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Serviços salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar serviços: {ex.Message}");
            }
        }

        static void SalvarServicosPrestados()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Downloads\CursoleoC-123-main\CursoleoC-123-main\livros.json";

            try
            {
                var dados = new Dados
                {
                    Alunos = new List<Aluno>(), // Lista vazia
                    Servicos = new List<Servico>(), // Lista vazia
                    ServicosPrestados = servicosPrestados
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Serviços prestados salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar serviços prestados: {ex.Message}");
            }
        }
       

        static void SalvarDados()
        {
            SalvarAlunos();
            SalvarServicos();
            SalvarServicosPrestados();
            
        }
        
    }

}







