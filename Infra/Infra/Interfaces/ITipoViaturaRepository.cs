using Domain.Entites;
using Domain.ViewModel;

namespace Infra.Interfaces
{
    public interface ITipoViaturaRepository
    {
        public List<Tipo_Viatura> GetTipoViaturas();
        public Tipo_Viatura GetTipoViaturaById(int id);
        public void InsertTipoViatura(Tipo_Viatura tipoViatura);
        public void UpdateTipoViatura(Tipo_Viatura tipoViatura);
        public void DeleteTipoViatura(Tipo_Viatura tipoViatura);
        List<Tipo_Viatura>? GetTipoViaturasByGerenteId(int gerenteId);
    }
}