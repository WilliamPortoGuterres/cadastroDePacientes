namespace cadastroDePacientes.Models
{
    public class PacienteModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public PacienteModel(string nome, string telefone, string email, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}
