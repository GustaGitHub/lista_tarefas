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
        public static async Task ExibirRelatorioTarefas()
        {
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    StringBuilder mensagemRelatorio = new StringBuilder();
                    DateTime dateTime = DateTime.Now;
                    string saudacao = string.Empty;
                    string? numeroTotal = string.Empty;
                    IList<string?> tarefasVencidas = new List<string?>();

                    #region Total de Tarefas

                    string contagemTotalTarefasSQL = "select count(ID_TAREFA) AS TOTAL from tarefas t where t.ATIVO = true";
                    MySqlCommand comando = new MySqlCommand(contagemTotalTarefasSQL, conn);
                    var execucaoComando = await comando.ExecuteReaderAsync();
                    
                    var dataTable = new DataTable();
                    dataTable.Load(execucaoComando);

                    numeroTotal = dataTable.Rows[0]["TOTAL"].ToString();

                    #endregion

                    #region Listar Tarefas Vencidas

                    string TarefasVencidasSQL = @"select 
	                                                concat(TITULO, ' | ', DATE_FORMAT(PRAZO,'%d/%m/%Y')) TAREFA
                                                from tarefas
                                                where PRAZO < sysdate() and ATIVO = TRUE";

                    MySqlCommand comando2 = new MySqlCommand(TarefasVencidasSQL, conn);
                    var execucaoComando2 = await comando2.ExecuteReaderAsync();

                    var dataTable2 = new DataTable();
                    dataTable2.Load(execucaoComando2);

                    if(dataTable2.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable2.Rows)
                            tarefasVencidas.Add(row["TAREFA"].ToString());
                    }
                    

                    #endregion

                    #region Montar texto do Relatório
                    
                    if (dateTime.Hour >= 0 && dateTime.Hour <= 11) mensagemRelatorio.AppendLine("Bom Dia");
                    else if (dateTime.Hour >= 12 && dateTime.Hour <= 17) mensagemRelatorio.AppendLine("Boa Tarde");
                    else mensagemRelatorio.AppendLine("Boa noite");

                    mensagemRelatorio.AppendLine();

                    mensagemRelatorio.AppendLine("Total de Tarefas Pendentes: " + numeroTotal);
                    

                    if(tarefasVencidas != null && tarefasVencidas.Count > 0)
                    {
                        mensagemRelatorio.AppendLine();
                       
                        mensagemRelatorio.AppendLine("Você possui Tarefas Pendentes: ");

                        foreach (string tarefa in tarefasVencidas)
                            mensagemRelatorio.AppendLine("  - " + tarefa);
                    }

                    #endregion

                    MessageBox.Show(mensagemRelatorio.ToString(), "Relatório de Tarefas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
