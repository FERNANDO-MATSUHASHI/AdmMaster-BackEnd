﻿using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IAtendimentoApplication
    {       
        List<Atendimento> GetAtendimentos();
        Atendimento GetAtendimentoById(int id);
        void InsertAtendimento(AtendimentoViewModel atendimentoViewModel);
        void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel);
        void DeleteAtendimento(int id);
        List<Atendimento> GetAtendimentoGerenteById(int gerenteId);
        List<Atendimento> GetAtendimentosAnalise(int gerenteId);
        List<Atendimento> GetAtendimentosByFilter(int gerenteId, DateTime? dataInicial, DateTime? dataFinal);
        List<Atendimento> GetAtendimentoGerenteTodosById(int gerenteId);
    }
}