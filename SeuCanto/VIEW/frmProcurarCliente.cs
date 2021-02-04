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
    public partial class frmProcurarCliente : Form
    {
        private int modo;
        private int idCliente;
        int count;// mudar lógica depois
        bool consulta;// refatorar depois
        

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int Modo { get => modo; set => modo = value; }

        // Atribuindo Zero para o InCliente


        public frmProcurarCliente()
        {
            InitializeComponent();
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente cliente= new Cliente();
            this.consulta = false;

        }

        public frmProcurarCliente( bool consulta)// refatorar depois
        {
            
            InitializeComponent();
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente cliente = new Cliente();
            this.consulta = consulta;

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            count = 1;

        }

        private void frmProcurarCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            dataGridView1.DataSource = clienteDao.ListAll();
            count = 0; // carregando o contador de seleção do dataGride, refatorar depois
            if(consulta==true) //desabilitar o botão de consulta
                btnOK.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idCliente = 0;// não retorna nenhum valor
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            // envia id do cliente como parametro 
            if (( count!=0)&&(Modo ==1))
            {
                frmCadastroCliente janelaCliente = new frmCadastroCliente(2, idCliente);
                janelaCliente.ShowDialog();
                txtNome.Text = ""; // limpando o campo do filtro
                //recarregando o dataGridView1
                dataGridView1.DataSource = clienteDao.ListAll();
                count = 0; // carregando o contador de seleção do dataGride
            }
            else 
                if ((count != 0) && (Modo == 3))
                {
                    frmCadastroCliente janelaCliente = new frmCadastroCliente(3, idCliente);          
                    janelaCliente.ShowDialog();
                    txtNome.Text = ""; // limpando o campo do filtro
                    //recarregando o dataGridView1
                    dataGridView1.DataSource = clienteDao.ListAll();
            }
                    
            else 
                if ((count != 0) && (Modo == 2))
                {
                this.Close();

                }
            else // não devolve valor de nenhum id
            {
               MessageBox.Show("Nenhum cliente foi selecionado!\n Selecione com um click", "Aviso!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            count = 1;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            if (txtNome.Text.Equals(""))
            {
                dataGridView1.DataSource = clienteDao.ListAll();
            }
            else
                dataGridView1.DataSource = clienteDao.FindByName(txtNome.Text.ToString());
        
        }
    }
}
