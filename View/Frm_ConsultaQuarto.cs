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
    public partial class Frm_ConsultaQuarto : Form
    {
        Quarto Quarto;
        Ctr_Quarto Ctr_Quarto;
        Frm_CadastroQuarto Frm_CadastroQuarto;

        public Frm_ConsultaQuarto()
        {
            Quarto = new Quarto();
            Ctr_Quarto = new Ctr_Quarto();
            Frm_CadastroQuarto = new Frm_CadastroQuarto();
            InitializeComponent();
            
        }

        private void Frm_ConsultaQuarto_Load(object sender, EventArgs e)
        {
            CarregaListaQuarto();            
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Quarto.Numero = dataGridView_Quartos.CurrentRow.Cells[0].Value.ToString();

            var ResultResp = MessageBox.Show("Deseja realmente excluir o Quarto selecionado?", "Exclusão Quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResultResp == System.Windows.Forms.DialogResult.Yes)
            {
                Ctr_Quarto.Excluir(Quarto);
                CarregaListaQuarto();
            }
        }        

        private void btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            CarregaListaQuarto();            
        }

        private void btn_Editar_Click_1(object sender, EventArgs e)
        {
            SetaSetaDadosGridParaForms();
            CarregaListaQuarto();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            string ParamWhere;
            string ParamBusca;

            ParamBusca = txb_Consulta.Text;
            ParamWhere = cbx_FiltroTipoQuarto.Text;

            if (ParamWhere != "")
            {
                dataGridView_Quartos.DataSource = Ctr_Quarto.Buscar_Quarto(ParamBusca, ParamWhere);
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Tipo Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //mtds uteis
        public void CarregaListaQuarto()
        {
            dataGridView_Quartos.DataSource = Ctr_Quarto.Carregar_Quarto();
            dataGridView_Quartos.Columns.Remove("Qtd_Max");
            dataGridView_Quartos.Columns.Remove("Valor_Diaria");
            dataGridView_Quartos.Columns.Remove("Refeicao");
        }
        public void SetaSetaDadosGridParaForms()
        {
            Frm_CadastroQuarto.txb_NumQuarto.Text = dataGridView_Quartos.CurrentRow.Cells[0].Value.ToString();
            Frm_CadastroQuarto.txb_Andar.Text = dataGridView_Quartos.CurrentRow.Cells[1].Value.ToString();
            Frm_CadastroQuarto.cbx_Tipo.Text = dataGridView_Quartos.CurrentRow.Cells[3].Value.ToString();

            Frm_CadastroQuarto.ShowDialog();
        }
    }
}
