namespace LeiaJa.Application.DTOs.Autor;
public class AutorPostDTO
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [MaxLength(50, ErrorMessage = "O Nome deve no mínimo 50 caracteres")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "O sobrenome é obrigatório")]
    [MaxLength(50, ErrorMessage = "O SobreNome deve no mínimo 50 caracteres")]
    public string SobreNome { get; set; } = null!;
}
