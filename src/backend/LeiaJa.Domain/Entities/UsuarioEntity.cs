namespace LeiaJa.Domain.Entities;
public sealed class UsuarioEntity : EntityBase
{

        public string Nome { get; private set; } = null!;
        public string SobreNome { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public byte[] PasswordHash { get; private set; } = null!;
        public byte[] PasswordSalt { get; private set; } = null!;
        public int GeneroId { get; private set; }
        public int TipoUsuarioId { get; private set; }
        public int MunicipioId { get; private set; }

        [JsonIgnore]
        public ICollection<TelefoneEntity> Telefones { get; set; } = null!;

        [JsonIgnore]
        public ICollection<EmprestimoEntity> Emprestimos { get; set; } = null!;

        [JsonIgnore]
        public GeneroEntity Genero { get; set; } = null!;

        [JsonIgnore]
        public TipoUsuarioEntity TipoUsuario { get; set; } = null!;

        [JsonIgnore]
        public MunicipioEntity Municipio { get; set; } = null!;

        [JsonConstructor]
        public UsuarioEntity(){}

        public UsuarioEntity(int id, string nome, string sobreNome, string emial, int generoId, int tipoUsuarioId, int municipioId)
        {
                DomainExceptionValidation.When(int.IsNegative(id), "O ID da Provincia Não deve ser Negativo");
                DomainExceptionValidation.When(id < 0, "O ID da Provincia deve ser positiva");
                Id = id;
                ValidationDomain(nome, sobreNome, emial, generoId, tipoUsuarioId, municipioId);
        }
        public UsuarioEntity(string nome, string sobreNome, string emial, int generoId, int tipoUsuarioId, int municipioId)
        {
                ValidationDomain(nome, sobreNome, emial, generoId, tipoUsuarioId, municipioId);
        }
        public void Update(string nome, string sobreNome, string emial, int generoId, int tipoUsuarioId, int municipioId)
        {
                ValidationDomain(nome, sobreNome, emial, generoId, tipoUsuarioId, municipioId);
        }
        public void UpdatePassword(byte[] passwordHash, byte[] passwordSalt)
        {
                PasswordHash = passwordHash;
                PasswordSalt = passwordSalt;
        }
        public void ValidationDomain(string nome, string sobreNome, string emial, int generoId, int tipoUsuarioId, int municipioId)
        {
                ValidationDomain(nome, sobreNome, emial, generoId, tipoUsuarioId, municipioId);
        }
}
