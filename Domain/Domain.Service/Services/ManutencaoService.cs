using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class ManutencaoService : IManutencaoService
    {
        public readonly IManutencaoRepository _manutencaoRepository;

        public ManutencaoService(IManutencaoRepository manutencaoRepository)
        {
            _manutencaoRepository = manutencaoRepository;
        }

        public List<Manutencao> GetManutencoes()
        {
            return _manutencaoRepository.GetManutencoes();
        }

        public Manutencao GetManutencaoById(int id)
        {
            return _manutencaoRepository.GetManutencaoById(id);
        }

        public void InsertManutencao(ManutencaoViewModel manutencaoViewModel)
        {
            var manutencao = new Manutencao
            {
                data_manutencao = manutencaoViewModel.data_manutencao,
                nome_manutencao = manutencaoViewModel.nome_manutencao,
                descricao_manutencao = manutencaoViewModel.descricao_manutencao,
                viaturaId = manutencaoViewModel.viaturaId,
                valor_total_manutencao = manutencaoViewModel.valor_total_manutencao,
                gerenteId = manutencaoViewModel.gerenteId
            };

            _manutencaoRepository.InsertManutencao(manutencao);
        }

        public void UpdateManutencao(int id, ManutencaoViewModel manutencaoViewModel)
        {
            var originalManutencao = _manutencaoRepository.GetManutencaoById(id);
            if (originalManutencao == null)
                throw new Exception("Manutencao nao existe.");

            originalManutencao.data_manutencao = manutencaoViewModel.data_manutencao;
            originalManutencao.nome_manutencao = manutencaoViewModel.nome_manutencao;
            originalManutencao.descricao_manutencao = manutencaoViewModel.descricao_manutencao;
            originalManutencao.viaturaId = manutencaoViewModel.viaturaId;
            originalManutencao.valor_total_manutencao = manutencaoViewModel.valor_total_manutencao;
            originalManutencao.gerenteId = manutencaoViewModel.gerenteId;

            _manutencaoRepository.UpdateManutencao(originalManutencao);
        }

        public void DeleteManutencao(int id)
        {
            var originalManutencao = _manutencaoRepository.GetManutencaoById(id);
            if (originalManutencao == null)
                throw new Exception("Manutencao nao existe.");

            _manutencaoRepository.DeleteManutencao(originalManutencao);
        }
        public List<Manutencao> GetManutencaoGerenteById(int gerenteId)
        {
            return _manutencaoRepository.GetManutencaoGerenteById(gerenteId);
        }
    }
}
