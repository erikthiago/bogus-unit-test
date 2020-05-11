using Bogus;
using Bogus.Extensions.Brazil;
using GerarDadosFakesModel;

namespace GerarDadosFakes.ModelHelpers
{
    public static class UsuarioFaker
    {
        #region Opção 1

        private readonly static Faker _faker = new Faker("pt_BR");

        public static string Nome = _faker.Name.FirstName(new Bogus.DataSets.Name.Gender());
        public static string SobreNome = _faker.Name.LastName(new Bogus.DataSets.Name.Gender());
        public static string CPF = _faker.Person.Cpf();
        public static string Email = _faker.Internet.Email(Nome, SobreNome);
        public static string Senha = _faker.Random.Int() + _faker.Random.String();
        public static string Telefone = _faker.Phone.PhoneNumber("## ####-####");
        public static int Idade = _faker.Random.Int(1, 999);
        public static string Biografia = new Bogus.DataSets.Lorem(locale: "pt-BR").ToString();
        public static Genero Genero = _faker.PickRandom<Genero>();

        public static Faker<Usuario> GerarCampanhaIncentivo() => new Faker<Usuario>().CustomInstantiator(x => new Usuario(
                Nome,
                SobreNome,
                CPF,
                Email,
                Senha,
                Telefone,
                Idade,
                Biografia,
                Genero
               ));

        #endregion

        #region Opção 2

        public static Faker<Usuario> Gerar()
        {
            Faker<Usuario> usuario = new Faker<Usuario>("pt_BR")
                .RuleFor(s => s.Nome, f => f.Person.FirstName)
                .RuleFor(s => s.SobreNome, f => f.Person.LastName)
                .RuleFor(s => s.CPF, f => f.Person.Cpf())
                .RuleFor(s => s.Email, f => f.Internet.Email(Nome, SobreNome))
                .RuleFor(s => s.Senha, f => f.Random.Int() + f.Random.String())
                .RuleFor(s => s.NumeroTelefone, f => f.Phone.PhoneNumber("## ####-####"))
                .RuleFor(s => s.Idade, f => f.Random.Int(1, 999))
                .RuleFor(s => s.Biografia, f => f.Lorem.Text())
                .RuleFor(s => s.Genero, f => f.PickRandom<Genero>());

            return usuario;
        }

        #endregion
    }
}
