using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace CrudTarerfas
{
    public partial class Form2 : Form
    {
        private readonly string connString = @"Server=localhost;Database=faculdade;Uid=root;Pwd=fei3g98;";
        private readonly MySqlConnection conn;
        public Form2()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
        }

        private async void CriarTarefa_Click(object sender, EventArgs e)
        {
            using (var connection = conn)
            {
                try
                {
                    connection.Open();
                    var comando = new MySqlCommand(@$"INSERT INTO TAREFAS(TITULO, DESCRICAO, PRAZO, DATA_CRIACAO) 
                                                    VALUES ('{Titulo.Text}', 
                                                            '{DescricaoTarefa.Text}', 
                                                            '{PrazoTarefa.Value.Date.ToString("yyyy-MM-dd HH:mm")}',
                                                            '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'
                                                            )", connection);

                    var execucao = await comando.ExecuteNonQueryAsync();

                    if (execucao > 0)
                        MessageBox.Show("Tarefa incluida com sucesso, Atualize sua lista de Tarefas");
                    else
                        MessageBox.Show("Não foi possível inserir a nova tarefa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }
            }
        }

        private async void ExcluirBtn_Click(object sender, EventArgs e)
        {
            if(IdTarefa.Text.Length < 0)
            {
                MessageBox.Show("Inclua o id para concluir Tarefa");
                return;
            }


            using (var connection = conn)
            {
                try
                {
                    connection.Open();
                    var comando = new MySqlCommand(@$"DELETE FROM TAREFAS
                                                      WHERE ID_TAREFA = {IdTarefa.Text}", connection);

                    var execucao = await comando.ExecuteNonQueryAsync();

                    if (execucao > 0)
                        MessageBox.Show("Tarefa concluida, Atualize sua lista de Tarefas");
                    else
                        MessageBox.Show("O ID desta tarefa não existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }
            }
        }

        private async void EditarBtn_Click(object sender, EventArgs e)
        {
            using (var connection = conn)
            {
                try
                {
                    connection.Open();
                    var comando = new MySqlCommand(@$"UPDATE TAREFAS 
                                                    SET TITULO = '{Titulo.Text}', 
                                                        DESCRICAO = '{DescricaoTarefa.Text}', 
                                                        PRAZO = '{PrazoTarefa.Value.Date.ToString("yyyy-MM-dd HH:mm")}'
                                                    WHERE ID_TAREFA = {IdTarefa.Text}        
                                                   ", connection);

                    var execucao = await comando.ExecuteNonQueryAsync();

                    if (execucao > 0)
                        MessageBox.Show("Tarefa atualiada com sucesso, Atualize sua lista de Tarefas");
                    else
                        MessageBox.Show("o id desta tarefa que você quer atualizar não existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }
            }

        }
    }
}
