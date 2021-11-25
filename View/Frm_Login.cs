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
    public partial class Frm_Login : Form
    {
        Frm_Principal Frm_Principal;
        Ctr_Usuario Ctr_Usuario;
        Usuario Usuario;
        Frm_ConsultaUsuario Frm_ConsultaUsuario;
        public Frm_Login()
        {
            Frm_Principal = new Frm_Principal();
            Frm_ConsultaUsuario = new Frm_ConsultaUsuario();
            Usuario = new Usuario();
            Ctr_Usuario = new Ctr_Usuario();
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Login();            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        //mtds uteis
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
                MessageBox.Show("Preencha os Campos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return res;
        }
        public void Login()
        {            
            if (VerificaCampos() == true)
            {
                Usuario.User = txb_Usuario.Text;
                Usuario.Senha = txb_Senha.Text;
                Usuario.Id_UserLogado = Ctr_Usuario.Obter_IdUser(Usuario);
                if (Ctr_Usuario.FazerLogin(Usuario) == true)
                {
                    if(Ctr_Usuario.Verifica_Ativo_Inativo(Usuario) == true)
                    {
                        this.Hide();
                        Frm_Principal.lbl_User.Text = Usuario.User;
                        Frm_Principal.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Este usuário está inativo, tente outro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txb_Usuario.Text = "";
                        txb_Senha.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado, verifique login ou senha!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txb_Usuario.Text = "";
                    txb_Senha.Text = "";
                }
            }
        }
    }
}
