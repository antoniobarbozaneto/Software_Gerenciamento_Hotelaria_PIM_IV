using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class Reserva : Hospede
    {
        public int Num_Reserva { get; set; }
        public DateTime Dt_Checkin { get; set; }
        public DateTime Dt_Checkout { get; set; }
        public int Qtd_Hospede { get; set; }
        public double ValorTotal { get; set; }

        public Reserva()
        {

        }
    }
}
