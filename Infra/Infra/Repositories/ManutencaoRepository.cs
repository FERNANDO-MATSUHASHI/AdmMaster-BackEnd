using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class ManutencaoRepository : IManutencaoRepository
    {
        private readonly SqlContext _context;

        public ManutencaoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Manutencao> GetManutencoes()
        {
            return _context.Manutencao.ToList();
        }

        public Manutencao GetManutencaoById(int id)
        {
            return _context.Manutencao.Find(id);
        }

        public void InsertManutencao(Manutencao manutencao)
        {
            _context.Manutencao.Add(manutencao);
            _context.SaveChanges();
        }
        public void UpdateManutencao(Manutencao manutencao)
        {
            _context.Manutencao.Update(manutencao);
            _context.SaveChanges();
        }
        public void DeleteManutencao(Manutencao manutencao)
        {
            _context.Manutencao.Remove(manutencao);
            _context.SaveChanges();
        }
        public List<Manutencao> GetManutencaoGerenteById(int gerenteId)
        {
            //return _context.Manutencao.Where(x => x.gerenteId == gerenteId).ToList();
            var query = from manutencao in _context.Manutencao
                        join viatura in _context.Viaturas on manutencao.viaturaId equals viatura.Id
                        where manutencao.gerenteId == gerenteId
                        select new Manutencao()
                        {
                            Id = manutencao.Id,
                            data_manutencao = manutencao.data_manutencao,
                            nome_manutencao = manutencao.nome_manutencao,
                            descricao_manutencao = manutencao.descricao_manutencao,
                            viaturaId = manutencao.viaturaId,
                            valor_total_manutencao = manutencao.valor_total_manutencao,
                            gerenteId = manutencao.gerenteId,
                            Viatura = new Viatura()
                            {
                                sigla = viatura.sigla,
                                Tipo_ViaturaId = viatura.Tipo_ViaturaId,
                            },
                        };
            return query.ToList();
        }
    }
}