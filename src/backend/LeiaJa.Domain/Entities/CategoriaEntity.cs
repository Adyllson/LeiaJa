namespace LeiaJa.Domain.Entities;
public sealed class CategoriaEntity : EntityBase
{
    public string Categoria { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<LivroEntity> Livros { get; set; } = null!;

    [JsonConstructor]
    public CategoriaEntity(){}

    public CategoriaEntity(int id, string categoria)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID da Categoria Não deve ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID da Categoria deve ser positiva");
        Id = id;
        ValidationDomain(categoria);
    }

    public CategoriaEntity(string categoria)
    {
        ValidationDomain(categoria);
    }

    public void Update(string categoria)
    {
        ValidationDomain(categoria);
    }

    public void ValidationDomain(string categoria)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(categoria),"A Categoria é obrigatório");
        DomainExceptionValidation.When(categoria.Length > 50, "A Categoria deve ter, no máximo 50 caracteres");

        Categoria = categoria;
    }
}
