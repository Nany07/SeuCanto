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
    public partial class frmQuartosDisp : Form
    {
        private int modo;
        private int idQuarto;

        public int IdQuarto { get => idQuarto; set => idQuarto = value; }
        public int Modo { get => modo; set => modo = value; }

        public frmQuartosDisp()
        {
            IdQuarto = 0;
            InitializeComponent();
        }

        public frmQuartosDisp(int modo)
        {
            this.modo = modo;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            IdQuarto = 0;
            this.Close();
        }

        private void frmQuartosDisp_Load(object sender, EventArgs e)
        {
            QuartoDAO QuartoDAO = new QuartoDAO();
            dataGridView1.DataSource = QuartoDAO.ListAll();
            if (this.modo == 4) //desabilitar o botão de consulta
                btnOK.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if((IdQuarto>0)&&(this.modo == 2))// Atualizar
            {
                QuartoDAO QuartoDAO = new QuartoDAO();
                frmCadastroQuarto janelaQuarto = new frmCadastroQuarto(2, IdQuarto);
                janelaQuarto.ShowDialog();
                txtNomeModelo.Text = ""; // limpando o campo do filtro
                dataGridView1.DataSource = QuartoDAO.ListAll();
            }
            else
                 if ((IdQuarto > 0) && (this.modo == 3))//Delete
                 {
                    QuartoDAO QuartoDAO = new QuartoDAO();
                    frmCadastroQuarto janelaQuarto = new frmCadastroQuarto(3, IdQuarto);
                    janelaQuarto.ShowDialog();
                    txtNomeModelo.Text = ""; // limpando o campo do filtro
                    dataGridView1.DataSource = QuartoDAO.ListAll();
                 }
                 else
                    if((IdQuarto > 0) && (this.modo == 1))//~Botão "Procurar" de Reserva de Quartos...
                    {
                         
                         this.Close();
                         
                    }     

                    else{
                              MessageBox.Show("Nenhum Quarto foi selecionado!\n Selecione com duplo click", "Aviso!",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         }
        }

        private void frmQuartosDisp_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            IdQuarto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnProcurar_Click(object sender, EventArgs e)  
        {
            QuartoDAO QuartoDAO = new QuartoDAO();

            if (txtNomeModelo.Text.Equals(""))
            {
                dataGridView1.DataSource = QuartoDAO.ListAll();
            }
            else
                dataGridView1.DataSource = QuartoDAO.FindByName(txtNomeModelo.Text.ToString());
        }

        private void txtNomeModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
