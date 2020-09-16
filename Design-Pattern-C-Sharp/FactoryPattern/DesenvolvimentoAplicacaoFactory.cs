using System;
using System.Collections.Generic;

namespace Design_Pattern_C_Sharp.FactoryPattern
{
    public class DesenvolvimentoAplicacaoFactory
    {
        public IDesenvolvimento IniciarDesenvolvimento(ETipoAplicacao tipoAtendimento)
        {
            var opcaoAtendimento = new Dictionary<ETipoAplicacao, Func<IDesenvolvimento>>()
            {
                {ETipoAplicacao.Mobile, RealizarDesenvolvimentoMobile },
                {ETipoAplicacao.Desktop, RealizarDesenvolvimentoDesktop },
                {ETipoAplicacao.Web, RealizarDesenvolvimentoWeb }
            };

            return opcaoAtendimento[tipoAtendimento].Invoke();
        }

        private IDesenvolvimento RealizarDesenvolvimentoMobile()
        {
            return new DesenvolverAplicacaoMobile();
        }

        private IDesenvolvimento RealizarDesenvolvimentoDesktop()
        {
            return new DesenvolverAplicacaoDesktop();
        }

        private IDesenvolvimento RealizarDesenvolvimentoWeb()
        {
            return new DesenvolverAplicacaoWeb();
        }
    }
}
