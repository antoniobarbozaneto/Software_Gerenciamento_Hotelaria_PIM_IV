using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Model
{
    class Hospede : Quarto
    {
        public int Id_Hospede { get; set; } //AutoIncremento Feito pelo BD
        public string Nome { get; set; }
        public string Dt_Nascimento { get; set; }
        public string RG { get; set; }
        public string Cpf { get; set; }
        public string Passaporte { get; set; }
        public string Rua { get; set; }
        public string Num { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular_Um { get; set; }
        public string Celular_Dois { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }

        public Hospede()
        {

        }

    }
}
