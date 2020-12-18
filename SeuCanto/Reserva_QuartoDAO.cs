using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SeuCanto
{
    class Reserva_QuartoDAO
    {
        public void Create(Reserva_Quarto r)
        {
            // Instância de Database para gerenciar a conexão com o banco. 
            // Essa instância é única para toda aplicação, 
            // pois Database segue o padrão Singleton
            Database dbQuarto = Database.GetInstance();

            //OBS!!
            //Criar um emprestimo, eh colocar o campo devolucao como null
            //Foi emprestado, ainda nao devolvido...

            string qry =
            string.Format("INSERT INTO reserva_quarto(cod_cli,cod_quarto,data_ini_aluguel, data_devol, preco_total,cod_func) " +
                          "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                          r.Cliente.Codigo,r.Quarto.Nro_quarto, r.DataIniAluguel.ToString("yyyy-MM-dd"),
                          r.DataEntrega.ToString("yyyy-MM-dd"), r.PrecoTotal.ToString("F"), r.CodFunc);

            // Uso a instância de Database para executar o comando sql.
            dbQuarto.ExecuteSQL(qry);
        }

       
        public Reserva_Quarto Read(int codigo)
        {
            Reserva_Quarto reserva_quarto = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT cod_cli,cod_quarto,data_ini_aluguel, data_devol, preco_total,cod_reserva, cod_func FROM reserva_quarto WHERE cod_reserva = " +
                         codigo;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read()) // A busca por chave primária só retorna um objeto
            {
                // Cria um objeto reserva_quarto para transferir os dados 
                // do banco para a aplicação (DTO)
                reserva_quarto = new Reserva_Quarto();
                ClienteDAO clienteDao = new ClienteDAO();
                reserva_quarto.Cliente = clienteDao.Read(dr.GetInt32(0));
                QuartoDAO quartoDao = new QuartoDAO();                
                reserva_quarto.Quarto = quartoDao.Read(dr.GetInt32(1));                
                reserva_quarto.DataIniAluguel = DateTime.Parse(dr.GetString(2));
                reserva_quarto.DataEntrega = DateTime.Parse(dr.GetString(3));
                //reserva_quarto.PrecoTotal = dr.GetDecimal(4);
                reserva_quarto.PrecoTotal = decimal.Parse(dr.GetString(4));
                reserva_quarto.CodReserva = dr.GetInt32(5);
                reserva_quarto.CodFunc = dr.GetInt32(6);
            }
            dr.Close();
            conexao.Close();
            return reserva_quarto;
        }

        public void Update(Reserva_Quarto r)
         {
             
             Database dbQuarto = Database.GetInstance();

             string qry =
             string.Format("UPDATE reserva_quarto SET cod_cli ='{0}',cod_quarto='{1}',data_ini_aluguel='{2}', data_devol='{3}'," +
                             "preco_total='{4}', cod_func ='{5}' WHERE cod_reserva={6}", r.Cliente.Codigo,r.Quarto.Nro_quarto, r.DataIniAluguel.ToString("yyy-MM-dd"),
                             r.DataEntrega.ToString("yyyy-MM-dd"),r.PrecoTotal.ToString("F"),r.CodFunc,r.CodReserva);

             dbQuarto.ExecuteSQL(qry);
         }

        public void Delete(int codigo)
         {
             Database dbQuarto = Database.GetInstance();

             string qry = "DELETE FROM reserva_quarto WHERE cod_reserva =" + codigo;

             dbQuarto.ExecuteSQL(qry);
         }

        public List<Reserva_Quarto> ListAll()
        {
            List<Reserva_Quarto> lista = new List<Reserva_Quarto>();
            Reserva_Quarto reserva_quarto = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT  cod_cli,cod_quarto,data_ini_aluguel, data_devol, preco_total,cod_reserva, cod_func FROM reserva_quarto";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto reserva_quarto para transferir os dados 
                // do banco para a aplicação (DTO)
                reserva_quarto = new Reserva_Quarto();

                ClienteDAO clienteDao = new ClienteDAO();
                reserva_quarto.Cliente = clienteDao.Read(dr.GetInt32(0));

                if(reserva_quarto.Cliente==null)
                {
                    reserva_quarto.NomeCliente = null;
                }
                else
                {
                    reserva_quarto.NomeCliente = reserva_quarto.Cliente.Nome;
                }
               
                QuartoDAO quartoDao = new QuartoDAO();
                reserva_quarto.Quarto = quartoDao.Read(dr.GetInt32(1));
                if(reserva_quarto.Quarto==null)
                {                   
                    reserva_quarto.PrecoQuarto = null;
                }
                else
                {                   
                    reserva_quarto.PrecoQuarto = Convert.ToString(reserva_quarto.Quarto.PrecoDia);
                }

                reserva_quarto.DataIniAluguel = DateTime.Parse(dr.GetString(2));
                reserva_quarto.DataEntrega = DateTime.Parse(dr.GetString(3));
                //reserva_quarto.PrecoTotal = dr.GetDecimal(4);
                reserva_quarto.PrecoTotal = decimal.Parse(dr.GetString(4));
                reserva_quarto.CodReserva = dr.GetInt32(5);
                reserva_quarto.CodFunc = dr.GetInt32(6);
                lista.Add(reserva_quarto); // Adiciona o objeto na lista de resultados
            }
            dr.Close();
            conexao.Close(); //  fechar a conexão
            return lista;
        }

        public List<Reserva_Quarto> FindByName(string nome)
        {
            List<Reserva_Quarto> lista = new List<Reserva_Quarto>();
            Reserva_Quarto reserva_quarto = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry;

            if (nome != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT rb.cod_cli,rb.cod_quarto,rb.data_ini_aluguel, rb.data_devol, rb.preco_total,rb.cod_reserva, rb.cod_func FROM reserva_quarto rb, cliente c" +
                                 " WHERE rb.cod_cli = c.codigo AND c.nome LIKE '%{0}%' ;", nome);
            else
                qry = "SELECT cod_cli,cod_quarto,data_ini_aluguel, data_devol, preco_total,cod_reserva, cod_func FROM reserva_quarto";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);

            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                // Cria um objeto reserva_quarto para transferir os dados 
                // do banco para a aplicação (DTO)
                reserva_quarto = new Reserva_Quarto();

                ClienteDAO clienteDao = new ClienteDAO();
                reserva_quarto.Cliente = clienteDao.Read(dr.GetInt32(0));

                if (reserva_quarto.Cliente == null)
                {
                    reserva_quarto.NomeCliente = null;
                }
                else
                {
                    reserva_quarto.NomeCliente = reserva_quarto.Cliente.Nome;
                }

                QuartoDAO quartoDao = new QuartoDAO();
                reserva_quarto.Quarto = quartoDao.Read(dr.GetInt32(1));
                if (reserva_quarto.Quarto == null)
                {
                    reserva_quarto.PrecoQuarto = null;
                }
                else
                {
                    reserva_quarto.PrecoQuarto = Convert.ToString(reserva_quarto.Quarto.PrecoDia);
                }

                reserva_quarto.DataIniAluguel = DateTime.Parse(dr.GetString(2));
                reserva_quarto.DataEntrega = DateTime.Parse(dr.GetString(3));
                //reserva_quarto.PrecoTotal = dr.GetDecimal(4);
                reserva_quarto.PrecoTotal = decimal.Parse(dr.GetString(4));
                reserva_quarto.CodReserva = dr.GetInt32(5);
                reserva_quarto.CodFunc = dr.GetInt32(6);

                lista.Add(reserva_quarto); // Adiciona o objeto na lista de resultados
            }
            dr.Close();
            conexao.Close(); //  fechar a conexão
            return lista;
        }
    }
}
