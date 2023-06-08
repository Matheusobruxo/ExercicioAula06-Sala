using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user = "matheus", user2,
                pass = "vasco", pass2,
                tentaPass, tentaUser;
            int option;

            Console.WriteLine("----------Bem vindo ao NuBanco----------!!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("---------------- OPÇOES ------------------");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Cadastrar novo usuario!");
            Console.WriteLine("2 - Login");

            option = int.Parse(Console.ReadLine());

            while (option != 1 && option != 2)
            {
                Console.Clear();
                Console.WriteLine("----------Bem vindo ao NuBanco----------!!");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Digite uma opção indicada!");
                Console.WriteLine("1 - Cadastrar novo usuario!");
                Console.WriteLine("2 - Login");
                option = int.Parse(Console.ReadLine());
            }

            if (option == 1)
            {
                Console.Clear();
                Console.WriteLine("-------------- CADASTRO --------------");
                Console.WriteLine("Digite o user desejado:");
                user2 = Console.ReadLine();
                Console.WriteLine("Agora a senha:");
                pass2 = Console.ReadLine();

                Console.WriteLine("--- Cadastro realizado com sucesso ---");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("--------------- LOGIN ----------------");

                Console.WriteLine("Digite o seu user:");
                tentaUser = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");
                tentaPass = Console.ReadLine();
                Console.Clear();

                if (tentaPass == pass && tentaUser == user)
                {
                    Console.WriteLine("Cadastro realizado com sucesso!");
                    Console.ReadKey();
                    return;

                }
                else if (tentaPass == pass2 && tentaPass == user2)
                {
                    Console.WriteLine("Cadastro realizado com sucesso!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Usuário ou senha inválido");
                    Console.WriteLine("Aperte qualquer tecla para reiniciar o programa...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);


                }

                Console.WriteLine("Login realizado com sucesso!!!");
                Console.ReadKey();
                return;

            }
            if (option == 2)
            {
                Console.WriteLine("--------------- LOGIN ----------------");

                Console.WriteLine("Digite o seu user:");
                tentaUser = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");
                tentaPass = Console.ReadLine();
                Console.Clear();

                if (tentaPass != pass && tentaUser != user)
                {
                    Console.Clear();
                    Console.WriteLine("Usuário ou senha inválido");

                    Console.WriteLine("Digite o seu user:");
                    tentaUser = Console.ReadLine();

                    Console.WriteLine("Digite a sua senha:");
                    tentaPass = Console.ReadLine();
                    Main(null);
                    Console.Clear();
                    return;

                }


                Console.ReadKey();

            }
        }









    }







    /*void revisao()
    {
        int n1;

        Console.WriteLine("Digite um numero de 1 a 10:");
        n1 = int.Parse(Console.ReadLine());

        if (n1 > 10 || n1 < 1) // se n1 maior que 10 ou menor que 1
        {
            Console.WriteLine("\nDigite um número válido primo...");
            Console.ReadKey();
            Console.Clear();
            Main(null);
            return;                  // "return" retorna valor a classe atual e fecha o programa
        }

        else
        {
            Console.WriteLine("\nOque da dama da noite disse?\n" +
                              "------ Fim do programa ------\n\n");
            Console.ReadKey();
            Console.Clear();


        }

        Console.ReadKey();
        Main(null);
        return;
    }
    */
}
