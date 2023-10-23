using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class TipoServicoService : ITipoServicoService
    {
        private readonly ITipoServicoRepository _tipoServicoRepository;

        public TipoServicoService(ITipoServicoRepository tipoServicoRepository)
        {
            _tipoServicoRepository = tipoServicoRepository;
        }

        public List<Tipo_Servico> GetTipoServicos()
        {
            return _tipoServicoRepository.GetTipoServicos();
        }

        public Tipo_Servico GetTipoServicoById(int id)
        {
            return _tipoServicoRepository.GetTipoServicoById(id);
        }

        public void InsertTipoServico(TipoServicoViewModel TipoServicoViewModel)
        {
            var tipoServico = new Tipo_Servico
            {
                descricao = TipoServicoViewModel.descricao
            };

            _tipoServicoRepository.InsertTipoServico(tipoServico);
        }

        public void UpdateTipoServico(int id, TipoServicoViewModel TipoServicoViewModel)
        {
            var originalTipoServico = _tipoServicoRepository.GetTipoServicoById(id);
            if (originalTipoServico == null)
                throw new Exception("TipoServico nao existe.");

            originalTipoServico.descricao = TipoServicoViewModel.descricao;

            _tipoServicoRepository.UpdateTipoServico(originalTipoServico);
        }

        public void DeleteTipoServico(int id)
        {
            var originalTipoServico = _tipoServicoRepository.GetTipoServicoById(id);
            if (originalTipoServico == null)
                throw new Exception("TipoServico nao existe.");

            _tipoServicoRepository.DeleteTipoServico(originalTipoServico);
        }
    }
}