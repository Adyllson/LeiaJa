namespace LeiaJa.Domain.Interfaces;
public interface IAutorRepository
{
    Task<ResponseModel<List<AutorEntity>>> GetAllAutoresAsync();
    Task<ResponseModel<List<AutorEntity>>> CreateAutorAsync(AutorEntity autor);
    Task<ResponseModel<AutorEntity>> UpdateAutorAsync(AutorEntity autor);
    Task<ResponseModel<AutorEntity?>> DeleteAutorAsync(int autorId);
    Task<ResponseModel<AutorEntity>?> GetAutorByIdAsync(int autorId);
}
