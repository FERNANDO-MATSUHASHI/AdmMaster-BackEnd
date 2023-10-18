using AdmMaster.Infra.MemoryDb.Interfaces;
using DDD.Domain.Entites;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmMaster.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NivelController : Controller
    {
        readonly SqlContext _context;
        public NivelController(SqlContext context)
        {
            _context = context;
        }

        // GET: api/<GerenteController>
        [HttpGet]
        public List<Nivel> GetNivel()
        {
            return _context.Nivels.ToList();
        }

        [HttpGet("{id}")]
        public Nivel GetNivelById(int id)
        {
            return _context.Nivels.Find(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void InsertNivel(Nivel nivel)
        {
            _context.Nivels.Add(nivel);
            _context.SaveChanges();
        }

        [HttpPut]
        public void UpdateNivel(Nivel nivel)
        {
            _context.Entry(nivel).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete()]
        public void DeleteNivel(Nivel nivel)
        {
            _context.Set<Nivel>().Remove(nivel);
            _context.SaveChanges();
        }
    }
}

