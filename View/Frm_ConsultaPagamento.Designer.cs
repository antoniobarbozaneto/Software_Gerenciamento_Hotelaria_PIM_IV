namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_ConsultaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_Pagamentos = new System.Windows.Forms.DataGridView();
            this.cbx_FiltroPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Consulta = new System.Windows.Forms.TextBox();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atualizar.Location = new System.Drawing.Point(320, 484);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.btn_Atualizar.TabIndex = 58;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label50.Location = new System.Drawing.Point(247, 32);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(229, 19);
            this.label50.TabIndex = 55;
            this.label50.Text = "Consulta de Reservas Pagas";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.btn_Buscar);
            this.groupBox30.Controls.Add(this.dataGridView_Pagamentos);
            this.groupBox30.Controls.Add(this.cbx_FiltroPagamento);
            this.groupBox30.Controls.Add(this.label1);
            this.groupBox30.Controls.Add(this.label3);
            this.groupBox30.Controls.Add(this.txb_Consulta);
            this.groupBox30.Location = new System.Drawing.Point(14, 65);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(699, 413);
            this.groupBox30.TabIndex = 57;
            this.groupBox30.TabStop = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.Location = new System.Drawing.Point(595, 33);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 30);
            this.btn_Buscar.TabIndex = 27;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dataGridView_Pagamentos
            // 
            this.dataGridView_Pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pagamentos.Location = new System.Drawing.Point(19, 69);
            this.dataGridView_Pagamentos.Name = "dataGridView_Pagamentos";
            this.dataGridView_Pagamentos.ReadOnly = true;
            this.dataGridView_Pagamentos.Size = new System.Drawing.Size(663, 323);
            this.dataGridView_Pagamentos.TabIndex = 17;
            // 
            // cbx_FiltroPagamento
            // 
            this.cbx_FiltroPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FiltroPagamento.FormattingEnabled = true;
            this.cbx_FiltroPagamento.Items.AddRange(new object[] {
            "NFE",
            "Numero Reserva",
            "Forma Pagamento"});
            this.cbx_FiltroPagamento.Location = new System.Drawing.Point(19, 42);
            this.cbx_FiltroPagamento.Name = "cbx_FiltroPagamento";
            this.cbx_FiltroPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbx_FiltroPagamento.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(143, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "PESQUISAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "FILTRO";
            // 
            // txb_Consulta
            // 
            this.txb_Consulta.Location = new System.Drawing.Point(146, 42);
            this.txb_Consulta.Name = "txb_Consulta";
            this.txb_Consulta.Size = new System.Drawing.Size(443, 20);
            this.txb_Consulta.TabIndex = 16;
            // 
            // Frm_ConsultaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 522);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.groupBox30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ConsultaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Pagamentos";
            this.Load += new System.EventHandler(this.Frm_ConsultaPagamento_Load);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dataGridView_Pagamentos;
        private System.Windows.Forms.ComboBox cbx_FiltroPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Consulta;
    }
}