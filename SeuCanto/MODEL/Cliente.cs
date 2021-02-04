using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCanto
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string cpf;
        private string estadoCivil;
        private string logradouro;
        private string nro_log;
        private string bairro;
        private string cep;
        private string uf;
        private string celular;


        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Nro_log { get => nro_log; set => nro_log = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}
