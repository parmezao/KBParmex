using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbUsuario
    {
        public TbjkbUsuario()
        {
            TbjkbBaseConhecimento = new HashSet<TbjkbBaseConhecimento>();
            TbjkbBaseProduto = new HashSet<TbjkbBaseProduto>();
            TbjkbBuscaChave = new HashSet<TbjkbBuscaChave>();
            TbjkbCausaRaiz = new HashSet<TbjkbCausaRaiz>();
            TbjkbPalavraChave = new HashSet<TbjkbPalavraChave>();
            TbjkbProduto = new HashSet<TbjkbProduto>();
            TbjkbResumo = new HashSet<TbjkbResumo>();
            TbjkbSolucaoPaliativa = new HashSet<TbjkbSolucaoPaliativa>();
        }

        public decimal IdUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string HashSenha { get; set; }
        public decimal IdUsuarioRegistro { get; set; }
        public decimal DhRegistro { get; set; }
        public string StUsuario { get; set; }

        public virtual TbjkbSituacaoUsuario StUsuarioNavigation { get; set; }
        public virtual ICollection<TbjkbBaseConhecimento> TbjkbBaseConhecimento { get; set; }
        public virtual ICollection<TbjkbBaseProduto> TbjkbBaseProduto { get; set; }
        public virtual ICollection<TbjkbBuscaChave> TbjkbBuscaChave { get; set; }
        public virtual ICollection<TbjkbCausaRaiz> TbjkbCausaRaiz { get; set; }
        public virtual ICollection<TbjkbPalavraChave> TbjkbPalavraChave { get; set; }
        public virtual ICollection<TbjkbProduto> TbjkbProduto { get; set; }
        public virtual ICollection<TbjkbResumo> TbjkbResumo { get; set; }
        public virtual ICollection<TbjkbSolucaoPaliativa> TbjkbSolucaoPaliativa { get; set; }
    }
}