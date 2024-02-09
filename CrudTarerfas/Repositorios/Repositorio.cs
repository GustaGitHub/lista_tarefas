using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTarerfas.Repositorios
{
    public class TarefasRepositorio
    {
        public TarefasRepositorio() { }

        public static async Task<bool> DesativarTarefa(MySqlConnection connection, string id)
        {
            var comando = new MySqlCommand(@$"UPDATE TAREFAS SET ATIVO = false WHERE ID_TAREFA = {id}", connection);

            var execucao = await comando.ExecuteNonQueryAsync();

            return execucao > 0;
        }
    }
}
