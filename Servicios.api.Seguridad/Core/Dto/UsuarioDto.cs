namespace Servicios.api.Seguridad.Core.Dto
{
    //data transformation object = DTO
    public class UsuarioDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string token { get; set; }
    }
}
