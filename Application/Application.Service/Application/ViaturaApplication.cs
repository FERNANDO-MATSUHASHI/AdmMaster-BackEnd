using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class ViaturaApplication : IViaturaApplication
    {
        public readonly IViaturaService _viaturaService;

        public ViaturaApplication(IViaturaService viaturaService)
        {
            _viaturaService = viaturaService;
        }

        public List<Viatura> GetViaturas()
        {
            return _viaturaService.GetViaturas();
        }

        public Viatura GetViaturaById(int id)
        {
            return _viaturaService.GetViaturaById(id);
        }

        public void InsertViatura(ViaturaViewModel ViaturaViewModel)
        {
            _viaturaService.InsertViatura(ViaturaViewModel);
        }

        public void UpdateViatura(int id, ViaturaViewModel ViaturaViewModel)
        {
            _viaturaService.UpdateViatura(id, ViaturaViewModel);
        }

        public void DeleteViatura(int id)
        {
            _viaturaService.DeleteViatura(id);
        }
    }
}
