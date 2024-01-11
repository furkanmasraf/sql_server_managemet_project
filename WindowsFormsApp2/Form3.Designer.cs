﻿namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new WindowsFormsApp2.DataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.ProductTableAdapter();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.BrandTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pAgeDataGridViewTextBoxColumn,
            this.pColorDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 101);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "P_Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // pAgeDataGridViewTextBoxColumn
            // 
            this.pAgeDataGridViewTextBoxColumn.DataPropertyName = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.HeaderText = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.Name = "pAgeDataGridViewTextBoxColumn";
            // 
            // pColorDataGridViewTextBoxColumn
            // 
            this.pColorDataGridViewTextBoxColumn.DataPropertyName = "P_Color";
            this.pColorDataGridViewTextBoxColumn.HeaderText = "P_Color";
            this.pColorDataGridViewTextBoxColumn.Name = "pColorDataGridViewTextBoxColumn";
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(264, 317);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.brandBindingSource;
            this.comboBox1.DisplayMember = "B_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "B_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(124, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(165, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Brand Id:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 103);
            this.button1.TabIndex = 11;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.dataSet1;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private DataSet1TableAdapters.BrandTableAdapter brandTableAdapter;
    }
}