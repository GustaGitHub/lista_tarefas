using CrudTarerfas.DTO.Tarefas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTarerfas.Repositorios
{
    public class TarefasRepositorio
    {
        private static readonly string connString = @"Server=localhost;Database=faculdade;Uid=root;Pwd=fei3g98;";

        public TarefasRepositorio() 
        {
        
        }

        public static async Task<DataTable> ListarTodasTarefas()
        {
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string SQL = @"SELECT 
                                    ID_TAREFA,
                                    TITULO,
                                    DATA_CRIACAO,
                                    PRAZO,
                                    DESCRICAO
                                FROM TAREFAS
                                WHERE ATIVO = 1";

                    var comando = new MySqlCommand(SQL, conn);
                    var execucaoComando = await comando.ExecuteReaderAsync();

                    DataTable resultado = new DataTable();
                    resultado.Load(execucaoComando);

                    return resultado;
                }
                catch(Exception ex) 
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();     
                }

            }
        }
        public static async Task<bool> CriarTarefa(NovaTarefaDTO dto)
        {
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string SQL = @$"INSERT INTO TAREFAS(TITULO, DESCRICAO, PRAZO, DATA_CRIACAO, ATIVO) 
                                                    VALUES ('{dto.titulo}', 
                                                            '{dto.descricao}', 
                                                            '{dto.prazoTarefa.ToString("yyyy-MM-dd HH:mm")}',
                                                            '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',
                                                            true
                                                            )";
                    var comando = new MySqlCommand(SQL, conn);
                    var execucao = await comando.ExecuteNonQueryAsync();

                    return execucao > 0;
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        public static async Task<bool> DesativarTarefa(string id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string SQL = @$"UPDATE TAREFAS SET ATIVO = false WHERE ID_TAREFA = {id}";

                    var comando = new MySqlCommand(SQL, conn);
                    var execucao = await comando.ExecuteNonQueryAsync();

                    return execucao > 0;
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        public static async Task<bool> AtualizarTarefa(AtualizarTarefaDTO dto)
        {
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    var SQL = @$"UPDATE TAREFAS 
                                SET TITULO = '{dto.titulo}', 
                                    DESCRICAO = '{dto.descricao}', 
                                    PRAZO = '{dto.prazoTarefa.ToString("yyyy-MM-dd HH:mm")}'
                                WHERE ID_TAREFA = {dto.idTarefa}";

                    var comando = new MySqlCommand(SQL, conn);
                    var execucao = await comando.ExecuteNonQueryAsync();

                    return execucao > 0;
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
    }
}
