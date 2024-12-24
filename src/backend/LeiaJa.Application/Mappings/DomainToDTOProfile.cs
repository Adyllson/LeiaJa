namespace LeiaJa.Application.Mappings;
public class DomainToDTOProfile : Profile
{
    public DomainToDTOProfile()
    {
        CreateMap<AutorEntity, AutorDTO>().ReverseMap();
    }
}
