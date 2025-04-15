namespace TestCartys
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtIdade = new TextBox();
            dtNascimento = new DateTimePicker();
            button1 = new Button();
            chkAtivo = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnPesq = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(53, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(53, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(53, 222);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(125, 27);
            txtIdade.TabIndex = 2;
            // 
            // dtNascimento
            // 
            dtNascimento.Location = new Point(53, 314);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(250, 27);
            dtNascimento.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(53, 368);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(54, 270);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(73, 24);
            chkAtivo.TabIndex = 5;
            chkAtivo.Text = "Ativo?";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 199);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 7;
            label2.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 119);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // btnPesq
            // 
            btnPesq.Location = new Point(1313, 67);
            btnPesq.Name = "btnPesq";
            btnPesq.Size = new Size(94, 29);
            btnPesq.TabIndex = 9;
            btnPesq.Text = "Pesquisar";
            btnPesq.UseVisualStyleBackColor = true;
            btnPesq.Click += button2_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1433, 662);
            Controls.Add(btnPesq);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkAtivo);
            Controls.Add(button1);
            Controls.Add(dtNascimento);
            Controls.Add(txtIdade);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtIdade;
        private DateTimePicker dtNascimento;
        private Button button1;
        private CheckBox chkAtivo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnPesq;
    }
}
