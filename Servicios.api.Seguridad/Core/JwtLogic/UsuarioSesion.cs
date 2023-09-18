using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Servicios.api.Seguridad.Core.JwtLogic
{
    public class UsuarioSesion : IUsuarioSesion
    {
        private IHttpContextAccessor _contextAccessor;

        public UsuarioSesion(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetUsuarioSesion()
        {
            var userName = _contextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == "username")?.Value;
            return userName;
        }
    }
}
