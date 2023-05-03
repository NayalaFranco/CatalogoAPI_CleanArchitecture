using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalogo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
            "VALUES('Caderno espiral','Caderno espiral 100 folhas',7.45,'caderno1.jpg',50,'2023-05-02',1)");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
            "VALUES('Estojo escolar','Estojo escolar cinza',5.65,'estojo1.jpg',70,'2023-04-02',1)");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
            "VALUES('Borracha escolar','Borracha branca pequena',3.25,'borracha1.jpg',80,'2023-03-01',1)");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
            "VALUES('Calculadora escolar','Calculadora simples',15.39,'calculadora1.jpg',20,'2023-04-29',2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
