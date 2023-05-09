namespace Catalogo.Domain.Entities
{
    // Classe abstrata para o Id que repete em Categoria e em Produto
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
