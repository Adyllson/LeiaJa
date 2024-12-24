using LeiaJa.Domain.Common;

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
    public Task<ResponseModel<List<AutorDTO>>> CreateAutorAsync(AutorDTO autor)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorDTO>> DeleteAutorAsync(int autorId)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseModel<List<AutorDTO>>> GetAllAutoresAsync()
    {
        ResponseModel<List<AutorDTO>> response = new();
        try
        {
            var autores = await _repository.GetAllAutoresAsync();
            var autoresDTOs = _mapper.Map<List<AutorDTO>>(autores);
            if(!autoresDTOs.Any())
            {
                response.Messege = "Não Foi Encontrado Nenhum Autor";
                response.StatusCode = 201;
                return response;
            }
            response.Data = autoresDTOs;
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

    public Task<ResponseModel<AutorDTO>> GetAutorByIdAsync(int autorId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorDTO>> UpdateAutorAsync(AutorDTO autor)
    {
        throw new NotImplementedException();
    }
}
