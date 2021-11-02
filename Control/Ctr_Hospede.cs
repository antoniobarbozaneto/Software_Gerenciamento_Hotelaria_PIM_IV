﻿using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Control
{
    class Ctr_Hospede
    {
        Dao_Hospede Dao_Hospede;
        List<Hospede> Lista_Hospede;

        public Ctr_Hospede()
        {
            Dao_Hospede = new Dao_Hospede();
        }
        public void Incluir(Hospede Hospede)
        {       
            Dao_Hospede.Create(Hospede);
        }
        
        public void Alterar(Hospede Hospede)
        {
            Dao_Hospede.Update(Hospede);
        }

        public void Excluir(Hospede Hospede)
        {
            Dao_Hospede.Delete(Hospede);
        }

        public List<Hospede> Carrega_Hospede()
        {
            Lista_Hospede = Dao_Hospede.CarregarLista_Hospede();
            return Lista_Hospede;
        }

        public List<Hospede> Busca_Hospede(string ParamBusca, string ParamWhere)
        {
                Lista_Hospede = Dao_Hospede.BuscarLista_Hospede(ParamBusca, ParamWhere);
                return Lista_Hospede;
        }
    }
}
