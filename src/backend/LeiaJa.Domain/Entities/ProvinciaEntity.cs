namespace LeiaJa.Domain.Entities;
public sealed class ProvinciaEntity : EntityBase
{
    public string Provincia { get; private set; } = null!;

    [JsonIgnore]
    public ICollection<MunicipioEntity> Municipios { get; set; } = null!;

    [JsonConstructor]
    public ProvinciaEntity(){}
    public ProvinciaEntity(int id, string provincia)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID da Provincia Não deve ser Negativo");
        DomainExceptionValidation.When(id < 0, "O ID da Provincia deve ser positiva");
        Id = id;
        ValidationDomain(provincia);
    }
    public ProvinciaEntity(string provincia)
    {
        ValidationDomain(provincia);
    }
    public void Update(string provincia)
    {
        ValidationDomain(provincia);
    }
    public void ValidationDomain(string provincia)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(provincia),"A Provincia é obrigatório");
        DomainExceptionValidation.When(provincia.Length > 30, "A Provincia deve ter, no máximo 30 caracteres");
        Provincia = provincia;
    }
}
