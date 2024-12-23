namespace LeiaJa.Domain.Entities;
public sealed class EmprestimoEntity : EntityBase
{
    public int UsuarioId { get; private set; }
    public int LivroId { get; private set; }
    public DateTime DataEmprestimo { get; private set; }
    public DateTime DataEntrega { get; private set; }
    public bool Entrega { get; private set; }

    [JsonIgnore]
    public UsuarioEntity usuario { get; set; } = null!;

    [JsonIgnore]
    public LivroEntity Livro { get; set; } = null!;
}
