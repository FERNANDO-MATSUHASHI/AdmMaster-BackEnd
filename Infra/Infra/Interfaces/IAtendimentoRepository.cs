﻿using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IAtendimentoRepository
    {
        public List<Atendimento> GetAtendimentos();
        public Atendimento GetAtendimentoById(int id);
        public void InsertAtendimento(Atendimento atendimento);
        public void UpdateAtendimento(Atendimento atendimento);
        public void DeleteAtendimento(Atendimento atendimento);
        List<Atendimento> GetAtendimentoByBetweenDate(DateTime dataInicial, DateTime dataFinal, int usuarioId);
        public List<Atendimento> GetAtendimentoGerenteById(int id);
        List<Atendimento> GetAtendimentosAnalise(int gerenteId);
        public List<Atendimento> GetAtendimentosByFilter(int gerenteId, DateTime? dataInicial, DateTime? dataFinal);
        public List<Atendimento> GetAtendimentoGerenteTodosById(int id);
    }
}