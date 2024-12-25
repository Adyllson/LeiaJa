namespace LeiaJa.Domain.Entities;
public sealed class LivroEntity : EntityBase
{
    public string Livro { get; private set; } = null!;
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
    public LivroEntity(int id, string livro, int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID dO Autor Não deve ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID do Autor deve ser positiva");
        Id = id;
        ValidationDomain(livro,autorId, categoriaId, editora, anoPublicacao, edicao);
    }
    public LivroEntity( string livro, int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        ValidationDomain(livro,autorId, categoriaId, editora, anoPublicacao, edicao);
    }
    public void Update(string livro, int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
        ValidationDomain(livro,autorId, categoriaId, editora, anoPublicacao, edicao);
    }
    public void ValidationDomain( string livro,int autorId, int categoriaId, string editora, DateTime anoPublicacao, string edicao)
    {
    }
}
