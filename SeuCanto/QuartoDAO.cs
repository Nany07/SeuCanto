using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SeuCanto
{
    class QuartoDAO
    {
        public void Create(Quarto quarto)
        {

            Database Quarto = Database.GetInstance();

            string qry = string.Format("INSERT INTO quarto(tipo,qtde_pessoas,preco_dia)" +
                                        "VALUES('{0}','{1}','{2}')",
                                        quarto.Tipo, quarto.QtdePessoas, quarto.PrecoDia.ToString("F"));
            Quarto.ExecuteSQL(qry);
        }

        public Quarto Read(int nro_quarto)
        {

            Quarto quarto = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nro_quarto,tipo,qtde_pessoas,preco_dia " +
                        "FROM quarto   " +
                        "WHERE nro_quarto =" + nro_quarto;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            try
            {
                SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read()) // A busca por chave primária só retorna um objeto
            {
                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                quarto = new Quarto();                
                quarto.Nro_quarto = dr.GetInt32(0);               
                quarto.Tipo = dr.GetString(1);
                quarto.QtdePessoas = dr.GetInt32(2);               
                quarto.PrecoDia = decimal.Parse(dr.GetString(3));
                }
            dr.Close();
           // conexao.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler dados do Quarto: " + ex.Message);
            }
            
            return quarto;

        }

        public void Update(Quarto quarto)
        {

            Database Quarto = Database.GetInstance();

            string qry = string.Format("UPDATE quarto SET tipo='{0}',qtde_pessoas ='{1}',preco_dia ='{2}' " +
                                        "WHERE nro_quarto ='{3}'",
                                        quarto.Tipo, quarto.QtdePessoas,quarto.PrecoDia.ToString("F"), quarto.Nro_quarto);

            Quarto.ExecuteSQL(qry);
        }
        public void Delete(int nro_quarto)
        {

            Database Quarto = Database.GetInstance();
            string qry = "DELETE FROM quarto WHERE nro_quarto =" + nro_quarto;
            Quarto.ExecuteSQL(qry);

        }

        public List<Quarto> ListAll()
        {

            List<Quarto> lista = new List<Quarto>();
            Quarto quarto;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry = "SELECT nro_quarto,tipo,qtde_pessoas,preco_dia FROM quarto";
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {

                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                quarto = new Quarto();        
                quarto.Nro_quarto = dr.GetInt32(0);
                quarto.Tipo = dr.GetString(1);
                quarto.QtdePessoas = dr.GetInt32(2);
                quarto.PrecoDia = decimal.Parse(dr.GetString(3));
                lista.Add(quarto);
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); //  fechar a conexão

            return lista;
        }

        public List<Quarto> FindByName(string tipo) {
            List<Quarto> lista = new List<Quarto>();
            Quarto quarto;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry;

            if (tipo != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT nro_quarto,tipo,qtde_pessoas,preco_dia FROM quarto WHERE tipo LIKE '%{0}%' ;", tipo);
            else
                 qry = "SELECT nro_quarto,tipo,qtde_pessoas,preco_dia FROM quarto";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {

                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                quarto = new Quarto();

                quarto.Nro_quarto = dr.GetInt32(0);
                quarto.Tipo = dr.GetString(1);
                quarto.QtdePessoas = dr.GetInt32(2);
                quarto.PrecoDia = decimal.Parse(dr.GetString(3));
            
                lista.Add(quarto);
            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); //  fechar a conexão




            return lista;

        }


    }
}
