namespace LeiaJa.Infrastructure.Repositories;
public class AutorRepository : IAutorRepository
{
    private readonly AppDbContext _context;
    public AutorRepository(AppDbContext context)
    {
        _context = context;
    }
    public Task<List<AutorEntity>> CreateAutorAsync(AutorEntity autor)
    {
        throw new NotImplementedException();
    }

    public Task<AutorEntity?> DeleteAutorAsync(int autorId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AutorEntity>> GetAllAutoresAsync()
    {
        try
        {
            var autores = await _context.Autores.AsNoTracking().ToListAsync();
            if(autores == null)
            {
                return null!;
            }
            return autores;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Task<AutorEntity?> GetAutorByIdAsync(int autorId)
    {
        throw new NotImplementedException();
    }

    public Task<AutorEntity> UpdateAutorAsync(AutorEntity autor)
    {
        throw new NotImplementedException();
    }
}
