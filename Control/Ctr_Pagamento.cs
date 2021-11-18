using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Control
{
    class Ctr_Pagamento
    {
        Dao_Pagamento Dao_Pagamento;

        public Ctr_Pagamento()
        {
            Dao_Pagamento = new Dao_Pagamento();
        }

        public double Realizar_Pagamento(Pagamento Pagamento)
        {
            if (Pagamento.FormPagamento == "Cartão Débito")
            {
                Pagamento.ValorPago = Pagamento.ValorTotal;
                Dao_Pagamento.Create(Pagamento);
                AlterarStatusQuarto(Pagamento);
                AlterarStatusReserva(Pagamento);
                return Pagamento.ValorPago;
            }
            else
            {
                if (Pagamento.FormPagamento == "Dinheiro")
                {
                    if (Pagamento.ValorPago == Pagamento.ValorTotal)
                    {
                        Pagamento.ValorTroco = 0;
                        Dao_Pagamento.Create(Pagamento);
                        AlterarStatusQuarto(Pagamento);
                        AlterarStatusReserva(Pagamento);
                    }
                    else
                    {
                        if (Pagamento.ValorPago > Pagamento.ValorTotal)
                        {
                            Pagamento.ValorTroco = Pagamento.ValorPago - Pagamento.ValorTotal;
                            Dao_Pagamento.Create(Pagamento);
                            AlterarStatusQuarto(Pagamento);
                            AlterarStatusReserva(Pagamento);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    return Pagamento.ValorTroco;
                }
                else
                {
                    if (Pagamento.FormPagamento == "Cartão Crédito")
                    {
                        Pagamento.ValorParcela = Pagamento.ValorTotal / Pagamento.NumParcela;
                        Console.WriteLine(Pagamento.ValorParcela);
                        Dao_Pagamento.Create(Pagamento);
                        AlterarStatusQuarto(Pagamento);
                        AlterarStatusReserva(Pagamento);
                    }
                    return Pagamento.ValorParcela;
                }
            }
        }
        public void AlterarStatusQuarto(Pagamento Pagamento)
        {
            Dao_Pagamento.UpdateStatusDisponivel(Pagamento);
        }

        public void AlterarStatusReserva(Pagamento Pagamento)
        {
            Dao_Pagamento.UpdateStatusReserva(Pagamento);
        }
    }
}