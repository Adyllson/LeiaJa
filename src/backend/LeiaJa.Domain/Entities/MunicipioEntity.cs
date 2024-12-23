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
            DomainExceptionValidation.When(id < 0, "O ID do Municipio deve ser positiva");
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
            DomainExceptionValidation.When(string.IsNullOrEmpty(municipio), "O Municipio é obrigatório");
            DomainExceptionValidation.When(municipio.Length > 30, "O Municipio deve ter, no máximo 30 caracteres");

            DomainExceptionValidation.When(int.IsNegative(provinciaId), "ID da Provincia não deve ser negativa");
            DomainExceptionValidation.When(provinciaId < 0, "O ID da Provincia deve ser positivo");

            Municipio = municipio;
            ProvinciaId = provinciaId;
        }
    }
}