namespace Porter2023_test.Helpers.Classes
{
    internal class Pessoa
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }

        public Pessoa(string id, string name, int idade)
        {
            Id = id;
            Name = name;
            Idade = idade;
        }
    }
}
