namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_CadastroTipoQuarto
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
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_Almoco = new System.Windows.Forms.CheckBox();
            this.ckb_CafeDaManha = new System.Windows.Forms.CheckBox();
            this.ckb_Jantar = new System.Windows.Forms.CheckBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_QtdHospede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Tipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_ValorDiaria = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(251, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 15);
            this.label19.TabIndex = 53;
            this.label19.Text = "(* Campos obrigatórios)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sair);
            this.groupBox2.Controls.Add(this.btn_Limpar);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btn_Gravar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_QtdHospede);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_Tipo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_ValorDiaria);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 284);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Sair.Location = new System.Drawing.Point(162, 233);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(89, 33);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Red;
            this.btn_Limpar.Location = new System.Drawing.Point(257, 233);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(89, 33);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_Almoco);
            this.groupBox1.Controls.Add(this.ckb_CafeDaManha);
            this.groupBox1.Controls.Add(this.ckb_Jantar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(105, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refeições";
            // 
            // ckb_Almoco
            // 
            this.ckb_Almoco.AutoSize = true;
            this.ckb_Almoco.Location = new System.Drawing.Point(6, 47);
            this.ckb_Almoco.Name = "ckb_Almoco";
            this.ckb_Almoco.Size = new System.Drawing.Size(75, 20);
            this.ckb_Almoco.TabIndex = 5;
            this.ckb_Almoco.Text = "Almoço";
            this.ckb_Almoco.UseVisualStyleBackColor = true;
            // 
            // ckb_CafeDaManha
            // 
            this.ckb_CafeDaManha.AutoSize = true;
            this.ckb_CafeDaManha.Location = new System.Drawing.Point(6, 24);
            this.ckb_CafeDaManha.Name = "ckb_CafeDaManha";
            this.ckb_CafeDaManha.Size = new System.Drawing.Size(123, 20);
            this.ckb_CafeDaManha.TabIndex = 4;
            this.ckb_CafeDaManha.Text = "Café da Manhã";
            this.ckb_CafeDaManha.UseVisualStyleBackColor = true;
            // 
            // ckb_Jantar
            // 
            this.ckb_Jantar.AutoSize = true;
            this.ckb_Jantar.Location = new System.Drawing.Point(6, 70);
            this.ckb_Jantar.Name = "ckb_Jantar";
            this.ckb_Jantar.Size = new System.Drawing.Size(67, 20);
            this.ckb_Jantar.TabIndex = 6;
            this.ckb_Jantar.Text = "Jantar";
            this.ckb_Jantar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Gravar.Location = new System.Drawing.Point(67, 233);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(89, 33);
            this.btn_Gravar.TabIndex = 7;
            this.btn_Gravar.Text = "GRAVAR";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(111, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "*Tipo do Quarto:";
            // 
            // txb_QtdHospede
            // 
            this.txb_QtdHospede.Location = new System.Drawing.Point(229, 51);
            this.txb_QtdHospede.Name = "txb_QtdHospede";
            this.txb_QtdHospede.Size = new System.Drawing.Size(100, 20);
            this.txb_QtdHospede.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Quantidade Máx. de Hóspedes:";
            // 
            // txb_Tipo
            // 
            this.txb_Tipo.Location = new System.Drawing.Point(229, 25);
            this.txb_Tipo.Name = "txb_Tipo";
            this.txb_Tipo.Size = new System.Drawing.Size(100, 20);
            this.txb_Tipo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(37, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "*Valor Diária por Pessoa:";
            // 
            // txb_ValorDiaria
            // 
            this.txb_ValorDiaria.Location = new System.Drawing.Point(229, 78);
            this.txb_ValorDiaria.Name = "txb_ValorDiaria";
            this.txb_ValorDiaria.Size = new System.Drawing.Size(100, 20);
            this.txb_ValorDiaria.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(92, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 19);
            this.label17.TabIndex = 51;
            this.label17.Text = "Cadastro Novo Tipo Quarto";
            // 
            // Frm_CadastroTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 366);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_CadastroTipoQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Tipo Quarto";
            this.Load += new System.EventHandler(this.Frm_CadastroTipoQuarto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txb_QtdHospede;
        public System.Windows.Forms.TextBox txb_Tipo;
        public System.Windows.Forms.TextBox txb_ValorDiaria;
        public System.Windows.Forms.CheckBox ckb_Almoco;
        public System.Windows.Forms.CheckBox ckb_CafeDaManha;
        public System.Windows.Forms.CheckBox ckb_Jantar;
    }
}