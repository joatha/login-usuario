
namespace Conexao.Apresentação
{
    partial class Cadastrese
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtLoginCad = new System.Windows.Forms.TextBox();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtSenhaConfirCad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(120, 268);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 34);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtLoginCad
            // 
            this.txtLoginCad.Location = new System.Drawing.Point(66, 70);
            this.txtLoginCad.Name = "txtLoginCad";
            this.txtLoginCad.Size = new System.Drawing.Size(189, 23);
            this.txtLoginCad.TabIndex = 4;
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(66, 144);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.PasswordChar = '*';
            this.txtSenhaCad.Size = new System.Drawing.Size(189, 23);
            this.txtSenhaCad.TabIndex = 5;
            // 
            // txtSenhaConfirCad
            // 
            this.txtSenhaConfirCad.Location = new System.Drawing.Point(66, 218);
            this.txtSenhaConfirCad.Name = "txtSenhaConfirCad";
            this.txtSenhaConfirCad.PasswordChar = '*';
            this.txtSenhaConfirCad.Size = new System.Drawing.Size(189, 23);
            this.txtSenhaConfirCad.TabIndex = 6;
            // 
            // Cadastrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 335);
            this.Controls.Add(this.txtSenhaConfirCad);
            this.Controls.Add(this.txtSenhaCad);
            this.Controls.Add(this.txtLoginCad);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastrese";
            this.Text = "Cadastrese";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtLoginCad;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtSenhaConfirCad;
    }
}