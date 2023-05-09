using Catalogo.Application.DTOs;

namespace Catalogo.Application.Interfaces
{
    // Contrato para realizar as operações com categorias.
    // Expõe somente as informações do DTO e não do dominio.
    // A implementação dessas interfaces foi feita na pasta Services.
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> GetCategorias();
        Task<CategoriaDTO> GetById(int? id);
        Task Add(CategoriaDTO categoriaDto);
        Task Update(CategoriaDTO categoriaDto);
        Task Remove(int? id);
    }
}
