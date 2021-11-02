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
    public partial class Frm_ConsultaTipoQuarto : Form
    {
        TipoQuarto TipoQuarto;
        Ctr_TipoQuarto Ctr_TipoQuarto;
        Frm_CadastroTipoQuarto Frm_CadastroTipoQuarto;

        public Frm_ConsultaTipoQuarto()
        {
            TipoQuarto = new TipoQuarto();
            Ctr_TipoQuarto = new Ctr_TipoQuarto();
            Frm_CadastroTipoQuarto = new Frm_CadastroTipoQuarto();
            InitializeComponent();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            TipoQuarto.Id_TipoQuarto = Convert.ToInt32(dataGridView_TipoQuarto.CurrentRow.Cells[0].Value.ToString());

            var ResultResp = MessageBox.Show("Deseja realmente excluir o Tipo Quarto selecionado?", "Exclusão Tipo Quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResultResp == System.Windows.Forms.DialogResult.Yes)
            {
                Ctr_TipoQuarto.Excluir(TipoQuarto);
                CarregaListaTipoQuarto();
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            CarregaListaTipoQuarto();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            SetaDadosGridParaForms();
        }

        private void Frm_ConsultaTipoQuarto_Load(object sender, EventArgs e)
        {
            CarregaListaTipoQuarto();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string ParamWhere;
            string ParamBusca;

            ParamBusca = txb_Consulta.Text;
            ParamWhere = cbx_FiltroTipoQuarto.Text;

            if (ParamWhere != "")
            {
                dataGridView_TipoQuarto.DataSource = Ctr_TipoQuarto.Busca_TipoQuarto(ParamBusca, ParamWhere);
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Tipo Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //mtds uteis
        public void CarregaListaTipoQuarto()
        {
            dataGridView_TipoQuarto.DataSource = Ctr_TipoQuarto.Carrega_TipoQuarto();
        }
        public void SetaDadosGridParaForms()
        {
            string tempRef = "";

            Frm_CadastroTipoQuarto.txb_Codigo.Text = dataGridView_TipoQuarto.CurrentRow.Cells[0].Value.ToString();
            Frm_CadastroTipoQuarto.txb_Tipo.Text = dataGridView_TipoQuarto.CurrentRow.Cells[1].Value.ToString();
            Frm_CadastroTipoQuarto.txb_QtdHospede.Text = dataGridView_TipoQuarto.CurrentRow.Cells[2].Value.ToString();
            Frm_CadastroTipoQuarto.txb_ValorDiaria.Text = dataGridView_TipoQuarto.CurrentRow.Cells[3].Value.ToString();

            tempRef = dataGridView_TipoQuarto.CurrentRow.Cells[4].Value.ToString();
            Console.WriteLine(tempRef);

            if (tempRef.Contains("Café"))
            {
                Frm_CadastroTipoQuarto.ckb_CafeDaManha.Checked = true;
            }
            if (tempRef.Contains("Almoço"))
            {
                Frm_CadastroTipoQuarto.ckb_Almoco.Checked = true;
            }
            if (tempRef.Contains("Jantar"))
            {
                Frm_CadastroTipoQuarto.ckb_Jantar.Checked = true;
            }

            Frm_CadastroTipoQuarto.ShowDialog();
        }
    }
}
