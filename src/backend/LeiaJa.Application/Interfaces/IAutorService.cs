namespace LeiaJa.Application.Interfaces;
public interface IAutorService
{
    Task<ResponseModel<List<AutorDTO>>> GetAllAutoresAsync();
    Task<ResponseModel<List<AutorDTO>>> CreateAutorAsync(AutorPostDTO autorDTO);
    Task<ResponseModel<AutorDTO>> UpdateAutorAsync(AutorDTO autor);
    Task<ResponseModel<AutorDTO>> DeleteAutorAsync(int autorId);
    Task<ResponseModel<AutorDTO>> GetAutorByIdAsync(int autorId);
}
