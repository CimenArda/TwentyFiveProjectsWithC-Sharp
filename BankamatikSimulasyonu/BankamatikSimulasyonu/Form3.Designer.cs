﻿namespace BankamatikSimulasyonu
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.mskkimlikno = new System.Windows.Forms.MaskedTextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnhesapno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC Kimlik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesap No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Şifre:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(90, 31);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(180, 28);
            this.txtad.TabIndex = 10;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(105, 77);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(180, 28);
            this.txtsoyad.TabIndex = 11;
            // 
            // mskkimlikno
            // 
            this.mskkimlikno.Location = new System.Drawing.Point(134, 121);
            this.mskkimlikno.Mask = "00000000000";
            this.mskkimlikno.Name = "mskkimlikno";
            this.mskkimlikno.Size = new System.Drawing.Size(174, 28);
            this.mskkimlikno.TabIndex = 12;
            this.mskkimlikno.ValidatingType = typeof(int);
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(134, 171);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(174, 28);
            this.msktelefon.TabIndex = 13;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Enabled = false;
            this.mskhesapno.Location = new System.Drawing.Point(134, 222);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(174, 28);
            this.mskhesapno.TabIndex = 14;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(134, 266);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(180, 28);
            this.txtsifre.TabIndex = 15;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(131, 314);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(154, 44);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnhesapno
            // 
            this.btnhesapno.Location = new System.Drawing.Point(314, 218);
            this.btnhesapno.Name = "btnhesapno";
            this.btnhesapno.Size = new System.Drawing.Size(58, 36);
            this.btnhesapno.TabIndex = 17;
            this.btnhesapno.Text = "...";
            this.btnhesapno.UseVisualStyleBackColor = true;
            this.btnhesapno.Click += new System.EventHandler(this.btnhesapno_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 567);
            this.Controls.Add(this.btnhesapno);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.mskkimlikno);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox mskkimlikno;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnhesapno;
    }
}