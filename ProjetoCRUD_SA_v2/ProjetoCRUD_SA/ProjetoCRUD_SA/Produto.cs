using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjetoCRUD_SA
{
    internal class Produto
    {
        // Atributos de produtos - encapsulados
        private int id;
        private string nome = "", descricao = "", emoji = "", categoria = "", tag = "";
        private decimal preco;
        private bool ativo = true;

        // Criação dos métodos de permissão de acesso aos atributos - SET / GET
        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetNome(string nome) { this.nome = nome; }
        public string GetNome() { return this.nome; }

        public void SetDescricao(string descricao) { this.descricao = descricao; }
        public string GetDescricao() { return this.descricao; }

        public void SetPreco(decimal preco) { this.preco = preco; }
        public decimal GetPreco() { return this.preco; }

        public void SetEmoji(string emoji) { this.emoji = emoji; }
        public string GetEmoji() { return this.emoji; }

        public void SetCategoria(string categoria) { this.categoria = categoria; }
        public string GetCategoria() { return this.categoria; }

        public void SetTag(string tag) { this.tag = tag; }
        public string GetTag() { return this.tag; }

        public void SetAtivo(bool ativo) { this.ativo = ativo; }
        public bool GetAtivo() { return this.ativo; }

        // Criação dos métodos do CRUD:
        //1º passo: instanciar a classe de Conexão
        Conexao db = new Conexao();

        //2º passo: métodos de INSERT, UPDATE, DELETE e SELECT:
        public void InserirProduto()
        {
            string inserir = @"INSERT INTO tblProdutos (nome, descricao, preco, emoji, categoria, tag, ativo)
                               VALUES (@nome, @descricao, @preco, @emoji, @categoria, @tag, @ativo);";
            db.ExecutarComando(inserir,
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@descricao", descricao),
                new MySqlParameter("@preco", preco),
                new MySqlParameter("@emoji", emoji),
                new MySqlParameter("@categoria", categoria),
                new MySqlParameter("@tag", tag),
                new MySqlParameter("@ativo", ativo));
        }

        public void AlterarProduto()
        {
            string alterar = @"UPDATE tblProdutos
                                  SET nome = @nome, descricao = @descricao, preco = @preco,
                                      emoji = @emoji, categoria = @categoria, tag = @tag, ativo = @ativo
                                WHERE id = @id;";
            db.ExecutarComando(alterar,
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@descricao", descricao),
                new MySqlParameter("@preco", preco),
                new MySqlParameter("@emoji", emoji),
                new MySqlParameter("@categoria", categoria),
                new MySqlParameter("@tag", tag),
                new MySqlParameter("@ativo", ativo),
                new MySqlParameter("@id", id));
        }

        public void ExcluirProduto()
        {
            string excluir = "DELETE FROM tblProdutos WHERE id = @id;";
            db.ExecutarComando(excluir, new MySqlParameter("@id", id));
        }

        public DataTable ListarTodosProdutos()
        {
            return db.ExecutarConsulta("SELECT * FROM tblProdutos ORDER BY nome;");
        }
    }
}
