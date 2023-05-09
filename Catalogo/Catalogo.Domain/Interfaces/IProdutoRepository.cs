using Catalogo.Domain.Entities;

namespace Catalogo.Domain.Interfaces
{
    // Contrato que é implementado no projeto Infrastructure pelo repositorio
    // usando uma classe concreta.
    // Essa definição foi feita aqui porque dessa forma conseguimos acessar
    // as entidades de dominio, e como é interface não temos acoplamento
    // aqui no projeto domain, mantendo-o sem dependencia alguma.
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task<Produto> GetByIdAsync(int? id);
        Task<Produto> CreateAsync(Produto product);
        Task<Produto> UpdateAsync(Produto product);
        Task<Produto> RemoveAsync(Produto product);
    }
}
