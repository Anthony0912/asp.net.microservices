using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Servicios.api.Seguridad.Core.Entities;
using System.Threading.Tasks;

namespace Servicios.api.Seguridad.Core.Persistence
{
    public class SeguridadData
    {
        public static async Task InsertarUsuario(SeguridadContexto contexto, UserManager<Usuario> userManager)
        {
            if (!userManager.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nombre = "Anthony",
                    Apellido = "Cardona",
                    Direccion = "Los Chiles",
                    UserName = "akcardona",
                    Email = "akcardona0912@gmail.com"
                };

                await userManager.CreateAsync(usuario, "Password123$");
            }
        }
    }
}
