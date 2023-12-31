﻿using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class AtendimentoApplication : IAtendimentoApplication
    {
        private readonly IAtendimentoService _atendimentoService;

        public AtendimentoApplication(IAtendimentoService atendimentoService)
        {
            _atendimentoService = atendimentoService;
        }

        public List<Atendimento> GetAtendimentos()
        {
            return _atendimentoService.GetAtendimentos();
        }

        public Atendimento GetAtendimentoById(int id)
        {
            return _atendimentoService.GetAtendimentoById(id);
        }

        public void InsertAtendimento(AtendimentoViewModel atendimentoViewModel)
        {
            _atendimentoService.InsertAtendimento(atendimentoViewModel);
        }

        public void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel)
        {
            _atendimentoService.UpdateAtendimento(id, atendimentoViewModel);
        }

        public void DeleteAtendimento(int id)
        {
            _atendimentoService.DeleteAtendimento(id);
        }

        public List<Atendimento> GetAtendimentoGerenteById(int gerenteId)
        {
            return _atendimentoService.GetAtendimentoGerenteById(gerenteId);
        }
        public List<Atendimento> GetAtendimentosAnalise(int gerenteId)
        {
            return _atendimentoService.GetAtendimentosAnalise(gerenteId);
        }
        public List<Atendimento> GetAtendimentosByFilter(int gerenteId, DateTime? dataInicial, DateTime? dataFinal)
        {
            return _atendimentoService.GetAtendimentosByFilter(gerenteId, dataInicial, dataFinal);
        }
        public List<Atendimento> GetAtendimentoGerenteTodosById(int gerenteId)
        {
            return _atendimentoService.GetAtendimentoGerenteTodosById(gerenteId);
        }
    }
}