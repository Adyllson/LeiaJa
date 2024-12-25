using LeiaJa.Domain.Pagination;

namespace LeiaJa.Application.Services;
public class AutorService : IAutorService
{
    private readonly IAutorRepository _repository;
    private readonly IMapper _mapper;
    public AutorService(IAutorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<ResponseModel<List<AutorDTO>>> CreateAutorAsync(AutorPostDTO autorDTO)
    {
        ResponseModel<List<AutorDTO>> response = new();
        try
        {
            var autor = _mapper.Map<AutorEntity>(autorDTO);
            var createautor = await _repository.CreateAutorAsync(autor);
            if(createautor == null)
            {
                response.Messege = "Não Foi Salvo";
                response.StatusCode = 201;
                return response;
            }

            response.Data = _mapper.Map<List<AutorDTO>>(createautor);
            response.Messege = "Autor Salvo com sucesso";
            response.StatusCode = 200;
            return response;
        }
        catch (Exception ex)
        {
            response.Messege = $"Erro ao Salvar o autor: {ex.Message}";
            response.StatusCode = 500;
            return response;
        }
    }

    public async Task<ResponseModel<AutorDTO>> DeleteAutorAsync(int autorId)
    {
        ResponseModel<AutorDTO> response = new();
        try
        {
            var deletadoAutor = await _repository.DeleteAutorAsync(autorId);
            if(deletadoAutor == null)
            {
                response.Messege = $"Não Existe Autor com ID {autorId}";
                response.StatusCode = 201;
                return response;
            }
            response.Data = _mapper.Map<AutorDTO>(deletadoAutor);
            response.Messege = "Autor deletado com sucesso!";
            response.StatusCode = 200;
            return response;
        }
        catch(Exception ex)
        {
            response.Messege = $"Erro ao deletar o autor {ex.Message}";
            response.StatusCode = 500;
            return response;
        
        }
    }

    public async Task<ResponseModel<PagedList<AutorDTO>>> GetAllAutoresAsync(int pageNumber, int pageSize)
    {
        ResponseModel<PagedList<AutorDTO>> response = new();
        try
        {
            var autores = await _repository.GetAllAutoresAsync(pageNumber, pageSize);
            var autoresDTOs = _mapper.Map<List<AutorDTO>>(autores);
            if(!autoresDTOs.Any())
            {
                response.Messege = "Não Foi Encontrado Nenhum Autor";
                response.StatusCode = 201;
                return response;
            }
            response.Data =  new PagedList<AutorDTO>(autoresDTOs, pageNumber, pageSize, autores.TotalCount);
            response.Messege = "Autores Encontrados";
            response.StatusCode = 200;
            return response;
        }
        catch (Exception ex)    
        {
            response.Messege = $"Erro ao Listar o Autor: {ex.Message}";
            response.StatusCode = 500;
            return response;
        }
    }

    public async Task<ResponseModel<AutorDTO>> GetAutorByIdAsync(int autorId)
    {
        ResponseModel<AutorDTO> response = new();
        try
        {
            var autor = await _repository.GetAutorByIdAsync(autorId);
            var autorDTO = _mapper.Map<AutorDTO>(autor);
            if(autorDTO == null)
            {
                response.Messege = $"Não Exite O Autor Com {autorId}!";
                response.StatusCode = 201;
                return response;
            }
            response.Data = autorDTO;
            response.Messege = $"Foi Encontrado Autor Com ID = {autorId}!";
            response.StatusCode = 200;
            return response;
        }
        catch(Exception ex)
        {
            response.Messege = $"Erro ao Obter o Autor: {ex.Message}";
            response.StatusCode = 500;
            return response;
        }
    }

    public async Task<ResponseModel<AutorDTO>> UpdateAutorAsync(AutorDTO autor)
    {
        ResponseModel<AutorDTO> response = new();
        try
        {
            var autorEntity = _mapper.Map<AutorEntity>(autor);
            var updateAutor = await _repository.UpdateAutorAsync(autorEntity);
            if(updateAutor == null)
            {
                response.Messege = "Os parametros não devem ser nulo, vazias";
                response.StatusCode = 201;
                return response;
            }
            response.Data = _mapper.Map<AutorDTO>(updateAutor);
            response.Messege = "Autor editado com sucesso!";
            response.StatusCode = 200;
            return response;
        }
        catch(Exception ex)
        {
            response.Messege = $"Erro ao aditar o autor {ex.Message}";
            response.StatusCode = 500;
            return response;
        
        }
    }
}
