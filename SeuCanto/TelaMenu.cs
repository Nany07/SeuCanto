using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;   

namespace SeuCanto
{
    public partial class frmMenu : Form
    {
        private int idFuncionario;
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(int modo,int idFuncionario) // modo 1 administrador, modo 2 atendente...
        {   
            InitializeComponent();
            this.idFuncionario = idFuncionario;
            if (modo == 2)
            {
                btnFuncionario.Enabled = false;
                button1.Enabled = false;
            }

                

        }


        private void button4_Click(object sender, EventArgs e)
        {

            frmCadastroCliente frmCc = new frmCadastroCliente();
            frmCc.ShowDialog();
            
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmGerenciarFuncionario janelaFuncionario = new frmGerenciarFuncionario();
            janelaFuncionario.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Gerenciar gerenciarCliente = new Gerenciar();
            gerenciarCliente.ShowDialog();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            frmGerenciarQuarto frmBar = new frmGerenciarQuarto();
            frmBar.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLog = new frmLogin();
            frmLog.ShowDialog();
        }

        private void btnQuartosDisp_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsulReservaCliente frmConReserCli = new frmConsulReservaCliente(1);
            frmConReserCli.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReservarQuarto reservarQuarto = new frmReservarQuarto();
            reservarQuarto.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*frmGerarRelatorio gerarRelatorio = new frmGerarRelatorio();
            gerarRelatorio.ShowDialog();
            */
            frmRelatorioReserva frmRelReserva = new frmRelatorioReserva();
            frmRelReserva.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmConsulReservaCliente frmConReserCli = new frmConsulReservaCliente(2);
            frmConReserCli.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmConsulReservaCliente frmConReserCli = new frmConsulReservaCliente(3);
            frmConReserCli.ShowDialog();
        }

        private void btnConsularCliente_Click(object sender, EventArgs e)
        {
            frmProcurarCliente frmProCli = new frmProcurarCliente(true);// desabilita 
            frmProCli.ShowDialog();
        }

        private void btnConsultarQuarto_Click(object sender, EventArgs e)
        {
            frmQuartosDisp frmBarDisp = new frmQuartosDisp(4);// não exibe o botão 
            frmBarDisp.ShowDialog();

        }

        private void gbGerenciarReservas_Enter(object sender, EventArgs e)
        {

        }
    }
}
