namespace LeiaJa.Domain.Entities;
public sealed class TipoUsuarioEntity : EntityBase
{
    public string TipoUsuario { get; set; } = null!;
    
    [JsonIgnore]
    public ICollection<UsuarioEntity> Usuarios{ get; set; } = null!;

    [JsonConstructor]
    public TipoUsuarioEntity(){}
    public TipoUsuarioEntity(int id, string tipoUsuario)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID do Tipo de Usuario Não deve ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID do Tipo de Usuario deve ser positiva");
        Id = id;
        ValidationDomain(tipoUsuario);
    }
    public TipoUsuarioEntity(string tipoUsuario)
    {
        ValidationDomain(tipoUsuario);
    }
    public void Update(string tipoUsuario)
    {
        ValidationDomain(tipoUsuario);
    }
    public void ValidationDomain(string tipoUsuario)
    {
        ValidationDomain(tipoUsuario);
    }
}
