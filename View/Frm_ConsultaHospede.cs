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
    public partial class Frm_ConsultaHospede : Form
    {
        Hospede Hospede;
        Ctr_Hospede Ctr_Hospede;
        Frm_CadastroHospede Frm_CadastroHospede;
        public Frm_ConsultaHospede()
        {
            Hospede = new Hospede();
            Ctr_Hospede = new Ctr_Hospede();
            Frm_CadastroHospede = new Frm_CadastroHospede();
            InitializeComponent();
        }

        private void Frm_ConsultaHospede_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaListaHospede();           

        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            CarregaListaHospede();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            SetaDadosGridParaForms();
            CarregaListaHospede();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Hospede.Id_Hospede = Convert.ToInt32(dataGridView_Hospedes.CurrentRow.Cells[0].Value.ToString());

            if (Ctr_Hospede.Verifica_SituacaoHospede(Hospede) == true)
            {
                MessageBox.Show("Este hóspede não pode ser excluido, é permitido apenas alterá-lo.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var ResultResp = MessageBox.Show("Deseja realmente excluir o cliente selecionado?", "Exclusão Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ResultResp == System.Windows.Forms.DialogResult.Yes)
                {
                    Ctr_Hospede.Excluir(Hospede);
                    CarregaListaHospede();
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cbx_FiltroHospede.SelectedIndex != -1)
            {
                Hospede.Nome = "null";
                Hospede.Cpf = "null";
                Hospede.RG = "null";
                Hospede.Passaporte = "null";
                if (cbx_FiltroHospede.Text == "Nome")
                {
                    Hospede.Nome = txb_Consulta.Text;
                }
                else
                {
                    if (cbx_FiltroHospede.Text == "Cpf")
                    {
                        Hospede.Cpf = txb_Consulta.Text;
                    }
                    else
                    {
                        if (cbx_FiltroHospede.Text == "Rg")
                        {
                            Hospede.RG = txb_Consulta.Text;
                        }
                        else
                        {
                            if (cbx_FiltroHospede.Text == "Passaporte")
                            {
                                Hospede.Passaporte = txb_Consulta.Text;
                            }
                        }
                    }
                }
                dataGridView_Hospedes.DataSource = Ctr_Hospede.Busca_Hospede(Hospede);
                //EsconderColunas();
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
        }

        //mtds uteis
        public void LimparCampos()
        {
            txb_Consulta.Text = "";
            cbx_FiltroHospede.SelectedIndex = -1;
        }
        public void CarregaListaHospede()
        {
            dataGridView_Hospedes.DataSource = Ctr_Hospede.Carrega_Hospede();

            if (dataGridView_Hospedes.DataSource == null)
            {
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
            }
            else
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                EsconderColunas();
            }
        }
        public void EsconderColunas()
        {
            dataGridView_Hospedes.Columns["Numero"].Visible = false;
            dataGridView_Hospedes.Columns["Andar"].Visible = false;
            dataGridView_Hospedes.Columns["Status"].Visible = false;
            dataGridView_Hospedes.Columns["Tipo"].Visible = false;
            dataGridView_Hospedes.Columns["Qtd_Max"].Visible = false;
            dataGridView_Hospedes.Columns["Valor_Diaria"].Visible = false;
            dataGridView_Hospedes.Columns["Refeicao"].Visible = false;
            dataGridView_Hospedes.Columns["Situacao"].Visible = false;
            dataGridView_Hospedes.Columns["Id"].Visible = false;
            dataGridView_Hospedes.Columns["Senha"].Visible = false;
            dataGridView_Hospedes.Columns["User"].Visible = false;
            dataGridView_Hospedes.Columns["Id_UserLogado"].Visible = false;
            dataGridView_Hospedes.Columns["Situacao_U"].Visible = false;
        }

        public void SetaDadosGridParaForms()
        {
            Frm_CadastroHospede.txb_Codigo.Text = dataGridView_Hospedes.CurrentRow.Cells[0].Value.ToString();
            Frm_CadastroHospede.txb_Nome.Text = dataGridView_Hospedes.CurrentRow.Cells[1].Value.ToString();
            Frm_CadastroHospede.maskedtxb_DtNasc.Text = dataGridView_Hospedes.CurrentRow.Cells[2].Value.ToString();
            Frm_CadastroHospede.maskedtxb_Rg.Text = dataGridView_Hospedes.CurrentRow.Cells[3].Value.ToString();
            Frm_CadastroHospede.maskedtxb_Cpf.Text = dataGridView_Hospedes.CurrentRow.Cells[4].Value.ToString();
            Frm_CadastroHospede.maskedtxb_Passaporte.Text = dataGridView_Hospedes.CurrentRow.Cells[5].Value.ToString();
            Frm_CadastroHospede.txb_Rua.Text = dataGridView_Hospedes.CurrentRow.Cells[6].Value.ToString();
            Frm_CadastroHospede.txb_Numero.Text = dataGridView_Hospedes.CurrentRow.Cells[7].Value.ToString();
            Frm_CadastroHospede.txb_Bairro.Text = dataGridView_Hospedes.CurrentRow.Cells[8].Value.ToString();
            Frm_CadastroHospede.txb_Cidade.Text = dataGridView_Hospedes.CurrentRow.Cells[9].Value.ToString();
            Frm_CadastroHospede.maskedtxb_Cep.Text = dataGridView_Hospedes.CurrentRow.Cells[10].Value.ToString();
            Frm_CadastroHospede.maskedtxb_Telefone.Text = dataGridView_Hospedes.CurrentRow.Cells[11].Value.ToString();
            Frm_CadastroHospede.maskedtxb_CelularUm.Text = dataGridView_Hospedes.CurrentRow.Cells[12].Value.ToString();
            Frm_CadastroHospede.maskedtxb_CelularDois.Text = dataGridView_Hospedes.CurrentRow.Cells[13].Value.ToString();
            Frm_CadastroHospede.txb_Email.Text = dataGridView_Hospedes.CurrentRow.Cells[14].Value.ToString();
            Frm_CadastroHospede.txb_Obs.Text = dataGridView_Hospedes.CurrentRow.Cells[15].Value.ToString();
            Frm_CadastroHospede.cbx_Situacao.Text = dataGridView_Hospedes.CurrentRow.Cells[16].Value.ToString();
            Frm_CadastroHospede.ShowDialog();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // para indicar ao Form chamador que o usuário adicionou um cliente
            this.Close();
        }
    }
}
