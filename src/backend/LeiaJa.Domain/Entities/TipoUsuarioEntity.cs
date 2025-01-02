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
        DomainExceptionValidation.When(int.IsNegative(id), "O ID Do Tipo De Usuario Não Deve Ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID Do Tipo De Usuario Deve Ser positiva");
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
