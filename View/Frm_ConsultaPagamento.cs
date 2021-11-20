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
            CarregaListaTipoQuarto();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {

        }
        //mtds uteis
        public void CarregaListaTipoQuarto()
        {
            dataGridView_Pagamentos.DataSource = Ctr_Pagamento.Carrega_Pagamento();
        }
    }
}
