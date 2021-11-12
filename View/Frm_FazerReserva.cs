using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    public partial class Frm_FazerReserva : Form
    {
        Frm_ConsultaHospede Frm_ConsultaHospede;
        Frm_ConsultaQuarto Frm_ConsultaQuarto;
        public Frm_FazerReserva()
        {
            Frm_ConsultaHospede = new Frm_ConsultaHospede();
            Frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            InitializeComponent();
        }

        private void btn_BuscarHospede_Click(object sender, EventArgs e)
        {
            Frm_ConsultaHospede.btn_Confirmar.Visible = true;
            Frm_ConsultaHospede.btn_Atualizar.Visible = false;
            Frm_ConsultaHospede.btn_Editar.Visible = false;
            Frm_ConsultaHospede.btn_Excluir.Visible = false;
            Frm_ConsultaHospede.ShowDialog();
        }

        private void btn_BuscarQuarto_Click(object sender, EventArgs e)
        {
            Frm_ConsultaQuarto.btn_Confirmar.Visible = true;
            Frm_ConsultaQuarto.btn_Atualizar.Visible = false;
            Frm_ConsultaQuarto.btn_Editar.Visible = false;
            Frm_ConsultaQuarto.btn_Excluir.Visible = false;
            Frm_ConsultaQuarto.ShowDialog();
        }
    }
}
