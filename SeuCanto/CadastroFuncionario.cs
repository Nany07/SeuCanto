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
    public partial class frmCadastroFuncionario : Form
    {
        private int idFuncionario;
        private bool cadastroPrimeiroFuncionario;
        FuncionarioDAO funcionarioDao = new FuncionarioDAO();
        Funcionario funcionario = new Funcionario();

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public bool CadastroPrimeiroFuncionario { get => cadastroPrimeiroFuncionario; set => cadastroPrimeiroFuncionario = value; }

        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }
        

        public frmCadastroFuncionario(int modo, int id, bool cadastroPrimeiroFuncionario)
        {
            this.cadastroPrimeiroFuncionario = cadastroPrimeiroFuncionario; // verifica se é o primeiro funcionário
            InitializeComponent();
            idFuncionario = id;      // atribuindo a propriedade da classe

            switch (modo)
            {

                case 1:                    
                    btnApagar.Visible = false;
                    btnAtualizar.Visible = false;
                    this.Text = "Cadastro Funcionário";
                    break;// cadastrar
                case 2:
                    
                    // Desabilitando as funcionalidades da tela, que não fazem parte da atualizar 
                    btnApagar.Visible = false;
                    btnSalvarCadastroFuncionario.Visible = false;
                    this.Text = "Atualizar Funcionário";
                   
                    if (idFuncionario>0)
                    {
                        funcionario = funcionarioDao.Read(idFuncionario); // Recuperar dados do cliente com codigo=id                       


                        // Preenchendo os campos da tela com os dados do cliente                     
                        txtNomeFuncionario.Text = funcionario.Nome;
                        txtNomeLogradouro.Text = funcionario.Logradouro;
                        txtNroLogradouro.Text = funcionario.NroLog;
                        mtbTelefone.Text = funcionario.Telefone;
                        maskedTextBox1.Text = funcionario.DtNasc.ToString("dd/MM/yyyy");
                        textBox2.Text = funcionario.Bairro;
                        cboEstadoCliente.Text = funcionario.Uf;
                        txtDataAdmissao.Text = funcionario.AdmissaoData.ToString("dd/MM/yyyy");
                        txtCpfFuncionario.Text = funcionario.Cpf;
                        cmbFuncao.Text = funcionario.Funcao;
                        txtCepCliente.Text = funcionario.Cep;
                        mtbCelular.Text = funcionario.Celular;
                        cboEstadoCivilFuncionario.Text = funcionario.EstadoCivil;
                        txtPassword.Text = funcionario.Password;
                    }
                    

                    break;//atualizar
                case 3:
                    funcionario = funcionarioDao.Read(idFuncionario); // Recuperar dados do cliente com codigo=id                       


                    // Preenchendo os campos da tela com os dados do cliente                     
                    txtNomeFuncionario.Text = funcionario.Nome;
                    txtNomeLogradouro.Text = funcionario.Logradouro;
                    txtNroLogradouro.Text = funcionario.NroLog;
                    mtbTelefone.Text = funcionario.Telefone;
                    maskedTextBox1.Text = funcionario.DtNasc.ToString("dd/MM/yyyy");
                    textBox2.Text = funcionario.Bairro;
                    cboEstadoCliente.Text = funcionario.Uf;
                    txtDataAdmissao.Text = funcionario.AdmissaoData.ToString("dd/MM/yyyy");
                    txtCpfFuncionario.Text = funcionario.Cpf;
                    cmbFuncao.Text = funcionario.Funcao;                    
                    mtbCelular.Text = funcionario.Celular;
                    cboEstadoCivilFuncionario.Text = funcionario.EstadoCivil;
                    txtPassword.Text = funcionario.Password;
                    txtCepCliente.Text = funcionario.Cep;

                    btnAtualizar.Visible = false;
                    btnSalvarCadastroFuncionario.Visible = false;
                    this.Text = "Deletar Funcionário";
                    txtNomeFuncionario.Enabled = false;
                    txtNomeLogradouro.Enabled = false;
                    txtNroLogradouro.Enabled = false;
                    mtbTelefone.Enabled = false;
                    txtNomeLogradouro.Enabled = false;
                    txtNroLogradouro.Enabled = false;
                    maskedTextBox1.Enabled = false;
                    textBox2.Enabled = false;
                    cboEstadoCliente.Enabled = false;
                    maskedTextBox1.Enabled = false;
                    cboEstadoCliente.Enabled = false;
                    txtCpfFuncionario.Enabled = false;
                    txtDataAdmissao.Enabled = false;
                    maskedTextBox1.Enabled = false;
                    mtbCelular.Enabled = false;
                    cboEstadoCivilFuncionario.Enabled = false;
                    cmbFuncao.Enabled = false;
                    txtPassword.Enabled = false;
                    txtCepCliente.Enabled = false;


                    break;// Apagar                 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void cboEspecificacaoLogradouro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBairroCliente_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCpfFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            if (this.cadastroPrimeiroFuncionario == true)
            {
                this.Close();
                Application.Exit();
            }
            this.Close();
        }

        private void cboEstadoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (txtNomeFuncionario.Text.Equals("") || txtCpfFuncionario.Text.Equals("") || 
            txtNomeLogradouro.Text.Equals("") ||txtNroLogradouro.Text.Equals("") ||
            mtbTelefone.Text.Equals("") ||maskedTextBox1.Text.Equals("") ||
            textBox2.Text.Equals("") ||cboEstadoCliente.Text.Equals("") ||
            maskedTextBox1.Text.Equals("") || cmbFuncao.Text.Equals("") ||
            maskedTextBox1.Text.Equals("") ||mtbCelular.Text.Equals("") ||
            cboEstadoCivilFuncionario.Text.Equals("")|| txtPassword.Text.Equals(""))
                MessageBox.Show("Preencher todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {                              
                // pegando os dados da interface
                funcionario.Nome = txtNomeFuncionario.Text;
                funcionario.Cpf = txtCpfFuncionario.Text;
                funcionario.EstadoCivil = cboEstadoCivilFuncionario.Text;
                funcionario.Logradouro = txtNomeLogradouro.Text;
                funcionario.NroLog = txtNroLogradouro.Text;
                funcionario.Bairro = textBox2.Text;
                funcionario.Cep = txtCepCliente.Text;
                funcionario.Telefone = mtbTelefone.Text;                
                funcionario.AdmissaoData = DateTime.Parse(txtDataAdmissao.Text);
                funcionario.Celular = mtbCelular.Text;
                funcionario.DtNasc = DateTime.Parse(maskedTextBox1.Text);
                funcionario.Uf = cboEstadoCliente.Text;
                funcionario.Password = txtPassword.Text;

                // verificando se é o primeiro funcionário 
                if (this.cadastroPrimeiroFuncionario == true)
                {
                    funcionario.Funcao = "Administrador";// O primeiro funcionário é sempre administrador
                }
               else
                    funcionario.Funcao = cmbFuncao.Text;





                // inserindo os dados do funcionario 
                funcionarioDao.Create(funcionario);
                MessageBox.Show("Funcionario criado com sucesso!", "Funcionario criado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // verificar se é o primeiro funcinário a ser cadastrado 
                if (this.cadastroPrimeiroFuncionario == true)
                {
                    this.Close();
                    Application.Exit();
                }
                    this.Close();
            }
        }

        private void lblCpfFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void lblDadosFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (txtNomeFuncionario.Text.Equals("") || txtCpfFuncionario.Text.Equals("") ||
            txtNomeLogradouro.Text.Equals("") || txtNroLogradouro.Text.Equals("") ||
            mtbTelefone.Text.Equals("") || maskedTextBox1.Text.Equals("") ||
            textBox2.Text.Equals("") || cboEstadoCliente.Text.Equals("") ||
            maskedTextBox1.Text.Equals("") || cmbFuncao.Text.Equals("") ||
            maskedTextBox1.Text.Equals("") || mtbCelular.Text.Equals("") ||
            cboEstadoCivilFuncionario.Text.Equals("") || txtPassword.Text.Equals(""))
                MessageBox.Show("Preencher todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Atualizando os dados 
                funcionario.Nome = txtNomeFuncionario.Text;
                funcionario.Logradouro = txtNomeLogradouro.Text;
                funcionario.NroLog = txtNroLogradouro.Text;
                funcionario.Telefone = mtbTelefone.Text;
                funcionario.DtNasc = DateTime.Parse(maskedTextBox1.Text);
                funcionario.Bairro = textBox2.Text;
                funcionario.Uf = cboEstadoCliente.Text;
                funcionario.AdmissaoData = DateTime.Parse(txtDataAdmissao.Text);
                funcionario.Cpf = txtCpfFuncionario.Text;
                funcionario.Funcao = cmbFuncao.Text;
                funcionario.Cep = txtCepCliente.Text;
                funcionario.Celular = mtbCelular.Text;
                funcionario.EstadoCivil = cboEstadoCivilFuncionario.Text;
                funcionario.Codigo = IdFuncionario;
                funcionario.Password = txtPassword.Text;

                funcionarioDao.Update(funcionario);
                MessageBox.Show("Funcionário atualizado com sucesso!", "Funcionário atualizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            funcionarioDao.Delete(idFuncionario);
            MessageBox.Show("Funcionário apagado com sucesso!", "Funcionário Apagado",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
