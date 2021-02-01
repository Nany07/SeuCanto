using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SeuCanto
{
    class Database
    {
        private static SQLiteConnection conexao;
        private static Database instance;
        private const string URL = "Data Source=SLar.db";

        private Database()
        {
            // caso o banco não tenha sido criado, este método irá criar
            if (!File.Exists("SLar.db"))
                GerarBD();

            conexao = new SQLiteConnection(URL);

        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public SQLiteConnection GetConnection()
        {
            return conexao;
        }

        public void ExecuteSQL(string qry)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            conexao.Close();

        }

        private void GerarBD()
        {
            SQLiteConnection.CreateFile("SLar.db");
            SQLiteConnection conn = new SQLiteConnection(URL);
            conn.Open();

            //criando tabela funcionario
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS funcionario (");
            sql.AppendLine("codigo INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");
            sql.AppendLine("cpf VARCHAR(14) NOT NULL, ");
            sql.AppendLine("dtnasc DATE, ");
            sql.AppendLine("nome VARCHAR(40) NOT NULL,");
            sql.AppendLine("estado_civil VARCHAR(10),");
            sql.AppendLine("logradouro VARCHAR(80),");
            sql.AppendLine("nro_log VARCHAR(5),");
            sql.AppendLine("bairro VARCHAR(20),");
            sql.AppendLine("cep VARCHAR(10),");
            sql.AppendLine("uf VARCHAR(2),");
            sql.AppendLine("celular VARCHAR(14),");
            sql.AppendLine("telefone VARCHAR(14),");            
            sql.AppendLine("admissao_data DATE NOT NULL,");
            sql.AppendLine("funcao VARCHAR(10),");
            sql.AppendLine("password VARCHAR(14) NOT NULL);");


            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            //criando tabela cliente
            sql.Clear();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS cliente(");
            sql.AppendLine("codigo INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");
            sql.AppendLine("nome VARCHAR(40) NOT NULL,");
            sql.AppendLine("cpf VARCHAR(14) NOT NULL, ");
            sql.AppendLine("estado_civil VARCHAR(10),");
            sql.AppendLine("logradouro VARCHAR(80),");
            sql.AppendLine("nro_log VARCHAR(5),");
            sql.AppendLine("bairro VARCHAR(20),");
            sql.AppendLine("cep VARCHAR(10),");
            sql.AppendLine("uf   VARCHAR(2),");
            sql.AppendLine("celular VARCHAR(12));");

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            //criando tabela cadasto_quarto
            sql.Clear();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS quarto(");        
            sql.AppendLine("nro_quarto INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");            
            sql.AppendLine("tipo VARCHAR(20),");
            sql.AppendLine("qtde_pessoas int,");      
            sql.AppendLine("preco_dia decimal(6,2));");
            
          

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }


            //criando tabela login

            sql.Clear();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS login(");
            sql.AppendLine("nome_login VARCHAR(20) NOT NULL PRIMARY KEY,");
            sql.AppendLine("senha varchar(20) NOT NULL,");
            sql.AppendLine("codigo_fun INTEGER NOT NULL,");
            sql.AppendLine("FOREIGN KEY(codigo_fun) REFERENCES funcionario(codigo));");

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            //criando tabela reserva_quarto
            sql.Clear();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS reserva_quarto(");               
            sql.AppendLine("cod_cli  INTEGER NOT NULL,");
            sql.AppendLine("cod_quarto INTEGER NOT NULL,");
            sql.AppendLine("data_ini_aluguel DATE NOT NULL,");
            sql.AppendLine("data_devol DATE NOT NULL,");            
            sql.AppendLine("preco_total decimal (6,2) DEFAULT 0,");
            sql.AppendLine("cod_reserva INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("cod_func INTEGER NOT NULL,");
            sql.AppendLine("FOREIGN KEY(cod_func) REFERENCES funcionario (codigo),");
            sql.AppendLine("FOREIGN KEY(cod_cli) REFERENCES cliente(codigo),");
            sql.AppendLine("FOREIGN KEY(cod_quarto) REFERENCES cadastro_quarto(nro_quarto));");

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }
            conn.Close();

        }
    }
}
