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
    public partial class Frm_CadastroTipoQuarto : Form
    {
        TipoQuarto TipoQuarto;
        Ctr_TipoQuarto Ctr_TipoQuarto;
        public Frm_CadastroTipoQuarto()
        {
            TipoQuarto = new TipoQuarto();
            Ctr_TipoQuarto = new Ctr_TipoQuarto();
            InitializeComponent();
        }

        private void Frm_CadastroTipoQuarto_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            TipoQuarto.Tipo = txb_Tipo.Text;
            TipoQuarto.Qtd_Max = Convert.ToInt32(txb_QtdHospede.Text);
            TipoQuarto.Valor_Diaria = Convert.ToDouble(txb_ValorDiaria.Text);
            //TipoQuarto.Refeicao = Refeicao
            if (ckb_CafeDaManha.Checked)
            {
                TipoQuarto.Refeicao = " Café da Manhã ";
            }
            if (ckb_Almoco.Checked)
            {
                TipoQuarto.Refeicao = TipoQuarto.Refeicao + " Almoço "; 
            }
            if (ckb_Jantar.Checked)
            {
                TipoQuarto.Refeicao = TipoQuarto.Refeicao + " Jantar "; 
            }

            if(!ckb_CafeDaManha.Checked && !ckb_Almoco.Checked && !ckb_Jantar.Checked)
            {
                TipoQuarto.Refeicao = "Nenhuma";
            }

            if (VerificaCampos() == true)
            {
                if (txb_Codigo.Text == "")
                {
                    //Create!
                    Ctr_TipoQuarto.Incluir(TipoQuarto);
                    LimparCampos();
                }
                else
                {
                    //Update!  
                    TipoQuarto.Id_TipoQuarto = Convert.ToInt32(txb_Codigo.Text);
                    Ctr_TipoQuarto.Alterar(TipoQuarto);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Métodos úteis
        public void LimparCampos()
        {
            txb_Tipo.Text = "";
            txb_QtdHospede.Text = "";
            txb_ValorDiaria.Text = "";
            ckb_CafeDaManha.Checked = false;
            ckb_Almoco.Checked = false;
            ckb_Jantar.Checked = false;
        }

        public bool VerificaCampos()
        {
            bool res;
            if (txb_Tipo.Text != null && txb_QtdHospede.Text != null && txb_ValorDiaria.Text != null)
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
