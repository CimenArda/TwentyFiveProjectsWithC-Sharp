﻿namespace MailVeTelefonRehberKayitModulu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.MSKTEL = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTSOYAD = new System.Windows.Forms.TextBox();
            this.TXTMAIL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNGUNCELLE = new System.Windows.Forms.Button();
            this.BTNSIL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNSIL);
            this.groupBox2.Controls.Add(this.BTNGUNCELLE);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXTMAIL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TXTSOYAD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXTAD);
            this.groupBox2.Controls.Add(this.BTNEKLE);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.MSKTEL);
            this.groupBox2.Controls.Add(this.TXTID);
            this.groupBox2.Location = new System.Drawing.Point(999, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kişi";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(145, 39);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(180, 28);
            this.TXTID.TabIndex = 0;
            // 
            // MSKTEL
            // 
            this.MSKTEL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MSKTEL.Location = new System.Drawing.Point(145, 184);
            this.MSKTEL.Mask = "(999) 000-0000";
            this.MSKTEL.Name = "MSKTEL";
            this.MSKTEL.Size = new System.Drawing.Size(174, 28);
            this.MSKTEL.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 379);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Location = new System.Drawing.Point(129, 286);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(115, 41);
            this.BTNEKLE.TabIndex = 6;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "AD:";
            // 
            // TXTAD
            // 
            this.TXTAD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTAD.Location = new System.Drawing.Point(145, 88);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(180, 28);
            this.TXTAD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "SOYAD:";
            // 
            // TXTSOYAD
            // 
            this.TXTSOYAD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTSOYAD.Location = new System.Drawing.Point(145, 137);
            this.TXTSOYAD.Name = "TXTSOYAD";
            this.TXTSOYAD.Size = new System.Drawing.Size(180, 28);
            this.TXTSOYAD.TabIndex = 2;
            // 
            // TXTMAIL
            // 
            this.TXTMAIL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTMAIL.Location = new System.Drawing.Point(145, 239);
            this.TXTMAIL.Name = "TXTMAIL";
            this.TXTMAIL.Size = new System.Drawing.Size(180, 28);
            this.TXTMAIL.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "MAİL:";
            // 
            // BTNGUNCELLE
            // 
            this.BTNGUNCELLE.Location = new System.Drawing.Point(145, 333);
            this.BTNGUNCELLE.Name = "BTNGUNCELLE";
            this.BTNGUNCELLE.Size = new System.Drawing.Size(180, 41);
            this.BTNGUNCELLE.TabIndex = 8;
            this.BTNGUNCELLE.Text = "GÜNCELLE";
            this.BTNGUNCELLE.UseVisualStyleBackColor = true;
            this.BTNGUNCELLE.Click += new System.EventHandler(this.BTNGUNCELLE_Click);
            // 
            // BTNSIL
            // 
            this.BTNSIL.Location = new System.Drawing.Point(250, 286);
            this.BTNSIL.Name = "BTNSIL";
            this.BTNSIL.Size = new System.Drawing.Size(115, 41);
            this.BTNSIL.TabIndex = 7;
            this.BTNSIL.Text = "SİL";
            this.BTNSIL.UseVisualStyleBackColor = true;
            this.BTNSIL.Click += new System.EventHandler(this.BTNSIL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1551, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTMAIL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTSOYAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MaskedTextBox MSKTEL;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Button BTNSIL;
        private System.Windows.Forms.Button BTNGUNCELLE;
    }
}
