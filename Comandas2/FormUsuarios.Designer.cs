namespace Comandas2
{
    partial class FormUsuarios
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
            EntrarUsuario = new ReaLTaiizor.Controls.CyberButton();
            SairUsuario = new ReaLTaiizor.Controls.CyberButton();
            Login = new Label();
            txtSenha = new ReaLTaiizor.Controls.CyberTextBox();
            txtEmail = new ReaLTaiizor.Controls.CyberTextBox();
            txtNome = new ReaLTaiizor.Controls.CyberTextBox();
            Nome = new Label();
            BotaoVoltarUsuarios = new ReaLTaiizor.Controls.CyberButton();
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
            groupBox1 = new GroupBox();
            senhaUsuario = new Label();
            idUsuario = new Label();
            txtId = new ReaLTaiizor.Controls.CyberTextBox();
            btnSalvarUsuario = new ReaLTaiizor.Controls.CyberButton();
            dgvUsuarios = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // EntrarUsuario
            // 
            EntrarUsuario.Alpha = 20;
            EntrarUsuario.BackColor = Color.Transparent;
            EntrarUsuario.Background = true;
            EntrarUsuario.Background_WidthPen = 4F;
            EntrarUsuario.BackgroundPen = true;
            EntrarUsuario.ColorBackground = Color.FromArgb(192, 255, 192);
            EntrarUsuario.ColorBackground_1 = Color.Black;
            EntrarUsuario.ColorBackground_2 = Color.Black;
            EntrarUsuario.ColorBackground_Pen = Color.Black;
            EntrarUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            EntrarUsuario.ColorPen_1 = Color.FromArgb(37, 52, 68);
            EntrarUsuario.ColorPen_2 = Color.FromArgb(41, 63, 86);
            EntrarUsuario.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            EntrarUsuario.Effect_1 = true;
            EntrarUsuario.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            EntrarUsuario.Effect_1_Transparency = 25;
            EntrarUsuario.Effect_2 = true;
            EntrarUsuario.Effect_2_ColorBackground = Color.White;
            EntrarUsuario.Effect_2_Transparency = 20;
            EntrarUsuario.Font = new Font("Arial", 11F);
            EntrarUsuario.ForeColor = Color.Black;
            EntrarUsuario.Lighting = false;
            EntrarUsuario.LinearGradient_Background = false;
            EntrarUsuario.LinearGradientPen = false;
            EntrarUsuario.Location = new Point(230, 562);
            EntrarUsuario.Name = "EntrarUsuario";
            EntrarUsuario.PenWidth = 15;
            EntrarUsuario.Rounding = true;
            EntrarUsuario.RoundingInt = 70;
            EntrarUsuario.Size = new Size(181, 83);
            EntrarUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            EntrarUsuario.TabIndex = 0;
            EntrarUsuario.Tag = "Cyber";
            EntrarUsuario.TextButton = "Entrar";
            EntrarUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            EntrarUsuario.Timer_Effect_1 = 5;
            EntrarUsuario.Timer_RGB = 300;
            // 
            // SairUsuario
            // 
            SairUsuario.Alpha = 20;
            SairUsuario.BackColor = Color.Transparent;
            SairUsuario.Background = true;
            SairUsuario.Background_WidthPen = 4F;
            SairUsuario.BackgroundPen = true;
            SairUsuario.ColorBackground = Color.FromArgb(255, 192, 192);
            SairUsuario.ColorBackground_1 = Color.Black;
            SairUsuario.ColorBackground_2 = Color.Black;
            SairUsuario.ColorBackground_Pen = Color.Black;
            SairUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            SairUsuario.ColorPen_1 = Color.FromArgb(37, 52, 68);
            SairUsuario.ColorPen_2 = Color.FromArgb(41, 63, 86);
            SairUsuario.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            SairUsuario.Effect_1 = true;
            SairUsuario.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            SairUsuario.Effect_1_Transparency = 25;
            SairUsuario.Effect_2 = true;
            SairUsuario.Effect_2_ColorBackground = Color.White;
            SairUsuario.Effect_2_Transparency = 20;
            SairUsuario.Font = new Font("Arial", 11F);
            SairUsuario.ForeColor = Color.Black;
            SairUsuario.Lighting = false;
            SairUsuario.LinearGradient_Background = false;
            SairUsuario.LinearGradientPen = false;
            SairUsuario.Location = new Point(459, 562);
            SairUsuario.Name = "SairUsuario";
            SairUsuario.PenWidth = 15;
            SairUsuario.Rounding = true;
            SairUsuario.RoundingInt = 70;
            SairUsuario.Size = new Size(181, 83);
            SairUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            SairUsuario.TabIndex = 1;
            SairUsuario.Tag = "Cyber";
            SairUsuario.TextButton = "Sair";
            SairUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            SairUsuario.Timer_Effect_1 = 5;
            SairUsuario.Timer_RGB = 300;
            SairUsuario.Click += SairUsuario_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(578, 25);
            Login.Name = "Login";
            Login.Size = new Size(62, 24);
            Login.TabIndex = 4;
            Login.Text = "Email :";
            // 
            // txtSenha
            // 
            txtSenha.Alpha = 20;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.Background_WidthPen = 3F;
            txtSenha.BackgroundPen = true;
            txtSenha.ColorBackground = Color.White;
            txtSenha.ColorBackground_Pen = Color.Black;
            txtSenha.ColorLighting = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtSenha.Font = new Font("Arial", 13F);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Lighting = false;
            txtSenha.LinearGradientPen = false;
            txtSenha.Location = new Point(429, 144);
            txtSenha.Name = "txtSenha";
            txtSenha.PenWidth = 15;
            txtSenha.RGB = false;
            txtSenha.Rounding = true;
            txtSenha.RoundingInt = 60;
            txtSenha.Size = new Size(374, 53);
            txtSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtSenha.TabIndex = 3;
            txtSenha.Tag = "Cyber";
            txtSenha.TextButton = "Senha";
            txtSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtSenha.Timer_RGB = 300;
            // 
            // txtEmail
            // 
            txtEmail.Alpha = 20;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Background_WidthPen = 3F;
            txtEmail.BackgroundPen = true;
            txtEmail.ColorBackground = Color.White;
            txtEmail.ColorBackground_Pen = Color.Black;
            txtEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtEmail.Font = new Font("Arial", 13F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Lighting = false;
            txtEmail.LinearGradientPen = false;
            txtEmail.Location = new Point(432, 52);
            txtEmail.Name = "txtEmail";
            txtEmail.PenWidth = 15;
            txtEmail.RGB = false;
            txtEmail.Rounding = true;
            txtEmail.RoundingInt = 60;
            txtEmail.Size = new Size(374, 53);
            txtEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtEmail.TabIndex = 2;
            txtEmail.Tag = "Cyber";
            txtEmail.TextButton = "Email";
            txtEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtEmail.Timer_RGB = 300;
            // 
            // txtNome
            // 
            txtNome.Alpha = 20;
            txtNome.BackColor = Color.Transparent;
            txtNome.Background_WidthPen = 3F;
            txtNome.BackgroundPen = true;
            txtNome.ColorBackground = Color.White;
            txtNome.ColorBackground_Pen = Color.Black;
            txtNome.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNome.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNome.Font = new Font("Arial", 13F);
            txtNome.ForeColor = Color.Black;
            txtNome.Lighting = false;
            txtNome.LinearGradientPen = false;
            txtNome.Location = new Point(23, 144);
            txtNome.Name = "txtNome";
            txtNome.PenWidth = 15;
            txtNome.RGB = false;
            txtNome.Rounding = true;
            txtNome.RoundingInt = 60;
            txtNome.Size = new Size(374, 53);
            txtNome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNome.TabIndex = 7;
            txtNome.Tag = "Cyber";
            txtNome.TextButton = "Nome";
            txtNome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNome.Timer_RGB = 300;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nome.Location = new Point(165, 117);
            Nome.Name = "Nome";
            Nome.Size = new Size(65, 24);
            Nome.TabIndex = 8;
            Nome.Text = "Nome :";
            // 
            // BotaoVoltarUsuarios
            // 
            BotaoVoltarUsuarios.Alpha = 20;
            BotaoVoltarUsuarios.BackColor = Color.Transparent;
            BotaoVoltarUsuarios.Background = true;
            BotaoVoltarUsuarios.Background_WidthPen = 4F;
            BotaoVoltarUsuarios.BackgroundPen = true;
            BotaoVoltarUsuarios.ColorBackground = Color.FromArgb(192, 255, 255);
            BotaoVoltarUsuarios.ColorBackground_1 = Color.Black;
            BotaoVoltarUsuarios.ColorBackground_2 = Color.Black;
            BotaoVoltarUsuarios.ColorBackground_Pen = Color.Black;
            BotaoVoltarUsuarios.ColorLighting = Color.FromArgb(29, 200, 238);
            BotaoVoltarUsuarios.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BotaoVoltarUsuarios.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BotaoVoltarUsuarios.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BotaoVoltarUsuarios.Effect_1 = true;
            BotaoVoltarUsuarios.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BotaoVoltarUsuarios.Effect_1_Transparency = 25;
            BotaoVoltarUsuarios.Effect_2 = true;
            BotaoVoltarUsuarios.Effect_2_ColorBackground = Color.White;
            BotaoVoltarUsuarios.Effect_2_Transparency = 20;
            BotaoVoltarUsuarios.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoVoltarUsuarios.ForeColor = Color.Black;
            BotaoVoltarUsuarios.Lighting = false;
            BotaoVoltarUsuarios.LinearGradient_Background = false;
            BotaoVoltarUsuarios.LinearGradientPen = false;
            BotaoVoltarUsuarios.Location = new Point(48, 25);
            BotaoVoltarUsuarios.Name = "BotaoVoltarUsuarios";
            BotaoVoltarUsuarios.PenWidth = 15;
            BotaoVoltarUsuarios.Rounding = true;
            BotaoVoltarUsuarios.RoundingInt = 70;
            BotaoVoltarUsuarios.Size = new Size(70, 62);
            BotaoVoltarUsuarios.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BotaoVoltarUsuarios.TabIndex = 10;
            BotaoVoltarUsuarios.Tag = "Cyber";
            BotaoVoltarUsuarios.TextButton = "↶";
            BotaoVoltarUsuarios.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BotaoVoltarUsuarios.Timer_Effect_1 = 5;
            BotaoVoltarUsuarios.Timer_RGB = 300;
            BotaoVoltarUsuarios.Click += BotaoVoltarUsuarios_Click;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background = true;
            btnNovo.Background_WidthPen = 4F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.FromArgb(192, 192, 255);
            btnNovo.ColorBackground_1 = Color.Black;
            btnNovo.ColorBackground_2 = Color.Black;
            btnNovo.ColorBackground_Pen = Color.Black;
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Effect_1 = true;
            btnNovo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovo.Effect_1_Transparency = 25;
            btnNovo.Effect_2 = true;
            btnNovo.Effect_2_ColorBackground = Color.White;
            btnNovo.Effect_2_Transparency = 20;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.Black;
            btnNovo.Lighting = false;
            btnNovo.LinearGradient_Background = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(589, 25);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 70;
            btnNovo.Size = new Size(123, 62);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 11;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "Novo";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_Effect_1 = 5;
            btnNovo.Timer_RGB = 300;
            btnNovo.Click += btnNovo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(senhaUsuario);
            groupBox1.Controls.Add(idUsuario);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(Nome);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(Login);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(48, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 237);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // senhaUsuario
            // 
            senhaUsuario.AutoSize = true;
            senhaUsuario.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            senhaUsuario.Location = new Point(571, 110);
            senhaUsuario.Name = "senhaUsuario";
            senhaUsuario.Size = new Size(69, 24);
            senhaUsuario.TabIndex = 11;
            senhaUsuario.Text = "Senha :";
            // 
            // idUsuario
            // 
            idUsuario.AutoSize = true;
            idUsuario.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idUsuario.Location = new Point(182, 25);
            idUsuario.Name = "idUsuario";
            idUsuario.Size = new Size(31, 24);
            idUsuario.TabIndex = 10;
            idUsuario.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Alpha = 20;
            txtId.BackColor = Color.Transparent;
            txtId.Background_WidthPen = 3F;
            txtId.BackgroundPen = true;
            txtId.ColorBackground = Color.White;
            txtId.ColorBackground_Pen = Color.Black;
            txtId.ColorLighting = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtId.Font = new Font("Arial", 13F);
            txtId.ForeColor = Color.Black;
            txtId.Lighting = false;
            txtId.LinearGradientPen = false;
            txtId.Location = new Point(23, 52);
            txtId.Name = "txtId";
            txtId.PenWidth = 15;
            txtId.RGB = false;
            txtId.Rounding = true;
            txtId.RoundingInt = 60;
            txtId.Size = new Size(374, 53);
            txtId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtId.TabIndex = 9;
            txtId.Tag = "Cyber";
            txtId.TextButton = "Id";
            txtId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtId.Timer_RGB = 300;
            // 
            // btnSalvarUsuario
            // 
            btnSalvarUsuario.Alpha = 20;
            btnSalvarUsuario.BackColor = Color.Transparent;
            btnSalvarUsuario.Background = true;
            btnSalvarUsuario.Background_WidthPen = 4F;
            btnSalvarUsuario.BackgroundPen = true;
            btnSalvarUsuario.ColorBackground = Color.FromArgb(192, 192, 255);
            btnSalvarUsuario.ColorBackground_1 = Color.Black;
            btnSalvarUsuario.ColorBackground_2 = Color.Black;
            btnSalvarUsuario.ColorBackground_Pen = Color.Black;
            btnSalvarUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSalvarUsuario.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSalvarUsuario.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSalvarUsuario.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalvarUsuario.Effect_1 = true;
            btnSalvarUsuario.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSalvarUsuario.Effect_1_Transparency = 25;
            btnSalvarUsuario.Effect_2 = true;
            btnSalvarUsuario.Effect_2_ColorBackground = Color.White;
            btnSalvarUsuario.Effect_2_Transparency = 20;
            btnSalvarUsuario.Font = new Font("Arial", 11F);
            btnSalvarUsuario.ForeColor = Color.Black;
            btnSalvarUsuario.Lighting = false;
            btnSalvarUsuario.LinearGradient_Background = false;
            btnSalvarUsuario.LinearGradientPen = false;
            btnSalvarUsuario.Location = new Point(444, 25);
            btnSalvarUsuario.Name = "btnSalvarUsuario";
            btnSalvarUsuario.PenWidth = 15;
            btnSalvarUsuario.Rounding = true;
            btnSalvarUsuario.RoundingInt = 70;
            btnSalvarUsuario.Size = new Size(123, 62);
            btnSalvarUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalvarUsuario.TabIndex = 13;
            btnSalvarUsuario.Tag = "Cyber";
            btnSalvarUsuario.TextButton = "Salvar";
            btnSalvarUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalvarUsuario.Timer_Effect_1 = 5;
            btnSalvarUsuario.Timer_RGB = 300;
            btnSalvarUsuario.Click += btnSalvarUsuario_Click_1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(48, 336);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(828, 220);
            dgvUsuarios.TabIndex = 14;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 657);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnSalvarUsuario);
            Controls.Add(groupBox1);
            Controls.Add(btnNovo);
            Controls.Add(BotaoVoltarUsuarios);
            Controls.Add(SairUsuario);
            Controls.Add(EntrarUsuario);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton EntrarUsuario;
        private ReaLTaiizor.Controls.CyberButton SairUsuario;
        private Label Login;
        private ReaLTaiizor.Controls.CyberTextBox txtSenha;
        private ReaLTaiizor.Controls.CyberTextBox txtEmail;
        private ReaLTaiizor.Controls.CyberTextBox txtNome;
        private Label Nome;
        private ReaLTaiizor.Controls.CyberButton cadastrar;
        private ReaLTaiizor.Controls.CyberButton BotaoVoltarUsuarios;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.CyberButton btnSalvarUsuario;
        private Label senhaUsuario;
        private Label idUsuario;
        private ReaLTaiizor.Controls.CyberTextBox txtId;
        private DataGridView dgvUsuarios;
    }
}