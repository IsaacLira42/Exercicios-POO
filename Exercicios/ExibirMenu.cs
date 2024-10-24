using System;

namespace Exercicios
{
    class ExibirMenu
    {
        public static void Menu()
        {
            Console.Write("Escolha a questão que deseja testar [4] [5]: ");
            int escolherQuestao = int.Parse(Console.ReadLine());

            switch (escolherQuestao)
            {
                case 4:
                    Console.Write("Digite o nome do titular: ");
                    string nome = Console.ReadLine();
                    Titular t = new Titular(nome, 31232142);
                    t.Escolha();
                break;

                case 5:
                    // Questão do Cinema
                break;
            }
        }
    }
}
