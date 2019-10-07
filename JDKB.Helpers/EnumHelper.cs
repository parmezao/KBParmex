using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Helpers
{
    public static class EnumHelper
    {
        public enum Visibilidade
        {
            INTERNO,
            PRIVADO,
            PUBLICO
        }

        public enum SituacaoUsuario
        {
            UA9, //Ativo
            UE9, //Excluído
        }

        public enum SituacaoBase
        {
            BA9, //Ativa
            BE9, //Excluído
        }
    }
}
