using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SeuCanto
{
    class ClienteDAO

    {
        public void Create(Cliente cliente)
        {

            Database Quarto = Database.GetInstance();

            string qry = string.Format("INSERT INTO cliente(nome,cpf,estado_civil,logradouro,nro_log,bairro,cep,uf,celular) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                cliente.Nome, cliente.Cpf, cliente.EstadoCivil, cliente.Logradouro, cliente.Nro_log, cliente.Bairro, cliente.Cep,cliente.Uf, cliente.Celular);

            Quarto.ExecuteSQL(qry);

        }

        public Cliente Read(int codigo)
        {

            Cliente cliente = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT codigo,nome,cpf,estado_civil,logradouro,nro_log,bairro,cep,uf,celular " +
                         "FROM cliente WHERE codigo="+codigo;
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            try
            {
                SQLiteDataReader dr = comm.ExecuteReader();
           

            if (dr.Read()) // A busca por chave primária só retorna um objeto
                {
                    // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                    cliente = new Cliente();
                    cliente.Codigo = dr.GetInt32(0);
                    cliente.Nome = dr.GetString(1);
                    cliente.Cpf = dr.GetString(2);
                    cliente.EstadoCivil = dr.GetString(3);
                    cliente.Logradouro = dr.GetString(4);
                    cliente.Nro_log = dr.GetString(5);
                    cliente.Bairro = dr.GetString(6);
                    cliente.Cep = dr.GetString(7);
                    cliente.Uf = dr.GetString(8);
                    cliente.Celular = dr.GetString(9);
                }
             dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler dados do Cliente: " + ex.Message);
            }
            //conexao.Close();
            return cliente;

        }

        public void Update(Cliente cliente)
        {

            Database dbQuarto = Database.GetInstance();

            string qry = string.Format("UPDATE cliente SET nome='{0}'," +
                " cpf = '{1}', estado_civil = '{2}', logradouro ='{3}', nro_log = '{4}'," +
                "bairro = '{5}', cep = '{6}', uf='{7}',celular ='{8}' WHERE codigo = {9}", cliente.Nome, cliente.Cpf,
                cliente.EstadoCivil, cliente.Logradouro, cliente.Nro_log, cliente.Bairro,
                cliente.Cep,cliente.Uf,cliente.Celular, cliente.Codigo);

            dbQuarto.ExecuteSQL(qry);
        }

        public void Delete(int codigo)
        {

            Database dbQuarto = Database.GetInstance();
            string qry = "DELETE FROM cliente WHERE codigo =" + codigo;
            dbQuarto.ExecuteSQL(qry);

        }

        public List<Cliente> ListAll()
        {

            List<Cliente> lista = new List<Cliente>();
            Cliente cliente;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry = "SELECT codigo,nome,cpf,estado_civil,logradouro,nro_log,bairro,cep,uf,celular" +
                " FROM cliente";
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {

                cliente = new Cliente();
                cliente.Codigo = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.EstadoCivil = dr.GetString(3);
                cliente.Logradouro = dr.GetString(4);
                cliente.Nro_log = dr.GetString(5);
                cliente.Bairro = dr.GetString(6);
                cliente.Cep = dr.GetString(7);
                cliente.Uf = dr.GetString(8);
                cliente.Celular = dr.GetString(9);
                lista.Add(cliente);

            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); //  fechar a conexão

            return lista;
        }

        public List<Cliente> FindByName(string nome) {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry;

            if (nome != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT codigo,nome,cpf,estado_civil,logradouro,nro_log,bairro,cep,uf,celular FROM cliente" +
                    " WHERE nome LIKE '%{0}%' ;", nome);
            else
                qry = "SELECT codigo,nome,cpf,estado_civil,logradouro,nro_log,bairro,cep,uf,celular FROM cliente";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {

                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                cliente = new Cliente();
                cliente.Codigo = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.EstadoCivil = dr.GetString(3);
                cliente.Logradouro = dr.GetString(4);
                cliente.Nro_log = dr.GetString(5);
                cliente.Bairro = dr.GetString(6);
                cliente.Cep = dr.GetString(7);
                cliente.Uf = dr.GetString(8);
                cliente.Celular = dr.GetString(9);
                lista.Add(cliente);

            }

            dr.Close(); // para nao ocorrer erro de database locked
            conexao.Close(); //  fechar a conexão




            return lista;
        }
    }
}
