using Design_Pattern_C_Sharp.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_C_Sharp
{
    public class App
    {
        public static void Iniciar()
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();

            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("| 1-SINGLETON |--------------------+");
            Console.WriteLine("+----------------------------------+");

            Console.WriteLine();

            ControleSelecaoMenu();
        }

        public static void ControleSelecaoMenu()
        {
            var opcaoSelecionada = Console.ReadLine();

            var opcao = new Dictionary<string, Action>()
            {
                {"1",  AbrirSingleton},
            };

            if (opcao.ContainsKey(opcaoSelecionada))
                opcao[opcaoSelecionada].Invoke();
            else
                MostrarRespostaRetorno("Seleção inválida.");
        }

        public static void AbrirSingleton()
        {
            //TODO: Implementar
        }

        public static void MostrarRespostaRetorno(string mensagem)
        {
            Console.Clear();
            Console.WriteLine(mensagem);
            Console.WriteLine("Aperte Qualquer tecla pra voltar");
            Console.Clear();
            Console.ReadKey();
            Menu();
        }
    }
}
