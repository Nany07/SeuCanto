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
    public partial class Gerenciar : Form// cliente
    {
        public Gerenciar()
        {
            InitializeComponent();
        }

        private void Gerenciar_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente janelaCliente = new frmCadastroCliente(1,0);
            janelaCliente.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmProcurarCliente janelaListarClientes = new frmProcurarCliente();
            janelaListarClientes.Modo = 1;
            janelaListarClientes.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmProcurarCliente janelaListarClientes = new frmProcurarCliente();
            janelaListarClientes.Modo = 3; // Abrir no modo que abre a tela apagar cadastro dp cliente posteriormente
            janelaListarClientes.ShowDialog();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
