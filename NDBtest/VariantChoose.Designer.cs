namespace NDBtest
{
    partial class VariantChoose
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
            this.btn_Choose = new System.Windows.Forms.Button();
            this.variantsDataGridView = new System.Windows.Forms.DataGridView();
            this.variantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normalizationDataSet = new NDBtest.NormalizationDataSet();
            this.variantsTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.VariantsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.variantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Choose
            // 
            this.btn_Choose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Choose.Location = new System.Drawing.Point(0, 427);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(800, 23);
            this.btn_Choose.TabIndex = 4;
            this.btn_Choose.Text = "Выбрать";
            this.btn_Choose.UseVisualStyleBackColor = true;
            this.btn_Choose.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // variantsDataGridView
            // 
            this.variantsDataGridView.AutoGenerateColumns = false;
            this.variantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.variantsDataGridView.DataSource = this.variantsBindingSource;
            this.variantsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variantsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.variantsDataGridView.Name = "variantsDataGridView";
            this.variantsDataGridView.RowHeadersWidth = 51;
            this.variantsDataGridView.RowTemplate.Height = 24;
            this.variantsDataGridView.Size = new System.Drawing.Size(800, 450);
            this.variantsDataGridView.TabIndex = 3;
            this.variantsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.variantsDataGridView_CellContentClick);
            // 
            // variantsBindingSource
            // 
            this.variantsBindingSource.DataMember = "Variants";
            this.variantsBindingSource.DataSource = this.normalizationDataSet;
            // 
            // normalizationDataSet
            // 
            this.normalizationDataSet.DataSetName = "NormalizationDataSet";
            this.normalizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // variantsTableAdapter
            // 
            this.variantsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // VariantChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.variantsDataGridView);
            this.Name = "VariantChoose";
            this.Text = "Выбор варианта";
            this.Load += new System.EventHandler(this.VariantChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.variantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Choose;
        private System.Windows.Forms.DataGridView variantsDataGridView;
        private NormalizationDataSet normalizationDataSet;
        private System.Windows.Forms.BindingSource variantsBindingSource;
        private NormalizationDataSetTableAdapters.VariantsTableAdapter variantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}