using System;
using System.Collections;
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
    public partial class frmCadastroCliente : Form
    {
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public frmCadastroCliente(int forma, int id)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente cliente = new Cliente();

            InitializeComponent();
            switch (forma)
            {
                case 1:
                    btnApagar.Visible = false;
                    btnAtualizar.Visible = false;
                    this.Text = "Cadastro Cliente";
                    break;// cadastrar

                case 2:                   
                    btnApagar.Visible = false;
                    btnSalvarCadastroCliente.Visible = false;
                    this.Text = "Atualizar Cliente";

                    if (id!=0)
                    {
                        IdCliente = id;                        
                        cliente = clienteDao.Read(id);

                         // colocando os dados da interface
                         txtNomeCliente.Text = cliente.Nome;
                         txtCpfCliente.Text = cliente.Cpf;
                         cboEstadoCivilCliente.Text = cliente.EstadoCivil;
                         cboEstadoCliente.Text = cliente.Uf;
                         txtCelularCliente.Text = cliente.Celular;
                         txtNomeLogradouro.Text =cliente.Logradouro;
                         txtNroLogradouro.Text= cliente.Nro_log;
                         textBox2.Text= cliente.Bairro;
                         txtCepCliente.Text  = cliente.Cep;

                    }
                    break;//atualizar
                case 3:
                    IdCliente = id;                    
                    cliente = clienteDao.Read(id);

                    btnAtualizar.Visible= false;
                    btnSalvarCadastroCliente.Visible = false;
                    this.Text = "Deletar Cliente";
                    txtNomeCliente.Enabled = false;                    
                    txtCelularCliente.Enabled = false;
                    txtCpfCliente.Enabled = false;
                    txtCepCliente.Enabled = false;
                    txtNomeLogradouro.Enabled = false;
                    txtNroLogradouro.Enabled = false;                    
                    textBox2.Enabled = false;
                    cboEstadoCliente.Enabled= false;
                    cboEstadoCivilCliente.Enabled = false;
                    

                    // colocando os dados da interface
                    txtNomeCliente.Text = cliente.Nome;
                    txtCpfCliente.Text = cliente.Cpf;
                    txtCelularCliente.Text = cliente.Celular;
                    cboEstadoCliente.Text = cliente.Uf;
                    cboEstadoCivilCliente.Text = cliente.EstadoCivil;
                    txtNomeLogradouro.Text = cliente.Logradouro;
                    txtNroLogradouro.Text = cliente.Nro_log;
                    textBox2.Text = cliente.Bairro;
                    txtCepCliente.Text = cliente.Cep;
                    break;// Apagar                 
            }
            
        }

        private void cboEstadoCivilCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            //EstadoCivil();
            //PreencherComboLogradouro();
            //PreencherComboUf();


        }

        private void cboEspecificacaoLogradouro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtNomeLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstadoCivil()
        {
            Hashtable htEstadoCivil = new Hashtable();
            htEstadoCivil.Add("0", "[ Selecione ]");
            htEstadoCivil.Add("1", "Casado");
            htEstadoCivil.Add("2", "Solteiro");
            htEstadoCivil.Add("3", "Viuvo");
            htEstadoCivil.Add("4", "Outros");


            BindingSource bs = new BindingSource();
            bs.DataSource = htEstadoCivil;
            cboEstadoCivilCliente.DataSource = bs;
            cboEstadoCivilCliente.DisplayMember = "Value";
        }

        private void PreencherComboLogradouro()
        {
            Hashtable hrEspecificacaoLogradouro = new Hashtable();
            hrEspecificacaoLogradouro.Add("0", "[ Selecione ]");
            hrEspecificacaoLogradouro.Add("1", "AL");
            hrEspecificacaoLogradouro.Add("2", "AV");
            hrEspecificacaoLogradouro.Add("3", "EST");
            hrEspecificacaoLogradouro.Add("4", "EST-MUN");
            hrEspecificacaoLogradouro.Add("5", "TV");
            hrEspecificacaoLogradouro.Add("6", "R");
            hrEspecificacaoLogradouro.Add("7", "ROD");
            

            BindingSource bs = new BindingSource();
            bs.DataSource = hrEspecificacaoLogradouro;
            //cboEspecificacaoLogradouro.DataSource = bs;
         //   cboEspecificacaoLogradouro.DisplayMember = "Value";
        }

        private void lblLogradouroCliente_Click(object sender, EventArgs e)
        {

        }

         private void PreencherComboUf()
        {
            Hashtable hrUF = new Hashtable();
            hrUF.Add("0","[ Selecione ]");
            hrUF.Add("1","AC");
            hrUF.Add("2","AL");
            hrUF.Add("3","AP");
            hrUF.Add("4","AM");
            hrUF.Add("5","BA");
            hrUF.Add("6","CE");
            hrUF.Add("7","DF");
            hrUF.Add("8","ES");
            hrUF.Add("9","GO");
            hrUF.Add("10","MA");
            hrUF.Add("11","MT");
            hrUF.Add("12","MS");
            hrUF.Add("13","MG");
            hrUF.Add("14","PA");
            hrUF.Add("15","PB");
            hrUF.Add("16","PR");
            hrUF.Add("17","PE");
            hrUF.Add("18","PI");
            hrUF.Add("19","RJ");
            hrUF.Add("20","RN");
            hrUF.Add("21","RS");       
            hrUF.Add("22","RO");
            hrUF.Add("23","RR");
            hrUF.Add("24","SC");
            hrUF.Add("25","SP");
            hrUF.Add("26","SE");
            hrUF.Add("27","TO");

            BindingSource bs = new BindingSource();
            bs.DataSource = hrUF;
            cboEstadoCliente.DataSource = bs;
            cboEstadoCliente.DisplayMember = "Value";
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }

        private void cboEstadoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text.Equals("") || txtCpfCliente.Text.Equals("") || 
            txtCelularCliente.Text.Equals("")|| cboEstadoCliente.Text.Equals("") ||
            cboEstadoCivilCliente.Text.Equals("") ||txtNomeLogradouro.Text.Equals("") ||
            txtNroLogradouro.Text.Equals("") ||textBox2.Text.Equals("") ||
            txtCepCliente.Text.Equals(""))
                MessageBox.Show("Preencher todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                Cliente cliente = new Cliente();

                // pegando os dados da interface
                cliente.Nome = txtNomeCliente.Text;
                cliente.Cpf = txtCpfCliente.Text;
                cliente.EstadoCivil = cboEstadoCivilCliente.Text;
                cliente.Logradouro = txtNomeLogradouro.Text;
                cliente.Nro_log = txtNroLogradouro.Text;
                cliente.Bairro = textBox2.Text;
                cliente.Cep = txtCepCliente.Text;
                cliente.Uf = cboEstadoCliente.Text;
                cliente.Celular = txtCelularCliente.Text;

                // inserindo os dados do cliente
                clienteDAO.Create(cliente);
                MessageBox.Show("Cliente criado com sucesso!", "Cliente criado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = new Cliente();

            // Verifica se todas as entradas estão preenchidas 
            if (txtNomeCliente.Text.Equals("") || txtCpfCliente.Text.Equals("") ||
            txtCelularCliente.Text.Equals("") || cboEstadoCliente.Text.Equals("") ||
            cboEstadoCivilCliente.Text.Equals("") || txtNomeLogradouro.Text.Equals("") ||
            txtNroLogradouro.Text.Equals("") || textBox2.Text.Equals("") ||
            txtCepCliente.Text.Equals(""))
                MessageBox.Show("Preencher todos os campos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                // pegando os dados da interface
                cliente.Nome = txtNomeCliente.Text;
                cliente.Cpf = txtCpfCliente.Text;
                cliente.EstadoCivil = cboEstadoCivilCliente.Text;
                cliente.Logradouro = txtNomeLogradouro.Text;
                cliente.Nro_log = txtNroLogradouro.Text;
                cliente.Bairro = textBox2.Text;
                cliente.Cep = txtCepCliente.Text;
                cliente.Codigo = IdCliente;
                cliente.Uf = cboEstadoCliente.Text;
                cliente.Celular = txtCelularCliente.Text;


                // atualizar
                clienteDAO.Update(cliente);
                MessageBox.Show("Cliente atualizado com sucesso!", "Cliente atualizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            clienteDao.Delete(idCliente);
            MessageBox.Show("Cliente apagado com sucesso!", "Cliente apagado",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
