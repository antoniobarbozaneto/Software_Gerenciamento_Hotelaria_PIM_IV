namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_CadastroUsuario
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
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(180, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 15);
            this.label19.TabIndex = 62;
            this.label19.Text = "(* Campos obrigatórios)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(73, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 19);
            this.label17.TabIndex = 61;
            this.label17.Text = "Cadastro Novo Usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_Senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_Usuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Sair);
            this.groupBox1.Controls.Add(this.btn_Gravar);
            this.groupBox1.Controls.Add(this.btn_Limpar);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 115);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(96, 45);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.Size = new System.Drawing.Size(127, 20);
            this.txb_Senha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "*Senha:";
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(96, 19);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(127, 20);
            this.txb_Usuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "*Usuário:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Sair.Location = new System.Drawing.Point(110, 76);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(98, 33);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Gravar.Location = new System.Drawing.Point(6, 76);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(98, 33);
            this.btn_Gravar.TabIndex = 3;
            this.btn_Gravar.Text = "CONFIRMAR";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Red;
            this.btn_Limpar.Location = new System.Drawing.Point(214, 76);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(89, 33);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 192);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Limpar;
    }
}