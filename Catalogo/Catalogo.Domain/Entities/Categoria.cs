using Catalogo.Domain.Validation;

namespace Catalogo.Domain.Entities
{
    // Classe sealed não pode ser herdada, objetivo encapsular e isolar.
    public sealed class Categoria : Entity
    {
        // Construtor com validação
        public Categoria(string nome, string imagemUrl)
        {
            ValidateDomain(nome, imagemUrl);
        }

        // Construtor com validação com id para usar a auto "população" de tabela
        // feita em FluentAPI na classe CategoriaConfiguration no projeto
        // Infrastructure na pasta EntitiesConfiguration
        public Categoria(int id, string nome, string imagemUrl)
        {
            DomainExceptionValidation.When(id < 0, "valor de Id inválido.");
            Id = id;
            ValidateDomain(nome, imagemUrl);
        }

        // Set privado só permite que os dados sejam inseridos por métodos contidos nessa classe.
        public string Nome { get; private set; }
        public string ImagemUrl { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        // Aqui estamos fazendo uma validação simples
        // essa validação poderia ser feito na camada application
        // mas devido a simplicidade do projeto é oque tinha para
        // demonstrar como fazer validação em domain.
        private void ValidateDomain(string nome, string imagemUrl)
        {
            // Esse DomainExceptionValidation foi criado na pasta Validation
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
                "Nome inválido. O nome é obrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(imagemUrl),
                "Nome da imagem inválido. O nome é obrigatório");

            DomainExceptionValidation.When(nome.Length < 3,
               "O nome deve ter no mínimo 3 caracteres");

            DomainExceptionValidation.When(imagemUrl.Length < 5,
                "Nome da imagem deve ter no mínimo 5 caracteres");

            Nome = nome;
            ImagemUrl = imagemUrl;
        }
    }
}
