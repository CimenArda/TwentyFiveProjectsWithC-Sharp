namespace BankamatikSimulasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.lnkKayıtOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "HesapNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(253, 130);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 28);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(253, 77);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(174, 28);
            this.mskhesapno.TabIndex = 0;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(246, 181);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(154, 44);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giris Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lnkKayıtOl
            // 
            this.lnkKayıtOl.AutoSize = true;
            this.lnkKayıtOl.Location = new System.Drawing.Point(439, 133);
            this.lnkKayıtOl.Name = "lnkKayıtOl";
            this.lnkKayıtOl.Size = new System.Drawing.Size(81, 22);
            this.lnkKayıtOl.TabIndex = 8;
            this.lnkKayıtOl.TabStop = true;
            this.lnkKayıtOl.Text = "Kayıt Ol";
            this.lnkKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayıtOl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 327);
            this.Controls.Add(this.lnkKayıtOl);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.LinkLabel lnkKayıtOl;
    }
}

