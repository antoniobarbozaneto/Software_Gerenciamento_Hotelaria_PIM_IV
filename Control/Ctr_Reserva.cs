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
        List<Reserva> Lista_Reserva;
        public Ctr_Reserva()
        {
            Dao_Reserva = new Dao_Reserva();
        }
        public void Incluir(Reserva Reserva)
        {
            Dao_Reserva.Create(Reserva);
        }
        
        public void AlterarStatus(Reserva Reserva)
        {
            Dao_Reserva.UpdateStatusOcupado(Reserva);
        }
        
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
            ResFinal = ResQtdDias * Res;
            return ResFinal;
        }
        
        public List<Reserva> Carrega_Reserva()
        {
            Lista_Reserva = Dao_Reserva.CarregarLista_Reserva();
            return Lista_Reserva;
        }

        public List<Reserva> BuscarReserva(string ParamBusca, string ParamWhere)
        {
            if (ParamWhere == "Quarto_Numero")
            {
                ParamBusca = "'" + ParamBusca + "'";
                Lista_Reserva = Dao_Reserva.BuscarLista_Reserva(ParamBusca, ParamWhere);
            }
            else
            {
                Lista_Reserva = Dao_Reserva.BuscarLista_Reserva(ParamBusca, ParamWhere);
            }
            return Lista_Reserva;
        }
    }
}
