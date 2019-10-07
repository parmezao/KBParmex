using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public enum UsuarioSituacao
    {
        Ativo,
        Inativo
    }

    public class Usuario : Entity
    {
        public Usuario()
        {
            BaseConhecimento = new HashSet<BaseConhecimento>();
            BaseProduto = new HashSet<BaseProduto>();
            BuscaChave = new HashSet<BuscaChave>();
            CausaRaiz = new HashSet<CausaRaiz>();
            PalavraChave = new HashSet<PalavraChave>();
            Produto = new HashSet<Produto>();
            Resumo = new HashSet<Resumo>();
            SolucaoPaliativa = new HashSet<SolucaoPaliativa>();
        }

        public decimal IdUsuario { get; set; }

        public string NmUsuario { get; set; }

        public string EmailUsuario { get; set; }

        public string HashSenha { get; set; }

        public decimal IdUsuarioRegistro { get; set; }

        public decimal DhRegistro { get; set; }

        public string StUsuario { get; set; }

        public virtual SituacaoUsuario SituacaoUsuario { get; set; }

        public virtual ICollection<BaseConhecimento> BaseConhecimento { get; set; }

        public virtual ICollection<BaseProduto> BaseProduto { get; set; }

        public virtual ICollection<BuscaChave> BuscaChave { get; set; }

        public virtual ICollection<CausaRaiz> CausaRaiz { get; set; }

        public virtual ICollection<PalavraChave> PalavraChave { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }

        public virtual ICollection<Resumo> Resumo { get; set; }

        public virtual ICollection<SolucaoPaliativa> SolucaoPaliativa { get; set; }
    }
}
