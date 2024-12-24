namespace LeiaJa.Domain.Interfaces;
public interface IAutorRepository
{
    Task<List<AutorEntity>> GetAllAutoresAsync();
    Task<List<AutorEntity>> CreateAutorAsync(AutorEntity autor);
    Task<AutorEntity> UpdateAutorAsync(AutorEntity autor);
    Task<AutorEntity?> DeleteAutorAsync(int autorId);
    Task<AutorEntity?> GetAutorByIdAsync(int autorId);
}
