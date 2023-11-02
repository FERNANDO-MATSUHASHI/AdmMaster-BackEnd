﻿using Domain.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class Despesas_AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }
        public DateTime data { get; set; }
        public string qru { get; set; }        
        public string descricao { get; set; }
        public string tipo { get; set; }        

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor { get; set; }
    }
}