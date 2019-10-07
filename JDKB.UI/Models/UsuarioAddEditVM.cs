using JDKB.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class UsuarioAddEditVM
    {
        public decimal Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeUsuario { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }

        [DisplayName("ConfirmaSenha")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string ConfirmaSenha { get; set; }

        public decimal IdUsuarioRegistro { get; set; }

        public decimal DataHoraRegistro { get; set; }

        public string SitUsuario { get; set; }
    }

    public static class UsuarioModelExtensions
    {
        public static UsuarioAddEditVM ToVM(this Usuario data)
        {
            return new UsuarioAddEditVM
            {
                Id = data.IdUsuario,
                NomeUsuario = data.NmUsuario,
                Email = data.EmailUsuario,
                Senha = data.HashSenha,
                IdUsuarioRegistro = data.IdUsuarioRegistro,
                DataHoraRegistro = data.DhRegistro,
                SitUsuario = data.StUsuario
            };
        }

        public static Usuario ToData(this UsuarioAddEditVM model)
        {
            return new Usuario
            {
                IdUsuario = model.Id,
                NmUsuario = model.NomeUsuario,
                EmailUsuario = model.Email,
                HashSenha = model.Senha,
                IdUsuarioRegistro = model.IdUsuarioRegistro,
                DhRegistro = model.DataHoraRegistro,
                StUsuario = model.SitUsuario
            };
        }
    }
}
