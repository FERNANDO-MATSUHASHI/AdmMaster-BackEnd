using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class AtendimentoService : IAtendimentoService
    {
        private readonly IAtendimentoRepository _atendimentoRepository;

        public AtendimentoService(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }

        public List<Atendimento> GetAtendimento()
        {
            return _atendimentoRepository.GetAtendimentos();
        }

        public Atendimento GetAtendimentoById(int id)
        {
            return _atendimentoRepository.GetAtendimentoById(id);
        }

        public void InsertAtendimento(AtendimentoViewModel AtendimentoViewModel)
        {
            var atendimento = new Atendimento
            {
                data = AtendimentoViewModel.data,
                qru = AtendimentoViewModel.qru,
                qth = AtendimentoViewModel.qth,
                qti = AtendimentoViewModel.qti,
                km = AtendimentoViewModel.km,
                valor_total = AtendimentoViewModel.valor_total
            };

            _atendimentoRepository.InsertAtendimento(atendimento);
        }

        public void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel)
        {
            var originalAtendimento = _atendimentoRepository.GetAtendimentoById(id);
            if (originalAtendimento == null)
                throw new Exception("Atendimento nao existe.");

            originalAtendimento.data = atendimentoViewModel.data;
            originalAtendimento.qru = atendimentoViewModel.qru;
            originalAtendimento.qth = atendimentoViewModel.qth;
            originalAtendimento.qti = atendimentoViewModel.qti;
            originalAtendimento.km = atendimentoViewModel.km;
            originalAtendimento.valor_total = atendimentoViewModel.valor_total;

            _atendimentoRepository.UpdateAtendimento(originalAtendimento);
        }

        public void DeleteAtendimento(int id)
        {
            var originalAtendimento = _atendimentoRepository.GetAtendimentoById(id);
            if (originalAtendimento == null)
                throw new Exception("Atendimento nao existe.");

            _atendimentoRepository.DeleteAtendimento(originalAtendimento);
        }
    }
}