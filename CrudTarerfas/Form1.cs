using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text;
using CrudTarerfas.Repositorios;

namespace CrudTarerfas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 janelaGerenciamentoTarefas = new Form2();
            janelaGerenciamentoTarefas.Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try 
            {
                await TarefasRepositorio.ExibirRelatorioTarefas();
                var tarefas = await TarefasRepositorio.ListarTodasTarefas();

                foreach (DataRow row in tarefas.Rows)
                {
                    var colunas = new[]
                       {
                        row["ID_TAREFA"],
                        row["TITULO"],
                        row["DATA_CRIACAO"],
                        row["PRAZO"],
                        row["DESCRICAO"]
                    };

                    TarefasDataGridView.Rows.Add(colunas);
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            TarefasDataGridView.Rows.Clear();

            try
            {
                var tarefas = await TarefasRepositorio.ListarTodasTarefas();

                foreach (DataRow row in tarefas.Rows)
                {
                    var colunas = new[]
                    {
                        row["ID_TAREFA"],
                        row["TITULO"],
                        row["DATA_CRIACAO"],
                        row["PRAZO"],
                        row["DESCRICAO"]
                    };

                    TarefasDataGridView.Rows.Add(colunas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}