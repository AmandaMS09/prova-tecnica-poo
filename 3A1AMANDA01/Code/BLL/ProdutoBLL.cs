using System.Data;

using _3A1AMANDA01.Code.DTO;
using _3A1AMANDA01.Code.DAL;

namespace _3A1AMANDA01.Code.BLL
{
    class ProdutoBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "produto";

        public void Inserir(ProdutoDTO dto)
        {
            string inserir = $"insert into {tabela} values(null,'{dto.Nome}','{dto.Preco}','{dto.Marca}','{dto.Descricao}')";
            conexao.ExecutarComando(inserir);
        }

        public void Alterar(ProdutoDTO dto)
        {
            string alterar = $"update {tabela} set nome = '{dto.Nome}', preco = '{dto.Preco}', marca = '{dto.Marca}', descricao = '{dto.Descricao}' where id = '{dto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(ProdutoDTO dto)
        {
            string excluir = $"delete from {tabela} where id = '{dto.Id}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
