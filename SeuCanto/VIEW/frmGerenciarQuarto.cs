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
    public partial class frmGerenciarQuarto : Form
    {
        public frmGerenciarQuarto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroQuarto janelaQuarto = new frmCadastroQuarto(1,0);
            janelaQuarto.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmQuartosDisp frmQroDis = new frmQuartosDisp(2);
            frmQroDis.ShowDialog();
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmQuartosDisp frmQroDis = new frmQuartosDisp(3);
            frmQroDis.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGerenciarQuarto_Load(object sender, EventArgs e)
        {

        }
    }
}
