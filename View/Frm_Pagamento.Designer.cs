namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_Pagamento
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_ValorParcela = new System.Windows.Forms.TextBox();
            this.txb_NumReserva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_FormaPag = new System.Windows.Forms.ComboBox();
            this.txb_ValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Parcelas = new System.Windows.Forms.ComboBox();
            this.txb_ValorPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Troco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(192, 252);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 29);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txb_ValorParcela);
            this.groupBox1.Controls.Add(this.txb_NumReserva);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_FormaPag);
            this.groupBox1.Controls.Add(this.txb_ValorTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_Parcelas);
            this.groupBox1.Controls.Add(this.txb_ValorPago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_Troco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(39, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Valor por Parcela:";
            // 
            // txb_ValorParcela
            // 
            this.txb_ValorParcela.Location = new System.Drawing.Point(168, 80);
            this.txb_ValorParcela.Name = "txb_ValorParcela";
            this.txb_ValorParcela.ReadOnly = true;
            this.txb_ValorParcela.Size = new System.Drawing.Size(100, 20);
            this.txb_ValorParcela.TabIndex = 57;
            // 
            // txb_NumReserva
            // 
            this.txb_NumReserva.Location = new System.Drawing.Point(168, 27);
            this.txb_NumReserva.Name = "txb_NumReserva";
            this.txb_NumReserva.ReadOnly = true;
            this.txb_NumReserva.Size = new System.Drawing.Size(53, 20);
            this.txb_NumReserva.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(45, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número Reserva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(80, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Pago:";
            // 
            // cbx_FormaPag
            // 
            this.cbx_FormaPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FormaPag.FormattingEnabled = true;
            this.cbx_FormaPag.Items.AddRange(new object[] {
            "Cartão Crédito",
            "Cartão Débito",
            "Dinheiro"});
            this.cbx_FormaPag.Location = new System.Drawing.Point(168, 53);
            this.cbx_FormaPag.Name = "cbx_FormaPag";
            this.cbx_FormaPag.Size = new System.Drawing.Size(100, 21);
            this.cbx_FormaPag.TabIndex = 0;
            this.cbx_FormaPag.SelectedIndexChanged += new System.EventHandler(this.cbx_FormaPag_SelectedIndexChanged);
            // 
            // txb_ValorTotal
            // 
            this.txb_ValorTotal.Location = new System.Drawing.Point(168, 106);
            this.txb_ValorTotal.Name = "txb_ValorTotal";
            this.txb_ValorTotal.ReadOnly = true;
            this.txb_ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txb_ValorTotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(82, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Total:";
            // 
            // cbx_Parcelas
            // 
            this.cbx_Parcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Parcelas.FormattingEnabled = true;
            this.cbx_Parcelas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_Parcelas.Location = new System.Drawing.Point(274, 53);
            this.cbx_Parcelas.Name = "cbx_Parcelas";
            this.cbx_Parcelas.Size = new System.Drawing.Size(53, 21);
            this.cbx_Parcelas.TabIndex = 8;
            this.cbx_Parcelas.SelectedIndexChanged += new System.EventHandler(this.cbx_Parcelas_SelectedIndexChanged);
            // 
            // txb_ValorPago
            // 
            this.txb_ValorPago.Location = new System.Drawing.Point(168, 132);
            this.txb_ValorPago.Name = "txb_ValorPago";
            this.txb_ValorPago.Size = new System.Drawing.Size(100, 20);
            this.txb_ValorPago.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Forme de Pagamento:";
            // 
            // txb_Troco
            // 
            this.txb_Troco.Location = new System.Drawing.Point(168, 158);
            this.txb_Troco.Name = "txb_Troco";
            this.txb_Troco.ReadOnly = true;
            this.txb_Troco.Size = new System.Drawing.Size(100, 20);
            this.txb_Troco.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(115, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Troco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(128, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pagamento";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Confirmar.Location = new System.Drawing.Point(86, 252);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(100, 29);
            this.btn_Confirmar.TabIndex = 13;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // Frm_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 290);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Confirmar;
        public System.Windows.Forms.TextBox txb_ValorParcela;
        public System.Windows.Forms.TextBox txb_NumReserva;
        public System.Windows.Forms.ComboBox cbx_FormaPag;
        public System.Windows.Forms.TextBox txb_ValorTotal;
        public System.Windows.Forms.ComboBox cbx_Parcelas;
        public System.Windows.Forms.TextBox txb_ValorPago;
        public System.Windows.Forms.TextBox txb_Troco;
    }
}