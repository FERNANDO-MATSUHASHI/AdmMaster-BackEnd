﻿using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuario();
        public Usuario GetUsuarioById(int id);
        public void InsertUsuario(Usuario usuario);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);
    }
}