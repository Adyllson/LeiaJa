namespace LeiaJa.Domain.Entities
{
    public sealed class MunicipioEntity : EntityBase
    {
        public string Municipio { get; private set; } = null!;
        public int ProvinciaId { get; private set; }

        [JsonIgnore]
        public ProvinciaEntity Provincia { get; set; } = null!;

        [JsonIgnore]
        public ICollection<UsuarioEntity> usuario { get; set; } = null!;

        [JsonConstructor]
        public MunicipioEntity(){}
        public MunicipioEntity(int id, string municipio, int provinciaId)
        {
            DomainExceptionValidation.When(int.IsNegative(id), "O ID do Municipio Não deve ser Negativo");
            DomainExceptionValidation.When(id <= 0, "O ID do Municipio deve ser positiva");
            Id = id;
            ValidationDomain(municipio, provinciaId);
        }
        public MunicipioEntity(string municipio, int provinciaId)
        {
            ValidationDomain(municipio, provinciaId);
        }
        public void Update(string municipio, int provinciaId)
        {
            ValidationDomain(municipio, provinciaId);
        }
        public void ValidationDomain(string municipio, int provinciaId)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(municipio), "O Municipio É Obrigatório");
            DomainExceptionValidation.When(municipio.Length > 30, "O Municipio Dve Ter Menos de 30 caracteres");

            DomainExceptionValidation.When(int.IsNegative(provinciaId), "Provincia Não Deve Ser Negativa");
            DomainExceptionValidation.When(provinciaId <= 0, "O Provincia Deve Ser Positivo");

            Municipio = municipio;
            ProvinciaId = provinciaId;
        }
    }
}