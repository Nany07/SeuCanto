using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCanto
{
    class Login
    {
        private string nome;
        private string senha;
        private int codigoFun;

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int CodigoFun { get => codigoFun; set => codigoFun = value; }
    }
}
