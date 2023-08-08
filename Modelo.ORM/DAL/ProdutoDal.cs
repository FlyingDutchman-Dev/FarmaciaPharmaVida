using Dapper;
using Modelo.ORM.INFO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.DAL
{
    public class ProdutoDal
    {
        private readonly string ConnectionString;

        public ProdutoDal()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString;
        }

        //Strings de comandos mysql
        const string sqlInserir = @"INSERT INTO PRODUTOS (CATEGORIAID, DESCRICAO, DESCRICAO_REDUZIDA, UNIDADE, VALOR_CUSTO, PORCENTAGEM_LUCRO, VALOR_VENDA, CODIGO_BARRA, ESTOQUE_ATUAL, ESTOQUE_MINIMO, ESTOQUE_MAXIMO, ISATIVO) 
                                  VALUES (@CategoriaID, @Descricao, @DescricaoReduzida, @Unidade, @ValorCusto, @PorcentagemLucro, @ValorVenda, @CodigoBarra, @EstoqueAtual, @EstoqueMinimo, @EstoqueMaximo, @IsAtivo);";

        const string sqlAtualizar = @"UPDATE PRODUTOS SET CATEGORIAID = @CategoriaID, DESCRICAO = @Descricao, DESCRICAO_REDUZIDA = @DescricaoReduzida, UNIDADE = @Unidade, VALOR_CUSTO = @ValorCusto, 
                                    PORCENTAGEM_LUCRO = @PorcentagemLucro, VALOR_VENDA = @ValorVenda, CODIGO_BARRA = @CodigoBarra, ESTOQUE_ATUAL = @EstoqueAtual, ESTOQUE_MINIMO = @EstoqueMinimo, ESTOQUE_MAXIMO = @EstoqueMaximo, ISATIVO = @IsAtivo
                                    WHERE PRODUTO_ID = @ProdutoID;";

        const string sqlExcluir = @"DELETE FROM PRODUTOS WHERE PRODUTO_ID = @ProdutoID;";

        const string sqlSelecionar = @"SELET * FROM PRODUTOS WHERE PRODUTO_ID = @ProdutoID;";

        const string sqlSelecionarTodos = @"SELECT * FROM PRODUTOS ORDER BY DESCRICAO;";

        const string sqlSelecionarFiltro = @"SELECT * FROM PRODUTOS WHERE DESCRICAO LIKE @ProdutoID OERDER BY DESCRICAO;";

        //Funções CRUD
        public ProdutoInfo Salvar(ProdutoInfo prodInfo)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                if (prodInfo.ProdutoID == 0)
                {
                    // Utilize o parâmetro com o nome correto que está presente na consulta SQL (exemplo: @Descricao, @IsAtivo)
                    return dbConnection.Query<ProdutoInfo>(sqlInserir, prodInfo).SingleOrDefault();
                }
                else
                {
                    // Utilize o parâmetro com o nome correto que está presente na consulta SQL (exemplo: @Descricao, @IsAtivo, @CategoriaID)
                    dbConnection.Execute(sqlAtualizar, prodInfo);
                    return prodInfo;
                }
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public bool Excluir(int prodID)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Execute(sqlExcluir, new { @ProdutoID = prodID }) > 0;
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public ProdutoInfo Selecionar(int prodID)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<ProdutoInfo>(sqlSelecionar, new { @ProdutoID = prodID }).SingleOrDefault();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public List<ProdutoInfo> SelecionarTodos()
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<ProdutoInfo>(sqlSelecionarTodos, null).ToList();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public List<ProdutoInfo> SelecionarFiltro(string pDescricao)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<ProdutoInfo>(sqlSelecionarFiltro, new { @Descricao = "%" + pDescricao + "%" }).ToList();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }
    }
}
