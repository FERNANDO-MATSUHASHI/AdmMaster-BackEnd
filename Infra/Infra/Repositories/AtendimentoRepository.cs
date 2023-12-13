using Domain.Entites;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly SqlContext _context;

        public AtendimentoRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Atendimento> GetAtendimentos()
        {
            return _context.Atendimentos.ToList();
        }
        public Atendimento GetAtendimentoById(int id)
        {
            return _context.Atendimentos.Find(id);
        }
        public void InsertAtendimento(Atendimento atendimento)
        {
            _context.Atendimentos.Add(atendimento);
            _context.SaveChanges();
        }
        public void UpdateAtendimento(Atendimento atendimento)
        {
            _context.Atendimentos.Update(atendimento);
            _context.SaveChanges();
        }
        public void DeleteAtendimento(Atendimento atendimento)
        {
            _context.Atendimentos.Remove(atendimento);
            _context.SaveChanges();
        }
        public List<Atendimento> GetAtendimentoByBetweenDate(DateTime dataInicial, DateTime dataFinal, int usuarioId)
        {
            return _context.Atendimentos.Where(x => x.usuarioId == usuarioId && x.data >= dataInicial && x.data <= dataFinal).ToList();
        }
        public List<Atendimento> GetAtendimentoGerenteById(int gerenteId)
        {
            // Obtém a data e hora atuais
            DateTime dataAtual = DateTime.Now;

            // Obtém o mês corrente
            int mesCorrente = dataAtual.Month;

            // Obtém o ano corrente
            int anoCorrente = dataAtual.Year;

            return _context.Atendimentos.Where(x => x.gerenteId == gerenteId && x.data.Month == mesCorrente && x.data.Year == anoCorrente).ToList();
        }
        public List<Atendimento> GetAtendimentosAnalise(int gerenteId)
        {
            return _context.Atendimentos.Where(x => x.em_analise == true && x.gerenteId == gerenteId).ToList();
        }
        public List<Atendimento> GetAtendimentosByFilter(int gerenteId, DateTime? dataInicial, DateTime? dataFinal)
        {
            var query = from atendimento in _context.Atendimentos
                        where atendimento.gerenteId == gerenteId &&
                            (dataInicial == null || atendimento.data.Date >= dataInicial) &&
                            (dataFinal == null || atendimento.data.Date <= dataFinal)
                        select new Atendimento()
                        {
                            data = atendimento.data,
                            qru = atendimento.qru,
                            ris = atendimento.ris,
                            patins = atendimento.patins,
                            rodaExtra = atendimento.rodaExtra,
                            qth = atendimento.qth,
                            qti = atendimento.qti,
                            km = atendimento.km,
                            noturno = atendimento.noturno,
                            qtd_hora_parada = atendimento.qtd_hora_parada,
                            obs_hora_parada = atendimento.obs_hora_parada,
                            hospedagem = atendimento.hospedagem,
                            qtd_pedagio = atendimento.qtd_pedagio,
                            pedagio = atendimento.pedagio,
                            adicionais = atendimento.adicionais,
                            obs_adicionais = atendimento.obs_adicionais,
                            valor_total = atendimento.valor_total,
                            em_analise = atendimento.em_analise,
                            cancelado = atendimento.cancelado,
                            ativo = atendimento.ativo,
                            viaturaId = atendimento.viaturaId,
                            usuarioId = atendimento.usuarioId,
                            gerenteId = atendimento.gerenteId,
                            tipoVeiculoId = atendimento.tipoVeiculoId,
                            tipoServicoId = atendimento.tipoServicoId,
                            empresaId = atendimento.empresaId,
                         };
            return query.ToList();
        }

        public List<Atendimento> GetAtendimentoGerenteTodosById(int gerenteId)
        {
            return _context.Atendimentos.Where(x => x.gerenteId == gerenteId).ToList();
        }
    }
}