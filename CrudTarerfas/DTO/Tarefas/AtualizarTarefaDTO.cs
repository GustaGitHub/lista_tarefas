using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTarerfas.DTO.Tarefas
{
    public class AtualizarTarefaDTO
    {
        public AtualizarTarefaDTO(){}

        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime prazoTarefa { get; set; }
        public string idTarefa { get; set; }
    }
}
