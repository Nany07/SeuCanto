namespace SeuCanto
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnQuarto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConsultarQuarto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsularCliente = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbGerenciarReservas = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbGerenciarReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reservas ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.btnFuncionario);
            this.groupBox1.Controls.Add(this.btnQuarto);
            this.groupBox1.Location = new System.Drawing.Point(492, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciar ";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(26, 94);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(153, 23);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(28, 35);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(153, 23);
            this.btnFuncionario.TabIndex = 5;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnQuarto
            // 
            this.btnQuarto.Location = new System.Drawing.Point(28, 149);
            this.btnQuarto.Name = "btnQuarto";
            this.btnQuarto.Size = new System.Drawing.Size(153, 23);
            this.btnQuarto.TabIndex = 4;
            this.btnQuarto.Text = "Quartos";
            this.btnQuarto.UseVisualStyleBackColor = true;
            this.btnQuarto.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(677, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 28);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConsultarQuarto);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnConsularCliente);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(112, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 191);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnConsultarQuarto
            // 
            this.btnConsultarQuarto.Location = new System.Drawing.Point(28, 114);
            this.btnConsultarQuarto.Name = "btnConsultarQuarto";
            this.btnConsultarQuarto.Size = new System.Drawing.Size(153, 23);
            this.btnConsultarQuarto.TabIndex = 19;
            this.btnConsultarQuarto.Text = "Quartos";
            this.btnConsultarQuarto.UseVisualStyleBackColor = true;
            this.btnConsultarQuarto.Click += new System.EventHandler(this.btnConsultarQuarto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Relório de Reservas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsularCliente
            // 
            this.btnConsularCliente.Location = new System.Drawing.Point(28, 74);
            this.btnConsularCliente.Name = "btnConsularCliente";
            this.btnConsularCliente.Size = new System.Drawing.Size(153, 23);
            this.btnConsularCliente.TabIndex = 18;
            this.btnConsularCliente.Text = "Cliente";
            this.btnConsularCliente.UseVisualStyleBackColor = true;
            this.btnConsularCliente.Click += new System.EventHandler(this.btnConsularCliente_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Efetuar Reserva";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(328, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 53);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seu Canto";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(408, 29);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(151, 23);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Apagar Reserva";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(28, 66);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(153, 23);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar Reserva";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // gbGerenciarReservas
            // 
            this.gbGerenciarReservas.Controls.Add(this.button5);
            this.gbGerenciarReservas.Controls.Add(this.btnDeletar);
            this.gbGerenciarReservas.Controls.Add(this.btnAtualizar);
            this.gbGerenciarReservas.Location = new System.Drawing.Point(112, 44);
            this.gbGerenciarReservas.Name = "gbGerenciarReservas";
            this.gbGerenciarReservas.Size = new System.Drawing.Size(606, 99);
            this.gbGerenciarReservas.TabIndex = 20;
            this.gbGerenciarReservas.TabStop = false;
            this.gbGerenciarReservas.Text = "Gerenciar Reservas";
            this.gbGerenciarReservas.Enter += new System.EventHandler(this.gbGerenciarReservas_Enter);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(829, 446);
            this.Controls.Add(this.gbGerenciarReservas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Menu ";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbGerenciarReservas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnQuarto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gbGerenciarReservas;
        private System.Windows.Forms.Button btnConsultarQuarto;
        private System.Windows.Forms.Button btnConsularCliente;
    }
}