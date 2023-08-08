using Dapper;
using Modelo.ORM.INFO;
using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;

namespace Modelo.ORM.DAL
{
    public class CategoriaDal
    {
        private readonly string ConnectionString;

        public CategoriaDal()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString;
        }

        //Strings de comandos mysql
        const string sqlInserir = @"INSERT INTO CATEGORIA (DESCRICAO, ISATIVO) VALUES (@Descricao, @IsAtivo);";

        const string sqlAtualizar = @"UPDATE CATEGORIA SET DESCRICAO = @Descricao, ISATIVO = @IsAtivo WHERE CATEGORIA_ID = @CategoriaID;";

        const string sqlExcluir = @"DELETE FROM CATEGORIA WHERE CATEGORIA_ID = @CategoriaID;";

        const string sqlSelecionar = @"SELET * FROM CATEGORIA WHERE CATEGORIA_ID = @CategoriaID;";

        const string sqlSelecionarTodos = @"SELECT * FROM CATEGORIA ORDER BY DESCRICAO;";

        const string sqlSelecionarFiltro = @"SELECT * FROM CATEGORIA WHERE DESCRICAO LIKE @CategoriaID OERDER BY DESCRICAO;";

        //Funções CRUD
        public CategoriaInfo Salvar(CategoriaInfo catInfo)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                if (catInfo.CategoriaID == 0)
                {
                    // Utilize o parâmetro com o nome correto que está presente na consulta SQL (exemplo: @Descricao, @IsAtivo)
                    return dbConnection.Query<CategoriaInfo>(sqlInserir, catInfo).SingleOrDefault();
                }
                else
                {
                    // Utilize o parâmetro com o nome correto que está presente na consulta SQL (exemplo: @Descricao, @IsAtivo, @CategoriaID)
                    dbConnection.Execute(sqlAtualizar, catInfo);
                    return catInfo;
                }
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public bool Excluir(int categID)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Execute(sqlExcluir, new { @CategoriaID = categID }) > 0;
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public CategoriaInfo Selecionar(int categID)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<CategoriaInfo>(sqlSelecionar, new { @CategoriaID  = categID }).SingleOrDefault();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public List<CategoriaInfo> SelecionarTodos()
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<CategoriaInfo>(sqlSelecionarTodos, null).ToList();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }

        public List<CategoriaInfo> SelecionarFiltro(string pDescricao)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<CategoriaInfo>(sqlSelecionarFiltro, new { @Descricao = "%" + pDescricao + "%" }).ToList();
            } // A conexão será fechada automaticamente quando sair do bloco 'using'
        }
    }
}