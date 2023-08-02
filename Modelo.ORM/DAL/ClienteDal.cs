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
    public class ClienteDal
    {
        private readonly string ConnectionString;

        public ClienteDal()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString;
        }

        //Strings de comandos mysql
        const string sqlInserir = @"INSERT INTO CATEGORIA (DESCRICAO, ISATIVO) VALUES (@Descricao, @IsAtivo);";

        const string sqlAtualizar = @"UPDATE CATEGORIA SET DESCRICAO = @Descricao, ISATIVO = @IsAtivo WHERE CATEGORIA_ID = @CategoriaID;";

        const string sqlExcluir = @"DELETE FROM CATEGORIA WHERE CATEGORIA_ID = @CategoriaID";

        const string sqlSelecionar = @"SELET * FROM CATEGORIA WHERE CATEGORIA_ID = @CategoriaID";

        const string sqlSelecionarTodos = @"SELECT * FROM CATEGORIA ORDER BY DESCRICAO";

        const string sqlSelecionarFiltro = @"SELECT * FROM CATEGORIA WHERE DESCRICAO LIKE @CategoriaID OERDER BY DESCRICAO";

        //Funções CRUD
        public ClienteInfo Salvar(ClienteInfo clientetInfo)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                if (clientetInfo.ClienteID == 0)
                {
                    // Utilize o parâmetro com o nome correto que está presente na consulta SQL (exemplo: @Descricao, @IsAtivo)
                    return dbConnection.Query<ClienteInfo>(sqlInserir, clientetInfo).SingleOrDefault();
                }
                else
                {
                    // Utilize o parâmetro com o nome correto que está presente na consulta SQL (exemplo: @Descricao, @IsAtivo, @CategoriaID)
                    dbConnection.Execute(sqlAtualizar, clientetInfo);
                    return clientetInfo;
                }
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public bool Excluir(int clientetID)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Execute(sqlExcluir, new { @ClienteID = clientetID }) > 0;
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public ClienteInfo Selecionar(int clientetID)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<ClienteInfo>(sqlSelecionar, new { ClientetID = clientetID }).SingleOrDefault();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public List<ClienteInfo> SelecionarTodos()
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<ClienteInfo>(sqlSelecionarTodos, null).ToList();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public List<ClienteInfo> SelecionarFiltro(string pNome)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<ClienteInfo>(sqlSelecionarFiltro, new { @NomeRazaoSocial = "%" + pNome + "%" }).ToList();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }
    }
}
