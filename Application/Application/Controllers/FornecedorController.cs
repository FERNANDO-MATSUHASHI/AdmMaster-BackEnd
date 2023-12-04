using Application.Service.Application;
using Application.Service.Interface;
using Domain.Entites;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorApplication _fornecedorApplication;

        public FornecedorController(IFornecedorApplication fornecedorApplication)
        {
            _fornecedorApplication = fornecedorApplication;
        }

        [HttpGet]
        public IActionResult GetFornecedores()
        {
            try
            {
                var fornecedores = _fornecedorApplication.GetFornecedores();
                return Ok(fornecedores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetFornecedorById(int id)
        {
            try
            {
                var fornecedor = _fornecedorApplication.GetFornecedorById(id);
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertFornecedor(FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                _fornecedorApplication.InsertFornecedor(fornecedorViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFornecedor(int id, FornecedorViewModel fornecedorViewModel)
        {
            try
            {
                _fornecedorApplication.UpdateFornecedor(id, fornecedorViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFornecedor(int id)
        {
            try
            {
                _fornecedorApplication.DeleteFornecedor(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Fornecedor/{gerenteId}")]
        public IActionResult GetFornecedorGerenteById(int gerenteId)
        {
            try
            {
                var abastecimento = _fornecedorApplication.GetFornecedorGerenteById(gerenteId);
                return Ok(abastecimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
