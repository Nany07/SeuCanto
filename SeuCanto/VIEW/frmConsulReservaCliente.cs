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
    public partial class frmConsulReservaCliente : Form
    {
        private int idReserva;

        public frmConsulReservaCliente()
        {
            idReserva = 0;
            InitializeComponent();

        }
        public frmConsulReservaCliente(int modo)
        {
            InitializeComponent();

            switch (modo)
            {
                case 1: button2.Visible = false;
                        btnApagar.Visible = false;
                        break;
                case 2:
                        button2.Visible = true;
                        btnApagar.Visible = false;
                        break;
                case 3:
                        button2.Visible = false;
                        btnApagar.Visible = true;
                        break; 
            }
            
        }

        

        private void frmConsulReservaCliente_Load(object sender, EventArgs e)
        {
           Reserva_QuartoDAO reserva_quartoDao  = new Reserva_QuartoDAO();
            dataGridView1.DataSource = reserva_quartoDao .ListAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void picSalvarConsu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Reserva_QuartoDAO reserva_quartoDao  = new Reserva_QuartoDAO();
            if (idReserva > 0)
            {
            frmReservarQuarto frmResQuarto = new frmReservarQuarto(idReserva);
            frmResQuarto.ShowDialog();
            txtNome.Text = ""; // limpando o campo do filtro
            dataGridView1.DataSource = reserva_quartoDao .ListAll();
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhuma reserva!!\n Selecione com duplo click", "Aviso!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Reserva_QuartoDAO reserva_quartoDao  = new Reserva_QuartoDAO();
            if(idReserva>0)
            {
                reserva_quartoDao .Delete(idReserva);
                MessageBox.Show("Registro apagado com sucesso!", "Aviso!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = ""; // limpando o campo do filtro
                dataGridView1.DataSource = reserva_quartoDao .ListAll();
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhuma reserva!!\n Selecione com duplo click", "Aviso!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idReserva= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserva_QuartoDAO reserva_quartoDao  = new Reserva_QuartoDAO();

            if (txtNome.Text.Equals(""))
            {
                dataGridView1.DataSource = reserva_quartoDao .ListAll();
            }
            else
                dataGridView1.DataSource = reserva_quartoDao .FindByName(txtNome.Text.ToString());
        }
    }
}
