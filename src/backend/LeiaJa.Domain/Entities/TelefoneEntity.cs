namespace LeiaJa.Domain.Entities;
public sealed class TelefoneEntity : EntityBase
{
    public string Telefone { get; private set; } = null!;
    public int UsuarioId { get; private set; }
    public int TipoUsuarioId { get; private set; }
    
    [JsonIgnore]
    public TipoTelefoneEntity TipoTelefoneId { get; set; } = null!;

    [JsonIgnore]
    public UsuarioEntity Usuario { get; set; } = null!;
}
