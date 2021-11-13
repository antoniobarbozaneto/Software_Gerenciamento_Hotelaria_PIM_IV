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
        public Frm_ConsultaUsuario()
        {
            Usuario = new Usuario();
            Ctr_Usuario = new Ctr_Usuario();
            Frm_CadastroUsuario = new Frm_CadastroUsuario();
            InitializeComponent();
        }

        private void Frm_ConsultaUsuario_Load(object sender, EventArgs e)
        {
            CarregaListaUsuario();
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

            var ResultResp = MessageBox.Show("Deseja realmente excluir o usuário selecionado?", "Exclusão Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResultResp == System.Windows.Forms.DialogResult.Yes)
            {
                Ctr_Usuario.Excluir(Usuario);
                CarregaListaUsuario();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string ParamWhere;
            string ParamBusca;

            ParamBusca = txb_Consulta.Text;
            ParamWhere = cbx_FiltroUsuario.Text;

            if (ParamWhere != "")
            {
                dataGridView_Usuarios.DataSource = Ctr_Usuario.Busca_Hospede(ParamBusca, ParamWhere);
            }
            else
            {
                MessageBox.Show("Escolha uma opção no filtro", "Busca Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //mtds uteis
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
    }
}
