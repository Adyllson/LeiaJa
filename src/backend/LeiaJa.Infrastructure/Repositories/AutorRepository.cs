namespace LeiaJa.Infrastructure.Repositories;
public class AutorRepository : IAutorRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _logger;
    public AutorRepository(AppDbContext context, ILogger<AutorRepository> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task<List<AutorEntity>> CreateAutorAsync(AutorEntity autor)
    {
        try
        {
            if (autor == null)
            {
                throw new ArgumentNullException(nameof(autor), "O autor não deve ser nulo.");
            }

            await _context.Autores.AddAsync(autor);

            await _context.SaveChangesAsync();

            return await _context.Autores.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,"Ocorreu um erro ao criar o autor: ");
            return null!;
        }
    }

    public async Task<AutorEntity?> DeleteAutorAsync(int autorId)
    {
        try
        {
            if (autorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(autorId), "O ID não deve ser negativo ou zero.");
            }
            
            var autor = await _context.Autores.FirstOrDefaultAsync(x => x.Id == autorId);
            if (autor == null)
            {
                throw new KeyNotFoundException($"Nenhum autor encontrado com o ID {autorId}.");
            }
            
            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();
            return autor;

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao deletar o Autor");
            return null!;
        }
    }

    public async Task<PagedList<AutorEntity>> GetAllAutoresAsync(int pageNumber, int pageSize)
    {
        try
        {
            var autores = await _context.Autores.AsNoTracking().ToListAsync();
            if(autores == null)
            {
                throw new KeyNotFoundException($"Não encontrado os autores.");
            }
            var query = _context.Autores.AsQueryable();
            return await PaginationHelper.CreateAsync(query,pageNumber, pageSize);
            
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter os autores");
            return null!;
        }
    }

    public async Task<AutorEntity?> GetAutorByIdAsync(int autorId)
    {
        try
        {
            if (autorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(autorId), "O ID não deve ser negativo ou zero.");
            }
            return await _context.Autores.FirstOrDefaultAsync(x => x.Id == autorId);
        }
        catch
        {
            _logger.LogError("Erro ao buscar o autor com ID {AutorId}", autorId);
            return null;
        }
    }

    public async Task<AutorEntity> UpdateAutorAsync(AutorEntity autor)
    {
        try
        {
            if(autor == null)
                throw new ArgumentNullException(nameof(autor),"Não deve ser vazio ou nulo");

            _context.Autores.Update(autor);
            var result = await _context.SaveChangesAsync();

            if (result == 0)
            {
                _logger.LogWarning($"Nenhuma modificação foi realizada ao editar o autor com ID {autor.Id}.");
                return null!;
            }
            
            return autor;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao editar o autor");
            return null!;
        }
    }
}
