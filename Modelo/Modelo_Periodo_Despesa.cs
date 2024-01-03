using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Modelo_Periodo_Despesa
    {
        public int id_PeriodoDespesa { get; set; }

        public decimal valor_Pago { get; set; }         

        public DateTime data_Vencimento { get; set; }

        public string status_DespesaMes { get; set; }

        [ForeignKey("id_Periodo")]
        public int id_Periodo { get; set; }

        [ForeignKey("id_Despesa")]
        public int id_Despesa { get; set; }
    }
}
