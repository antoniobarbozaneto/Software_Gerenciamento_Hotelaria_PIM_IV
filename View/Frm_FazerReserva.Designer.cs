namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_FazerReserva
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
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarHospede = new System.Windows.Forms.Button();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedtxb_Passaporte = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarQuarto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_NumQuarto = new System.Windows.Forms.TextBox();
            this.txb_TipoQuarto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedtxb_dt_Checkin = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedtxb_dtCheckout = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_ValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_QtdHospede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(184, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 19);
            this.label11.TabIndex = 61;
            this.label11.Text = "Reservar / Hospedar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn_Limpar);
            this.groupBox1.Controls.Add(this.btn_Confirmar);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 456);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_BuscarHospede);
            this.groupBox2.Controls.Add(this.txb_Nome);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.maskedtxb_Passaporte);
            this.groupBox2.Controls.Add(this.maskedtxb_Cpf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 137);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Hóspede";
            // 
            // btn_BuscarHospede
            // 
            this.btn_BuscarHospede.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_BuscarHospede.ForeColor = System.Drawing.Color.Black;
            this.btn_BuscarHospede.Location = new System.Drawing.Point(175, 16);
            this.btn_BuscarHospede.Name = "btn_BuscarHospede";
            this.btn_BuscarHospede.Size = new System.Drawing.Size(113, 33);
            this.btn_BuscarHospede.TabIndex = 55;
            this.btn_BuscarHospede.Text = "BUSCAR HÓSPEDE";
            this.btn_BuscarHospede.UseVisualStyleBackColor = true;
            this.btn_BuscarHospede.Click += new System.EventHandler(this.btn_BuscarHospede_Click);
            // 
            // txb_Nome
            // 
            this.txb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_Nome.Location = new System.Drawing.Point(175, 55);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.ReadOnly = true;
            this.txb_Nome.Size = new System.Drawing.Size(203, 20);
            this.txb_Nome.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "*Passaporte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "*Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "*Cpf:";
            // 
            // maskedtxb_Passaporte
            // 
            this.maskedtxb_Passaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedtxb_Passaporte.Location = new System.Drawing.Point(175, 107);
            this.maskedtxb_Passaporte.Mask = "00000000";
            this.maskedtxb_Passaporte.Name = "maskedtxb_Passaporte";
            this.maskedtxb_Passaporte.ReadOnly = true;
            this.maskedtxb_Passaporte.Size = new System.Drawing.Size(83, 20);
            this.maskedtxb_Passaporte.TabIndex = 7;
            // 
            // maskedtxb_Cpf
            // 
            this.maskedtxb_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedtxb_Cpf.Location = new System.Drawing.Point(175, 81);
            this.maskedtxb_Cpf.Mask = "000.000.000-00";
            this.maskedtxb_Cpf.Name = "maskedtxb_Cpf";
            this.maskedtxb_Cpf.ReadOnly = true;
            this.maskedtxb_Cpf.Size = new System.Drawing.Size(83, 20);
            this.maskedtxb_Cpf.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_BuscarQuarto);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txb_NumQuarto);
            this.groupBox3.Controls.Add(this.txb_TipoQuarto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 108);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Quarto";
            // 
            // btn_BuscarQuarto
            // 
            this.btn_BuscarQuarto.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_BuscarQuarto.ForeColor = System.Drawing.Color.Black;
            this.btn_BuscarQuarto.Location = new System.Drawing.Point(174, 17);
            this.btn_BuscarQuarto.Name = "btn_BuscarQuarto";
            this.btn_BuscarQuarto.Size = new System.Drawing.Size(113, 33);
            this.btn_BuscarQuarto.TabIndex = 56;
            this.btn_BuscarQuarto.Text = "BUSCAR QUARTO";
            this.btn_BuscarQuarto.UseVisualStyleBackColor = true;
            this.btn_BuscarQuarto.Click += new System.EventHandler(this.btn_BuscarQuarto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "*Número:";
            // 
            // txb_NumQuarto
            // 
            this.txb_NumQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_NumQuarto.Location = new System.Drawing.Point(174, 56);
            this.txb_NumQuarto.Name = "txb_NumQuarto";
            this.txb_NumQuarto.ReadOnly = true;
            this.txb_NumQuarto.Size = new System.Drawing.Size(51, 20);
            this.txb_NumQuarto.TabIndex = 55;
            // 
            // txb_TipoQuarto
            // 
            this.txb_TipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_TipoQuarto.Location = new System.Drawing.Point(174, 82);
            this.txb_TipoQuarto.Name = "txb_TipoQuarto";
            this.txb_TipoQuarto.ReadOnly = true;
            this.txb_TipoQuarto.Size = new System.Drawing.Size(203, 20);
            this.txb_TipoQuarto.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Tipo Quarto:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedtxb_dt_Checkin);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.maskedtxb_dtCheckout);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txb_ValorTotal);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txb_QtdHospede);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 132);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Reserva";
            // 
            // maskedtxb_dt_Checkin
            // 
            this.maskedtxb_dt_Checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedtxb_dt_Checkin.Location = new System.Drawing.Point(175, 21);
            this.maskedtxb_dt_Checkin.Mask = "00/00/0000";
            this.maskedtxb_dt_Checkin.Name = "maskedtxb_dt_Checkin";
            this.maskedtxb_dt_Checkin.Size = new System.Drawing.Size(83, 20);
            this.maskedtxb_dt_Checkin.TabIndex = 15;
            this.maskedtxb_dt_Checkin.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "*Data Check-out:";
            // 
            // maskedtxb_dtCheckout
            // 
            this.maskedtxb_dtCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedtxb_dtCheckout.Location = new System.Drawing.Point(175, 47);
            this.maskedtxb_dtCheckout.Mask = "00/00/0000";
            this.maskedtxb_dtCheckout.Name = "maskedtxb_dtCheckout";
            this.maskedtxb_dtCheckout.Size = new System.Drawing.Size(83, 20);
            this.maskedtxb_dtCheckout.TabIndex = 17;
            this.maskedtxb_dtCheckout.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "*Data Check-in:";
            // 
            // txb_ValorTotal
            // 
            this.txb_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_ValorTotal.Location = new System.Drawing.Point(175, 100);
            this.txb_ValorTotal.Name = "txb_ValorTotal";
            this.txb_ValorTotal.ReadOnly = true;
            this.txb_ValorTotal.Size = new System.Drawing.Size(83, 20);
            this.txb_ValorTotal.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "*Quantidade de Pessoas:";
            // 
            // txb_QtdHospede
            // 
            this.txb_QtdHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txb_QtdHospede.Location = new System.Drawing.Point(175, 73);
            this.txb_QtdHospede.Name = "txb_QtdHospede";
            this.txb_QtdHospede.Size = new System.Drawing.Size(51, 20);
            this.txb_QtdHospede.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Valor Total:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Limpar.Location = new System.Drawing.Point(204, 413);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(107, 33);
            this.btn_Limpar.TabIndex = 43;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Confirmar.Location = new System.Drawing.Point(91, 413);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(107, 33);
            this.btn_Confirmar.TabIndex = 42;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(317, 413);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(107, 33);
            this.btn_Cancelar.TabIndex = 44;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(400, 502);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 15);
            this.label19.TabIndex = 59;
            this.label19.Text = "(* Campos obrigatórios)";
            // 
            // Frm_FazerReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 525);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_FazerReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazer Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_BuscarHospede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_BuscarQuarto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txb_Nome;
        public System.Windows.Forms.MaskedTextBox maskedtxb_Passaporte;
        public System.Windows.Forms.MaskedTextBox maskedtxb_Cpf;
        public System.Windows.Forms.TextBox txb_NumQuarto;
        public System.Windows.Forms.TextBox txb_TipoQuarto;
        public System.Windows.Forms.MaskedTextBox maskedtxb_dt_Checkin;
        public System.Windows.Forms.MaskedTextBox maskedtxb_dtCheckout;
        public System.Windows.Forms.TextBox txb_ValorTotal;
        public System.Windows.Forms.TextBox txb_QtdHospede;
    }
}