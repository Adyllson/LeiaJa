
namespace LeiaJa.Application.Services;
public class CategoriaService : ICategoriaService
{
    public Task<ResponseModel<List<CategoriaDTO>>> CreateCategoriaAsync(CategoriaPostDTO categoriaPostDTO)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<CategoriaDTO>> DeleteCategoriaAsync(int categoriaId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<PagedList<CategoriaDTO>>> GetAllCategoriasAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<CategoriaDTO>> GetCategoriaByIdAsync(int categoriaId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<CategoriaDTO>> UpdateCategoriaAsync(CategoriaDTO categoriaDTO)
    {
        throw new NotImplementedException();
    }
}
