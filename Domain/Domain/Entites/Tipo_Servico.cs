﻿namespace Domain.Entites
{
    public class Tipo_Servico
    {
        public int Id { get; set; }
        public string descricao { get; set; }

        public List<Veiculo> Veiculos { get; set; }
        public List<Atendimento> Atendimentos { get; set; }
    }
}