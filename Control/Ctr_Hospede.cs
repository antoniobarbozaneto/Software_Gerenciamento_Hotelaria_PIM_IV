using Software_Gerenciamento_Hotelaria_PIM_IV.Dao;
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
            Hospede.Cpf.Replace(",", ".");
                        
            Dao_Hospede.Create(Hospede);
        }
        
        public void Alterar(Hospede Hospede)
        {
            Hospede.Cpf.Replace(",", ".");

            Dao_Hospede.Update(Hospede);
        }

        public void Excluir(Hospede Hospede)
        {
            Dao_Hospede.Delete(Hospede);
        }

        public List<Hospede> Carrega_Hospede()
        {
            //Dao_Hospede.CarregaListaHospedes();

            Lista_Hospede = Dao_Hospede.CarregaLista_Hospede();
            Console.WriteLine(Lista_Hospede);
            return Lista_Hospede;
        }
    }
}
