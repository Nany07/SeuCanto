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
    public partial class frmProcurarFuncionario : Form
    {
        protected int modo;
        protected int idFuncionario;
        FuncionarioDAO funcionarioDao = new FuncionarioDAO();

        public frmProcurarFuncionario()
        {
            InitializeComponent();
        }
        public frmProcurarFuncionario(int modo_tela)
        {
            InitializeComponent();
            modo=modo_tela;
            idFuncionario = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProcurarFuncionario_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = funcionarioDao.ListAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int ID = Session.Instance.UserID; // pegando id do usuário do programa

            if ((idFuncionario > 0)&&(modo==2)) // atualizar 
            {
                frmCadastroFuncionario janelaFuncionario = new frmCadastroFuncionario(modo, idFuncionario, false);
                txtNome.Text = ""; // limpando o campo do filtro
                janelaFuncionario.ShowDialog();
                //recarregando o dataGridView1
                dataGridView1.DataSource = funcionarioDao.ListAll();
            }
            else
                if ((idFuncionario > 0) && (modo == 3)&&(idFuncionario!=ID)) // apagar registro
                {
                    frmCadastroFuncionario janelaFuncionario = new frmCadastroFuncionario(modo, idFuncionario, false);
                    txtNome.Text = ""; // limpando o campo do filtro
                    janelaFuncionario.ShowDialog();
                    //recarregando o dataGridView1
                    dataGridView1.DataSource = funcionarioDao.ListAll();
                }
                else
                    if ((idFuncionario > 0) && (modo == 3) && (idFuncionario == ID))
                    {
                        MessageBox.Show("Esse registro não pode ser apagada pelo usuário atual!", "Aviso!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                         MessageBox.Show("Não foi selecionado nenhum Funcionário!!\n Selecione com duplo click", "Aviso!!!",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            

        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();

            if (txtNome.Text.Equals(""))
            {
                dataGridView1.DataSource = funcionarioDao.ListAll();
            }
            else
                dataGridView1.DataSource = funcionarioDao.FindByName(txtNome.Text.ToString());
        }
    }
}
