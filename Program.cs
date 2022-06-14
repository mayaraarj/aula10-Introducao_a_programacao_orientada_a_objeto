//Exercício da aula 06

namespace aula10_exercicio06
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario();
            Console.WriteLine("Qual é o seu nome?");
            usuario1.nomeDoUsuario = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            usuario1.idadeDoUsuario = int.Parse(Console.ReadLine());
            usuario1.anoAtual = 2022;
            usuario1.anoNascimento = usuario1.anoAtual - usuario1.idadeDoUsuario;
            Console.Write($"Olá {usuario1.nomeDoUsuario}, você nasceu em {usuario1.anoNascimento}!");

        }
    }


    public class Usuario
    {
        public string nomeDoUsuario;
        public int idadeDoUsuario;
        public int anoAtual;
        public int anoNascimento;

    }


    //Desafio do professor

    public class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos quilômetros foram percorridos ");
        }
    }
}