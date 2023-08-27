namespace CrudTarerfas
{
    partial class Form2
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
            this.IdTarefa = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.PrazoTarefa = new System.Windows.Forms.DateTimePicker();
            this.DescricaoTarefa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.ExcluirBtn = new System.Windows.Forms.Button();
            this.CriarTarefa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdTarefa
            // 
            this.IdTarefa.Location = new System.Drawing.Point(748, 96);
            this.IdTarefa.Name = "IdTarefa";
            this.IdTarefa.Size = new System.Drawing.Size(579, 27);
            this.IdTarefa.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(28, 96);
            this.Titulo.MaxLength = 255;
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(579, 27);
            this.Titulo.TabIndex = 6;
            // 
            // PrazoTarefa
            // 
            this.PrazoTarefa.Location = new System.Drawing.Point(28, 340);
            this.PrazoTarefa.Name = "PrazoTarefa";
            this.PrazoTarefa.Size = new System.Drawing.Size(579, 27);
            this.PrazoTarefa.TabIndex = 4;
            // 
            // DescricaoTarefa
            // 
            this.DescricaoTarefa.Location = new System.Drawing.Point(28, 187);
            this.DescricaoTarefa.MaxLength = 255;
            this.DescricaoTarefa.Multiline = true;
            this.DescricaoTarefa.Name = "DescricaoTarefa";
            this.DescricaoTarefa.Size = new System.Drawing.Size(579, 70);
            this.DescricaoTarefa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID da Tarefa Desejada";
            // 
            // EditarBtn
            // 
            this.EditarBtn.BackColor = System.Drawing.Color.Olive;
            this.EditarBtn.ForeColor = System.Drawing.Color.White;
            this.EditarBtn.Location = new System.Drawing.Point(751, 156);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(585, 48);
            this.EditarBtn.TabIndex = 12;
            this.EditarBtn.Text = "EDITAR TAREFA";
            this.EditarBtn.UseVisualStyleBackColor = false;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // ExcluirBtn
            // 
            this.ExcluirBtn.BackColor = System.Drawing.Color.Brown;
            this.ExcluirBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcluirBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExcluirBtn.Location = new System.Drawing.Point(751, 227);
            this.ExcluirBtn.Name = "ExcluirBtn";
            this.ExcluirBtn.Size = new System.Drawing.Size(585, 48);
            this.ExcluirBtn.TabIndex = 13;
            this.ExcluirBtn.Text = "EXCLUIR TAREFA";
            this.ExcluirBtn.UseVisualStyleBackColor = false;
            this.ExcluirBtn.Click += new System.EventHandler(this.ExcluirBtn_Click);
            // 
            // CriarTarefa
            // 
            this.CriarTarefa.BackColor = System.Drawing.Color.SeaGreen;
            this.CriarTarefa.ForeColor = System.Drawing.Color.White;
            this.CriarTarefa.Location = new System.Drawing.Point(28, 403);
            this.CriarTarefa.Name = "CriarTarefa";
            this.CriarTarefa.Size = new System.Drawing.Size(579, 48);
            this.CriarTarefa.TabIndex = 14;
            this.CriarTarefa.Text = "CRIAR TAREFA";
            this.CriarTarefa.UseVisualStyleBackColor = false;
            this.CriarTarefa.Click += new System.EventHandler(this.CriarTarefa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 486);
            this.Controls.Add(this.CriarTarefa);
            this.Controls.Add(this.ExcluirBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescricaoTarefa);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.PrazoTarefa);
            this.Controls.Add(this.IdTarefa);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Cadastro de Tarefa (CRUD)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IdTarefa;
        private TextBox Titulo;
        private DateTimePicker PrazoTarefa;
        private TextBox DescricaoTarefa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button EditarBtn;
        private Button ExcluirBtn;
        private Button CriarTarefa;
    }
}