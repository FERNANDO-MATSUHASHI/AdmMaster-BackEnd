﻿namespace Domain.Entites
{
    public class Tipo_Combustivel
    {
        public int Id { get; set; }
        public string nome_combustivel { get; set; }

        public List<Abastecimento> Abastecimento { get; set; }
    }
}