using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class Pagamento : Reserva
    {
        public int Nfe { get; set; }
        public double ValorTroco { get; set; }
        public double ValorPago { get; set; }
        public double ValorParcela { get; set; }
        public int NumParcela { get; set; }
        public string FormPagamento { get; set; }
        public DateTime Dt_Pagamento { get; set; }

        public Pagamento()
        {

        }       
    }
}
