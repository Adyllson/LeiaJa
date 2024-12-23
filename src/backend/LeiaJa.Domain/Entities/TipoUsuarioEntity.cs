namespace LeiaJa.Domain.Entities;
public sealed class TipoUsuarioEntity : EntityBase
{
    public string TipoUsuario { get; set; } = null!;
    
    [JsonIgnore]
    public ICollection<UsuarioEntity> Usuarios{ get; set; } = null!;
}
