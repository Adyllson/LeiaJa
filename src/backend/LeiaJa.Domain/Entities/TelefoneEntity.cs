namespace LeiaJa.Domain.Entities;
public sealed class TelefoneEntity : EntityBase
{
    public string Telefone { get; private set; } = null!;
    public int UsuarioId { get; private set; }
    public int TipoTelefoneId { get; private set; }
    
    [JsonIgnore]
    public TipoTelefoneEntity TipoTelefone{ get; set; } = null!;

    [JsonIgnore]
    public UsuarioEntity Usuario { get; set; } = null!;

    [JsonConstructor]
    public TelefoneEntity(){}
    public TelefoneEntity(int id, string usuarioId, int tipoTelefoneId)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID do Telefone Não deve ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID do Telefone deve ser positiva");
        Id = id;
        ValidationDomain(usuarioId, tipoTelefoneId);
    }
    public TelefoneEntity(string usuarioId, int tipoTelefoneId)
    {
        ValidationDomain(usuarioId, tipoTelefoneId);
    }
    public void Update(string usuarioId, int tipoTelefoneId)
    {
        ValidationDomain(usuarioId, tipoTelefoneId);
    }
    public void ValidationDomain(string usuarioId, int tipoTelefoneId)
    {
        ValidationDomain(usuarioId, tipoTelefoneId);
    }
}
