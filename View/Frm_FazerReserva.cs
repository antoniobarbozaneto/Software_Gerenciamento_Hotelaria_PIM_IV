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
        Frm_ConsultaQuarto Frm_ConsultaQuarto;
        Frm_ConsultaHospede Frm_ConsultaHospede;
        public Frm_FazerReserva()
        {
            Frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            Frm_ConsultaHospede = new Frm_ConsultaHospede();
            InitializeComponent();
        }

        private void btn_BuscarHospede_Click(object sender, EventArgs e)
        {
            Frm_ConsultaHospede.btn_Confirmar.Visible = true;
            Frm_ConsultaHospede.btn_Atualizar.Visible = false;
            Frm_ConsultaHospede.btn_Editar.Visible = false;
            Frm_ConsultaHospede.btn_Excluir.Visible = false;

            if (Frm_ConsultaHospede.ShowDialog() == DialogResult.OK)
            {
                txb_Nome.Text = Frm_ConsultaHospede.dataGridView_Hospedes.CurrentRow.Cells[1].Value.ToString();
                maskedtxb_Cpf.Text = Frm_ConsultaHospede.dataGridView_Hospedes.CurrentRow.Cells[4].Value.ToString();
                maskedtxb_Passaporte.Text = Frm_ConsultaHospede.dataGridView_Hospedes.CurrentRow.Cells[5].Value.ToString();
            }           
        }

        private void btn_BuscarQuarto_Click(object sender, EventArgs e)
        {
            Frm_ConsultaQuarto.btn_Confirmar.Visible = true;
            Frm_ConsultaQuarto.btn_Atualizar.Visible = false;
            Frm_ConsultaQuarto.btn_Editar.Visible = false;
            Frm_ConsultaQuarto.btn_Excluir.Visible = false;

            if (Frm_ConsultaQuarto.ShowDialog() == DialogResult.OK)
            {
                txb_NumQuarto.Text = Frm_ConsultaQuarto.dataGridView_Quartos.CurrentRow.Cells[0].Value.ToString();
                txb_TipoQuarto.Text = Frm_ConsultaQuarto.dataGridView_Quartos.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        
        //mtd uteis
        public void LimparCampos()
        {
            txb_Nome.Text = "";
            maskedtxb_Cpf.Text = "";
            maskedtxb_Passaporte.Text = "";
            txb_NumQuarto.Text = "";
            txb_TipoQuarto.Text = "";
            maskedtxb_dtCheckin.Text = "";
            maskedtxb_dtCheckout.Text = "";
            txb_QtdHospede.Text = "";
            txb_ValorTotal.Text = "";
        }
    }
}
