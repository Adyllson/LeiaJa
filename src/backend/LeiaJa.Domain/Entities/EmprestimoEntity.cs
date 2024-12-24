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

    [JsonConstructor]
    public EmprestimoEntity(){}
    public EmprestimoEntity(int id, int usuarioId, int livroId, DateTime dataEmprestimo, DateTime dataEntrega, bool entrega)
    {
        DomainExceptionValidation.When(int.IsNegative(id), "O ID da Provincia Não deve ser Negativo");
        DomainExceptionValidation.When(id <= 0, "O ID da Provincia deve ser positiva");
        Id = id;
        ValidationDomain(usuarioId, livroId, dataEmprestimo, dataEntrega, entrega);
    }

    public EmprestimoEntity(int usuarioId, int livroId, DateTime dataEmprestimo, DateTime dataEntrega, bool entrega)
    {
        ValidationDomain(usuarioId, livroId, dataEmprestimo, dataEntrega, entrega);
    }
    public void Update(int usuarioId, int livroId, DateTime dataEmprestimo, DateTime dataEntrega, bool entrega)
    {
        ValidationDomain(usuarioId, livroId, dataEmprestimo, dataEntrega, entrega);
    }

    public void ValidationDomain(int usuarioId, int livroId, DateTime dataEmprestimo, DateTime dataEntrega, bool entrega)
    {
        
    }
}
