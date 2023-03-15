namespace OcjenskaVjezba_kolekcije
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRod = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmboSpol = new System.Windows.Forms.ComboBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 49);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(208, 31);
            this.txtIme.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(12, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 133);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(208, 31);
            this.txtPrezime.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Prezime";
            // 
            // txtRod
            // 
            this.txtRod.Location = new System.Drawing.Point(12, 211);
            this.txtRod.Name = "txtRod";
            this.txtRod.Size = new System.Drawing.Size(208, 31);
            this.txtRod.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 24);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Godina rodenja";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(12, 264);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 24);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Spol";
            // 
            // cmboSpol
            // 
            this.cmboSpol.FormattingEnabled = true;
            this.cmboSpol.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmboSpol.Location = new System.Drawing.Point(12, 294);
            this.cmboSpol.Name = "cmboSpol";
            this.cmboSpol.Size = new System.Drawing.Size(208, 33);
            this.cmboSpol.TabIndex = 7;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(291, 46);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(218, 205);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(600, 47);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(214, 202);
            this.btnIspis.TabIndex = 10;
            this.btnIspis.Text = "Ispisi";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(914, 46);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(215, 205);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.BackColor = System.Drawing.SystemColors.Window;
            this.txtIspis.Location = new System.Drawing.Point(12, 352);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(1117, 466);
            this.txtIspis.TabIndex = 12;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.FileName = "podaci";
            this.saveFileDialog.Filter = "\"CSV files (*.csv)|*.csv|All files (*.*)|*.*\"";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 840);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmboSpol);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtRod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtRod;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cmboSpol;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

