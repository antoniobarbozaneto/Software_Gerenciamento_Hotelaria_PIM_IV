using Software_Gerenciamento_Hotelaria_PIM_IV.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Gerenciamento_Hotelaria_PIM_IV
{
    public partial class Frm_Principal : Form
    {
        Frm_CadastroHospede Frm_CadastroHospede;
        //Frm_CadastroQuarto frm_CadastroQuarto;
        //Frm_FazerReserva frm_FazerReserva;
        //Frm_CadastroUsuario frm_CadastroUsuario;
        //Frm_CadastroTipoQuarto frm_CadastroTipoQuarto;
        Frm_ConsultaHospede Frm_ConsultaHospede;
        //Frm_ConsultaReserva frm_ConsultaReserva;
        //Frm_ConsultaQuarto frm_ConsultaQuarto;
        //Frm_ConsultaPagamento frm_ConsultaPagamento;
        public Frm_Principal()
        {
            Frm_CadastroHospede = new Frm_CadastroHospede();
            //frm_CadastroQuarto = new Frm_CadastroQuarto();
            //frm_FazerReserva = new Frm_FazerReserva();
            //frm_CadastroUsuario = new Frm_CadastroUsuario();
            //frm_CadastroTipoQuarto = new Frm_CadastroTipoQuarto();
            Frm_ConsultaHospede = new Frm_ConsultaHospede();            
            //frm_ConsultaReserva = new Frm_ConsultaReserva();
            //frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            //frm_ConsultaPagamento = new Frm_ConsultaPagamento();
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroHospede.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsultaHospede.ShowDialog();
        }
    }
}
