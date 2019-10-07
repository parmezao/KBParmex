using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(JDDataContext ctx)
            : base(ctx)
        {
        }

        public async Task<Usuario> AuthenticateAsync(string Username, string Password)
        {
            return await _db.FirstOrDefaultAsync(u => 
                (
                    u.EmailUsuario.ToLower() == Username.ToLower() || u.NmUsuario.ToLower() == Username.ToLower()
                ) && 
                u.HashSenha == Password);             
        }
    }
}
