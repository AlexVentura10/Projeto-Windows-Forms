using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Lista_de_Tarefas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void botaoAddTarefa_Click(object sender, EventArgs e)
        {

            panelAddTarefa.Visible = true;
            flowLayoutPanelVerTarefas.Visible = false;
            panelMenuIncial.Visible = false;
        }



        public class Tarefa
        {
            public string tarefaAdd { get; set; }
            public DateTime Data { get; set; }
        }


        List<Tarefa> Tarefas = new List<Tarefa>();


        private void buttonAddTarefa_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textBoxAddTarefa.Text) && monthCalendar.SelectionStart != DateTime.MinValue)    // Verifica se o TextBox não está vazio
            {

                string tarefaAdd = textBoxAddTarefa.Text;   // Obtém o texto do TextBox

                DateTime dataTarefa = monthCalendar.SelectionEnd;  // Obtém a data selecionada no MonthCalendar



                Tarefa novaTarefa = new Tarefa()  // Cria uma nova instância da classe Tarefa com a descrição e a data
                {
                    tarefaAdd = tarefaAdd,
                    Data = dataTarefa
                };


                Tarefas.Add(novaTarefa);   // Adiciona a nova tarefa à lista de tarefas

                textBoxAddTarefa.Clear();


                MessageBox.Show("Tarefa Adicionda com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                MessageBox.Show("Digite uma tarefa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (monthCalendar.SelectionStart != DateTime.MinValue)
                {
                    MessageBox.Show("Informe a data da tarefa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void botaoVerTarefas_Click(object sender, EventArgs e)
        {

            if (Tarefas.Count > 0)
            {

                flowLayoutPanelVerTarefas.Visible = true;
                panelAddTarefa.Visible = false;
                panelMenuIncial.Visible = false;

                MostrarLista();

            }

            else
            {
                flowLayoutPanelVerTarefas.Visible = false;
                MessageBox.Show("Você não possui nenhuma tarefa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        private void MostrarLista()
        {

            listBoxTarefas.Items.Clear(); // Limpando meu TextBox para remover as tarefas antigas e capturar somente as novas 


            foreach (Tarefa tarefa in Tarefas) // Adiciona tarefa e data ao ListBox
            {
                string listaFormatada = $"{tarefa.tarefaAdd} - {tarefa.Data.ToString("dd/MM/yyyy")}";

                listBoxTarefas.Items.Add(listaFormatada);
            }

        }

        private void panelAutoScrollMenu_Paint(object sender, PaintEventArgs e)
        {
            panelAutoScrollMenu.AutoScroll = true;
        }
    }
}
