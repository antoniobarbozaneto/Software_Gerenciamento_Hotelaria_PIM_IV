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
    public partial class Frm_ConsultaUsuario : Form
    {
        Usuario Usuario;
        Ctr_Usuario Ctr_Usuario;
        Frm_CadastroUsuario Frm_CadastroUsuario;
        public static string lblUser;
        public Frm_ConsultaUsuario()
        {
            Usuario = new Usuario();
            Ctr_Usuario = new Ctr_Usuario();
            Frm_CadastroUsuario = new Frm_CadastroUsuario();
            //Frm_Principal = new Frm_Principal();
            InitializeComponent();
        }

        private void Frm_ConsultaUsuario_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaListaUsuario();
            EscondeColunas();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            CarregaListaUsuario();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            SetaDadosGridParaForms();
            CarregaListaUsuario();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Usuario.Id = Convert.ToInt32(dataGridView_Usuarios.CurrentRow.Cells[0].Value.ToString());                       

            if (lblUser == Convert.ToString(dataGridView_Usuarios.CurrentRow.Cells[1].Value.ToString()))
            {
                MessageBox.Show("Usuário está em uso no momento, não é possivel excluir!", "Exclusão Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Ctr_Usuario.Verifica_SituacaoHospede(Usuario) == true)
                {
                    MessageBox.Show("Este Usuário não pode ser excluido, é permitido apenas alterá-lo.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var ResultResp = MessageBox.Show("Deseja realmente excluir o usuário selecionado?", "Exclusão Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ResultResp == System.Windows.Forms.DialogResult.Yes)
                    {

                        Ctr_Usuario.Excluir(Usuario);
                        CarregaListaUsuario();
                    }
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (cbx_FiltroUsuario.SelectedIndex != -1)
            {
                Usuario.Id = 0;
                Usuario.User = "NULL";

                if(cbx_FiltroUsuario.Text == "Id")
                {
                    Usuario.Id = Convert.ToInt32(txb_Consulta.Text);
                }
                else
                {
                    if(cbx_FiltroUsuario.Text == "Usuario")
                    {
                        Usuario.User = txb_Consulta.Text;
                    }
                }
                dataGridView_Usuarios.DataSource = Ctr_Usuario.Busca_Hospede(Usuario);
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //mtds uteis
        public void LimparCampos()
        {
            cbx_FiltroUsuario.SelectedIndex = -1;
            txb_Consulta.Text = "";
        }
        public void CarregaListaUsuario()
        {
            dataGridView_Usuarios.DataSource = Ctr_Usuario.Carrega_Usuario();

            if (dataGridView_Usuarios.DataSource == null)
            {
                btn_Editar.Enabled = false;
                btn_Excluir.Enabled = false;
            }
            else
                dataGridView_Usuarios.Columns[2].Width = 420;
            {
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
            }
        }
        public void SetaDadosGridParaForms()
        {
            Frm_CadastroUsuario.txb_Codigo.Text = dataGridView_Usuarios.CurrentRow.Cells[0].Value.ToString();
            Frm_CadastroUsuario.txb_Usuario.Text = dataGridView_Usuarios.CurrentRow.Cells[1].Value.ToString();
            Frm_CadastroUsuario.txb_Senha.Text = dataGridView_Usuarios.CurrentRow.Cells[2].Value.ToString();
            
            Frm_CadastroUsuario.ShowDialog();
        }
        public void EscondeColunas()
        {
            if (dataGridView_Usuarios.Columns.Count > 0)
            {
                dataGridView_Usuarios.Columns["Id_UserLogado"].Visible = false;
            }
        }
    }
}
