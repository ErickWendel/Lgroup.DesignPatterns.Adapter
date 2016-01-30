using LGroup.Adapter.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankOfAmerica;

namespace LGroup.Adapter.Business
{
    //Adaptamos o boleto do BOA para rodar dentro de nosso componente de
    //geracao de boletos, esse boleto externo vai fazer parte
    //da familia interna de boletos
    //

    public sealed class BoletoBankOfAmericaBusiness : IBoleto
    {
        private Billet _boletoBoa = new Billet();
        public void EmitirBoleto(Model.BoletoModel boleto_)
        {
            const Decimal VALOR_ATUAL_DOLAR = 4;
            //para  nós os dados do boleto ficam no bOLETOMODEL
            //temos que pegar esses dados e ADAPTAR, colocar em 1 formato
            //que a classe BILLET do BOA consiga ler

            var valorAtualDolar = boleto_.Valor * VALOR_ATUAL_DOLAR;
            _boletoBoa.Send(valorAtualDolar, boleto_.DataVencimento);

            
        }
    }
}
