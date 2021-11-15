using Software_Gerenciamento_Hotelaria_PIM_IV.Control;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
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
        Reserva Reserva;
        Ctr_Reserva Ctr_Reserva;
        public Frm_FazerReserva()
        {
            Frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            Frm_ConsultaHospede = new Frm_ConsultaHospede();
            Reserva = new Reserva();
            Ctr_Reserva = new Ctr_Reserva();
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
                txb_IdHospede.Text = Frm_ConsultaHospede.dataGridView_Hospedes.CurrentRow.Cells[0].Value.ToString();
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
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos() == true)
            {
                Reserva.Dt_Checkin = DateTime.Parse(maskedtxb_dtCheckin.Text);
                Reserva.Dt_Checkout = DateTime.Parse(maskedtxb_dtCheckout.Text);
                Reserva.Qtd_Hospede = Convert.ToInt32(txb_QtdHospede.Text);
                Reserva.Tipo = txb_TipoQuarto.Text;
                //
                if (Ctr_Reserva.Verifica_QtdHospede(Reserva) == false)
                {
                    MessageBox.Show("Quantidade de hóspedes não permitida para este tipo de quarto, por favor escolha outro.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txb_ValorTotal.Text = Convert.ToString(Ctr_Reserva.Calc_Valor_Reserva(Reserva));
                    if (MessageBox.Show("Valor total da reserva ficou : "+txb_ValorTotal.Text+" \n Deseja confirmar a reserva?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Gravar no banco
                        MessageBox.Show("Reserva efetuada com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Reserva cancelada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }

                }
            }
        }

        //mtd uteis
        public void LimparCampos()
        {
            txb_IdHospede.Text = "";
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
        public bool VerificaCampos()
        {
            bool res;
            if (txb_IdHospede.Text != "" && txb_Nome.Text != "" && txb_NumQuarto.Text != "" && txb_TipoQuarto.Text != "" && maskedtxb_dtCheckin.MaskCompleted && maskedtxb_dtCheckout.MaskCompleted && txb_QtdHospede.Text != "" &&  (maskedtxb_Cpf.MaskCompleted || maskedtxb_Passaporte.MaskCompleted))
            {
                res = true; //Está tudo preenchido!
            }
            else
            {
                res = false;
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return res;
        }
    }
}
