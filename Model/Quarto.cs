using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class Quarto : TipoQuarto
    {
        public string Numero { get; set; }
        public string Andar { get; set; }
        public string Status { get; set; }

        public Quarto()
        {

        }
    }
}
