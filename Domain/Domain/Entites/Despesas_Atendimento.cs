using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Despesas_Atendimento
    {
        public int Id { get; set; }
        public int AtendimentoId { get; set; }        
        public Atendimento? Atendimento { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor { get; set; }
    }
}
