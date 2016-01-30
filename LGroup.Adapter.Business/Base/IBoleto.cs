using LGroup.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Adapter.Business.Base
{
    //Montamos uma familia de boletos
    //Boletos do Itau, Bradesco e depois de
    //bancos estrangeiros
   public interface IBoleto
    {
       void EmitirBoleto(BoletoModel boleto_);
    }
}
