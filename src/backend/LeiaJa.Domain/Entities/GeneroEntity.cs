namespace LeiaJa.Domain.Entities;
public sealed class GeneroEntity : EntityBase
{
    public string Genero { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<UsuarioEntity> Usuarios{ get; set; } = null!;
}
