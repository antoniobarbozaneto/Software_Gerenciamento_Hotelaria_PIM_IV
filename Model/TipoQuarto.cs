using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class TipoQuarto : Usuario
    {
        public string Tipo { get; set; }
        public int Qtd_Max { get; set; }
        public double Valor_Diaria { get; set; }
        public string Refeicao { get; set; }
        public TipoQuarto()
        {

        }
    }
}
