namespace PartiSecimGrafikIstatistik
{
    partial class FrmOyGiris
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnoygiris = new System.Windows.Forms.Button();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(237, 55);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(260, 31);
            this.txtad.TabIndex = 1;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(237, 140);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(260, 31);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(237, 205);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(260, 31);
            this.txtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "B Parti:";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(237, 261);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(260, 31);
            this.txtc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "C Parti:";
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(237, 308);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(260, 31);
            this.txtd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "D Parti:";
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(237, 370);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(260, 31);
            this.txte.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Parti:";
            // 
            // btnoygiris
            // 
            this.btnoygiris.Location = new System.Drawing.Point(237, 423);
            this.btnoygiris.Name = "btnoygiris";
            this.btnoygiris.Size = new System.Drawing.Size(260, 41);
            this.btnoygiris.TabIndex = 12;
            this.btnoygiris.Text = "Oy Girişi Yap";
            this.btnoygiris.UseVisualStyleBackColor = true;
            this.btnoygiris.Click += new System.EventHandler(this.btnoygiris_Click);
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(363, 470);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(134, 41);
            this.btngrafik.TabIndex = 14;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(237, 470);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(128, 41);
            this.btncikis.TabIndex = 15;
            this.btncikis.Text = "Çıkış Yap";
            this.btncikis.UseVisualStyleBackColor = true;
            // 
            // FrmOyGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(788, 647);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btngrafik);
            this.Controls.Add(this.btnoygiris);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOyGiris";
            this.Text = "Grafik Seçim Sistemi";
            this.Load += new System.EventHandler(this.FrmOyGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnoygiris;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btncikis;
    }
}

