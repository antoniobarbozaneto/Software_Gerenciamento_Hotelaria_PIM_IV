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
    public partial class Frm_CadastroQuarto : Form
    {
        Quarto Quarto;
        Ctr_Quarto Ctr_Quarto;
        bool ver_resp;
        public Frm_CadastroQuarto()
        {
            Quarto = new Quarto();
            Ctr_Quarto = new Ctr_Quarto();
            InitializeComponent();
        }

        private void Frm_CadastroQuarto_Load(object sender, EventArgs e)
        {
            ver_resp = Verifica_CreateOrUpdate();
            cbx_Tipo.DataSource = Ctr_Quarto.Buscar_TipoQuarto();
            cbx_Tipo.ValueMember = "Tipo"; //Seleciona os Tipos da Lista
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos() == true)
            {
                Quarto.Numero = txb_NumQuarto.Text;
                Quarto.Andar = txb_Andar.Text;
                Quarto.Status = "Disponível";
                Quarto.Tipo = cbx_Tipo.Text;

                if (ver_resp == true)
                {
                    //Create!
                    Ctr_Quarto.Incluir(Quarto);
                    LimparCampos();
                }
                else
                {
                    //Update!
                    Ctr_Quarto.Alterar(Quarto);
                }
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //mtd úteis
        public void LimparCampos()
        {
            txb_NumQuarto.Text = "";
            txb_Andar.Text = "";
            cbx_Tipo.Text = "";
            txb_QtdHospede.Text = "";
            txb_ValorDiaria.Text = "";
        }
        //
        public bool VerificaCampos()
        {
            bool res;
            if (txb_NumQuarto.Text != "" && txb_Andar.Text != "" && cbx_Tipo.Text != "")
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
            if (txb_NumQuarto.Text == "")
            {
                aux = true; //Create
            }
            else
            {
                aux = false; //Update
            }
            return aux;
        }

        private void cbx_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Quarto> Lista_QtdH_ValorD;

            txb_QtdHospede.DataBindings.Clear();
            txb_ValorDiaria.DataBindings.Clear();

            Lista_QtdH_ValorD = Ctr_Quarto.Buscar_QtdHospedeMax_ValorDiaria(cbx_Tipo.Text);

            if (Lista_QtdH_ValorD != null)
            {
                txb_QtdHospede.DataBindings.Add("Text", Lista_QtdH_ValorD, "Qtd_Max");
                txb_ValorDiaria.DataBindings.Add("Text", Lista_QtdH_ValorD, "Valor_Diaria");
            }  
        }
    }
}
