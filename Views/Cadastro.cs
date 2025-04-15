using TestCartys.Data.Entities;
using TestCartys.Domain.InterFaces.Services;
using TestCartys.Views;

namespace TestCartys
{
    public partial class Cadastro : Form
    {
        private readonly IServiceUser _userService;

        public Cadastro(IServiceUser userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nome e Email são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new Users
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Idade = idade,
                DataNascimento = dtNascimento.Value,
                Ativo = chkAtivo.Checked
            };

            var result = await _userService.CreateUser(user);

            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
                return;
            }

            MessageBox.Show("Usuário salvo com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formPesquisa = new Pesquisar(_userService);
            formPesquisa.Show();

        }
    }
}
