namespace LeiaJa.Domain.Entities;
public sealed class LivroEntity : EntityBase
{
    public int AutorId { get; private set; }
    public int CategoriaId { get; set; }
    public string Editora { get; private set; } = null!;
    public DateTime AnoPublicacao { get; private set; }
    public string Edicao { get; private set; } = null!;

    [JsonIgnore]
    public CategoriaEntity Categoria { get; set; } = null!;

    [JsonIgnore]
    public AutorEntity Autores { get; set; } = null!;

    [JsonIgnore]
    public ICollection<EmprestimoEntity> Emprestimos { get; set; } = null!;

    [JsonConstructor]
    public LivroEntity(int id, int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID dO Autor Não deve ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID do Autor deve ser positiva");
        Id = id;
        ValidationDomain(autorId, categoriaId, editora, anoPublicacao, edicao);
    }
    public LivroEntity(int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        ValidationDomain(autorId, categoriaId, editora, anoPublicacao, edicao);
    }
    public void Update(int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        ValidationDomain(autorId, categoriaId, editora, anoPublicacao, edicao);
    }
    public void ValidationDomain(int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        ValidationDomain(autorId, categoriaId, editora, anoPublicacao, edicao);
    }
}
