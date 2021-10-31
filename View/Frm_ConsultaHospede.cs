using Software_Gerenciamento_Hotelaria_PIM_IV.Control;
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
    public partial class Frm_ConsultaHospede : Form
    {
        Ctr_Hospede Ctr_Hospede;

        public Frm_ConsultaHospede()
        {
            Ctr_Hospede = new Ctr_Hospede();
            InitializeComponent();
        }

        private void Frm_ConsultaHospede_Load(object sender, EventArgs e)
        {
            dataGridView_Hospedes.DataSource = Ctr_Hospede.Carrega_Hospede();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            dataGridView_Hospedes.DataSource = Ctr_Hospede.Carrega_Hospede();
        }
    }
}
