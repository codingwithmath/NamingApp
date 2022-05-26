using System;

namespace NamingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcoes;

            string[] nomes = new String[0];

            static string[] ExcluiNome(int posicao, string[] nomes)
            {
                string[] resultado = new string[nomes.Length - 1];
                int z = 0;

                for (int i = 0; i < nomes.Length; i++)
                {
                    if (posicao != i)
                    {
                        resultado[z] = nomes[i];
                        z++;
                    }
                }
                return resultado;
            }

            static string[] adicionaNome(string[] arrayAtual, string nome)
            {
                arrayAtual = arrayAtual.Append(nome).ToArray();

                return arrayAtual;
            }

            static string[] atualizaNome(string[] arrayAtual, int posicao, string nomeAtual)
            {
                arrayAtual[posicao] = nomeAtual;

                return arrayAtual;
            }

            static void mostraNomes(string[] arrayDeNomes)
            {
                for (int i = 0; i < arrayDeNomes.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, arrayDeNomes[i]);
                }
            }

            static string nomeDeSugestao(int numeroEscolhido, int genero)
            {
                //masculino
                if (genero == 1)
                {
                    if (numeroEscolhido == 0)
                    {
                        return "Roberto";
                    }

                    else if (numeroEscolhido == 1)
                    {
                        return "Gustavo";
                    }

                    else if (numeroEscolhido == 2)
                    {
                        return "João";
                    }

                    else if (numeroEscolhido == 3)
                    {
                        return "João";
                    }
                    
                    else
                    {
                        return "Gilberto";
                    }
                }

                else
                {
                    if (numeroEscolhido == 0)
                    {
                        return "Joana";
                    }

                    else if (numeroEscolhido == 1)
                    {
                        return "Martha";
                    }

                    else if (numeroEscolhido == 2)
                    {
                        return "Maria";
                    }

                    else if (numeroEscolhido == 3)
                    {
                        return "Juliana";
                    }

                    else
                    {
                        return "Estella";
                    }
                }

            }

            //loop para manter na aplicação
            do
            {
                Console.WriteLine("\n\n════════════════════ BEM VINDO ao menu principal do ARMAZENADOR DE NOMES ════════════════════ \nPara começar, escolha a opção que deseja. \n\n 1 - LER \n 2 - ADICIONAR \n 3 - ATUALIZAR \n 4 - EXCLUIR \n 5 - SUGESTÃO \n 6 - SAIR");
                Console.Write("\nDigite o número da opção desejada: ");
                opcoes = int.Parse(Console.ReadLine());
                Console.Clear();

                while (opcoes < 1 || opcoes > 6)
                {
                    Console.Clear();            
                    Console.WriteLine("\n\n════════════════════ BEM VINDO ao menu principal do ARMAZENADOR DE NOMES ════════════════════ \nPara começar, escolha a opção que deseja. \n\n 1 - LER \n 2 - ADICIONAR \n 3 - ATUALIZAR \n 4 - EXCLUIR \n 5 - SUGESTÃO \n 6 - SAIR");
                    Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                    opcoes = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                switch (opcoes)
                {
                    case 1:
                        Console.WriteLine("Leitura dos nomes \n");

                        mostraNomes(nomes);

                        Console.Write("\nNome(s) lido(s) com sucesso! \nPressione qualquer tecla para voltar ao menu principal.");

                        Console.ReadKey();

                        Console.Clear();

                        break;

                    case 2:
                        Console.Write("\nDigite o nome que deseja inserir no armazenador: ");
                        string nomeParaInserir = Console.ReadLine();

                        nomes = adicionaNome(nomes, nomeParaInserir);

                        Console.Write("\nNome inserido com sucesso! \nPressione qualquer tecla para voltar ao menu principal.");

                        Console.ReadKey();

                        Console.Clear();

                        break;

                    case 3:
                        Console.WriteLine("Atualização de nomes");

                        Console.Write("\nDigite o número do nome que deseja atualizar no armazenador: ");
                        int posicaoDeAtualizacao = int.Parse(Console.ReadLine());

                        while (posicaoDeAtualizacao < 1 || posicaoDeAtualizacao > nomes.Length)
                        {
                            Console.Clear();
                            Console.Write("\nNOME NÃO EXISTE. Por Favor, escolha um nome existente: ");
                            Console.Write("\nDigite o número do nome que deseja atualizar no armazenador: ");
                            posicaoDeAtualizacao = int.Parse(Console.ReadLine());
                        }

                        Console.Write("\nDigite o novo nome: ");
                        string nomeDeAtualizacao = Console.ReadLine();

                        nomes = atualizaNome(nomes, posicaoDeAtualizacao - 1, nomeDeAtualizacao);

                        Console.Write("\nNome atualizado com sucesso! \nPressione qualquer tecla para voltar ao menu principal.");


                        Console.ReadKey();

                        Console.Clear();

                        break;

                    case 4:
                        Console.WriteLine("Atualização de nomes");

                        Console.Write("\nDigite o número do nome que deseja excluir do armazenador: ");
                        int posicaoDeExclusao = int.Parse(Console.ReadLine());

                        while (posicaoDeExclusao < 1 || posicaoDeExclusao > nomes.Length)
                        {
                            Console.Clear();
                            Console.Write("\nNOME NÃO EXISTE. Por Favor, escolha um nome existente: ");
                            Console.Write("\nDigite o número do nome que deseja excluir do armazenador: ");
                            posicaoDeExclusao = int.Parse(Console.ReadLine());
                        }

                        nomes = ExcluiNome(posicaoDeExclusao - 1, nomes);

                        Console.Write("\nNome excluido com sucesso! \nPressione qualquer tecla para voltar ao menu principal.");


                        Console.ReadKey();

                        Console.Clear();

                        break;

                    case 5:
                        Console.WriteLine("Sugestão de nomes");

                        Console.WriteLine("\n Escolha o gênero do nome: \n1 - MASCULINO \n2 - FEMININO");

                        Console.Write("\n Digite sua escolha: ");
                        int escolhaDeGenero = int.Parse(Console.ReadLine());

                        while (escolhaDeGenero < 1 || escolhaDeGenero > 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\n Escolha o gênero do nome: \n1 - MASCULINO \n2 - FEMININO");
                            Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha uma das opções válidas do menu acima: ");
                            opcoes = int.Parse(Console.ReadLine());
                        }

                        Console.Clear();

                        Console.WriteLine("\n Escolha um número de 1 a 5");

                        Console.Write("\n Digite o número escolhido: ");
                        int numeroDeEscolha = int.Parse(Console.ReadLine());

                        while (numeroDeEscolha < 1 || numeroDeEscolha > 5)
                        {
                            Console.Clear();
                            Console.Write("\nOPÇÃO INVÁLIDA. Por Favor, escolha um número de 1 a 5: ");
                            numeroDeEscolha = int.Parse(Console.ReadLine());
                        }

                        Console.Clear();

                        string nomeSugerido = nomeDeSugestao(numeroDeEscolha, escolhaDeGenero);

                        Console.WriteLine("O nome escolhido foi " + nomeSugerido);

                        Console.WriteLine("\n Gostou do nome? \n 1 - SIM \n 2 - NÃO");
                        Console.Write("Digite sua escolha: ");
                        int gostou = int.Parse(Console.ReadLine());

                        while (gostou < 1 || gostou > 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\nOPÇÃO INVÁLIDA. \n Gostou do nome? \n 1 - SIM \n 2 - NÃO \n");
                            Console.Write("Digite sua escolha: ");
                            gostou = int.Parse(Console.ReadLine());
                        }

                        if (gostou == 1)
                        {
                            nomes = adicionaNome(nomes, nomeSugerido);

                            Console.Write("\nNome escolhido com sucesso! \nPressione qualquer tecla para voltar ao menu principal.");
                        }
                        else
                        {
                            Console.WriteLine("Que pena! =(. \nPressione qualquer tecla para voltar ao menu principal.");
                        }

                        Console.ReadKey();

                        break;

                }



            } while (opcoes != 6);

        }
    }
}