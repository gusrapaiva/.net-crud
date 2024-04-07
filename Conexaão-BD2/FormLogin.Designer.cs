namespace Conexaão_BD2
{
    partial class FormLogin
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
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sairBtn = new System.Windows.Forms.Button();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(33, 53);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(141, 20);
            this.loginTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // sairBtn
            // 
            this.sairBtn.Location = new System.Drawing.Point(259, 112);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(94, 23);
            this.sairBtn.TabIndex = 4;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = true;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // entrarBtn
            // 
            this.entrarBtn.Location = new System.Drawing.Point(259, 53);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(94, 23);
            this.entrarBtn.TabIndex = 3;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(33, 112);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(141, 20);
            this.senhaTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 180);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.loginTxt);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label2;
    }
}