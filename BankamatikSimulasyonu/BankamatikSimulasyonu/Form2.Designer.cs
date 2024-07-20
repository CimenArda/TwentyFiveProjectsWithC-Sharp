namespace BankamatikSimulasyonu
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblhesapno = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lbltckimlik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(181, 64);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(60, 22);
            this.lbladsoyad.TabIndex = 4;
            this.lbladsoyad.Text = "NULL";
            // 
            // lblhesapno
            // 
            this.lblhesapno.AutoSize = true;
            this.lblhesapno.Location = new System.Drawing.Point(181, 108);
            this.lblhesapno.Name = "lblhesapno";
            this.lblhesapno.Size = new System.Drawing.Size(60, 22);
            this.lblhesapno.TabIndex = 5;
            this.lblhesapno.Text = "NULL";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(181, 165);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(60, 22);
            this.lbltelefon.TabIndex = 6;
            this.lbltelefon.Text = "NULL";
            // 
            // lbltckimlik
            // 
            this.lbltckimlik.AutoSize = true;
            this.lbltckimlik.Location = new System.Drawing.Point(181, 213);
            this.lbltckimlik.Name = "lbltckimlik";
            this.lbltckimlik.Size = new System.Drawing.Size(60, 22);
            this.lbltckimlik.TabIndex = 7;
            this.lbltckimlik.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngonder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.mskhesapno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 319);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HAVALE";
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(152, 157);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(154, 44);
            this.btngonder.TabIndex = 6;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tutar:";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(152, 97);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(180, 28);
            this.txttutar.TabIndex = 4;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(152, 43);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(174, 28);
            this.mskhesapno.TabIndex = 3;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hesap No:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltckimlik);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lblhesapno);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblhesapno;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lbltckimlik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Button btngonder;
    }
}