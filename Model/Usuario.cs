namespace GerarDadosFakesModel
{
    public class Usuario
    {
        public Usuario(string nome, string sobreNome, string cPF, string email, string senha, string numeroTelefone, int idade, string biografia, Genero genero)
        {
            Nome = nome;
            SobreNome = sobreNome;
            CPF = cPF;
            Email = email;
            Senha = senha;
            NumeroTelefone = numeroTelefone;
            Idade = idade;
            Biografia = biografia;
            Genero = genero;
        }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string NumeroTelefone { get; set; }
        public int Idade { get; set; }
        public string Biografia { get; set; }
        public Genero Genero { get; set; }
    }

    public enum Genero
    {
        Masculino,
        Feminino
    }
}
