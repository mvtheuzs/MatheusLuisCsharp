using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            string[] vetjogos = new string[3];

            do
            {

                //MENU

                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ░░█ █▀█ █▀▀ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▄█ █▄█ █▄█ ▄█");

                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Excluir");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //CADASTRAR NOME NO VETOR
                    for (int i = 0; i < vetjogos.Length; i++)
                    {
                        Console.Write($"Informe o {i + 1}° nome do jogo: ");
                        vetjogos[i] = Console.ReadLine();
                    }
                    Console.WriteLine("PARA CONTINUAR, PRESSIONE A TECLA ENTER.");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    for (int i = 0; i < vetjogos.Length; i++)
                    {
                        Console.WriteLine($"Posição: {i} | Nome do jogo: {vetjogos[i]}");
                    }
                    Console.WriteLine("PARA CONTINUAR, PRESSIONE A TECLA ENTER.");
                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    //IMPLEMENTAR A FUNÇÃO ATUALIZAR
                    //SOLICITAR INDICE E O NOVO NOME
                    // ALTERAR O NOME DO VETOR

                    for (int i = 0; i < vetjogos.Length; i++)
                    {
                        String indice;
                        Console.WriteLine($"indice: {indice}")
                    }
                }
                else if (opcao == 4)
                {
                    //IMPLEMENTAR A FUNÇÃO EXCLUIR 
                    //SOLICITAR O INDICE DO NOME DO JOGO PARA O USUARIO 
                    //ATRIBUIR UM VALOR " " PARA EXECUTAR
                }
                Console.Clear();
            } while (true);
        }
    }
}
