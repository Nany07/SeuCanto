namespace SeuCanto
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cboEstadoCivilCliente = new System.Windows.Forms.ComboBox();
            this.lblLogradouroCliente = new System.Windows.Forms.Label();
            this.txtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.lblNroLogradouro = new System.Windows.Forms.Label();
            this.txtNroLogradouro = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCelularCliente = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnSalvarCadastroCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBairroCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboEstadoCliente = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCepCliente = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(73, 113);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome ";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(141, 110);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(432, 20);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCliente.Location = new System.Drawing.Point(84, 156);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(27, 13);
            this.lblCpfCliente.TabIndex = 2;
            this.lblCpfCliente.Text = "CPF";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(49, 205);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 4;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cboEstadoCivilCliente
            // 
            this.cboEstadoCivilCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstadoCivilCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivilCliente.FormattingEnabled = true;
            this.cboEstadoCivilCliente.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo (a)",
            "Outros"});
            this.cboEstadoCivilCliente.Location = new System.Drawing.Point(141, 202);
            this.cboEstadoCivilCliente.Name = "cboEstadoCivilCliente";
            this.cboEstadoCivilCliente.Size = new System.Drawing.Size(199, 21);
            this.cboEstadoCivilCliente.TabIndex = 5;
            this.cboEstadoCivilCliente.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCivilCliente_SelectedIndexChanged);
            // 
            // lblLogradouroCliente
            // 
            this.lblLogradouroCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogradouroCliente.AutoSize = true;
            this.lblLogradouroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouroCliente.Location = new System.Drawing.Point(54, 251);
            this.lblLogradouroCliente.Name = "lblLogradouroCliente";
            this.lblLogradouroCliente.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouroCliente.TabIndex = 7;
            this.lblLogradouroCliente.Text = "Logradouro";
            this.lblLogradouroCliente.Click += new System.EventHandler(this.lblLogradouroCliente_Click);
            // 
            // txtNomeLogradouro
            // 
            this.txtNomeLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLogradouro.Location = new System.Drawing.Point(141, 249);
            this.txtNomeLogradouro.Name = "txtNomeLogradouro";
            this.txtNomeLogradouro.Size = new System.Drawing.Size(351, 20);
            this.txtNomeLogradouro.TabIndex = 9;
            this.txtNomeLogradouro.TextChanged += new System.EventHandler(this.txtNomeLogradouro_TextChanged);
            // 
            // lblNroLogradouro
            // 
            this.lblNroLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNroLogradouro.AutoSize = true;
            this.lblNroLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLogradouro.Location = new System.Drawing.Point(508, 254);
            this.lblNroLogradouro.Name = "lblNroLogradouro";
            this.lblNroLogradouro.Size = new System.Drawing.Size(19, 13);
            this.lblNroLogradouro.TabIndex = 10;
            this.lblNroLogradouro.Text = "Nº";
            // 
            // txtNroLogradouro
            // 
            this.txtNroLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNroLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroLogradouro.Location = new System.Drawing.Point(533, 251);
            this.txtNroLogradouro.Name = "txtNroLogradouro";
            this.txtNroLogradouro.Size = new System.Drawing.Size(60, 20);
            this.txtNroLogradouro.TabIndex = 11;
            // 
            // lblCep
            // 
            this.lblCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(356, 299);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP";
            // 
            // lblUf
            // 
            this.lblUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(523, 295);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 15;
            this.lblUf.Text = "UF";
            // 
            // lblCelularCliente
            // 
            this.lblCelularCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCelularCliente.AutoSize = true;
            this.lblCelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularCliente.Location = new System.Drawing.Point(86, 336);
            this.lblCelularCliente.Name = "lblCelularCliente";
            this.lblCelularCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCelularCliente.TabIndex = 18;
            this.lblCelularCliente.Text = "Celular";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(607, 401);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(104, 28);
            this.btnVoltarMenu.TabIndex = 21;
            this.btnVoltarMenu.Text = "Cancelar";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnSalvarCadastroCliente
            // 
            this.btnSalvarCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroCliente.Location = new System.Drawing.Point(457, 401);
            this.btnSalvarCadastroCliente.Name = "btnSalvarCadastroCliente";
            this.btnSalvarCadastroCliente.Size = new System.Drawing.Size(116, 28);
            this.btnSalvarCadastroCliente.TabIndex = 20;
            this.btnSalvarCadastroCliente.Text = "Cadastrar";
            this.btnSalvarCadastroCliente.UseMnemonic = false;
            this.btnSalvarCadastroCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroCliente.Click += new System.EventHandler(this.btnSalvarCadastroCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.pictureBox1.Image = global::SeuCanto.Properties.Resources.dog_tag;
            this.pictureBox1.Location = new System.Drawing.Point(42, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblBairroCliente
            // 
            this.lblBairroCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBairroCliente.AutoSize = true;
            this.lblBairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCliente.Location = new System.Drawing.Point(81, 295);
            this.lblBairroCliente.Name = "lblBairroCliente";
            this.lblBairroCliente.Size = new System.Drawing.Size(34, 13);
            this.lblBairroCliente.TabIndex = 24;
            this.lblBairroCliente.Text = "Bairro";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(141, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 25;
            // 
            // cboEstadoCliente
            // 
            this.cboEstadoCliente.DropDownHeight = 70;
            this.cboEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCliente.FormattingEnabled = true;
            this.cboEstadoCliente.IntegralHeight = false;
            this.cboEstadoCliente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM ",
            "AP",
            "BA ",
            "CE ",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cboEstadoCliente.Location = new System.Drawing.Point(559, 294);
            this.cboEstadoCliente.Name = "cboEstadoCliente";
            this.cboEstadoCliente.Size = new System.Drawing.Size(91, 21);
            this.cboEstadoCliente.Sorted = true;
            this.cboEstadoCliente.TabIndex = 26;
            this.cboEstadoCliente.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCliente_SelectedIndexChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(448, 401);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 28);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(448, 401);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(125, 28);
            this.btnApagar.TabIndex = 29;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCliente.Location = new System.Drawing.Point(141, 151);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(91, 22);
            this.txtCpfCliente.TabIndex = 47;
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularCliente.Location = new System.Drawing.Point(141, 331);
            this.txtCelularCliente.Mask = "(00) 00000-0000";
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(104, 22);
            this.txtCelularCliente.TabIndex = 49;
            // 
            // txtCepCliente
            // 
            this.txtCepCliente.Location = new System.Drawing.Point(390, 296);
            this.txtCepCliente.Mask = "00000-000";
            this.txtCepCliente.Name = "txtCepCliente";
            this.txtCepCliente.Size = new System.Drawing.Size(68, 20);
            this.txtCepCliente.TabIndex = 50;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(829, 446);
            this.Controls.Add(this.txtCepCliente);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cboEstadoCliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblBairroCliente);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.btnSalvarCadastroCliente);
            this.Controls.Add(this.lblCelularCliente);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtNroLogradouro);
            this.Controls.Add(this.lblNroLogradouro);
            this.Controls.Add(this.txtNomeLogradouro);
            this.Controls.Add(this.lblLogradouroCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboEstadoCivilCliente);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cboEstadoCivilCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogradouroCliente;
        private System.Windows.Forms.TextBox txtNomeLogradouro;
        private System.Windows.Forms.Label lblNroLogradouro;
        private System.Windows.Forms.TextBox txtNroLogradouro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCelularCliente;
        private System.Windows.Forms.Button btnSalvarCadastroCliente;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Label lblBairroCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboEstadoCliente;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        private System.Windows.Forms.MaskedTextBox txtCelularCliente;
        private System.Windows.Forms.MaskedTextBox txtCepCliente;
    }
}