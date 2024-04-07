namespace Conexaão_BD2
{
    partial class FormCadastro
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
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.codTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.celTxt = new System.Windows.Forms.MaskedTextBox();
            this.Celular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.MaskedTextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alterarBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(31, 390);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBtn.TabIndex = 0;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // codTxt
            // 
            this.codTxt.Location = new System.Drawing.Point(143, 116);
            this.codTxt.Name = "codTxt";
            this.codTxt.Size = new System.Drawing.Size(110, 20);
            this.codTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // celTxt
            // 
            this.celTxt.Location = new System.Drawing.Point(143, 180);
            this.celTxt.Mask = "(99)99999-9999";
            this.celTxt.Name = "celTxt";
            this.celTxt.Size = new System.Drawing.Size(110, 20);
            this.celTxt.TabIndex = 3;
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(140, 164);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(42, 13);
            this.Celular.TabIndex = 2;
            this.Celular.Text = "Celular:";
            this.Celular.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(143, 248);
            this.telTxt.Mask = "(99)9999-9999";
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(110, 20);
            this.telTxt.TabIndex = 3;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(143, 53);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(183, 20);
            this.nomeTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(143, 314);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(157, 20);
            this.emailTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // alterarBtn
            // 
            this.alterarBtn.Location = new System.Drawing.Point(143, 390);
            this.alterarBtn.Name = "alterarBtn";
            this.alterarBtn.Size = new System.Drawing.Size(75, 23);
            this.alterarBtn.TabIndex = 0;
            this.alterarBtn.Text = "Alterar";
            this.alterarBtn.UseVisualStyleBackColor = true;
            this.alterarBtn.Click += new System.EventHandler(this.alterarBtn_Click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.Location = new System.Drawing.Point(251, 390);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(75, 23);
            this.excluirBtn.TabIndex = 0;
            this.excluirBtn.Text = "Excluir";
            this.excluirBtn.UseVisualStyleBackColor = true;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(363, 390);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 0;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 443);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.celTxt);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.codTxt);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.alterarBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.TextBox codTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox celTxt;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox telTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button alterarBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Button buscarBtn;
    }
}