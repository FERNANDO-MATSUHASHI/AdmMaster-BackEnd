﻿namespace Domain.ViewModel
{
    public class ColaboradoresViewModel
    {
        //public string nome { get; set; }
        //public string email { get; set; }
        //public string cargo { get; set; }
        //public string estado { get; set; }
        //public string criado_em { get; set; }
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime data_nascimento { get; set; }
        public int cep { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string user_name { get; set; }
        public string senha { get; set; }
        public bool ativo { get; set; }
        public Decimal comissao { get; set; }
        public int? gerenteId { get; set; }
        public int cargoId { get; set; }
        public string criado_em { get; set; }

    }
}