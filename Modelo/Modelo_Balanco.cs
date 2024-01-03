using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Modelo_Balanco
    {

        public int id_Balanco { get; set; }

        public decimal total_Caixa { get; set; }

        public decimal caixa_Atual { get; set; }

        [ForeignKey("id_Periodo")]
        public int Id_Periodo { get; set; }



    }
}
