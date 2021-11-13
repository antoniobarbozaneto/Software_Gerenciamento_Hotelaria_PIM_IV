using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Control
{
    class Ctr_Usuario
    {
        Dao_Usuario Dao_Usuario;
        List<Usuario> Lista_Usuario;

        public Ctr_Usuario()
        {
            Dao_Usuario = new Dao_Usuario();
        }
        public void Incluir(Usuario Usuario)
        {
            Dao_Usuario.Create(Usuario);
        } 

        public void Alterar(Usuario Usuario)
        {
            Dao_Usuario.Update(Usuario);
        }
        public void Excluir(Usuario Usuario)
        {
            Dao_Usuario.Delete(Usuario);
        }
        public List<Usuario> Carrega_Usuario()
        {
            Lista_Usuario = Dao_Usuario.CarregarLista_Usuario();
            return Lista_Usuario;
        }

        public List<Usuario> Busca_Hospede(string ParamBusca, string ParamWhere)
        {
            Lista_Usuario = Dao_Usuario.BuscarLista_Usuario(ParamBusca, ParamWhere);
            return Lista_Usuario;
        }
        public bool FazerLogin(Usuario Usuario)
        {
            bool resp;
            resp = Dao_Usuario.Logar(Usuario);
            return resp;
        }
    }
}
