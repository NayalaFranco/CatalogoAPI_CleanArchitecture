using AutoMapper;
using Catalogo.Application.DTOs;
// Ref. ao Domain Entities
using Catalogo.Domain.Entities;

namespace Catalogo.Application.Mappings
{
    // Configura mapeamento do AutoMapper
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}
