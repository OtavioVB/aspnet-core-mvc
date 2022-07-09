namespace WebAppClientes.Models
{
    public class ClientesModel
    {
        public NomeModel Nome { get; set; }

        public ClientesModel(NomeModel nome)
        {
            this.Nome = nome;
        }
    }
}
