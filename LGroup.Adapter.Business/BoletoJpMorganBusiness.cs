using LGroup.Adapter.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JpMorgan;
namespace LGroup.Adapter.Business
{

    //A classe de negocio  é a classe ADAPTADORA
    //os dados entram como BOLETOMODEL e saem no formato DECIMAL
    //é a tomada conversora de dados
    //Adaptamos uma classe externa de boletos
    //para trabalhar em uma familia 
    //Externa de boletos
   public sealed  class BoletoJpMorganBusiness  :IBoleto
    {
       private Billet _boleto = new Billet();
        public void EmitirBoleto(Model.BoletoModel boleto_)
        {
            const Decimal VALOR_ATUAL_DOLAR = 4;

            var novoValor = boleto_.Valor * VALOR_ATUAL_DOLAR;
            _boleto.Transmit(novoValor, boleto_.DataVencimento, boleto_.Codigo);
        }
    }
}
