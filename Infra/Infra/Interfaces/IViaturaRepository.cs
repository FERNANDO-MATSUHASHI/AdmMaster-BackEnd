﻿using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IViaturaRepository
    {
        public List<Viatura> GetViaturas();
        public Viatura GetViaturaById(int id);
        public void InsertViatura(Viatura viatura);
        public void UpdateViatura(Viatura viatura);
        public void DeleteViatura(Viatura viatura);
        List<Viatura>? GetViaturasByGerenteId(int gerenteId);
    }
}