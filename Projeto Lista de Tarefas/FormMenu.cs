using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            public string TarefaAdd { get; set; }
            public DateTime Data { get; set; }
        }


        List<Tarefa> Tarefas = new List<Tarefa>();

        private void buttonAddTarefa_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxAddTarefa.Text) )   // Verifica se o usuário digitou a tarefa 
            {


                string tarefaAdd = textBoxAddTarefa.Text;   // Captura o texto(tarefa) do TextBox

                DateTime dataTarefa = monthCalendar.SelectionEnd;  // Captura a data selecionada no MonthCalendar


                Tarefa novaTarefa = new Tarefa()  // Cria um objeto (novaTarefa) da classe Tarefa atribui a ele os valores de "TarefaAdd" e a "Data"
                {
                    TarefaAdd = tarefaAdd,
                    Data = dataTarefa
                };


                Tarefas.Add(novaTarefa);   // Adiciona a nova tarefa à lista (Tarefas) de tarefas

                textBoxAddTarefa.Clear();


                MessageBox.Show("Tarefa adicionda com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            else
            {
                MessageBox.Show("Adicione uma tarefa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

        }


        private void botaoVerTarefas_Click(object sender, EventArgs e)
        {
       
                flowLayoutPanelVerTarefas.Visible = true;
                panelAddTarefa.Visible = false;
                panelMenuIncial.Visible = false;

                MostrarLista();
        
        }



        private void MostrarLista()
        {

            listBoxTarefas.Items.Clear(); // Limpando meu TextBox para remover as tarefas antigas e capturar somente as novas 


            foreach (Tarefa tarefa in Tarefas) //  Itera sobre cada elemento da lista "Tarefas" usando a variável tarefa
            {
                string listaFormatada = $" Tarefa: {tarefa.TarefaAdd} - Data: {tarefa.Data.ToString("dd/MM/yyyy")}"; // Formata a data para string

                listBoxTarefas.Items.Add(listaFormatada); // Adiciono a lista de tarefas formatada ao meu ListBox
            }

        }


        private void panelAutoScrollMenu_Paint(object sender, PaintEventArgs e)
        {
            panelAutoScrollMenu.AutoScroll = true;
        }



        private void botaoExluirLista_Click(object sender, EventArgs e)
        {

            if (Tarefas.Count > 0)
            {

                if (MessageBox.Show("Deseja realmente excluir suas tarefas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    Tarefas.Clear();

                listBoxTarefas.Items.Clear();

                MessageBox.Show("Tarefas excluidas com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Você não possui nenhuma tarefa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void botaoExluirItem_Click(object sender, EventArgs e)
        {

            if (listBoxTarefas.SelectedItem != null) // Verifica se o usuário selecionou uma tarefa 
            {
                if (MessageBox.Show("Deseja realmente excluir essa tarefa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) // Executar código se o usuário clicou em "Yes"
                {
                    listBoxTarefas.Items.Remove(listBoxTarefas.SelectedItem);                  
                }

            }

            else
            {
                if (Tarefas.Count == 0)
                {
                    MessageBox.Show("Você ainda não possui nenhuma tarefa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Selecione a tarefa que deseja exluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

        }

    }
}
