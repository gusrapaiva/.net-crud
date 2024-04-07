namespace Conexaão_BD2
{
    partial class Formconsulta
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscaTxt = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listarBtn = new System.Windows.Forms.Button();
            this.lblOpt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Email",
            "Telefone",
            "Celular"});
            this.comboBox.Location = new System.Drawing.Point(12, 55);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(183, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(662, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // buscaTxt
            // 
            this.buscaTxt.Enabled = false;
            this.buscaTxt.Location = new System.Drawing.Point(12, 115);
            this.buscaTxt.Name = "buscaTxt";
            this.buscaTxt.Size = new System.Drawing.Size(183, 20);
            this.buscaTxt.TabIndex = 2;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(227, 111);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(80, 26);
            this.buscarBtn.TabIndex = 3;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escolha a opção de busca:";
            // 
            // listarBtn
            // 
            this.listarBtn.Location = new System.Drawing.Point(12, 180);
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Size = new System.Drawing.Size(80, 26);
            this.listarBtn.TabIndex = 3;
            this.listarBtn.Text = "Listar todos";
            this.listarBtn.UseVisualStyleBackColor = true;
            this.listarBtn.Click += new System.EventHandler(this.listarBtn_Click);
            // 
            // lblOpt
            // 
            this.lblOpt.AutoSize = true;
            this.lblOpt.Location = new System.Drawing.Point(13, 96);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Size = new System.Drawing.Size(0, 13);
            this.lblOpt.TabIndex = 5;
            // 
            // Formconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 454);
            this.Controls.Add(this.lblOpt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.buscaTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox);
            this.Name = "Formconsulta";
            this.Text = "Formconsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox buscaTxt;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button listarBtn;
        private System.Windows.Forms.Label lblOpt;
    }
}