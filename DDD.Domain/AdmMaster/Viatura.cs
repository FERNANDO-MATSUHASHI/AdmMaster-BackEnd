using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.AdmMaster
{
    public class Viatura
    {
        public int viatura_ID { get; set; }
        public string sigla { get; set; }
        public string obs_vtr { get; set; }
        public List<Tipo_Servico>? Tipo_Servicos { get; set; }
        public List<Tipo_Viatura>? Tipo_Viaturas { get; set; }
        public List<Veiculo>? Veiculos { get; set; }


    }
}
