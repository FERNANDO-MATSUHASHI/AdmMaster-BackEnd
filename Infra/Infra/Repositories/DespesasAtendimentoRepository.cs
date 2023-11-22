using Domain.Entites;
using Infra.Interfaces;
using System.Globalization;

namespace Infra.Repositories
{
    public class DespesasAtendimentoRepository : IDespesasAtendimentoRepository
    {
        private readonly SqlContext _context;

        public DespesasAtendimentoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Despesas_Atendimento> GetDespesas()
        {
            //return _context.DespesasAtendimento.ToList();
            var query = from despesa in _context.DespesasAtendimento
                        join atendimento in _context.Atendimentos on despesa.AtendimentoId equals atendimento.Id
                        join usuario in _context.Usuarios on atendimento.usuarioId equals usuario.Id
                        select new Despesas_Atendimento()
                        {
                            Id = despesa.Id,
                            AtendimentoId = atendimento.Id,
                            Atendimento = new Atendimento()
                            {
                                Id = atendimento.Id,
                                qru = atendimento.qru,
                                tipoServicoId = atendimento.tipoServicoId,
                                data = atendimento.data,
                                usuarioId = atendimento.usuarioId,
                                Usuario = new Usuario()
                                {
                                    Id = usuario.Id,
                                    nome = usuario.nome
                                },
                                viaturaId = atendimento.viaturaId,
                            },
                            tipo = despesa.tipo,
                            descricao = despesa.descricao,
                            valor = despesa.valor
                        };
            return query.ToList();
        }

        public List<Despesas_Atendimento> GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal)
        {
            var query = from despesa in _context.DespesasAtendimento
                        join atendimento in _context.Atendimentos on despesa.AtendimentoId equals atendimento.Id
                        join usuario in _context.Usuarios on atendimento.usuarioId equals usuario.Id
                        where atendimento.qru == (qru ?? atendimento.qru) &&
                            (dataInicial == null || atendimento.data.Date >= dataInicial) &&
                            (dataFinal == null || atendimento.data.Date <= dataFinal)
                        select new Despesas_Atendimento()
                        {
                            Id = despesa.Id,
                            AtendimentoId = atendimento.Id,
                            Atendimento = new Atendimento()
                            {
                                Id = atendimento.Id,
                                qru = atendimento.qru,
                                tipoServicoId = atendimento.tipoServicoId,
                                data = atendimento.data,
                                usuarioId = atendimento.usuarioId,
                                Usuario = new Usuario()
                                {
                                    Id = usuario.Id,
                                    nome = usuario.nome
                                },
                                viaturaId = atendimento.viaturaId,
                            },
                            tipo = despesa.tipo,
                            descricao = despesa.descricao,
                            valor = despesa.valor
                        };
            return query.ToList();
        }

        public Viatura GetInfoViatura(int id)
        {
            var query = from viatura in _context.Viaturas
                        join tipoVitura in _context.Tipo_Viaturas on viatura.Tipo_ViaturaId equals tipoVitura.Id
                        where viatura.Id == id
                        select new Viatura()
                        {
                            Id = viatura.Id,
                            sigla = viatura.sigla,
                            obs_vtr = viatura.obs_vtr,
                            Tipo_Viatura = new Tipo_Viatura()
                            {
                                Id = tipoVitura.Id,
                                marca = tipoVitura.marca,
                                modelo = tipoVitura.modelo,
                                placa = tipoVitura.placa,
                                descricao = tipoVitura.descricao
                            },
                        };
            return query.FirstOrDefault();
        }

        public Despesas_Atendimento GetDespesaById(int id)
        {
            return _context.DespesasAtendimento.Find(id);
        }

        public void InsertDespesa(Despesas_Atendimento despesa)
        {
            _context.DespesasAtendimento.Add(despesa);
            _context.SaveChanges();
        }
        public void UpdateDespesa(Despesas_Atendimento despesa)
        {
            _context.DespesasAtendimento.Update(despesa);
            _context.SaveChanges();
        }
        public void DeleteDespesa(Despesas_Atendimento despesa)
        {
            _context.DespesasAtendimento.Remove(despesa);
            _context.SaveChanges();
        }
        public List<Despesas_Atendimento> GetDespesaGerenteById(int gerenteId)
        {
            //return _context.DespesasAtendimento.Where(x => x.gerenteId == gerenteId).ToList();
            var query = from despesa in _context.DespesasAtendimento
                        join atendimento in _context.Atendimentos on despesa.AtendimentoId equals atendimento.Id
                        join usuario in _context.Usuarios on atendimento.usuarioId equals usuario.Id
                        where atendimento.gerenteId == gerenteId
                        select new Despesas_Atendimento()
                        {
                            Id = despesa.Id,
                            AtendimentoId = atendimento.Id,
                            Atendimento = new Atendimento()
                            {
                                Id = atendimento.Id,
                                qru = atendimento.qru,
                                tipoServicoId = atendimento.tipoServicoId,
                                data = atendimento.data,
                                usuarioId = atendimento.usuarioId,
                                Usuario = new Usuario()
                                {
                                    Id = usuario.Id,
                                    nome = usuario.nome
                                },
                                viaturaId = atendimento.viaturaId,
                            },
                            tipo = despesa.tipo,
                            descricao = despesa.descricao,
                            valor = despesa.valor
                        };
            return query.ToList();
        }
    }
}