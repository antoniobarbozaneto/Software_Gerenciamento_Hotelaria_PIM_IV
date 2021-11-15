using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Control
{
    class Ctr_Reserva
    {
        Dao_Reserva Dao_Reserva;

        public Ctr_Reserva()
        {
            Dao_Reserva = new Dao_Reserva();
        }
        public void Incluir(Reserva Reserva)
        {
            Dao_Reserva.Create(Reserva);
        }
        //
        public void AlterarStatus(Reserva Reserva)
        {
            Dao_Reserva.UpdateStatus(Reserva);
        }
        //
        public bool Verifica_QtdHospede(Reserva Reserva)
        {
            bool resp = false ;

            if(Reserva.Qtd_Hospede <= Dao_Reserva.Verif_QtdHospede(Reserva))
            {
                resp = true;
            }
            else
            {
                resp = false;
            }
            return resp;
        }

        public double Calc_Valor_Reserva(Reserva Reserva)
        {
            double Res = 0;
            double ResFinal = 0;
            double ResQtdDias = 0;

            Res = Reserva.Qtd_Hospede * Dao_Reserva.Obtem_ValorDiaria(Reserva);
            TimeSpan final = Reserva.Dt_Checkout.Subtract(Reserva.Dt_Checkin);
            ResQtdDias = final.TotalDays;

            Console.WriteLine(ResFinal = ResQtdDias * Res);
            return ResFinal;
        }
    }
}
