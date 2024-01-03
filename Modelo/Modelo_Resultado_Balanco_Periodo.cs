using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo_Resultado_Balanco_Periodo
    {

        public int id_Periodo { get; set; }
        public int id_Balanco { get; set; }
        public decimal Total_Caixa { get; set; }

        public decimal Caixa_Atual { get; set; }

        public DateTime Data_Inicial { get; set; }

        public DateTime Data_Final { get; set; }



    }
}
