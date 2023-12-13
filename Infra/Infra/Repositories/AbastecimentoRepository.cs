using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class AbastecimentoRepository : IAbastecimentoRepository
    {
        private readonly SqlContext _context;

        public AbastecimentoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Abastecimento> GetAbastecimentos()
        {
            return _context.Abastecimento.ToList();
        }

        public Abastecimento GetAbastecimentoById(int id)
        {
            return _context.Abastecimento.Find(id);
        }

        public void InsertAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimento.Add(abastecimento);
            _context.SaveChanges();
        }
        public void UpdateAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimento.Update(abastecimento);
            _context.SaveChanges();
        }
        public void DeleteAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimento.Remove(abastecimento);
            _context.SaveChanges();
        }
        public List<Abastecimento> GetAbastecimentoGerenteById(int gerenteId)
        {
            // Obtém a data e hora atuais
            DateTime dataAtual = DateTime.Now;

            // Obtém o mês corrente
            int mesCorrente = dataAtual.Month;

            // Obtém o ano corrente
            int anoCorrente = dataAtual.Year;

            //return _context.Abastecimento.Where(x => x.gerenteId == gerenteId).ToList();
            var query = from abastecimento in _context.Abastecimento
                        join viatura in _context.Viaturas on abastecimento.viaturaId equals viatura.Id
                        join fornecedor in _context.Fornecedor on abastecimento.fornecedorId equals fornecedor.Id
                        join tipo_combustivel in _context.Tipo_Combustivel on abastecimento.tipo_combustivelId equals tipo_combustivel.Id
                        where abastecimento.gerenteId == gerenteId && abastecimento.data_abastecimento.Month == mesCorrente && abastecimento.data_abastecimento.Year == anoCorrente
                        select new Abastecimento()
                        {
                            Id = abastecimento.Id,
                            data_abastecimento = abastecimento.data_abastecimento,
                            valor_unid_abastecimento = abastecimento.valor_unid_abastecimento,
                            qtd = abastecimento.qtd,
                            valor_total_abastecimento = abastecimento.valor_total_abastecimento,
                            //viaturaId = abastecimento.viaturaId,
                            //fornecedorId = abastecimento.fornecedorId,
                            //tipo_combustivelId = abastecimento.tipo_combustivelId,
                            gerenteId = abastecimento.gerenteId,
                            Viatura = new Viatura()
                            {
                                sigla = viatura.sigla,
                                Tipo_ViaturaId = viatura.Tipo_ViaturaId,
                            },
                            Fornecedor = new Fornecedor()
                            {
                                nome_fantasia = fornecedor.nome_fantasia,
                                Id = fornecedor.Id,
                            },
                            Tipo_Combustivel = new Tipo_Combustivel()
                            {
                                nome_combustivel = tipo_combustivel.nome_combustivel,
                                Id = tipo_combustivel.Id,
                            }
                        };
            return query.ToList();
        }
        public List<Abastecimento> GetAbastecimentosByFilter(int? fornecedorId, int gerenteId, DateTime? dataInicial, DateTime? dataFinal)
        {
            var query = from abastecimento in _context.Abastecimento
                        join viatura in _context.Viaturas on abastecimento.viaturaId equals viatura.Id
                        join fornecedor in _context.Fornecedor on abastecimento.fornecedorId equals fornecedor.Id
                        join tipo_combustivel in _context.Tipo_Combustivel on abastecimento.tipo_combustivelId equals tipo_combustivel.Id
                        where abastecimento.gerenteId == gerenteId &&
                            (fornecedorId == null || abastecimento.fornecedorId == fornecedorId) &&
                            (dataInicial == null || abastecimento.data_abastecimento.Date >= dataInicial) &&
                            (dataFinal == null || abastecimento.data_abastecimento.Date <= dataFinal)
                        select new Abastecimento()
                        {
                            Id = abastecimento.Id,
                            data_abastecimento = abastecimento.data_abastecimento,
                            valor_unid_abastecimento = abastecimento.valor_unid_abastecimento,
                            qtd = abastecimento.qtd,
                            valor_total_abastecimento = abastecimento.valor_total_abastecimento,
                            gerenteId = abastecimento.gerenteId,
                            Viatura = new Viatura()
                            {
                                sigla = viatura.sigla,
                                Tipo_ViaturaId = viatura.Tipo_ViaturaId,
                            },
                            Fornecedor = new Fornecedor()
                            {
                                nome_fantasia = fornecedor.nome_fantasia,
                                Id = fornecedor.Id,
                            },
                            Tipo_Combustivel = new Tipo_Combustivel()
                            {
                                nome_combustivel = tipo_combustivel.nome_combustivel,
                                Id = tipo_combustivel.Id,
                            }
                        };
            return query.ToList();
        }
    }
}