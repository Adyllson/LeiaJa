namespace LeiaJa.Domain.Entities;
public sealed class CategoriaEntity : EntityBase
{
    public string Categoria { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<LivroEntity> Livros { get; set; } = null!;
}
