﻿namespace Domain.Entites
{
    public class Tipo_Servico
    {
        public int Id { get; set; }
        public string descricao { get; set; }

        public List<Viatura> Viaturas { get; set; }
    }
}