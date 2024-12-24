namespace LeiaJa.Domain.Interfaces;
public interface IAutorRepository
{
    Task<ResponseModel<List<AutorEntity>>> GetAllAsync();
}
