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
    public partial class Frm_CadastroHospede : Form
    {
        Hospede Hospede;
        Ctr_Hospede Ctr_Hospede;
        public Frm_CadastroHospede()
        {
            Hospede = new Hospede();
            Ctr_Hospede = new Ctr_Hospede();
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {                
                Hospede.Nome = txb_Nome.Text;
                Hospede.Dt_Nascimento = maskedtxb_DtNasc.Text;
                Hospede.RG = maskedtxb_Rg.Text;
                Hospede.Cpf = maskedtxb_Cpf.Text;
                Hospede.Passaporte = maskedtxb_Passaporte.Text;
                Hospede.Rua = txb_Rua.Text;
                Hospede.Num = txb_Numero.Text;
                Hospede.Bairro = txb_Bairro.Text;
                Hospede.Cidade = txb_Cidade.Text;
                Hospede.Cep = maskedtxb_Cep.Text;
                Hospede.Telefone = maskedtxb_Telefone.Text;
                Hospede.Celular_Um = maskedtxb_CelularUm.Text;
                Hospede.Celular_Dois = maskedtxb_CelularDois.Text;
                Hospede.Email = txb_Email.Text;
                Hospede.Obs = txb_Obs.Text;

            if (VerificaCampos() == true)
            {
                if (txb_Codigo.Text == "") 
                { 
                    //Create!
                    Ctr_Hospede.Incluir(Hospede);
                    LimparCampos();
                }
                else
                {
                    //Update!  
                    Hospede.Id_Hospede = Convert.ToInt32(txb_Codigo.Text);
                    Ctr_Hospede.Alterar(Hospede);                    
                }

            }
        }

        private void Frm_CadastroHospede_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Métodos úteis
        public void LimparCampos()
        {
            txb_Nome.Text = "";
            maskedtxb_DtNasc.Text = "";
            maskedtxb_Rg.Text = "";
            maskedtxb_Cpf.Text = "";
            maskedtxb_Passaporte.Text = "";
            txb_Rua.Text = "";
            txb_Numero.Text = "";
            txb_Bairro.Text = "";
            txb_Cidade.Text = "";
            maskedtxb_Cep.Text = "";
            maskedtxb_Telefone.Text = "";
            maskedtxb_CelularUm.Text = "";
            maskedtxb_CelularDois.Text = "";
            txb_Email.Text = "";
            txb_Obs.Text = "";
        }
        public bool VerificaCampos()
        {
            bool res;
            if (txb_Nome.Text != null && maskedtxb_DtNasc.MaskCompleted && (maskedtxb_Cpf.MaskCompleted || maskedtxb_Passaporte.MaskCompleted))
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

        private void checkBox_Estrang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Estrang.Checked)
            {
                maskedtxb_Passaporte.ReadOnly = false;
                maskedtxb_Cpf.ReadOnly = true;
                maskedtxb_Cpf.Text = "";
            }
            else
            {
                maskedtxb_Passaporte.ReadOnly = true;
                maskedtxb_Cpf.ReadOnly = false;
                maskedtxb_Passaporte.Text = "";
            }
        }
    }
}
