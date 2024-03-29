﻿namespace Projeto_Lista_de_Tarefas
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            botaoVerTarefas = new Button();
            botaoExluirLista = new Button();
            botaoSair = new Button();
            botaoAddTarefa = new Button();
            label4 = new Label();
            panelAddTarefa = new Panel();
            textBoxAddTarefa = new TextBox();
            pictureBox1 = new PictureBox();
            monthCalendar = new MonthCalendar();
            label3 = new Label();
            buttonAddTarefa = new Button();
            label2 = new Label();
            flowLayoutPanelVerTarefas = new FlowLayoutPanel();
            label1 = new Label();
            listBoxTarefas = new ListBox();
            pictureBox9 = new PictureBox();
            botaoExluirItem = new Button();
            panelMenuIncial = new Panel();
            pictureBox2 = new PictureBox();
            panelAutoScrollMenu = new Panel();
            pictureBox13 = new PictureBox();
            button7 = new Button();
            pictureBox7 = new PictureBox();
            button1 = new Button();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            panelBusca = new Panel();
            panelAddTarefa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanelVerTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panelMenuIncial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAutoScrollMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelBusca.SuspendLayout();
            SuspendLayout();
            // 
            // botaoVerTarefas
            // 
            botaoVerTarefas.Font = new Font("Segoe UI", 9.75F);
            botaoVerTarefas.Location = new Point(43, 114);
            botaoVerTarefas.Name = "botaoVerTarefas";
            botaoVerTarefas.Size = new Size(101, 24);
            botaoVerTarefas.TabIndex = 3;
            botaoVerTarefas.Text = "Ver tarefas";
            botaoVerTarefas.UseVisualStyleBackColor = true;
            botaoVerTarefas.Click += botaoVerTarefas_Click;
            // 
            // botaoExluirLista
            // 
            botaoExluirLista.Font = new Font("Segoe UI", 9.75F);
            botaoExluirLista.Location = new Point(41, 165);
            botaoExluirLista.Name = "botaoExluirLista";
            botaoExluirLista.Size = new Size(101, 24);
            botaoExluirLista.TabIndex = 4;
            botaoExluirLista.Text = "Excluir tarefas";
            botaoExluirLista.UseVisualStyleBackColor = true;
            botaoExluirLista.Click += botaoExluirLista_Click;
            // 
            // botaoSair
            // 
            botaoSair.Font = new Font("Segoe UI", 9.75F);
            botaoSair.Location = new Point(43, 215);
            botaoSair.Name = "botaoSair";
            botaoSair.Size = new Size(99, 24);
            botaoSair.TabIndex = 5;
            botaoSair.Text = "Sair";
            botaoSair.UseVisualStyleBackColor = true;
            botaoSair.Click += botaoSair_Click;
            // 
            // botaoAddTarefa
            // 
            botaoAddTarefa.Font = new Font("Segoe UI", 9.75F);
            botaoAddTarefa.Location = new Point(43, 60);
            botaoAddTarefa.Name = "botaoAddTarefa";
            botaoAddTarefa.Size = new Size(99, 27);
            botaoAddTarefa.TabIndex = 6;
            botaoAddTarefa.Text = "Adicionar ";
            botaoAddTarefa.UseVisualStyleBackColor = true;
            botaoAddTarefa.Click += botaoAddTarefa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 11);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 8;
            label4.Text = "Menu";
            // 
            // panelAddTarefa
            // 
            panelAddTarefa.BackColor = Color.Azure;
            panelAddTarefa.Controls.Add(textBoxAddTarefa);
            panelAddTarefa.Controls.Add(pictureBox1);
            panelAddTarefa.Controls.Add(monthCalendar);
            panelAddTarefa.Controls.Add(label3);
            panelAddTarefa.Controls.Add(buttonAddTarefa);
            panelAddTarefa.Controls.Add(label2);
            panelAddTarefa.Location = new Point(187, 43);
            panelAddTarefa.Name = "panelAddTarefa";
            panelAddTarefa.Size = new Size(478, 347);
            panelAddTarefa.TabIndex = 7;
            panelAddTarefa.Visible = false;
            // 
            // textBoxAddTarefa
            // 
            textBoxAddTarefa.Location = new Point(13, 37);
            textBoxAddTarefa.Name = "textBoxAddTarefa";
            textBoxAddTarefa.Size = new Size(161, 23);
            textBoxAddTarefa.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(250, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(21, 112);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 81);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Data";
            // 
            // buttonAddTarefa
            // 
            buttonAddTarefa.Location = new Point(86, 295);
            buttonAddTarefa.Name = "buttonAddTarefa";
            buttonAddTarefa.Size = new Size(103, 20);
            buttonAddTarefa.TabIndex = 2;
            buttonAddTarefa.Text = "Adicionar ";
            buttonAddTarefa.UseVisualStyleBackColor = true;
            buttonAddTarefa.Click += buttonAddTarefa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Tarefa";
            // 
            // flowLayoutPanelVerTarefas
            // 
            flowLayoutPanelVerTarefas.BackColor = Color.Azure;
            flowLayoutPanelVerTarefas.Controls.Add(label1);
            flowLayoutPanelVerTarefas.Controls.Add(listBoxTarefas);
            flowLayoutPanelVerTarefas.Controls.Add(pictureBox9);
            flowLayoutPanelVerTarefas.Controls.Add(botaoExluirItem);
            flowLayoutPanelVerTarefas.Location = new Point(192, 36);
            flowLayoutPanelVerTarefas.Name = "flowLayoutPanelVerTarefas";
            flowLayoutPanelVerTarefas.Size = new Size(473, 354);
            flowLayoutPanelVerTarefas.TabIndex = 10;
            flowLayoutPanelVerTarefas.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(85, 3);
            label1.Margin = new Padding(85, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 0;
            label1.Text = "Suas tarefas";
            // 
            // listBoxTarefas
            // 
            listBoxTarefas.BackColor = Color.Azure;
            listBoxTarefas.FormattingEnabled = true;
            listBoxTarefas.ItemHeight = 15;
            listBoxTarefas.Location = new Point(10, 43);
            listBoxTarefas.Margin = new Padding(10);
            listBoxTarefas.Name = "listBoxTarefas";
            listBoxTarefas.ScrollAlwaysVisible = true;
            listBoxTarefas.SelectionMode = SelectionMode.MultiExtended;
            listBoxTarefas.Size = new Size(268, 274);
            listBoxTarefas.TabIndex = 1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources._1567073;
            pictureBox9.Location = new Point(298, 83);
            pictureBox9.Margin = new Padding(10, 50, 10, 10);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(153, 134);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // botaoExluirItem
            // 
            botaoExluirItem.Location = new Point(100, 328);
            botaoExluirItem.Margin = new Padding(100, 1, 3, 3);
            botaoExluirItem.Name = "botaoExluirItem";
            botaoExluirItem.Size = new Size(74, 23);
            botaoExluirItem.TabIndex = 3;
            botaoExluirItem.Text = "Excluir";
            botaoExluirItem.UseVisualStyleBackColor = true;
            botaoExluirItem.Click += botaoExluirItem_Click;
            // 
            // panelMenuIncial
            // 
            panelMenuIncial.Controls.Add(pictureBox2);
            panelMenuIncial.Location = new Point(187, 43);
            panelMenuIncial.Name = "panelMenuIncial";
            panelMenuIncial.Size = new Size(427, 347);
            panelMenuIncial.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Azure;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 261);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelAutoScrollMenu
            // 
            panelAutoScrollMenu.BackColor = Color.Azure;
            panelAutoScrollMenu.Controls.Add(pictureBox13);
            panelAutoScrollMenu.Controls.Add(button7);
            panelAutoScrollMenu.Controls.Add(pictureBox7);
            panelAutoScrollMenu.Controls.Add(button1);
            panelAutoScrollMenu.Controls.Add(pictureBox8);
            panelAutoScrollMenu.Controls.Add(pictureBox6);
            panelAutoScrollMenu.Controls.Add(pictureBox5);
            panelAutoScrollMenu.Controls.Add(pictureBox3);
            panelAutoScrollMenu.Controls.Add(label4);
            panelAutoScrollMenu.Controls.Add(botaoAddTarefa);
            panelAutoScrollMenu.Controls.Add(botaoSair);
            panelAutoScrollMenu.Controls.Add(botaoExluirLista);
            panelAutoScrollMenu.Controls.Add(botaoVerTarefas);
            panelAutoScrollMenu.Location = new Point(1, 43);
            panelAutoScrollMenu.Name = "panelAutoScrollMenu";
            panelAutoScrollMenu.Size = new Size(185, 310);
            panelAutoScrollMenu.TabIndex = 11;
            panelAutoScrollMenu.Paint += panelAutoScrollMenu_Paint;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(12, 310);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(25, 24);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 27;
            pictureBox13.TabStop = false;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F);
            button7.Location = new Point(43, 310);
            button7.Name = "button7";
            button7.Size = new Size(101, 24);
            button7.TabIndex = 26;
            button7.Text = "...";
            button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 266);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(43, 266);
            button1.Name = "button1";
            button1.Size = new Size(101, 24);
            button1.TabIndex = 16;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 63);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 215);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 165);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // panelBusca
            // 
            panelBusca.Controls.Add(textBox1);
            panelBusca.Controls.Add(pictureBox4);
            panelBusca.Location = new Point(1, 5);
            panelBusca.Name = "panelBusca";
            panelBusca.Size = new Size(180, 32);
            panelBusca.TabIndex = 12;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(691, 524);
            Controls.Add(panelBusca);
            Controls.Add(panelAutoScrollMenu);
            Controls.Add(flowLayoutPanelVerTarefas);
            Controls.Add(panelAddTarefa);
            Controls.Add(panelMenuIncial);
            MaximumSize = new Size(707, 563);
            MinimumSize = new Size(707, 563);
            Name = "FormMenu";
            Text = "FormMenu";
            panelAddTarefa.ResumeLayout(false);
            panelAddTarefa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanelVerTarefas.ResumeLayout(false);
            flowLayoutPanelVerTarefas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panelMenuIncial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAutoScrollMenu.ResumeLayout(false);
            panelAutoScrollMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelBusca.ResumeLayout(false);
            panelBusca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button botaoVerTarefas;
        private Button botaoExluirLista;
        private Button botaoSair;
        private Button botaoAddTarefa;
        private Label label4;
        private Panel panelAddTarefa;
        private TextBox textBoxAddTarefa;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar;
        private Label label3;
        private Button buttonAddTarefa;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelVerTarefas;
        private Label label1;
        private ListBox listBoxTarefas;
        private Panel panelMenuIncial;
        private PictureBox pictureBox2;
        private Panel panelAutoScrollMenu;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private PictureBox pictureBox13;
        private Button button7;
        private PictureBox pictureBox7;
        private Button button1;
        private Panel panelBusca;
        private PictureBox pictureBox9;
        private Button botaoExluirItem;
    }
}