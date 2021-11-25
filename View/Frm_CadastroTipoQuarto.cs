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
        bool ver_resp;
        public Frm_CadastroTipoQuarto()
        {
            TipoQuarto = new TipoQuarto();
            Ctr_TipoQuarto = new Ctr_TipoQuarto();
            InitializeComponent();
        }

        private void Frm_CadastroTipoQuarto_Load(object sender, EventArgs e)        
        {

            ver_resp = Verifica_CreateOrUpdate();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos() == true)
            {
                TipoQuarto.Tipo = txb_Tipo.Text;
                TipoQuarto.Qtd_Max = Convert.ToInt32(txb_QtdHospede.Text);
                TipoQuarto.Valor_Diaria = Convert.ToDouble(txb_ValorDiaria.Text);

                if (ckb_CafeDaManha.Checked)
                {
                    TipoQuarto.Refeicao = " Café da Manhã ";
                }
                else
                {
                    TipoQuarto.Refeicao = "";
                }
                if (ckb_Almoco.Checked)
                {
                    if (!TipoQuarto.Refeicao.Contains(" Almoço "))
                    {
                        TipoQuarto.Refeicao = TipoQuarto.Refeicao + " Almoço ";
                    }
                }
                if (ckb_Jantar.Checked)
                {
                    if (!TipoQuarto.Refeicao.Contains(" Jantar "))
                    {
                        TipoQuarto.Refeicao = TipoQuarto.Refeicao + " Jantar ";
                    }
                }

                if (!ckb_CafeDaManha.Checked && !ckb_Almoco.Checked && !ckb_Jantar.Checked)
                {
                    TipoQuarto.Refeicao = "Nenhuma";
                }

                if (ver_resp == true)
                {
                    //Create!
                    Ctr_TipoQuarto.Incluir(TipoQuarto);
                    LimparCampos();
                }
                else
                {
                    //Update!  
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
        //
        public bool VerificaCampos()
        {
            bool res;
            if (txb_Tipo.Text != "" && txb_QtdHospede.Text != "" && txb_ValorDiaria.Text != "")
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
        //
        public bool Verifica_CreateOrUpdate()
        {
            bool aux;
            if(txb_Tipo.Text == "")
            {
                aux = true; //Create
            }
            else
            {
                aux = false; //Update
            }
            return aux;
        }
    }
}
