namespace LeiaJa.Domain.Entities;
public sealed class UsuarioEntity : EntityBase
{

        public string Nome { get; private set; } = null!;
        public string SobreNome { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public bool IsAdmin { get; private set; }
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
}
