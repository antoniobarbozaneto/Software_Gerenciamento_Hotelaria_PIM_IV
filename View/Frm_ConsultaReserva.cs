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
    public partial class Frm_ConsultaReserva : Form
    {
        Reserva Reserva;
        Ctr_Reserva Ctr_Reserva;
        Frm_Pagamento Frm_Pagamento;
        public Frm_ConsultaReserva()
        {
            Reserva = new Reserva();
            Ctr_Reserva = new Ctr_Reserva();
            Frm_Pagamento = new Frm_Pagamento();
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string ParamWhere;
            string ParamBusca;

            ParamBusca = txb_Consulta.Text;
            ParamWhere = cbx_FiltroReserva.Text;

            if (ParamWhere != "")
            {
                dataGridView_Reservas.DataSource = Ctr_Reserva.BuscarReserva(ParamBusca, ParamWhere);
                EscondeColunas();
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Tipo Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_DarBaixa_Click(object sender, EventArgs e)
        {
            SetaDadosGridParaForms();
            CarregaListReserva();

        }
        private void Frm_ConsultaReserva_Load(object sender, EventArgs e)
        {
            CarregaListReserva();            
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            CarregaListReserva();
        }

        //mtds uteis
        public void CarregaListReserva()
        {
            dataGridView_Reservas.DataSource = Ctr_Reserva.Carrega_Reserva();

            if (dataGridView_Reservas.DataSource == null)
            {
                btn_DarBaixa.Enabled = false;
            }
            else
            {
                dataGridView_Reservas.Columns[0].Width = 120;
                dataGridView_Reservas.Columns[21].HeaderText = "Número Quarto";
                btn_DarBaixa.Enabled = true;
            }
            EscondeColunas();
        }
        public void EscondeColunas()
        {
            if (dataGridView_Reservas.Columns.Count > 0)
            {
                dataGridView_Reservas.Columns["Qtd_Max"].Visible = false;
                dataGridView_Reservas.Columns["Qtd_Hospede"].Visible = false;
                dataGridView_Reservas.Columns["Nome"].Visible = false;
                dataGridView_Reservas.Columns["Dt_Nascimento"].Visible = false;
                dataGridView_Reservas.Columns["RG"].Visible = false;
                dataGridView_Reservas.Columns["Cpf"].Visible = false;
                dataGridView_Reservas.Columns["Passaporte"].Visible = false;
                dataGridView_Reservas.Columns["Rua"].Visible = false;
                dataGridView_Reservas.Columns["Num"].Visible = false;
                dataGridView_Reservas.Columns["Bairro"].Visible = false;
                dataGridView_Reservas.Columns["Cidade"].Visible = false;
                dataGridView_Reservas.Columns["Cep"].Visible = false;
                dataGridView_Reservas.Columns["Telefone"].Visible = false;
                dataGridView_Reservas.Columns["Celular_Um"].Visible = false;
                dataGridView_Reservas.Columns["Celular_Dois"].Visible = false;
                dataGridView_Reservas.Columns["Email"].Visible = false;
                dataGridView_Reservas.Columns["Obs"].Visible = false;
                dataGridView_Reservas.Columns["Andar"].Visible = false;
                dataGridView_Reservas.Columns["Status"].Visible = false;
                dataGridView_Reservas.Columns["Tipo"].Visible = false;
                dataGridView_Reservas.Columns["Refeicao"].Visible = false;
                dataGridView_Reservas.Columns["Valor_Diaria"].Visible = false;
                //
                dataGridView_Reservas.Columns[0].Width = 120;
                dataGridView_Reservas.Columns[22].HeaderText = "Número Quarto";
            }
        }
        public void SetaDadosGridParaForms()
        {
            Frm_Pagamento.txb_NumReserva.Text = dataGridView_Reservas.CurrentRow.Cells[0].Value.ToString();
            Frm_Pagamento.txb_ValorTotal.Text = dataGridView_Reservas.CurrentRow.Cells[4].Value.ToString();
            Frm_Pagamento.ShowDialog();
        }
    }
}
