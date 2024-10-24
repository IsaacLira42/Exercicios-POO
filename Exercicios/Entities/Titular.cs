using System;

namespace Exercicios
{
    class Titular
    {
        public string Nome { get; set; }
        public int Id { get; private set; }
        public double Saldo = 0;

        public Titular(string nome, int id)
        {
            Nome = nome;
            Id = GerarIdAleatorio();
        }

        private int GerarIdAleatorio()
        {
            Random random = new Random();
            return random.Next(1, 1000); // Gera um número aleatório entre 1 e 999
        }

        public void Escolha()
        {
            Console.Write("Deseja [s] Sacar ou [d] Depositar?: ");
            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine();
            escolha = char.ToUpper(escolha);

            switch(escolha)
            {
                case 'S':
                    Console.Write("Digite o valor: ");
                    Saque(double.Parse(Console.ReadLine()));
                    break;
                case 'D':
                    Console.Write("Digite o valor: ");
                    Deposito(double.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Valor Inválido, Tente novamente.");
                    Escolha();                    
                    break;
            }
            Console.Clear();
            MostrarInformações();
        }

        public void Deposito(double acrescimo)
        {
            Saldo += acrescimo;
        }

        public void Saque(double decrescimo)
        {
            Saldo -= decrescimo;
        }

        public void MostrarInformações()
        {
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nSaldo: {Saldo}");
        }
    }
}