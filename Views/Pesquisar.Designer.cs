namespace TestCartys.Views
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            btnPesq = new Button();
            label1 = new Label();
            txtPesq = new TextBox();
            dgvUsuarios = new DataGridView();
            btnLimpar = new Button();
            btnRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnPesq
            // 
            btnPesq.Location = new Point(21, 88);
            btnPesq.Name = "btnPesq";
            btnPesq.Size = new Size(94, 29);
            btnPesq.TabIndex = 0;
            btnPesq.Text = "Pesquisar";
            btnPesq.UseVisualStyleBackColor = true;
            btnPesq.Click += btnPesq_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite sua busca";
            // 
            // txtPesq
            // 
            txtPesq.Location = new Point(21, 45);
            txtPesq.Name = "txtPesq";
            txtPesq.Size = new Size(125, 27);
            txtPesq.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(640, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(794, 337);
            dgvUsuarios.TabIndex = 4;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(21, 168);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(644, 361);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(131, 29);
            btnRelatorio.TabIndex = 6;
            btnRelatorio.Text = "Gerar Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // Pesquisar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1446, 611);
            Controls.Add(btnRelatorio);
            Controls.Add(btnLimpar);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtPesq);
            Controls.Add(label1);
            Controls.Add(btnPesq);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pesquisar";
            Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesq;
        private Label label1;
        private TextBox txtPesq;
        private DataGridView dgvUsuarios;
        private Button btnLimpar;
        private Button btnRelatorio;
    }
}