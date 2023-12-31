﻿using Application.Service.Application;
using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        private readonly IAtendimentoApplication _atendimentoApplication;

        public AtendimentoController(IAtendimentoApplication atendimentoApplication)
        {
            _atendimentoApplication = atendimentoApplication;
        }

        [HttpGet]
        public IActionResult GetAtendimentos()
        {
            try
            {
                var atendimentos = _atendimentoApplication.GetAtendimentos();
                return Ok(atendimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAtendimentoById(int id)
        {
            try
            {
                var atendimento = _atendimentoApplication.GetAtendimentoById(id);
                return Ok(atendimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertAtendimento(AtendimentoViewModel atendimentoViewModel)
        {
            try
            {
                _atendimentoApplication.InsertAtendimento(atendimentoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel)
        {
            try
            {
                _atendimentoApplication.UpdateAtendimento(id, atendimentoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAtendimento(int id)
        {
            try
            {
                _atendimentoApplication.DeleteAtendimento(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Gerente/{gerenteId}")]
        public IActionResult GetAtendimentoGerenteById(int gerenteId)
        {
            try
            {
                var atendimento = _atendimentoApplication.GetAtendimentoGerenteById(gerenteId);
                return Ok(atendimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Em_Analise/{gerenteId}")]
        public IActionResult GetAtendimentosAnalise(int gerenteId)
        {
            try
            {
                var atendimentos = _atendimentoApplication.GetAtendimentosAnalise(gerenteId);
                return Ok(atendimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAtendimentosByFilter")]
        public IActionResult GetAtendimentosByFilter(int gerenteId, DateTime? dataInicial, DateTime? dataFinal)
        {
            try
            {
                var atendimentos = _atendimentoApplication.GetAtendimentosByFilter(gerenteId, dataInicial, dataFinal);
                return Ok(atendimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GerenteTodos/{gerenteId}")]
        public IActionResult GetAtendimentoGerenteTodosById(int gerenteId)
        {
            try
            {
                var atendimento = _atendimentoApplication.GetAtendimentoGerenteTodosById(gerenteId);
                return Ok(atendimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
