namespace LeiaJa.Domain.Entities;
public sealed class GeneroEntity : EntityBase
{
    public string Genero { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<UsuarioEntity> Usuarios{ get; set; } = null!;

    [JsonConstructor]
    public GeneroEntity(){}
    public GeneroEntity(int id, string genero)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID do Genero Não deve ser Negativo");
        DomainExceptionValidation.When(id < 0, "O ID do Genero deve ser positiva");
        Id = id;
        ValidationDomain(genero);
    }
    public GeneroEntity(string genero)
    {
        ValidationDomain(genero);
    }
    public void Update(string genero)
    {
        ValidationDomain(genero);
    }
    public void ValidationDomain(string genero)
    {
        ValidationDomain(genero);
    }
}
