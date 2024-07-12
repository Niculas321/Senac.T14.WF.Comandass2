using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas2
{
    public partial class FormUsuarios : Form
    {
        private bool ehNovo;

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void SairUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotaoVoltarUsuarios_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void atualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }
        }

        private void criarUsuario()
        {
            // acessar o banco e depois criar e depois salvar as alteraçoes
            using (var banco = new AppDbContext())
            {
                // criar um usuário
                var novoUsuario = new Usuario();
                // atribuir as propriedades do usuario
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                // salvar alteraçoes (INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
        }

        private void btnSalvarUsuario_Click_1(object sender, EventArgs e)
        {
            if (ehNovo)
                criarUsuario();
            else
                atualizarUsuario();
        }
    }
}
