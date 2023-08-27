using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text;

namespace CrudTarerfas
{
    public partial class Form1 : Form
    {
        private readonly string connString = @"Server=localhost;Database=faculdade;Uid=root;Pwd=fei3g98;";
        private readonly MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 janelaGerenciamentoTarefas = new Form2();
            janelaGerenciamentoTarefas.Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using(var connection = conn)
            {
                try 
                {
                    connection.Open();
                    
                    var comando = new MySqlCommand("SELECT * FROM TAREFAS", connection);
                    DataTable resultado = new DataTable();
                    resultado.Load(await comando.ExecuteReaderAsync());
                    
                   
                    foreach (DataRow row in resultado.Rows)
                    {
                        TarefasDataGridView.Rows.Add(
                            row["ID_TAREFA"],
                            row["TITULO"],
                            row["DATA_CRIACAO"],
                            row["PRAZO"],
                            row["DESCRICAO"]
                        );
                    }
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
                
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            TarefasDataGridView.Rows.Clear();

            using (var connection = conn)
            {
                try
                {
                    connection.Open();

                    var comando = new MySqlCommand("SELECT * FROM TAREFAS", connection);
                    DataTable resultado = new DataTable();
                    resultado.Load(await comando.ExecuteReaderAsync());


                    foreach (DataRow row in resultado.Rows)
                    {
                        TarefasDataGridView.Rows.Add(
                            row["ID_TAREFA"],
                            row["TITULO"],
                            row["DATA_CRIACAO"],
                            row["PRAZO"],
                            row["DESCRICAO"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }

            }
        }
    }
}