namespace KelimeOgrenUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.txtTürkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkelime = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(209, 59);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(197, 30);
            this.txtIngilizce.TabIndex = 10;
            // 
            // txtTürkce
            // 
            this.txtTürkce.Location = new System.Drawing.Point(209, 107);
            this.txtTürkce.Name = "txtTürkce";
            this.txtTürkce.Size = new System.Drawing.Size(197, 30);
            this.txtTürkce.TabIndex = 1;
            this.txtTürkce.TextChanged += new System.EventHandler(this.txtTürkce_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(647, 68);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(45, 30);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime:";
            // 
            // lblkelime
            // 
            this.lblkelime.AutoSize = true;
            this.lblkelime.Location = new System.Drawing.Point(670, 107);
            this.lblkelime.Name = "lblkelime";
            this.lblkelime.Size = new System.Drawing.Size(30, 30);
            this.lblkelime.TabIndex = 7;
            this.lblkelime.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(897, 352);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(68, 24);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "cevap";
            this.lblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 391);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblkelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTürkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.TextBox txtTürkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblkelime;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

