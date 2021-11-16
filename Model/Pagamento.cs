using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class Pagamento : Reserva
    {
        public double ValorTroco { get; set; }
        public double ValorPago { get; set; }
        public double ValorParcela { get; set; }
        public int NumParcela { get; set; }
        public string FormPagamento { get; set; }

        public Pagamento()
        {

        }
        public void PagDebito(double ValorTotal)
        {
            this.ValorPago = ValorTotal;
        }
        public void PagCredito(double ValorTotal, int NumParcela)
        {
            this.ValorParcela = ValorTotal / NumParcela;
        }

        public void PagDin(double ValorTotal, double ValorPago)
        {
            if (ValorTotal <= ValorPago)
            {
                this.ValorTroco = 0;
            }
            else
            {
                this.ValorTroco = ValorTotal - ValorPago;
            }
        }
    }
}
