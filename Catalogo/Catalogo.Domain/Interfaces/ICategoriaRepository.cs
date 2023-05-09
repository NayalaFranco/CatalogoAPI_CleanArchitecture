using Catalogo.Domain.Entities;

namespace Catalogo.Domain.Interfaces
{
    // Contrato que é implementado no projeto Infrastructure pelo repositorio
    // usando uma classe concreta.
    // Essa definição foi feita aqui porque dessa forma conseguimos acessar
    // as entidades de dominio, e como é interface não temos acoplamento
    // aqui no projeto domain, mantendo-o sem dependencia alguma.
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetCategoriasAsync();
        Task<Categoria> GetByIdAsync(int? id);
        Task<Categoria> CreateAsync(Categoria categoria);
        Task<Categoria> UpdateAsync(Categoria categoria);
        Task<Categoria> RemoveAsync(Categoria categoria);
    }
}
