using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Control
{
    class Ctr_Quarto
    {
        Dao_Quarto Dao_Quarto;
        List<Quarto> Lista_Quarto;
        List<Quarto> Lista_TipoQuarto; //Lista de tipos de quartos
        List<Quarto> Lista_QtdHospede_ValorDiaria; //Lista QtdMaxHospede e Valor_Diaria de um determinado tipo de quarto
        public Ctr_Quarto()
        {
            Dao_Quarto = new Dao_Quarto();
        }
        public void Incluir(Quarto Quarto)
        {
            Dao_Quarto.Create(Quarto);
        }
        
        public void Alterar(Quarto Quarto)
        {
            Dao_Quarto.Update(Quarto);
        }
        public void Excluir(Quarto Quarto)
        {
            Dao_Quarto.Delete(Quarto);
        }
        public List<Quarto> Carregar_Quarto()
        {
            Lista_Quarto = Dao_Quarto.CarregarLista_Quarto();
            return Lista_Quarto;
        }
        public List<Quarto> Buscar_Quarto(string ParamBusca, string ParamWhere)
        {
            if(ParamBusca == "Status")
            {

            }
            else
            {
                Lista_Quarto = Dao_Quarto.BuscarLista_Quarto(ParamBusca, ParamWhere);
            }
            return Lista_Quarto;
        }

        public List<Quarto> Buscar_TipoQuarto()
        {
            Lista_TipoQuarto = Dao_Quarto.Buscar_ListaTipoQuarto();
            return Lista_TipoQuarto;
        }
        public List<Quarto> Buscar_QtdHospedeMax_ValorDiaria(string ParamBusca)
        {
            Lista_QtdHospede_ValorDiaria = Dao_Quarto.Obter_QtdHospede_ValorDiaria(ParamBusca);
            return Lista_QtdHospede_ValorDiaria;
        }
        public bool Verifica_Situacao(Quarto Quarto)
        {
            bool resp = false;

            if (Dao_Quarto.Verif_SituacaoQuarto(Quarto) >= 1)
            {
                resp = true; //quarto ja foi reservado alguma vez
            }
            else
            {
                resp = false; //quarto nunca reservado
            }
            return resp;
        }
    }
}
