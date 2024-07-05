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
            criarUsuario();
        }
        private void criarUsuario()
        {
            // acessar o banco e depois criar e depois salvar as alteraçoes
            using(var banco = new AppDbContext())
            {
                // criar um usuário
                var novoUsuario = new Usuario();
                // atribuir as propriedades do usuario
                novoUsuario.Nome = "Niculas";
                novoUsuario.Email = "teste@teste.com";
                novoUsuario.Senha = "teste123";
                // salvar alteraçoes (INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
        }
    }
}
