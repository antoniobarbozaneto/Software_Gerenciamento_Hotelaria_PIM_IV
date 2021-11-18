using Software_Gerenciamento_Hotelaria_PIM_IV.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Gerenciamento_Hotelaria_PIM_IV
{
    public partial class Frm_Principal : Form
    {
        Frm_CadastroHospede Frm_CadastroHospede;
        Frm_CadastroQuarto Frm_CadastroQuarto;
        Frm_FazerReserva Frm_FazerReserva;
        Frm_CadastroUsuario Frm_CadastroUsuario;
        Frm_CadastroTipoQuarto Frm_CadastroTipoQuarto;
        Frm_ConsultaHospede Frm_ConsultaHospede;
        Frm_ConsultaTipoQuarto Frm_ConsultaTipoQuarto;
        Frm_ConsultaUsuario Frm_ConsultaUsuario;
        Frm_ConsultaReserva Frm_ConsultaReserva;
        Frm_ConsultaQuarto Frm_ConsultaQuarto;
        Frm_ConsultaPagamento Frm_ConsultaPagamento;
        public Frm_Principal()
        {
            Frm_CadastroHospede = new Frm_CadastroHospede();
            Frm_CadastroQuarto = new Frm_CadastroQuarto();
            Frm_FazerReserva = new Frm_FazerReserva();
            Frm_CadastroUsuario = new Frm_CadastroUsuario();
            Frm_CadastroTipoQuarto = new Frm_CadastroTipoQuarto();
            Frm_ConsultaHospede = new Frm_ConsultaHospede();
            Frm_ConsultaTipoQuarto = new Frm_ConsultaTipoQuarto();
            Frm_ConsultaReserva = new Frm_ConsultaReserva();
            Frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            Frm_ConsultaUsuario = new Frm_ConsultaUsuario();
            Frm_ConsultaPagamento = new Frm_ConsultaPagamento();
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroHospede.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsultaHospede.ShowDialog();
        }

        private void cadastroNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroTipoQuarto.ShowDialog();
        }

        private void consultaTipoQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsultaTipoQuarto.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_CadastroQuarto.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ConsultaQuarto.ShowDialog();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FazerReserva.ShowDialog();
        }

        private void cADASTROToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_CadastroUsuario.ShowDialog();
        }

        private void cONSULTAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_ConsultaUsuario.ShowDialog();
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count != 0)//se o total de forms ABERTAS FOR diferente de 0 fechar aplicação
            {
                Application.Exit();
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_DateTime.Text = (DateTime.Now.ToString("dd/MMM/yyyy"));
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_ConsultaReserva.ShowDialog();
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_ConsultaPagamento.ShowDialog();
        }
    }
}
