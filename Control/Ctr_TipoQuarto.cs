using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Control
{
    class Ctr_TipoQuarto
    {
        Dao_TipoQuarto Dao_TipoQuarto;
        List<TipoQuarto> Lista_TipoQuarto;

        public Ctr_TipoQuarto()
        {
            Dao_TipoQuarto = new Dao_TipoQuarto();
        }
        public void Incluir(TipoQuarto TipoQuarto)
        {
            Dao_TipoQuarto.Create(TipoQuarto);
        }

        public void Alterar(TipoQuarto TipoQuarto)
        {
            Dao_TipoQuarto.Update(TipoQuarto);
        }

        public void Excluir(TipoQuarto TipoQuarto)
        {
            Dao_TipoQuarto.Delete(TipoQuarto);
        }

        public List<TipoQuarto> Carrega_TipoQuarto()
        {
            Lista_TipoQuarto = Dao_TipoQuarto.CarregarLista_TipoQuarto();
            return Lista_TipoQuarto;
        }

        public List<TipoQuarto> Busca_TipoQuarto(string ParamBusca, string ParamWhere)
        {
            Lista_TipoQuarto = Dao_TipoQuarto.BuscarLista_TipoQuarto(ParamBusca, ParamWhere);
            return Lista_TipoQuarto;
        }
    }
}
