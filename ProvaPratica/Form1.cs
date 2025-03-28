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
            // Cria um novo usu�rio com os dados do formul�rio
            Usuario novoUsuario = new Usuario()
            {
                //Preencha com os valores que vem do formul�rio

                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };
            // Chama o m�todo para salvar no banco de dados
            bool sucesso = Database.SalvarUsuario(novoUsuario);

            //Implemente um messagebox para caso d� sucesso ou caso n�o d� sucesso

            if (sucesso)
            {
                MessageBox.Show("Usu�rio cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usu�rio! Telefone j� existe ou ocorreu um problema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
