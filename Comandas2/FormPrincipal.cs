using Microsoft.EntityFrameworkCore;

namespace Comandas2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        // metodo (visibilidade = private, retorno = 

        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo AppDbContext
            // usar a variavel e acessar o contexto
            // executar a migração == F5
            using (var banco = new AppDbContext())
            {
                banco.Database.Migrate();
            }

        }

        private void Cardapio_Click(object sender, EventArgs e)
        {
            new Cardapio().ShowDialog();
        }

        private void Comanda_Click(object sender, EventArgs e)
        {
            new FormComanda().ShowDialog();
        }

        private void PedidoCozinha_Click(object sender, EventArgs e)
        {
            new FormPedidoCozinha().ShowDialog();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            new FormUsuarios().ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnSairPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
