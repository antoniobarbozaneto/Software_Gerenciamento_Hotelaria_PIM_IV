namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_ConsultaTipoQuarto
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
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_TipoQuarto = new System.Windows.Forms.DataGridView();
            this.cbx_FiltroTipoQuarto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Consulta = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TipoQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.btn_Buscar);
            this.groupBox30.Controls.Add(this.dataGridView_TipoQuarto);
            this.groupBox30.Controls.Add(this.cbx_FiltroTipoQuarto);
            this.groupBox30.Controls.Add(this.label1);
            this.groupBox30.Controls.Add(this.label3);
            this.groupBox30.Controls.Add(this.txb_Consulta);
            this.groupBox30.Location = new System.Drawing.Point(14, 77);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(699, 413);
            this.groupBox30.TabIndex = 37;
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
            // dataGridView_TipoQuarto
            // 
            this.dataGridView_TipoQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TipoQuarto.Location = new System.Drawing.Point(19, 69);
            this.dataGridView_TipoQuarto.Name = "dataGridView_TipoQuarto";
            this.dataGridView_TipoQuarto.ReadOnly = true;
            this.dataGridView_TipoQuarto.Size = new System.Drawing.Size(663, 323);
            this.dataGridView_TipoQuarto.TabIndex = 17;
            // 
            // cbx_FiltroTipoQuarto
            // 
            this.cbx_FiltroTipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FiltroTipoQuarto.FormattingEnabled = true;
            this.cbx_FiltroTipoQuarto.Items.AddRange(new object[] {
            "Tipo"});
            this.cbx_FiltroTipoQuarto.Location = new System.Drawing.Point(19, 42);
            this.cbx_FiltroTipoQuarto.Name = "cbx_FiltroTipoQuarto";
            this.cbx_FiltroTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cbx_FiltroTipoQuarto.TabIndex = 24;
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
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Red;
            this.btn_Excluir.Location = new System.Drawing.Point(427, 496);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(87, 30);
            this.btn_Excluir.TabIndex = 35;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atualizar.Location = new System.Drawing.Point(241, 496);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.btn_Atualizar.TabIndex = 36;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.Location = new System.Drawing.Point(334, 496);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(87, 30);
            this.btn_Editar.TabIndex = 33;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label50.Location = new System.Drawing.Point(237, 41);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(227, 19);
            this.label50.TabIndex = 29;
            this.label50.Text = "Consulta de Tipo de Quartos";
            // 
            // Frm_ConsultaTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 538);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.groupBox30);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_ConsultaTipoQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Tipo de Quarto";
            this.Load += new System.EventHandler(this.Frm_ConsultaTipoQuarto_Load);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TipoQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dataGridView_TipoQuarto;
        private System.Windows.Forms.ComboBox cbx_FiltroTipoQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Consulta;
        public System.Windows.Forms.Button btn_Excluir;
        public System.Windows.Forms.Button btn_Atualizar;
        public System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label50;
    }
}