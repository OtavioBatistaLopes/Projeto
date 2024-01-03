using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo_Despesas
    {

        public int id_Despesa { get; set; }
        
        public string nome_Despesa { get; set; }

        public decimal valor_Despesa { get; set; }

        public string observacao_Despesa { get; set; }

        public string status_Despesa { get; set; }
    }
}
