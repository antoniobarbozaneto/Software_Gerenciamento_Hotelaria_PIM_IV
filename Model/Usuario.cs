using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }

        private static int id_userLogado;
        public Usuario()
        {

        }
        public int Id_UserLogado
        {
            get { return id_userLogado; }
            set { id_userLogado = value; }
        }
    }
}
