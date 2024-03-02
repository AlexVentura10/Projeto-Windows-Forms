namespace Projeto_Lista_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("Informe o nome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (textBoxUsuario.Text == "Alex")
                {

                    if (maskedTextBoxSenha.Text == "")
                    {
                        MessageBox.Show("Digite sua senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        if (maskedTextBoxSenha.Text == "2002")
                        {
                            MessageBox.Show("Login realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Aqui vamos criar uma instância do novo formulário e exibi-lo
                            FormMenu Menu = new FormMenu();
                            this.Hide(); // Oculta o formulário atual
                            Menu.ShowDialog(); // Exibe o novo formulário
                            this.Close(); // Fecha o formulário atual

                        }

                        else
                        {
                            MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

                else
                {
                    MessageBox.Show("Usuário incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

      
    }
}

