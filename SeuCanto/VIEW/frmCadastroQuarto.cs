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
    public partial class frmCadastroQuarto : Form
    {
        private int idQuarto;
        QuartoDAO quartoDAO = new QuartoDAO();
        Quarto quarto = new Quarto();

        public frmCadastroQuarto()
        {
            InitializeComponent();
        }

        public frmCadastroQuarto(int modo,int id)
        {
            InitializeComponent();
            idQuarto = id;
            
            switch (modo)
            {
                case 1:                    
                    btnDeletar.Visible = false;
                    btnAtualizar.Visible = false;
                    textBox1.Visible = false;
                    label2.Visible = false;

                    this.Text = "Cadastro Quarto";
                    break;// cadastrar
                case 2:
                    btnDeletar.Visible = false;
                    btnSalvar.Visible = false;
                    this.Text = "Atualizar Quarto";

                    // preencher os campos da tela 
                    quarto = quartoDAO.Read(idQuarto);
                   
                    textBox1.Text = quarto.Nro_quarto.ToString();
                    textBox1.Enabled = false;
                    comboBox2.Text = quarto.Tipo;                    
                    numericUpDown1.Text = quarto.QtdePessoas.ToString();
                    btnPrecoHora.Text = quarto.PrecoDia.ToString();
                    break;//atualizar
                case 3:
                    btnAtualizar.Visible = false;
                    btnSalvar.Visible = false;
                    this.Text = "Deletar Quarto";                  
                    comboBox2.Enabled = false;
                    textBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    btnPrecoHora.Enabled = false;

                    // preencher os campos da tela 
                    quarto = quartoDAO.Read(idQuarto);

                    textBox1.Text = quarto.Nro_quarto.ToString();
                    comboBox2.Text = quarto.Tipo;
                    numericUpDown1.Text = quarto.QtdePessoas.ToString();
                    btnPrecoHora.Text = quarto.PrecoDia.ToString();
                    break;// Apagar           

            }

        }
   

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                // if...         
                // pegando os dados da interface 
                quarto.Tipo = comboBox2.Text;               
                quarto.QtdePessoas= int.Parse(numericUpDown1.Text);
                quarto.PrecoDia = Convert.ToDecimal(btnPrecoHora.Text.ToString());
                
                 // inserindo os dados do quarto
                 quartoDAO.Create(quarto);
                MessageBox.Show("Quarto criado com sucesso!", "Quarto criado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCadastroQuarto_Load(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
                // pegando os dados da interface 
                quarto.Tipo = comboBox2.Text;
                quarto.QtdePessoas = int.Parse(numericUpDown1.Text);
                quarto.PrecoDia = decimal.Parse(btnPrecoHora.Text);


                // inserindo os dados do quarto
                quartoDAO.Update(quarto);
                MessageBox.Show("Quarto atualizado com sucesso!", "Quarto atualizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
           
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            quartoDAO.Delete(idQuarto);
            MessageBox.Show("Quarto apagado com sucesso!", "Deletar Quarto",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnPrecoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!(char.IsDigit(e.KeyChar)) && !(char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
            */

            /*if ((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)) || (char.IsSymbol(e.KeyChar)))
                e.Handled = true;
            */
            string caracteresPermitidos = "0123456789,";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }
    }
}
