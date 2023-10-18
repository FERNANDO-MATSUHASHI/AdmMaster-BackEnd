﻿using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IAtendimentoRepository
    {
        public List<Atendimento> GetAtendimentos();
        public Atendimento GetAtendimentoById(int id);
        public void InsertAtendimento(Atendimento atendimento, int idViatura, int idUsuario);
        public void UpdateAtendimento(Atendimento atendimento);
        public void DeleteAtendimento(Atendimento atendimento);
    }
}