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

        public double Realizar_Pagamento(Pagamento Pagamento)
        {
            if(Pagamento.FormPagamento == "Cartão Débito")
            {
                Pagamento.ValorPago = Pagamento.ValorTotal;
                Console.WriteLine(Pagamento.ValorPago);
                //grava no bd
                return Pagamento.ValorPago;
            }
            else
            {
                if(Pagamento.FormPagamento == "Dinheiro")
                {
                    if (Pagamento.ValorPago == Pagamento.ValorTotal)
                    {
                        Pagamento.ValorTroco = 0;
                    }
                    else
                    {
                        Pagamento.ValorTroco = Pagamento.ValorPago - Pagamento.ValorTotal;
                    }
                    //grava no bd
                    return Pagamento.ValorTroco;
                }
                else
                {
                    if(Pagamento.FormPagamento == "Cartão Crédito")
                    {
                        Pagamento.ValorParcela = Pagamento.ValorTotal / Pagamento.NumParcela;
                        Console.WriteLine(Pagamento.ValorParcela);
                        //grava no bd
                    }
                    return Pagamento.ValorParcela;
                }
            }
        }
    }
}