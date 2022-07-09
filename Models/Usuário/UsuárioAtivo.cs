using WebAppClientes.Models.LoginModel;

namespace WebAppClientes.Models.Usuário
{
    public class UsuárioAtivo
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
