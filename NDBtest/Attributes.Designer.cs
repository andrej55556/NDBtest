namespace NDBtest
{
    partial class Attributes
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
            this.button1 = new System.Windows.Forms.Button();
            this.attributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.normalizationDataSet = new NDBtest.NormalizationDataSet();
            this.keyAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyAttributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notKeyAttributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.AttributesTableAdapter();
            this.keyAttributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.KeyAttributesTableAdapter();
            this.notKeyAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notKeyAttributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.NotKeyAttributesTableAdapter();
            this.variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variant,
            this.variantDataGridViewTextBoxColumn1,
            this.id_attribute});
            this.dataGridView1.DataSource = this.attributesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1781, 1031);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 1008);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1781, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attributesBindingSource1
            // 
            this.attributesBindingSource1.DataMember = "Attributes";
            this.attributesBindingSource1.DataSource = this.normalizationDataSet;
            // 
            // normalizationDataSet
            // 
            this.normalizationDataSet.DataSetName = "NormalizationDataSet";
            this.normalizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keyAttributesBindingSource
            // 
            this.keyAttributesBindingSource.DataMember = "KeyAttributes";
            this.keyAttributesBindingSource.DataSource = this.normalizationDataSet;
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "Attributes";
            this.attributesBindingSource.DataSource = this.normalizationDataSet;
            // 
            // keyAttributesBindingSource1
            // 
            this.keyAttributesBindingSource1.DataMember = "KeyAttributes";
            this.keyAttributesBindingSource1.DataSource = this.normalizationDataSet;
            // 
            // notKeyAttributesBindingSource1
            // 
            this.notKeyAttributesBindingSource1.DataMember = "NotKeyAttributes";
            this.notKeyAttributesBindingSource1.DataSource = this.normalizationDataSet;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // keyAttributesTableAdapter
            // 
            this.keyAttributesTableAdapter.ClearBeforeFill = true;
            // 
            // notKeyAttributesBindingSource
            // 
            this.notKeyAttributesBindingSource.DataMember = "NotKeyAttributes";
            this.notKeyAttributesBindingSource.DataSource = this.normalizationDataSet;
            // 
            // notKeyAttributesTableAdapter
            // 
            this.notKeyAttributesTableAdapter.ClearBeforeFill = true;
            // 
            // variant
            // 
            this.variant.DataPropertyName = "variant";
            this.variant.HeaderText = "variant";
            this.variant.MinimumWidth = 6;
            this.variant.Name = "variant";
            this.variant.Visible = false;
            this.variant.Width = 125;
            // 
            // variantDataGridViewTextBoxColumn1
            // 
            this.variantDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.variantDataGridViewTextBoxColumn1.DataPropertyName = "attribute_name";
            this.variantDataGridViewTextBoxColumn1.HeaderText = "Атрибут";
            this.variantDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.variantDataGridViewTextBoxColumn1.Name = "variantDataGridViewTextBoxColumn1";
            // 
            // id_attribute
            // 
            this.id_attribute.DataPropertyName = "id_attribute";
            this.id_attribute.HeaderText = "id_attribute";
            this.id_attribute.MinimumWidth = 6;
            this.id_attribute.Name = "id_attribute";
            this.id_attribute.Visible = false;
            this.id_attribute.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1031);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Атрибуты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NormalizationDataSet normalizationDataSet;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private NormalizationDataSetTableAdapters.AttributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource keyAttributesBindingSource;
        private NormalizationDataSetTableAdapters.KeyAttributesTableAdapter keyAttributesTableAdapter;
        private System.Windows.Forms.BindingSource notKeyAttributesBindingSource;
        private NormalizationDataSetTableAdapters.NotKeyAttributesTableAdapter notKeyAttributesTableAdapter;
        private System.Windows.Forms.BindingSource notKeyAttributesBindingSource1;
        private System.Windows.Forms.BindingSource keyAttributesBindingSource1;
        private System.Windows.Forms.BindingSource attributesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn variant;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_attribute;
    }
}