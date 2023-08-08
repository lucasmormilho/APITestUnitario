namespace APITestUnitario.Entities
{
    public class User
    {
        public User(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
