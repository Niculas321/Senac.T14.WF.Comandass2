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
            label1 = new Label();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            CampoEmail = new ReaLTaiizor.Controls.CyberTextBox();
            CheckBoxManterLogado = new ReaLTaiizor.Controls.CyberCheckBox();
            NomeUsuario = new ReaLTaiizor.Controls.CyberTextBox();
            Nome = new Label();
            BotaoVoltarUsuarios = new ReaLTaiizor.Controls.CyberButton();
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
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
            EntrarUsuario.Location = new Point(76, 507);
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
            SairUsuario.Location = new Point(354, 507);
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
            Login.Location = new Point(274, 237);
            Login.Name = "Login";
            Login.Size = new Size(62, 24);
            Login.TabIndex = 4;
            Login.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 359);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 5;
            label1.Text = "Senha :";
            // 
            // cyberTextBox2
            // 
            cyberTextBox2.Alpha = 20;
            cyberTextBox2.BackColor = Color.Transparent;
            cyberTextBox2.Background_WidthPen = 3F;
            cyberTextBox2.BackgroundPen = true;
            cyberTextBox2.ColorBackground = Color.White;
            cyberTextBox2.ColorBackground_Pen = Color.Black;
            cyberTextBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox2.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox2.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox2.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox2.Font = new Font("Arial", 13F);
            cyberTextBox2.ForeColor = Color.Black;
            cyberTextBox2.Lighting = false;
            cyberTextBox2.LinearGradientPen = false;
            cyberTextBox2.Location = new Point(121, 397);
            cyberTextBox2.Name = "cyberTextBox2";
            cyberTextBox2.PenWidth = 15;
            cyberTextBox2.RGB = false;
            cyberTextBox2.Rounding = true;
            cyberTextBox2.RoundingInt = 60;
            cyberTextBox2.Size = new Size(374, 53);
            cyberTextBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox2.TabIndex = 3;
            cyberTextBox2.Tag = "Cyber";
            cyberTextBox2.TextButton = "Senha";
            cyberTextBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox2.Timer_RGB = 300;
            // 
            // CampoEmail
            // 
            CampoEmail.Alpha = 20;
            CampoEmail.BackColor = Color.Transparent;
            CampoEmail.Background_WidthPen = 3F;
            CampoEmail.BackgroundPen = true;
            CampoEmail.ColorBackground = Color.White;
            CampoEmail.ColorBackground_Pen = Color.Black;
            CampoEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            CampoEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            CampoEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            CampoEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            CampoEmail.Font = new Font("Arial", 13F);
            CampoEmail.ForeColor = Color.Black;
            CampoEmail.Lighting = false;
            CampoEmail.LinearGradientPen = false;
            CampoEmail.Location = new Point(121, 285);
            CampoEmail.Name = "CampoEmail";
            CampoEmail.PenWidth = 15;
            CampoEmail.RGB = false;
            CampoEmail.Rounding = true;
            CampoEmail.RoundingInt = 60;
            CampoEmail.Size = new Size(374, 53);
            CampoEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            CampoEmail.TabIndex = 2;
            CampoEmail.Tag = "Cyber";
            CampoEmail.TextButton = "Email";
            CampoEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            CampoEmail.Timer_RGB = 300;
            // 
            // CheckBoxManterLogado
            // 
            CheckBoxManterLogado.BackColor = Color.Transparent;
            CheckBoxManterLogado.Background = true;
            CheckBoxManterLogado.Background_WidthPen = 2F;
            CheckBoxManterLogado.BackgroundPen = true;
            CheckBoxManterLogado.Checked = false;
            CheckBoxManterLogado.ColorBackground = Color.Transparent;
            CheckBoxManterLogado.ColorBackground_1 = Color.Black;
            CheckBoxManterLogado.ColorBackground_2 = Color.Black;
            CheckBoxManterLogado.ColorBackground_Pen = Color.Black;
            CheckBoxManterLogado.ColorChecked = Color.FromArgb(29, 200, 238);
            CheckBoxManterLogado.ColorPen_1 = Color.FromArgb(37, 52, 68);
            CheckBoxManterLogado.ColorPen_2 = Color.FromArgb(41, 63, 86);
            CheckBoxManterLogado.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            CheckBoxManterLogado.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            CheckBoxManterLogado.Effect_1_Transparency = 25;
            CheckBoxManterLogado.Effect_2 = true;
            CheckBoxManterLogado.Effect_2_ColorBackground = Color.White;
            CheckBoxManterLogado.Effect_2_Transparency = 15;
            CheckBoxManterLogado.Font = new Font("Arial", 11F);
            CheckBoxManterLogado.ForeColor = Color.Black;
            CheckBoxManterLogado.LinearGradient_Background = false;
            CheckBoxManterLogado.LinearGradientPen = false;
            CheckBoxManterLogado.Location = new Point(121, 456);
            CheckBoxManterLogado.Name = "CheckBoxManterLogado";
            CheckBoxManterLogado.RGB = false;
            CheckBoxManterLogado.Rounding = true;
            CheckBoxManterLogado.RoundingInt = 100;
            CheckBoxManterLogado.Size = new Size(273, 45);
            CheckBoxManterLogado.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            CheckBoxManterLogado.TabIndex = 6;
            CheckBoxManterLogado.Tag = "Cyber";
            CheckBoxManterLogado.TextButton = "Manter-me logado?";
            CheckBoxManterLogado.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            CheckBoxManterLogado.Timer_Effect_1 = 1;
            CheckBoxManterLogado.Timer_RGB = 300;
            // 
            // NomeUsuario
            // 
            NomeUsuario.Alpha = 20;
            NomeUsuario.BackColor = Color.Transparent;
            NomeUsuario.Background_WidthPen = 3F;
            NomeUsuario.BackgroundPen = true;
            NomeUsuario.ColorBackground = Color.White;
            NomeUsuario.ColorBackground_Pen = Color.Black;
            NomeUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            NomeUsuario.ColorPen_1 = Color.FromArgb(29, 200, 238);
            NomeUsuario.ColorPen_2 = Color.FromArgb(37, 52, 68);
            NomeUsuario.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            NomeUsuario.Font = new Font("Arial", 13F);
            NomeUsuario.ForeColor = Color.Black;
            NomeUsuario.Lighting = false;
            NomeUsuario.LinearGradientPen = false;
            NomeUsuario.Location = new Point(121, 169);
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.PenWidth = 15;
            NomeUsuario.RGB = false;
            NomeUsuario.Rounding = true;
            NomeUsuario.RoundingInt = 60;
            NomeUsuario.Size = new Size(374, 53);
            NomeUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            NomeUsuario.TabIndex = 7;
            NomeUsuario.Tag = "Cyber";
            NomeUsuario.TextButton = "Nome";
            NomeUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            NomeUsuario.Timer_RGB = 300;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nome.Location = new Point(274, 117);
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
            BotaoVoltarUsuarios.Location = new Point(34, 24);
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
            btnNovo.Location = new Point(450, 24);
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
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 657);
            Controls.Add(btnNovo);
            Controls.Add(BotaoVoltarUsuarios);
            Controls.Add(Nome);
            Controls.Add(NomeUsuario);
            Controls.Add(CheckBoxManterLogado);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(cyberTextBox2);
            Controls.Add(CampoEmail);
            Controls.Add(SairUsuario);
            Controls.Add(EntrarUsuario);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton EntrarUsuario;
        private ReaLTaiizor.Controls.CyberButton SairUsuario;
        private Label Login;
        private Label label1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
        private ReaLTaiizor.Controls.CyberTextBox CampoEmail;
        private ReaLTaiizor.Controls.CyberCheckBox CheckBoxManterLogado;
        private ReaLTaiizor.Controls.CyberTextBox NomeUsuario;
        private Label Nome;
        private ReaLTaiizor.Controls.CyberButton cadastrar;
        private ReaLTaiizor.Controls.CyberButton BotaoVoltarUsuarios;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
    }
}