namespace Software_Gerenciamento_Hotelaria_PIM_IV.View
{
    partial class Frm_Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "LOGIN";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sair.ForeColor = System.Drawing.Color.Red;
            this.btn_Sair.Location = new System.Drawing.Point(143, 119);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(82, 36);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Entrar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Entrar.Location = new System.Drawing.Point(55, 119);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(82, 36);
            this.btn_Entrar.TabIndex = 3;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário:";
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(79, 93);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.PasswordChar = '*';
            this.txb_Senha.Size = new System.Drawing.Size(127, 20);
            this.txb_Senha.TabIndex = 2;
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(79, 67);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(127, 20);
            this.txb_Usuario.TabIndex = 1;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.txb_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.TextBox txb_Usuario;
    }
}