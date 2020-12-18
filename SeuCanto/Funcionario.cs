using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCanto
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private DateTime dtNasc;
        private string cpf;
        private string estadoCivil;
        private string logradouro;
        private string nroLog;
        private string bairro;
        private string cep;
        private string uf;
        private string celular;
        private string telefone;
        private DateTime admissaoData;
        private string funcao;
        private string password;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DtNasc { get => dtNasc; set => dtNasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string NroLog { get => nroLog; set => nroLog = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime AdmissaoData { get => admissaoData; set => admissaoData = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public string Password { get => password; set => password = value; }
    }
}
