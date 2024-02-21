using CrudTarerfas.DTO.Tarefas;
using CrudTarerfas.Repositorios;
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
            try
            {
                var insercao = await TarefasRepositorio.CriarTarefa(new NovaTarefaDTO() 
                { 
                    descricao = DescricaoTarefa.Text,
                    prazoTarefa = PrazoTarefa.Value,
                    titulo = Titulo.Text
                });

                if (insercao)
                    MessageBox.Show("Tarefa incluida com sucesso, Atualize sua lista de Tarefas");
                else
                    MessageBox.Show("Não foi possível inserir a nova tarefa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private async void ExcluirBtn_Click(object sender, EventArgs e)
        {
            if(IdTarefa.Text.Length < 0)
            {
                MessageBox.Show("Inclua o id para concluir Tarefa");
                return;
            }

            try
            {
                bool operacao = await TarefasRepositorio.DesativarTarefa(IdTarefa.Text) ;

                if (operacao) MessageBox.Show("Tarefa concluida, Atualize sua lista de Tarefas");
                else MessageBox.Show("O ID desta tarefa não existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void EditarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool execucao = await TarefasRepositorio.AtualizarTarefa(new AtualizarTarefaDTO()
                {
                    titulo = Titulo.Text,
                    descricao = DescricaoTarefa.Text,
                    prazoTarefa = PrazoTarefa.Value,
                    idTarefa = IdTarefa.Text
                });

                if (execucao)
                    MessageBox.Show("Tarefa atualiada com sucesso, Atualize sua lista de Tarefas");
                else
                    MessageBox.Show("o id desta tarefa que você quer atualizar não existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
