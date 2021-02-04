using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SeuCanto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // caso o banco não tenha sido criado, a aplicação entra direto no cadastrar funcionário
            if (!File.Exists("Slar.db"))
            {
                Application.Run(new frmCadastroFuncionario(1, 0, true)); // chama a tela no modo cadastrar
            }
            else
                Application.Run(new frmLogin());
        }
    }
}
