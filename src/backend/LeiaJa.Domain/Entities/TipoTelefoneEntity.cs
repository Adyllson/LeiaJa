namespace LeiaJa.Domain.Entities;
public sealed class TipoTelefoneEntity : EntityBase
{
    public string TipoTelefone { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<TelefoneEntity> Telefones { get; set; } = null!;

    [JsonConstructor]
    public TipoTelefoneEntity(){}

    public TipoTelefoneEntity(int id, string tipoTelefone)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID do Tipo de Telefone  Não deve ser Negativo");
        DomainExceptionValidation.When(id < 0, "O ID do Tipo de Telefone deve ser positiva");
        Id = id;
        ValidationDomain(tipoTelefone);
    }
    public TipoTelefoneEntity(string tipoTelefone)
    {
        ValidationDomain(tipoTelefone);
    }
    public void Update(string tipoTelefone)
    {
        ValidationDomain(tipoTelefone);
    }
    public void ValidationDomain(string tipoTelefone)
    {
        ValidationDomain(tipoTelefone);
    }
}
