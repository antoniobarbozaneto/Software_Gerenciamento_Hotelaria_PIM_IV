namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_ConsultaReserva
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
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_Reservas = new System.Windows.Forms.DataGridView();
            this.cbx_FiltroReserva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Consulta = new System.Windows.Forms.TextBox();
            this.btn_DarBaixa = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label50.Location = new System.Drawing.Point(268, 23);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(177, 19);
            this.label50.TabIndex = 50;
            this.label50.Text = "Consulta de Reservas";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.btn_Buscar);
            this.groupBox30.Controls.Add(this.dataGridView_Reservas);
            this.groupBox30.Controls.Add(this.cbx_FiltroReserva);
            this.groupBox30.Controls.Add(this.label1);
            this.groupBox30.Controls.Add(this.label3);
            this.groupBox30.Controls.Add(this.txb_Consulta);
            this.groupBox30.Location = new System.Drawing.Point(14, 54);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(699, 413);
            this.groupBox30.TabIndex = 53;
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
            // dataGridView_Reservas
            // 
            this.dataGridView_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reservas.Location = new System.Drawing.Point(19, 69);
            this.dataGridView_Reservas.Name = "dataGridView_Reservas";
            this.dataGridView_Reservas.ReadOnly = true;
            this.dataGridView_Reservas.Size = new System.Drawing.Size(663, 323);
            this.dataGridView_Reservas.TabIndex = 17;
            // 
            // cbx_FiltroReserva
            // 
            this.cbx_FiltroReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FiltroReserva.FormattingEnabled = true;
            this.cbx_FiltroReserva.Items.AddRange(new object[] {
            "Numero Reserva",
            "Numero Quarto",
            "Status Reserva",
            "Id Hospede"});
            this.cbx_FiltroReserva.Location = new System.Drawing.Point(19, 42);
            this.cbx_FiltroReserva.Name = "cbx_FiltroReserva";
            this.cbx_FiltroReserva.Size = new System.Drawing.Size(121, 21);
            this.cbx_FiltroReserva.TabIndex = 24;
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
            // btn_DarBaixa
            // 
            this.btn_DarBaixa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_DarBaixa.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_DarBaixa.Location = new System.Drawing.Point(358, 470);
            this.btn_DarBaixa.Name = "btn_DarBaixa";
            this.btn_DarBaixa.Size = new System.Drawing.Size(87, 30);
            this.btn_DarBaixa.TabIndex = 51;
            this.btn_DarBaixa.Text = "DAR BAIXA";
            this.btn_DarBaixa.UseVisualStyleBackColor = true;
            this.btn_DarBaixa.Click += new System.EventHandler(this.btn_DarBaixa_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atualizar.Location = new System.Drawing.Point(265, 470);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.btn_Atualizar.TabIndex = 54;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // Frm_ConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 512);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.groupBox30);
            this.Controls.Add(this.btn_DarBaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Reserva";
            this.Load += new System.EventHandler(this.Frm_ConsultaReserva_Load);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dataGridView_Reservas;
        private System.Windows.Forms.ComboBox cbx_FiltroReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Consulta;
        public System.Windows.Forms.Button btn_DarBaixa;
        public System.Windows.Forms.Button btn_Atualizar;
    }
}