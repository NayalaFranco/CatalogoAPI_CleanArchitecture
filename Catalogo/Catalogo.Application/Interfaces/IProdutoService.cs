using Catalogo.Application.DTOs;

namespace Catalogo.Application.Interfaces
{
    // Contrato para realizar as operações com produtos.
    // Expõe somente as informações do DTO e não do dominio.
    // A implementação dessas interfaces foi feita na pasta Services.
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDTO>> GetProdutos();
        Task<ProdutoDTO> GetById(int? id);
        Task Add(ProdutoDTO produtoDto);
        Task Update(ProdutoDTO produtoDto);
        Task Remove(int? id);
    }
}
