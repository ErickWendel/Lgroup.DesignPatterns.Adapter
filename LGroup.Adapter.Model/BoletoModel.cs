using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Adapter.Model
{
    //O padrão ADAPTER (ADAPTER)
    //GOF = 4 (DO FACTORY)
    //Server para fazer adaptacoes de DLLs de terceiros dentro do nosso sistema
    //DLL terceiro (Baixado da net, comprou, equipe de arquitetura)
    //Adaptamos uma DLL externa (Terceiro) para funcionar da melhor forma
    // dentro das nossas DLLs (Componentes)
    //adaptamos os DADOS de 1 DLL para outra DLL
    //Lembro muito tipos de TOMADA (3 PINOS e 2 PINOS)
    //Fazemos uma ponte utilizando um ADAPTADOR DE TOMADAS
    //Tradutor 
    public sealed class BoletoModel
    {

        public Int32 Codigo { get; set; }
        public Decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        //Quem emitiu o boleto (Empresa)
        public String Cedente { get; set; }
        public String Sacado { get; set; }

    }
}
