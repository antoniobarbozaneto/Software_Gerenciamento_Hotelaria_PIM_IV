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
            EscondeColunas();
            CarregaListaQuarto();            
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView_Quartos.CurrentRow.Cells[2].Value.ToString() == "OCUPADO")
            {
                MessageBox.Show("Quarto está reservado no momento não é permitido a exclusão.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Quarto.Numero = dataGridView_Quartos.CurrentRow.Cells[0].Value.ToString();
                var ResultResp = MessageBox.Show("Deseja realmente excluir o quarto número: "+Quarto.Numero+" selecionado?", "Exclusão Quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ResultResp == System.Windows.Forms.DialogResult.Yes)
                {
                    Ctr_Quarto.Excluir(Quarto);
                    CarregaListaQuarto();
                }
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
                EscondeColunas();
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

            if (dataGridView_Quartos.DataSource == null)
            {
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
            }
            else
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
            }
            EscondeColunas();
        }
        public void SetaSetaDadosGridParaForms()
        {
            Frm_CadastroQuarto.txb_NumQuarto.Text = dataGridView_Quartos.CurrentRow.Cells[0].Value.ToString();
            Frm_CadastroQuarto.txb_Andar.Text = dataGridView_Quartos.CurrentRow.Cells[1].Value.ToString();
            Frm_CadastroQuarto.cbx_Tipo.Text = dataGridView_Quartos.CurrentRow.Cells[3].Value.ToString();
            Frm_CadastroQuarto.ShowDialog();
        }

        public void EscondeColunas()
        {
            if (dataGridView_Quartos.Columns.Count > 3)
            {
               dataGridView_Quartos.Columns["Qtd_Max"].Visible = false;
               dataGridView_Quartos.Columns["Valor_Diaria"].Visible = false;
               dataGridView_Quartos.Columns["Refeicao"].Visible = false;
               dataGridView_Quartos.Columns[3].Width = 320;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView_Quartos.CurrentRow.Cells[2].Value.ToString() == "OCUPADO")
            {
                MessageBox.Show("Quato indisponível, por favor escolha outro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.OK; // para indicar ao Form chamador que o usuário adicionou um cliente
                this.Close();
            }                
        }
    }
}
