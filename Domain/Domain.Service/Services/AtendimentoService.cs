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

        public List<Atendimento> GetAtendimentos()
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
                ris = AtendimentoViewModel.ris,
                patins = AtendimentoViewModel.patins,
                rodaExtra = AtendimentoViewModel.rodaExtra,
                qth = AtendimentoViewModel.qth,
                qti = AtendimentoViewModel.qti,
                km = AtendimentoViewModel.km,
                noturno = AtendimentoViewModel.noturno,
                qtd_hora_parada = AtendimentoViewModel.qtd_hora_parada,
                obs_hora_parada = AtendimentoViewModel.obs_hora_parada,
                hospedagem = AtendimentoViewModel.hospedagem,
                qtd_pedagio = AtendimentoViewModel.qtd_pedagio,
                pedagio = AtendimentoViewModel.pedagio,
                adicionais = AtendimentoViewModel.adicionais,
                obs_adicionais = AtendimentoViewModel.obs_adicionais,
                valor_total = AtendimentoViewModel.valor_total,
                em_analise = AtendimentoViewModel.em_analise,
                viaturaId = AtendimentoViewModel.viaturaId,
                usuarioId = AtendimentoViewModel.usuarioId,
                tipoVeiculoId = AtendimentoViewModel.tipoVeiculoId,
                tipoServicoId = AtendimentoViewModel.tipoServicoId
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
            originalAtendimento.ris = atendimentoViewModel.ris;
            originalAtendimento.patins = atendimentoViewModel.patins;
            originalAtendimento.rodaExtra = atendimentoViewModel.rodaExtra;
            originalAtendimento.qth = atendimentoViewModel.qth;
            originalAtendimento.qti = atendimentoViewModel.qti;
            originalAtendimento.km = atendimentoViewModel.km;
            originalAtendimento.noturno = atendimentoViewModel.noturno;
            originalAtendimento.qtd_hora_parada = atendimentoViewModel.qtd_hora_parada;
            originalAtendimento.obs_hora_parada = atendimentoViewModel.obs_hora_parada;
            originalAtendimento.hospedagem = atendimentoViewModel.hospedagem;
            originalAtendimento.qtd_pedagio = atendimentoViewModel.qtd_pedagio;
            originalAtendimento.pedagio = atendimentoViewModel.pedagio;
            originalAtendimento.adicionais = atendimentoViewModel.adicionais;
            originalAtendimento.obs_adicionais = atendimentoViewModel.obs_adicionais;
            originalAtendimento.valor_total = atendimentoViewModel.valor_total;
            originalAtendimento.em_analise = atendimentoViewModel.em_analise;
            originalAtendimento.viaturaId = atendimentoViewModel.viaturaId;
            originalAtendimento.usuarioId = atendimentoViewModel.usuarioId;
            originalAtendimento.tipoVeiculoId = atendimentoViewModel.tipoVeiculoId;
            originalAtendimento.tipoServicoId = atendimentoViewModel.tipoServicoId;

            _atendimentoRepository.UpdateAtendimento(originalAtendimento);
        }

        public void DeleteAtendimento(int id)
        {
            var originalAtendimento = _atendimentoRepository.GetAtendimentoById(id);
            if (originalAtendimento == null)
                throw new Exception("Atendimento nao existe.");

            _atendimentoRepository.DeleteAtendimento(originalAtendimento);
        }

        public List<Atendimento> GetAtendimentoByBetweenDate(DateTime dataInicial, DateTime dataFinal)
        {
            var atendimentos = _atendimentoRepository.GetAtendimentoByBetweenDate(dataInicial, dataFinal);

            return atendimentos;
        }
    }
}