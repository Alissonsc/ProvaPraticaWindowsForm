namespace ProvaPratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Cria um novo usuário com os dados do formulário
            Usuario novoUsuario = new Usuario()
            {
                //Preencha com os valores que vem do formulário

                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };
            // Chama o método para salvar no banco de dados
            bool sucesso = Database.SalvarUsuario(novoUsuario);

            //Implemente um messagebox para caso dê sucesso ou caso não dê sucesso

            if (sucesso)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário! Telefone já existe ou ocorreu um problema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
