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
        //List<Quarto> Lista_Quarto;
        List<Quarto> Lista_TipoQuarto;
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
        /*
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
            Lista_Quarto = Dao_TipoQuarto.BuscarLista_Quarto(ParamBusca, ParamWhere);
            return Lista_Quarto;
        }*/

        public List<Quarto> Buscar_TipoQuarto()
        {
            Lista_TipoQuarto = Dao_Quarto.Buscar_ListaTipoQuarto();
            return Lista_TipoQuarto;
        }
    }
}
