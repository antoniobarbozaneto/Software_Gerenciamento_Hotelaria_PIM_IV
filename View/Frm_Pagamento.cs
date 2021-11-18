﻿using Software_Gerenciamento_Hotelaria_PIM_IV.Control;
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
    public partial class Frm_Pagamento : Form
    {
        Pagamento Pagamento;
        Ctr_Pagamento Ctr_Pagamento;
        public Frm_Pagamento()
        {
            Pagamento = new Pagamento();
            Ctr_Pagamento = new Ctr_Pagamento();
            InitializeComponent();
        }

        private void cbx_FormaPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_FormaPag.Text == "Dinheiro")
            {
                MessageBox.Show("Forma pagamento escolhida: Dinheiro", "Forma Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_ValorPago.Enabled = true;
                cbx_Parcelas.Enabled = false;
                txb_ValorPago.Text = "";
            }
            else
            {
                if (cbx_FormaPag.Text == "Cartão Débito")
                {
                    cbx_Parcelas.SelectedIndex = 0;
                    txb_Troco.Text = "0";
                    MessageBox.Show("Forma pagamento escolhida: Cartão Débito", "Forma Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information); cbx_Parcelas.Enabled = false;
                    txb_ValorPago.Enabled = false;
                    txb_ValorPago.Text = txb_ValorTotal.Text;
                }
                else
                {
                    if (cbx_FormaPag.Text == "Cartão Crédito")
                    {
                        cbx_Parcelas.SelectedIndex = 0;
                        txb_Troco.Text = "0";
                        MessageBox.Show("Forma pagamento escolhida: Cartão Crédito", "Forma Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information); cbx_Parcelas.Enabled = true;
                        txb_ValorPago.Enabled = false;
                        txb_ValorPago.Text = txb_ValorTotal.Text;
                    }
                }
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos() == true)
            {
                Pagamento.Numero = txb_NumReserva.Text;
                Pagamento.Dt_Pagamento = DateTime.Now;
                if (cbx_FormaPag.Text == "Cartão Débito")
                {
                    Pagamento.FormPagamento = cbx_FormaPag.Text;
                    Pagamento.Num_Reserva = Convert.ToInt32(txb_NumReserva.Text);
                    Pagamento.ValorTotal = Convert.ToDouble(txb_ValorTotal.Text);
                    txb_ValorPago.Text = Convert.ToString(Ctr_Pagamento.Realizar_Pagamento(Pagamento));
                    this.Close();
                }
                else
                {
                    if (cbx_FormaPag.Text == "Cartão Crédito")
                    {
                        Pagamento.FormPagamento = cbx_FormaPag.Text;
                        Pagamento.Num_Reserva = Convert.ToInt32(txb_NumReserva.Text);
                        Pagamento.ValorTotal = Convert.ToDouble(txb_ValorTotal.Text);
                        Pagamento.NumParcela = Convert.ToInt32(cbx_Parcelas.Text);
                        Pagamento.ValorPago = Convert.ToDouble(txb_ValorPago.Text);
                        txb_ValorParcela.Text = Convert.ToString(Ctr_Pagamento.Realizar_Pagamento(Pagamento));
                        this.Close();
                    }
                    else
                    {
                        if (cbx_FormaPag.Text == "Dinheiro")
                        {
                            Pagamento.FormPagamento = cbx_FormaPag.Text;
                            Pagamento.Num_Reserva = Convert.ToInt32(txb_NumReserva.Text);
                            Pagamento.ValorTotal = Convert.ToDouble(txb_ValorTotal.Text);
                            Pagamento.ValorPago = Convert.ToDouble(txb_ValorPago.Text);

                            if (Ctr_Pagamento.Realizar_Pagamento(Pagamento) == -1)
                            {
                                MessageBox.Show("Valor insuficiente, informe um novo valor!", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                txb_Troco.Text = Convert.ToString(Ctr_Pagamento.Realizar_Pagamento(Pagamento));
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            this.Close();
        }
        private void cbx_Parcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Parcelas.Text.Equals("0"))
            {
                txb_ValorParcela.Text = Convert.ToString(0);
            }
            else
            {
                Pagamento.FormPagamento = cbx_FormaPag.Text;
                Pagamento.Num_Reserva = Convert.ToInt32(txb_NumReserva.Text);
                Pagamento.ValorTotal = Convert.ToDouble(txb_ValorTotal.Text);
                Pagamento.NumParcela = Convert.ToInt32(cbx_Parcelas.Text);
                txb_ValorParcela.Text = Convert.ToString(Pagamento.ValorTotal / Pagamento.NumParcela);
            }
        }

        //mtd uteis
        public void LimparCampos()
        {
            txb_NumReserva.Text = "";
            cbx_FormaPag.Text = "";
            cbx_Parcelas.Text = "";
            txb_ValorParcela.Text = "";
            txb_ValorPago.Text = "";
            txb_ValorTotal.Text = "";
        }

        public bool VerificaCampos()
        {
            bool res;
            if (txb_NumReserva.Text != "" && cbx_FormaPag.Text != "" && txb_ValorTotal.Text != "" && txb_ValorPago.Text !="")
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