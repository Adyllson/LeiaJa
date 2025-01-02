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
        DomainExceptionValidation.When(int.IsNegative(id), "O ID Do Livro Não Deve Ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID Do Livro Deve Ser Positiva");
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

        DomainExceptionValidation.When(string.IsNullOrEmpty(livro), "O Livro é Obrigatório.");
        DomainExceptionValidation.When(livro.Length > 200, "O Livro Não Pode Ter Menos de 200 Caracteres.");

        DomainExceptionValidation.When(int.IsNegative(autorId), "O ID Do Autor Não Pode Ser Negativo.");
        DomainExceptionValidation.When(autorId <= 0, "O ID Do Livro Deve Ser Positivo.");

        DomainExceptionValidation.When(int.IsNegative(categoriaId), "O ID Da Categoria Não Pode Ser Negativo.");
        DomainExceptionValidation.When(categoriaId <= 0, "O ID Da Categoria Deve Ser Positivo.");

        DomainExceptionValidation.When(string.IsNullOrEmpty(editora), "A Editora é Obrigatória.");
        DomainExceptionValidation.When(editora.Length > 100, "A Editora Deve Ter Menos de 100 Caracteres.");

        DomainExceptionValidation.When(string.IsNullOrEmpty(edicao), "A Edição É Obrigatório.");
        DomainExceptionValidation.When(edicao.Length > 100, "A Edição Deve Ter Menos De 100 Caracteres.");


        Livro = livro;
        AutorId = autorId;
        CategoriaId = categoriaId;
        Editora = editora;
        AnoPublicacao = anoPublicacao;
        Edicao = edicao;
    }
}
