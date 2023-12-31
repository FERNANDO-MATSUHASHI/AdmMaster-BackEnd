﻿using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;

        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            try
            {
                var usuarios = _usuarioApplication.GetUsuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            try
            {
                var usuario = _usuarioApplication.GetUsuarioById(id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertUsuario(UsuarioViewModel usuarioViewModel)
        {
            try
            {
                _usuarioApplication.InsertUsuario(usuarioViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, UsuarioViewModel usuarioViewModel)
        {
            try
            {
                _usuarioApplication.UpdateUsuario(id, usuarioViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            try
            {
                _usuarioApplication.DeleteUsuario(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Colaboradores/{gerenteId}")]
        public IActionResult GetColaboradores(int gerenteId)
        {
            try
            {
                var colaboradores = _usuarioApplication.GetColaboradores(gerenteId);
                return Ok(colaboradores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            try
            {
                var token = _usuarioApplication.Login(loginViewModel);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet("Email")]
        public IActionResult GetUsuarioByEmail(string email)
        {
            try
            {
                var usuario = _usuarioApplication.GetUsuarioByEmail(email);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
