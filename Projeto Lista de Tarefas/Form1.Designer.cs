namespace Projeto_Lista_de_Tarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUsuario = new TextBox();
            maskedTextBoxSenha = new MaskedTextBox();
            botaoLogin = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(258, 89);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 78);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(88, 32);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(157, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.HidePromptOnLeave = true;
            maskedTextBoxSenha.Location = new Point(88, 70);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.PasswordChar = '*';
            maskedTextBoxSenha.Size = new Size(157, 23);
            maskedTextBoxSenha.TabIndex = 4;
            // 
            // botaoLogin
            // 
            botaoLogin.Location = new Point(93, 108);
            botaoLogin.Name = "botaoLogin";
            botaoLogin.Size = new Size(100, 28);
            botaoLogin.TabIndex = 5;
            botaoLogin.Text = "Login";
            botaoLogin.UseVisualStyleBackColor = true;
            botaoLogin.Click += botaoLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxUsuario);
            panel1.Controls.Add(botaoLogin);
            panel1.Controls.Add(maskedTextBoxSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(150, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 158);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(610, 441);
            Controls.Add(panel1);
            Controls.Add(label1);
            MaximumSize = new Size(626, 480);
            MinimumSize = new Size(626, 480);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsuario;
        private MaskedTextBox maskedTextBoxSenha;
        private Button botaoLogin;
        private Panel panel1;
    }
}
