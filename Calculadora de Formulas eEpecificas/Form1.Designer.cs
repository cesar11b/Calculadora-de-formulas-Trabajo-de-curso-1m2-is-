namespace Calculadora_de_Formulas_eEpecificas
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMRU = new System.Windows.Forms.Panel();
            this.cmbTipoMRU = new System.Windows.Forms.ComboBox();
            this.cmbIngresarTipo = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMRU.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(445, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 287);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 245);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbData);
            this.groupBox1.Location = new System.Drawing.Point(62, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 287);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(20, 19);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(318, 245);
            this.rtbData.TabIndex = 5;
            this.rtbData.Text = "";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(862, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 65);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(862, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 65);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(482, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 65);
            this.panel2.TabIndex = 11;
            // 
            // pnlMRU
            // 
            this.pnlMRU.Controls.Add(this.cmbTipoMRU);
            this.pnlMRU.Location = new System.Drawing.Point(219, 25);
            this.pnlMRU.Name = "pnlMRU";
            this.pnlMRU.Size = new System.Drawing.Size(247, 65);
            this.pnlMRU.TabIndex = 10;
            // 
            // cmbTipoMRU
            // 
            this.cmbTipoMRU.FormattingEnabled = true;
            this.cmbTipoMRU.Items.AddRange(new object[] {
            "Distancia",
            "Velocidad",
            "tiempo"});
            this.cmbTipoMRU.Location = new System.Drawing.Point(0, 19);
            this.cmbTipoMRU.Name = "cmbTipoMRU";
            this.cmbTipoMRU.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMRU.TabIndex = 0;
            // 
            // cmbIngresarTipo
            // 
            this.cmbIngresarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngresarTipo.FormattingEnabled = true;
            this.cmbIngresarTipo.Items.AddRange(new object[] {
            "Movimiento Rectilineo Uniforme"});
            this.cmbIngresarTipo.Location = new System.Drawing.Point(62, 45);
            this.cmbIngresarTipo.Name = "cmbIngresarTipo";
            this.cmbIngresarTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbIngresarTipo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMRU);
            this.Controls.Add(this.cmbIngresarTipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlMRU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMRU;
        private System.Windows.Forms.ComboBox cmbTipoMRU;
        private System.Windows.Forms.ComboBox cmbIngresarTipo;
    }
}

