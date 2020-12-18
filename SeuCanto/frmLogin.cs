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
using System.IO;

namespace SeuCanto
{
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e) // refatorar depois
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            Funcionario funcionario = null;
            funcionario = funcionarioDAO.Read(Convert.ToInt32(txtLogin.Text)); // try to convert (fatorar depois)

            if (funcionario!=null)// verificando se o nro do usuário existe
            {
                if ((funcionario.Password.Equals(txtSenha.Text)) && (funcionario.Codigo.Equals(Convert.ToInt32(txtLogin.Text))) && (funcionario.Funcao.Equals("Administrador")))
                {
                    frmMenu frmM = new frmMenu(1, funcionario.Codigo);// Entra no menu no modo administrador
                    this.Visible = false; // escondendo a tela de login

                    Session.Instance.UserID = funcionario.Codigo; // pegando o id do usuário do programa

                    // Limpando os campos
                    txtSenha.Text = "";
                    txtLogin.Text = "";

                    frmM.Show();                    
                }
                else
                    if ((funcionario.Password.Equals(txtSenha.Text)) && (funcionario.Codigo.Equals(Convert.ToInt32(txtLogin.Text))) && (funcionario.Funcao.Equals("Atendente")))
                    {
                        frmMenu frmM = new frmMenu(2, funcionario.Codigo); //Entra no menu no modo atendente

                        this.Visible = false; // escondendo a tela de login

                         Session.Instance.UserID = funcionario.Codigo; // pegando o id do usuário do programa     

                        // Limpando os campos
                        txtSenha.Text = "";
                        txtLogin.Text = "";

                        frmM.Show();

                    }
                    else
                        {
                            MessageBox.Show("Login ou senha inválida! (Dica: codigo, password de funcionário)" +
                            " ", "Aviso", MessageBoxButtons.OK);

                            // Limpando os campos
                            txtSenha.Text = "";
                            txtLogin.Text = "";
                        }

            }
            else
            {
                MessageBox.Show("Login ou senha inválida! (Dica: codigo, password de funcionário)" +
                " ", "Aviso", MessageBoxButtons.OK);

                // Limpando os campos
                txtSenha.Text = "";
                txtLogin.Text = "";
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          

        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*string caracterEspecial = "";
            if (!((char.IsDigit(e.KeyChar))||(char.IsZ)))
            {
                e.Handled = true;

            }*/
            if ((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)) || (char.IsSymbol (e.KeyChar)) || (char.IsPunctuation(e.KeyChar)))
                e.Handled = true;
        }
    }
}
