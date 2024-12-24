namespace LeiaJa.Infrastructure.Repositories;
public class AutorRepository : IAutorRepository
{
    private readonly AppDbContext _context;
    public AutorRepository(AppDbContext context)
    {
        _context = context;
    }
    public Task<ResponseModel<List<AutorEntity>>> CreateAutorAsync(AutorEntity autor)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorEntity?>> DeleteAutorAsync(int autorId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<List<AutorEntity>>> GetAllAutoresAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorEntity>?> GetAutorByIdAsync(int autorId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorEntity>> UpdateAutorAsync(AutorEntity autor)
    {
        throw new NotImplementedException();
    }
}
