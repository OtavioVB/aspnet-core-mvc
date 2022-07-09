namespace WebAppClientes.Models
{
    public class NomeModel
    {
        public string Valor { get; set; }

        public NomeModel(string Input)
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                throw new Exception("O nome cadastrado não pode conter espaços vazios");
            }

            foreach (char Letra in Input)
            {
                if (char.IsLetter(Letra) == false)
                {
                    throw new Exception("O input deve conter somente letras");
                }
            }
            this.Valor = Input;
        }
    }
}
