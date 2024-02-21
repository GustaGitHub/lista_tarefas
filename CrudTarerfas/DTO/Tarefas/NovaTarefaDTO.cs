using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTarerfas.DTO.Tarefas
{
    public class NovaTarefaDTO
    {
        public NovaTarefaDTO(){}
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime prazoTarefa { get; set; } 
    }
}
