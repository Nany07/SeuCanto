using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeuCanto
{
    public partial class frmGerenciarFuncionario : Form
    {
        public frmGerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario janelaFuncionario = new frmCadastroFuncionario(1,0,false);
            janelaFuncionario.ShowDialog(); 
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmProcurarFuncionario frmProcFunc = new frmProcurarFuncionario(2);
            frmProcFunc.ShowDialog();

            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmProcurarFuncionario frmProcFunc = new frmProcurarFuncionario(3);
            frmProcFunc.ShowDialog();            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGerenciarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
