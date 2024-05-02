using System.ComponentModel.Design;

namespace FilaDinamica
{
    internal class Program
    {       
        static FilaPessoa filaPessoas = new FilaPessoa();
        static int opcao = 0;
        static void Menu()
        {
            Console.WriteLine("Escolha uma Opção:\n" +
                "1 - Adicionar Pessoas;\n" +
                "2 - Retirar Pessoas;\n" +
                "3 - Listar Pessoas;\n" +
                "0 - Sair;");
            Escolha(int.Parse(Console.ReadLine()));
        }
        static void Escolha(int op)
        {
            opcao = op;
            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o nome da pessoa:");
                    filaPessoas.Push(new (Console.ReadLine()));
                    Console.ReadKey();
                    break;
                case 2:
                    filaPessoas.Pop();
                    Console.ReadKey();
                    break;
                case 3:
                    filaPessoas.RunOver();
                    Console.ReadKey();
                    break;
                    case 0:
                    Console.WriteLine("Fim de programa!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida!");
                    Console.ReadKey();
                    break;
            }

        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(">>>Fila<<<");
                Menu();
                Console.Clear();

            } while (opcao != 0);
        }
    }

}
