namespace ProfessorPontoMAUI.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }

        //public string Email { get; set; }

        public string Matricula { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
}
