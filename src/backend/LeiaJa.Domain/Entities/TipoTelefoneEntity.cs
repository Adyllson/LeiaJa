namespace LeiaJa.Domain.Entities;
public sealed class TipoTelefoneEntity : EntityBase
{
    public string TipoTelefone { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<TelefoneEntity> Telefones { get; set; } = null!;
}
