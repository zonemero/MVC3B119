using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoMVC3B119.DAL
{
    public class DALMVC
    {
        private MySqlConnection conexao;
        private readonly string string_conexao = "Persist security info = false; " +
                                                 "server=localhost" +
                                                 "database=ProjetoMVC3B119" +
                                                 "uid=root" +
                                                 "pwd=";

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch(MySqlException e)
            {
                throw new Exception("Erro ao se conectar com o banco de dados: " + e.Message);
            }
        }

        public void ExecutarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                throw new Exception("Erro ao executar o comando no banco de dados: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter Dados = new MySqlDataAdapter(sql, conexao);
                Dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro ao selecionar os dados no banco de dados: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}