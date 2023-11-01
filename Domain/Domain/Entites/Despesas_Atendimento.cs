﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Despesas_Atendimento
    {
        public int DespesaId { get; set; }
        public int AtendimentoId { get; set; }
        public Atendimento? Atendimento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_comissao { get; set; }
    }
}
