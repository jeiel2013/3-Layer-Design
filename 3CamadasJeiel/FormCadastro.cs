using System.Windows.Forms;
using _3CamadasJeiel.CODE.BLL;
using _3CamadasJeiel.CODE.DTO;

namespace _3CamadasJeiel
{
    public partial class FormCadastro : Form
    {
        bllCliente bllCliente = new bllCliente();
        dtoCliente dtoCliente = new dtoCliente();
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void limparComponentes()
        {
            textBoxId.Text = "";
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
        }

        public void carregarTabela()
        {
            gridView.DataSource = bllCliente.selecionar();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            dtoCliente.Nome = textBoxNome.Text;
            dtoCliente.Email = textBoxEmail.Text;
            bllCliente.inserir(dtoCliente);
            carregarTabela();
            limparComponentes();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            dtoCliente.Id_cliente = Convert.ToInt32(textBoxId.Text);
            dtoCliente.Nome = textBoxNome.Text;
            dtoCliente.Email = textBoxEmail.Text;
            bllCliente.alterar(dtoCliente);
            carregarTabela();
            limparComponentes();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            dtoCliente.Id_cliente = Convert.ToInt32(textBoxId.Text);
            bllCliente.excluir(dtoCliente);
            carregarTabela();
            limparComponentes();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            carregarTabela();
            limparComponentes();
        }
    }
}
