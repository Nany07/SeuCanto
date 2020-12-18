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
    public partial class frmReservarQuarto : Form
    {
        private Cliente cliente;
        private Quarto   quarto;
        protected decimal precoDia;
        private int idReserva;
        private int modo;
               

        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Quarto Quarto { get => quarto; set => quarto = value; }

        public frmReservarQuarto ()
        {
            InitializeComponent();
            precoDia = 0;
            btnAtualizar.Visible = false;
            
        }
        public frmReservarQuarto(int id)
        {
            InitializeComponent();
            precoDia = 0;
            idReserva = id;
            btnSalvar.Visible = false;
            modo = 2;

            // ler dados da reserva 
            Reserva_QuartoDAO reserva_quartoDao = new Reserva_QuartoDAO();
            Reserva_Quarto reserva_quarto = new Reserva_Quarto();
            reserva_quarto = reserva_quartoDao.Read(idReserva);


            //carregar as data
            dateTimePicker1.Value = reserva_quarto.DataIniAluguel;
            dateTimePicker2.Value = reserva_quarto.DataEntrega; 


            // carregando dados do quarto 
            if (reserva_quarto.Quarto != null)
             {
                 //quarto = quartoDao.Read(jnBarDisp.IdQuarto);
                 textBox5.Text = reserva_quarto.Quarto.Tipo.ToString();
                 textBox2.Text = reserva_quarto.Quarto.Nro_quarto.ToString();
                 textBox3.Text = reserva_quarto.Quarto.PrecoDia.ToString();
                 precoDia = reserva_quarto.Quarto.PrecoDia; // jogando na variavel com o valor do preco/dia do quarto
                 
             }
             // carregar dados do Cliente
            if (reserva_quarto.Cliente != null)
            {            
                // Preenchendo os dados do cliente
                textBox4.Text = reserva_quarto.Cliente.Nome.ToString();
                textBox1.Text = reserva_quarto.Cliente.Codigo.ToString();                
            }
            // atualizando dados de preco total
            precoDia = reserva_quarto.Quarto.PrecoDia;
            //textBox6.Text = totalPreco().ToString();
        }

        private decimal totalPreco()
        {
            TimeSpan totalDias = (DateTime.Parse(dateTimePicker2.Text).Date - DateTime.Parse(dateTimePicker1.Text).Date);
            return Convert.ToDecimal(totalDias.TotalDays)*precoDia;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int ID = Session.Instance.UserID; // recupera id do usuário

            if (textBox4.Text.Equals("")|| textBox5.Text.Equals(""))
                MessageBox.Show("Todos os campos tem que estar preenchidos!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
               if(totalPreco() <= 0)
                {
                MessageBox.Show("Preço total inválido!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    {
                        Reserva_QuartoDAO reserva_quartoDao = new Reserva_QuartoDAO();
                        Reserva_Quarto reserva_quarto = new Reserva_Quarto();
                        ClienteDAO clienteDAO = new ClienteDAO();
                        QuartoDAO quartoDAO = new QuartoDAO();
                

                        // pegando os dados da interface
                        reserva_quarto.DataEntrega = DateTime.Parse(dateTimePicker2.Text);
                        reserva_quarto.DataIniAluguel = DateTime.Parse(dateTimePicker1.Text);                
                        reserva_quarto.PrecoTotal = totalPreco();               
                        reserva_quarto.Cliente = clienteDAO.Read(int.Parse(textBox1.Text));// testar
                        reserva_quarto.Quarto = quartoDAO.Read(int.Parse(textBox2.Text));// testar
                
                        // atribuir dados a interface 
                        precoDia = quarto.PrecoDia;
                        textBox6.Text= totalPreco().ToString ();

                        // registrar codigo de usuário 
                        reserva_quarto.CodFunc = ID;


                        // inserindo os dados do funcionario 
                        reserva_quartoDao.Create(reserva_quarto);
                        MessageBox.Show("Reserva criada com sucesso!", "Reserva criado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // desenvolver...            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmReservarQuarto_Load(object sender, EventArgs e)
        {
            textBox4.Enabled= false;
            textBox1.Enabled= false;
            textBox2.Enabled= false;
            textBox5.Enabled= false;
            textBox1.Enabled= false;
            textBox3.Enabled= false;
            if(modo == 2)
                textBox6.Text = totalPreco().ToString();// para atualizar reserva            
            else
                textBox6.Text = "0.0"; // efetuar reserva
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProCliente_Click(object sender, EventArgs e)
        {
            frmProcurarCliente jnProcCliente = new frmProcurarCliente();
            ClienteDAO clienteDao = new ClienteDAO();
            
            //Selecionar cliente 
            jnProcCliente.Modo = 2; // acessar a janela no modo 2
            jnProcCliente.ShowDialog();

            if (jnProcCliente.IdCliente > 0)
            {
                // Pegando dados do cliente 
                Cliente = clienteDao.Read(jnProcCliente.IdCliente);
                // Preenchendo os dados do cliente
                textBox4.Text = Cliente.Nome.ToString();
                textBox1.Text = Cliente.Codigo.ToString();
            }
            
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            textBox6.Text = totalPreco().ToString();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            textBox6.Text = totalPreco().ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int ID = Session.Instance.UserID; // recupera id do usuário

            if (textBox4.Text.Equals("") || textBox5.Text.Equals(""))
                MessageBox.Show("Todos os campos tem que estar preenchidos!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
               if (totalPreco() <= 0)
            {
                MessageBox.Show("Preço total inválido!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Reserva_QuartoDAO reserva_quartoDao = new Reserva_QuartoDAO();
                Reserva_Quarto reserva_quarto = new Reserva_Quarto();
                ClienteDAO clienteDAO = new ClienteDAO();
                QuartoDAO quartoDAO = new QuartoDAO();


                // pegando os dados da interface
                reserva_quarto.CodReserva = idReserva;
                reserva_quarto.DataEntrega = DateTime.Parse(dateTimePicker2.Text);
                reserva_quarto.DataIniAluguel = DateTime.Parse(dateTimePicker1.Text);
                reserva_quarto.PrecoTotal = totalPreco();
                reserva_quarto.Cliente = clienteDAO.Read(int.Parse(textBox1.Text));// testar
                reserva_quarto.Quarto = quartoDAO.Read(int.Parse(textBox2.Text));// testar

                // registrar codigo de usuário 
                reserva_quarto.CodFunc = ID;


                // inserindo os dados do funcionario 
                reserva_quartoDao.Update(reserva_quarto);
                MessageBox.Show("Reserva atualizada com sucesso!", "Reserva atualizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
