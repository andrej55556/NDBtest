namespace NDBtest
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nk_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normalizationDataSet = new NDBtest.NormalizationDataSet();
            this.notKeyAttributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.variantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyAttributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.AttributesTableAdapter();
            this.keyAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyAttributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.KeyAttributesTableAdapter();
            this.notKeyAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notKeyAttributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.NotKeyAttributesTableAdapter();
            this.attributenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attributenameDataGridViewTextBoxColumn,
            this.id_attribute,
            this.variant});
            this.dataGridView1.DataSource = this.attributesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 985);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 1003);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variantDataGridViewTextBoxColumn,
            this.fd,
            this.k_name});
            this.dataGridView2.DataSource = this.keyAttributesBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(645, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(490, 985);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragDrop);
            this.dataGridView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragEnter);
            this.dataGridView2.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragOver);
            // 
            // fd
            // 
            this.fd.DataPropertyName = "fd";
            this.fd.HeaderText = "fd";
            this.fd.MinimumWidth = 6;
            this.fd.Name = "fd";
            this.fd.Width = 125;
            // 
            // k_name
            // 
            this.k_name.DataPropertyName = "k_name";
            this.k_name.DataSource = this.attributesBindingSource;
            this.k_name.DisplayMember = "attribute_name";
            this.k_name.HeaderText = "k_name";
            this.k_name.MinimumWidth = 6;
            this.k_name.Name = "k_name";
            this.k_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.k_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.k_name.ValueMember = "id_attribute";
            this.k_name.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.nk_name});
            this.dataGridView3.DataSource = this.notKeyAttributesBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(1278, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(490, 985);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEndEdit);
            // 
            // nk_name
            // 
            this.nk_name.DataPropertyName = "nk_name";
            this.nk_name.DataSource = this.attributesBindingSource;
            this.nk_name.DisplayMember = "attribute_name";
            this.nk_name.HeaderText = "nk_name";
            this.nk_name.MinimumWidth = 6;
            this.nk_name.Name = "nk_name";
            this.nk_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nk_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nk_name.ValueMember = "id_attribute";
            this.nk_name.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 1003);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(490, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1278, 1003);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(490, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fd";
            this.dataGridViewTextBoxColumn1.HeaderText = "fd";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "variant";
            this.dataGridViewTextBoxColumn3.HeaderText = "variant";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "Attributes";
            this.attributesBindingSource.DataSource = this.normalizationDataSet;
            // 
            // normalizationDataSet
            // 
            this.normalizationDataSet.DataSetName = "NormalizationDataSet";
            this.normalizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notKeyAttributesBindingSource1
            // 
            this.notKeyAttributesBindingSource1.DataMember = "NotKeyAttributes";
            this.notKeyAttributesBindingSource1.DataSource = this.normalizationDataSet;
            // 
            // variantDataGridViewTextBoxColumn
            // 
            this.variantDataGridViewTextBoxColumn.DataPropertyName = "variant";
            this.variantDataGridViewTextBoxColumn.HeaderText = "variant";
            this.variantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.variantDataGridViewTextBoxColumn.Name = "variantDataGridViewTextBoxColumn";
            this.variantDataGridViewTextBoxColumn.Visible = false;
            this.variantDataGridViewTextBoxColumn.Width = 125;
            // 
            // keyAttributesBindingSource1
            // 
            this.keyAttributesBindingSource1.DataMember = "KeyAttributes";
            this.keyAttributesBindingSource1.DataSource = this.normalizationDataSet;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // keyAttributesBindingSource
            // 
            this.keyAttributesBindingSource.DataMember = "KeyAttributes";
            this.keyAttributesBindingSource.DataSource = this.normalizationDataSet;
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
            // attributenameDataGridViewTextBoxColumn
            // 
            this.attributenameDataGridViewTextBoxColumn.DataPropertyName = "attribute_name";
            this.attributenameDataGridViewTextBoxColumn.HeaderText = "attribute_name";
            this.attributenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attributenameDataGridViewTextBoxColumn.Name = "attributenameDataGridViewTextBoxColumn";
            this.attributenameDataGridViewTextBoxColumn.Width = 125;
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
            // variant
            // 
            this.variant.DataPropertyName = "variant";
            this.variant.HeaderText = "variant";
            this.variant.MinimumWidth = 6;
            this.variant.Name = "variant";
            this.variant.Visible = false;
            this.variant.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1031);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NormalizationDataSet normalizationDataSet;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private NormalizationDataSetTableAdapters.AttributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource keyAttributesBindingSource;
        private NormalizationDataSetTableAdapters.KeyAttributesTableAdapter keyAttributesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource notKeyAttributesBindingSource;
        private NormalizationDataSetTableAdapters.NotKeyAttributesTableAdapter notKeyAttributesTableAdapter;
        private System.Windows.Forms.BindingSource notKeyAttributesBindingSource1;
        private System.Windows.Forms.BindingSource keyAttributesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fd;
        private System.Windows.Forms.DataGridViewComboBoxColumn k_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn nk_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn variant;
    }
}