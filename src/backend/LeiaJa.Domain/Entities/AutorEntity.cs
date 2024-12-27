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
        DomainExceptionValidation.When(int.IsNegative(id), "O ID do Autor não pode ser negativo.");
        DomainExceptionValidation.When(id <= 0, "O ID do Autor deve ser positivo.");
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
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome),"O Nome é obrigatório.");
        DomainExceptionValidation.When(nome.Length > 50, "O Nome não pode ter mais de 50 caracteres.");

        DomainExceptionValidation.When(string.IsNullOrEmpty(sobreNome),"O Sobrenome é obrigatório.");
        DomainExceptionValidation.When(sobreNome.Length > 50, "O Sobrenome não pode ter mais de 50 caracteres.");
        
        Nome = nome;
        SobreNome = sobreNome;
    }
}
