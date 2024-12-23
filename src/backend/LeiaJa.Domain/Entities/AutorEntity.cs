namespace LeiaJa.Domain.Entities;
public sealed class AutorEntity : EntityBase
{
    public string Nome { get; private set; } = null!;
    public string SobreNome { get; private set; } = null!;
    
    [JsonIgnore]
    public ICollection<LivroEntity> Livros { get; set; } = null!;

    [JsonConstructor]
    public AutorEntity(){}

    public AutorEntity(int id, string nome, string sobreNome)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID do Usuario Não deve ser Negativo");
        DomainExceptionValidation.When(id < 0, "O ID do Usuario deve ser positiva");
        Id = id;
        ValidationDomain(nome, sobreNome);
    }

    public AutorEntity(string nome, string sobreNome)
    {
        ValidationDomain(nome, sobreNome);
    }

    public void Update(string nome, string sobreNome)
    {
        ValidationDomain(nome, sobreNome);
    }

    public void ValidationDomain(string nome, string sobreNome)
    {
        ValidationDomain(nome, sobreNome);
    }
}
