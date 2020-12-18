using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SeuCanto
{
    class FuncionarioDAO
    {
        public void Create (Funcionario funcionario)
        {

            Database SLar = Database.GetInstance();

            string qry = string.Format("INSERT INTO funcionario(cpf,dtnasc,nome,estado_civil,logradouro,nro_log,bairro,cep,uf,celular,telefone,admissao_data,funcao,password) " +
                                        "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                                        funcionario.Cpf, funcionario.DtNasc.ToString("yyyy-MM-dd"), funcionario.Nome, funcionario.EstadoCivil, funcionario.Logradouro,
                                        funcionario.NroLog, funcionario.Bairro, funcionario.Cep, funcionario.Uf, funcionario.Celular, 
                                        funcionario.Telefone, funcionario.AdmissaoData.ToString("yyyy-MM-dd"), funcionario.Funcao,funcionario.Password);
            SLar.ExecuteSQL(qry);

        }

        public Funcionario Read(int codigo)
        {

            Funcionario funcionario = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT codigo,cpf,dtnasc, nome,estado_civil," +
                        "logradouro,nro_log,bairro,cep,uf,celular,telefone,admissao_data,funcao,password " +
                        "FROM funcionario   " +
                        "WHERE codigo ="+ codigo;
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read()) // A busca por chave primária só retorna um objeto
            {
                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                // refatorar depois
                funcionario = new Funcionario();
                funcionario.Codigo = dr.GetInt32(0);
                funcionario.Nome = dr.GetString(3);
                funcionario.Cpf = dr.GetString(1);
                funcionario.EstadoCivil = dr.GetString(4);
                funcionario.Logradouro = dr.GetString(5);
                funcionario.NroLog = dr.GetString(6);
                funcionario.Bairro = dr.GetString(7);
                funcionario.Cep = dr.GetString(8);
                funcionario.Uf = dr.GetString(9);
                funcionario.Telefone = dr.GetString(11);
                funcionario.Funcao = dr.GetString(13);
                funcionario.Celular = dr.GetString(10);
                funcionario.AdmissaoData = dr.GetDateTime(12);
                funcionario.DtNasc = dr.GetDateTime(2);
                funcionario.Password = dr.GetString(14);
            }
            dr.Close();
            conexao.Close();
            return funcionario;

        }

        public void Update(Funcionario funcionario)
        {

            Database SLar = Database.GetInstance();

            string qry = string.Format("UPDATE funcionario SET cpf='{0}',dtnasc='{1}', nome='{2}'" +
                        ",estado_civil='{3}',logradouro='{4}',nro_log='{5}',bairro='{6}',cep='{7}'," +
                        "uf='{8}',celular='{9}',telefone='{10}',admissao_data='{11}',funcao='{12}', password='{13}'" +
                        "WHERE codigo = '{14}'", funcionario.Cpf, funcionario.DtNasc.ToString("yyyy-MM-dd"), 
                        funcionario.Nome, funcionario.EstadoCivil, funcionario.Logradouro,
                        funcionario.NroLog, funcionario.Bairro, funcionario.Cep, funcionario.Uf,
                        funcionario.Celular, funcionario.Telefone, funcionario.AdmissaoData.ToString("yyyy-MM-dd"),
                        funcionario.Funcao,funcionario.Password, funcionario.Codigo);

            SLar.ExecuteSQL(qry);
        }
        public void Delete(int codigo)
        {

            Database SLar = Database.GetInstance();
            string qry = "DELETE FROM funcionario WHERE codigo =" + codigo;
            SLar.ExecuteSQL(qry);

        }

        public List<Funcionario> ListAll()
        {

            List<Funcionario> lista = new List<Funcionario>();
            Funcionario funcionario;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry = "SELECT codigo,cpf,dtnasc, nome,estado_civil,logradouro,nro_log," +
                         "bairro,cep,uf,celular,telefone,admissao_data,funcao,password FROM funcionario";
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {

                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                // refatorar depois
                funcionario = new Funcionario();
                funcionario.Codigo = dr.GetInt32(0);
                funcionario.Nome = dr.GetString(3);
                funcionario.Cpf = dr.GetString(1);
                funcionario.EstadoCivil = dr.GetString(4);
                funcionario.Logradouro = dr.GetString(5);
                funcionario.NroLog = dr.GetString(6);
                funcionario.Bairro = dr.GetString(7);
                funcionario.Cep = dr.GetString(8);
                funcionario.Uf = dr.GetString(9);
                funcionario.Telefone = dr.GetString(11);
                funcionario.Funcao = dr.GetString(13);
                funcionario.Celular = dr.GetString(10);
                funcionario.AdmissaoData = DateTime.Parse(dr.GetString(12));
                funcionario.DtNasc = DateTime.Parse(dr.GetString(2));
                funcionario.Password = dr.GetString(14);
                lista.Add(funcionario);

            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); //  fechar a conexão

            return lista;   
        }

        public List<Funcionario> FindByName(string nome) {


            List<Funcionario> lista = new List<Funcionario>();
            Funcionario funcionario;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();
            string qry;

            if (nome != "") // verifica se a consulta não é vazia
                qry = string.Format("SELECT  codigo,cpf,dtnasc, nome,estado_civil,logradouro,nro_log," +
                         "bairro,cep,uf,celular,telefone,admissao_data,funcao,password " +
                         "FROM funcionario WHERE nome LIKE '%{0}%' ;", nome);
            else
                qry = "SELECT codigo,cpf,dtnasc, nome,estado_civil,logradouro,nro_log," +
                         "bairro,cep,uf,celular,telefone,admissao_data,funcao,password FROM funcionario";


            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {

                // Cria um objeto cliente para transferir os dados do banco para a aplicação (DTO)
                // refatorar depois
                funcionario = new Funcionario();
                funcionario.Codigo = dr.GetInt32(0);
                funcionario.Nome = dr.GetString(3);
                funcionario.Cpf = dr.GetString(1);
                funcionario.EstadoCivil = dr.GetString(4);
                funcionario.Logradouro = dr.GetString(5);
                funcionario.NroLog = dr.GetString(6);
                funcionario.Bairro = dr.GetString(7);
                funcionario.Cep = dr.GetString(8);
                funcionario.Uf = dr.GetString(9);
                funcionario.Telefone = dr.GetString(11);
                funcionario.Funcao = dr.GetString(13);
                funcionario.Celular = dr.GetString(10);
                funcionario.AdmissaoData = DateTime.Parse(dr.GetString(12));
                funcionario.DtNasc = DateTime.Parse(dr.GetString(2));
                funcionario.Password = dr.GetString(14);
                lista.Add(funcionario);

            }

            dr.Close(); // para nao dar erro de database locked
            conexao.Close(); //  fechar a conexão

            return lista;
        }
    }
}
