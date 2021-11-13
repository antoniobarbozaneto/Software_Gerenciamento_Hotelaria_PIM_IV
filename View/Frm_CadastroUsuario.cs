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
    public partial class Frm_CadastroUsuario : Form
    {
        Usuario Usuario;
        Ctr_Usuario Ctr_Usuario;
        public Frm_CadastroUsuario()
        {
            Ctr_Usuario = new Ctr_Usuario();
            Usuario = new Usuario();
            InitializeComponent();
        }

        private void Frm_CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            Usuario.User = txb_Usuario.Text;
            Usuario.Senha = txb_Senha.Text;

            if (VerificaCampos() == true)
            {
                if (txb_Codigo.Text == "")
                {
                    Ctr_Usuario.Incluir(Usuario);
                    LimparCampos();
                }
                else
                {
                    Usuario.Id = Convert.ToInt32(txb_Codigo.Text);
                    Ctr_Usuario.Alterar(Usuario);
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

        //mtd uteis
        public void LimparCampos()
        {
            txb_Usuario.Text = "";
            txb_Senha.Text = "";
        }
        public bool VerificaCampos()
        {
            bool res;
            if (txb_Usuario.Text != "" && txb_Senha.Text != "")
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
    }
}
