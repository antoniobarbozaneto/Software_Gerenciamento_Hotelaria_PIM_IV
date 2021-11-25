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
    public partial class Frm_ConsultaPagamento : Form
    {
        Pagamento Pagamento;
        Ctr_Pagamento Ctr_Pagamento;
        public Frm_ConsultaPagamento()
        {
            Pagamento = new Pagamento();
            Ctr_Pagamento = new Ctr_Pagamento();
            InitializeComponent();
        }

        private void Frm_ConsultaPagamento_Load(object sender, EventArgs e)
        {
            LimparCampos();            
            CarregaListaTipoQuarto();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cbx_FiltroPagamento.SelectedIndex != -1)
            {
                Pagamento.Nfe = 0;
                Pagamento.FormPagamento = "null";
                Pagamento.Dt_Pagamento = default;

                if(cbx_FiltroPagamento.Text == "NFE")
                {
                    Pagamento.Nfe = Convert.ToInt32(txb_Consulta.Text);
                }
                else
                {
                    if (cbx_FiltroPagamento.Text == "Numero Reserva")
                    {
                        Pagamento.Num_Reserva = Convert.ToInt32(txb_Consulta.Text);
                    }
                    else
                    {
                        if (cbx_FiltroPagamento.Text == "Forma Pagamento")
                        {
                            Pagamento.FormPagamento = txb_Consulta.Text;
                        }                        
                    }
                }
                dataGridView_Pagamentos.DataSource = Ctr_Pagamento.Busca_Pagamento(Pagamento);
                EsconderColunas();
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaListaTipoQuarto();

        }
        //mtds uteis
        public void LimparCampos()
        {
            txb_Consulta.Text = "";
            cbx_FiltroPagamento.SelectedIndex = -1;
        }
        public void CarregaListaTipoQuarto()
        {
            dataGridView_Pagamentos.DataSource = Ctr_Pagamento.Carrega_Pagamento();
            EsconderColunas();
        }
        public void EsconderColunas()
        {
            if (dataGridView_Pagamentos.Columns.Count > 5)
            {
                dataGridView_Pagamentos.Columns["Qtd_Max"].Visible = false;
                dataGridView_Pagamentos.Columns["Qtd_Hospede"].Visible = false;
                dataGridView_Pagamentos.Columns["Nome"].Visible = false;
                dataGridView_Pagamentos.Columns["Dt_Nascimento"].Visible = false;
                dataGridView_Pagamentos.Columns["RG"].Visible = false;
                dataGridView_Pagamentos.Columns["Cpf"].Visible = false;
                dataGridView_Pagamentos.Columns["Passaporte"].Visible = false;
                dataGridView_Pagamentos.Columns["Rua"].Visible = false;
                dataGridView_Pagamentos.Columns["Num"].Visible = false;
                dataGridView_Pagamentos.Columns["Bairro"].Visible = false;
                dataGridView_Pagamentos.Columns["Cidade"].Visible = false;
                dataGridView_Pagamentos.Columns["Cep"].Visible = false;
                dataGridView_Pagamentos.Columns["Telefone"].Visible = false;
                dataGridView_Pagamentos.Columns["Celular_Um"].Visible = false;
                dataGridView_Pagamentos.Columns["Celular_Dois"].Visible = false;
                dataGridView_Pagamentos.Columns["Email"].Visible = false;
                dataGridView_Pagamentos.Columns["Obs"].Visible = false;
                dataGridView_Pagamentos.Columns["Andar"].Visible = false;
                dataGridView_Pagamentos.Columns["Status"].Visible = false;
                dataGridView_Pagamentos.Columns["Tipo"].Visible = false;
                dataGridView_Pagamentos.Columns["Refeicao"].Visible = false;
                dataGridView_Pagamentos.Columns["Valor_Diaria"].Visible = false;
                dataGridView_Pagamentos.Columns["Situacao"].Visible = false;
                dataGridView_Pagamentos.Columns["Situacao_h"].Visible = false;
                dataGridView_Pagamentos.Columns["Status_Reserva"].Visible = false;
                dataGridView_Pagamentos.Columns["Id_Hospede"].Visible = false;
                dataGridView_Pagamentos.Columns["Numero"].Visible = false;
                dataGridView_Pagamentos.Columns["Dt_Checkin"].Visible = false;
                dataGridView_Pagamentos.Columns["Dt_Checkout"].Visible = false;
                dataGridView_Pagamentos.Columns["Id"].Visible = false;
                dataGridView_Pagamentos.Columns["Senha"].Visible = false;
                dataGridView_Pagamentos.Columns["User"].Visible = false;
                dataGridView_Pagamentos.Columns["Id_UserLogado"].Visible = false;
                dataGridView_Pagamentos.Columns["Situacao_U"].Visible = false;                
            }
        }
    }
}
