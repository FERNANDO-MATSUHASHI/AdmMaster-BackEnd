using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.AdmMaster
{
    public class Cargo
    {
        public int cargo_ID { get; set; }
        public string descricao { get; set; }
        public List<Nivel>? Niveis { get; set; }

    }
}
