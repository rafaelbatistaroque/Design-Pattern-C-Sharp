using Design_Pattern_C_Sharp.FactoryPattern;
using Design_Pattern_C_Sharp.SingletonPattern;
using System;
using System.Collections.Generic;

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

            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| 1-SINGLETON | 2-FACTORY |--------------------|");
            Console.WriteLine("+----------------------------------------------+");

            Console.WriteLine();

            ControleSelecaoMenu();
        }

        public static void ControleSelecaoMenu()
        {
            var opcaoSelecionada = Console.ReadLine();

            var opcao = new Dictionary<string, Action>()
            {
                {"1",  AbrirSingleton},
                {"2",  SubMenuFactory}
            };

            if (opcao.ContainsKey(opcaoSelecionada))
                opcao[opcaoSelecionada].Invoke();
            else
                MostrarRespostaRetorno("Seleção inválida.");
        }

        public static void AbrirSingleton()
        {
            Console.Clear();

            Singleton instanciaUm = Singleton.Instancia;
            Singleton instanciaDois = Singleton.Instancia;

            MostrarRespostaRetorno($"Classes Singleton são iguais? {instanciaUm.Equals(instanciaDois)}");
            //SAIDA: True
        }

        public static void AbrirFactory(ETipoAplicacao opcaoTipoAplicacao)
        {
            var resultadoDesenvolvimento = new DesenvolvimentoAplicacaoFactory()
                                               .IniciarDesenvolvimento(opcaoTipoAplicacao);

            MostrarRespostaRetorno(resultadoDesenvolvimento.RealizarDesenvolvimento());

            //SAIDA: Desenvolvido Aplicação Web | Desktop | Mobile
        }

        public static void SubMenuFactory()
        {
            Console.Clear();

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("| 1-MOBILE | 2-WEB | 3-DESKTOP |");
            Console.WriteLine("+------------------------------+");

            Console.WriteLine();

            var opcaoSelecionada = int.Parse(Console.ReadLine()) - 1;
            var ehTipoAplicacao = Enum.IsDefined(typeof(ETipoAplicacao), opcaoSelecionada);

            if (ehTipoAplicacao)
            {
                var opcaoTipoAplicacao = Enum.Parse<ETipoAplicacao>(opcaoSelecionada.ToString());
                AbrirFactory(opcaoTipoAplicacao);
            }
            else
                MostrarRespostaRetorno("Seleção inválida.");
        }

        public static void MostrarRespostaRetorno(string mensagem)
        {
            Console.Clear();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            Console.WriteLine("Aperte Qualquer tecla pra voltar");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
