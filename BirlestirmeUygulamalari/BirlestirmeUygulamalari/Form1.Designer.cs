namespace BirlestirmeUygulamalari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.birlestirmeUygulamalariProje10DataSet = new BirlestirmeUygulamalari.BirlestirmeUygulamalariProje10DataSet();
            this.birlestirmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birlestirmeTableAdapter = new BirlestirmeUygulamalari.BirlestirmeUygulamalariProje10DataSetTableAdapters.BirlestirmeTableAdapter();
            this.hAREKETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birlestirmeUygulamalariProje10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birlestirmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hAREKETIDDataGridViewTextBoxColumn,
            this.ürünAdıDataGridViewTextBoxColumn,
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn,
            this.personelAdıDataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.birlestirmeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // birlestirmeUygulamalariProje10DataSet
            // 
            this.birlestirmeUygulamalariProje10DataSet.DataSetName = "BirlestirmeUygulamalariProje10DataSet";
            this.birlestirmeUygulamalariProje10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birlestirmeBindingSource
            // 
            this.birlestirmeBindingSource.DataMember = "Birlestirme";
            this.birlestirmeBindingSource.DataSource = this.birlestirmeUygulamalariProje10DataSet;
            // 
            // birlestirmeTableAdapter
            // 
            this.birlestirmeTableAdapter.ClearBeforeFill = true;
            // 
            // hAREKETIDDataGridViewTextBoxColumn
            // 
            this.hAREKETIDDataGridViewTextBoxColumn.DataPropertyName = "HAREKETID";
            this.hAREKETIDDataGridViewTextBoxColumn.HeaderText = "HAREKETID";
            this.hAREKETIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hAREKETIDDataGridViewTextBoxColumn.Name = "hAREKETIDDataGridViewTextBoxColumn";
            this.hAREKETIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ürünAdıDataGridViewTextBoxColumn
            // 
            this.ürünAdıDataGridViewTextBoxColumn.DataPropertyName = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünAdıDataGridViewTextBoxColumn.Name = "ürünAdıDataGridViewTextBoxColumn";
            // 
            // müşteriAdıSoyadıDataGridViewTextBoxColumn
            // 
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.DataPropertyName = "Müşteri Adı Soyadı";
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.HeaderText = "Müşteri Adı Soyadı";
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.Name = "müşteriAdıSoyadıDataGridViewTextBoxColumn";
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdıDataGridViewTextBoxColumn
            // 
            this.personelAdıDataGridViewTextBoxColumn.DataPropertyName = "Personel Adı";
            this.personelAdıDataGridViewTextBoxColumn.HeaderText = "Personel Adı";
            this.personelAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdıDataGridViewTextBoxColumn.Name = "personelAdıDataGridViewTextBoxColumn";
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 323);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birlestirmeUygulamalariProje10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birlestirmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BirlestirmeUygulamalariProje10DataSet birlestirmeUygulamalariProje10DataSet;
        private System.Windows.Forms.BindingSource birlestirmeBindingSource;
        private BirlestirmeUygulamalariProje10DataSetTableAdapters.BirlestirmeTableAdapter birlestirmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAREKETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriAdıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
    }
}

