namespace CrudTarerfas
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
            this.TarefasDataGridView = new System.Windows.Forms.DataGridView();
            this.IDTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TarefasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TarefasDataGridView
            // 
            this.TarefasDataGridView.AllowUserToAddRows = false;
            this.TarefasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TarefasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarefasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTarefa,
            this.TituloTarefa,
            this.DataCriacao,
            this.PrazoTarefa,
            this.DescricaoTarefa});
            this.TarefasDataGridView.Location = new System.Drawing.Point(12, 91);
            this.TarefasDataGridView.Name = "TarefasDataGridView";
            this.TarefasDataGridView.RowHeadersWidth = 51;
            this.TarefasDataGridView.RowTemplate.Height = 29;
            this.TarefasDataGridView.Size = new System.Drawing.Size(1818, 344);
            this.TarefasDataGridView.TabIndex = 0;
            // 
            // IDTarefa
            // 
            this.IDTarefa.HeaderText = "ID";
            this.IDTarefa.MinimumWidth = 6;
            this.IDTarefa.Name = "IDTarefa";
            this.IDTarefa.ReadOnly = true;
            // 
            // TituloTarefa
            // 
            this.TituloTarefa.HeaderText = "TITULO";
            this.TituloTarefa.MinimumWidth = 6;
            this.TituloTarefa.Name = "TituloTarefa";
            this.TituloTarefa.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "DATA DE CRIACAO";
            this.DataCriacao.MinimumWidth = 6;
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            // 
            // PrazoTarefa
            // 
            this.PrazoTarefa.HeaderText = "PRAZO DA TAREFA";
            this.PrazoTarefa.MinimumWidth = 6;
            this.PrazoTarefa.Name = "PrazoTarefa";
            this.PrazoTarefa.ReadOnly = true;
            // 
            // DescricaoTarefa
            // 
            this.DescricaoTarefa.HeaderText = "DESCRICAO DA TAREFA";
            this.DescricaoTarefa.MinimumWidth = 6;
            this.DescricaoTarefa.Name = "DescricaoTarefa";
            this.DescricaoTarefa.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(855, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "GERENCIAR TAREFAS ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(873, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(946, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "ATUALIZAR ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1831, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TarefasDataGridView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lista de Tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TarefasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView TarefasDataGridView;
        private DataGridViewTextBoxColumn IDTarefa;
        private DataGridViewTextBoxColumn TituloTarefa;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn PrazoTarefa;
        private DataGridViewTextBoxColumn DescricaoTarefa;
        private Button button1;
        private Button button2;
    }
}