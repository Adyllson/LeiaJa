namespace LeiaJa.Domain.Entities;
public sealed class AutorEntity : EntityBase
{
    public string Nome { get; private set; } = null!;
    public string SobreNome { get; private set; } = null!;
    
    [JsonIgnore]
    public ICollection<LivroEntity> Livros { get; set; } = null!;
}
