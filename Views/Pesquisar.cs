using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCartys.Data.Entities;
using TestCartys.Domain.InterFaces.Services;

namespace TestCartys.Views
{
    public partial class Pesquisar : Form
    {
        private readonly IServiceUser _userService;
        private BindingSource _bindingSource = new BindingSource();

        public Pesquisar(IServiceUser userService)
        {
            InitializeComponent();
            _userService = userService;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AllowUserToAddRows = false;


            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Idade",
                HeaderText = "Idade"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ativo",
                HeaderText = "Ativo?"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataNascimento",
                HeaderText = "Data Nascimento"
            });

            dgvUsuarios.DataSource = _bindingSource;
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            string nome = txtPesq.Text.Trim();

            var usuarios = _userService.BuscarPorNome(nome);
            _bindingSource.DataSource = usuarios;

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtPesq.Clear();
            _bindingSource.DataSource = null;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha para gerar o relatório.");
                return;
            }

            var usuarioSelecionado = dgvUsuarios.CurrentRow.DataBoundItem as Users;

            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Erro ao recuperar os dados do usuário.");
                return;
            }

            string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Relatorio_{usuarioSelecionado.Nome}.pdf");

            using (var writer = new PdfWriter(caminho))
            using (var pdf = new PdfDocument(writer))
            using (var doc = new Document(pdf))
            {
                doc.Add(new Paragraph("Relatório de Pessoa")
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetFontSize(18)
                    .SetFont(PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD)));

                doc.Add(new Paragraph($"Nome: {usuarioSelecionado.Nome}"));
                doc.Add(new Paragraph($"Email: {usuarioSelecionado.Email}"));
                doc.Add(new Paragraph($"Idade: {usuarioSelecionado.Idade}"));
                doc.Add(new Paragraph($"Data de Nascimento: {usuarioSelecionado.DataNascimento:dd/MM/yyyy}"));
                doc.Add(new Paragraph($"Ativo: {(usuarioSelecionado.Ativo ? "Sim" : "Não")}"));
            }

            MessageBox.Show("Relatório gerado com sucesso!");
        }
    }
}
