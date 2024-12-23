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
}
