namespace NDBtest
{
    partial class Variants
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
            this.variantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normalizationDataSet = new NDBtest.NormalizationDataSet();
            this.btn_Save = new System.Windows.Forms.Button();
            this.variantsTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.VariantsTableAdapter();
            this.tableAdapterManager = new NDBtest.NormalizationDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.variantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // variantsDataGridView
            // 
            this.variantsDataGridView.AutoGenerateColumns = false;
            this.variantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.variantsDataGridView.DataSource = this.variantsBindingSource;
            this.variantsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variantsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.variantsDataGridView.Name = "variantsDataGridView";
            this.variantsDataGridView.RowHeadersWidth = 51;
            this.variantsDataGridView.RowTemplate.Height = 24;
            this.variantsDataGridView.Size = new System.Drawing.Size(800, 450);
            this.variantsDataGridView.TabIndex = 1;
            this.variantsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.variantsDataGridView_CellContentClick);
            this.variantsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.variantsDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(0, 427);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(800, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Choose_Click);
            // 
            // variantsTableAdapter
            // 
            this.variantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttributesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KeyAttributesTableAdapter = null;
            this.tableAdapterManager.NotKeyAttributesTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NDBtest.NormalizationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.VariantsTableAdapter = this.variantsTableAdapter;
            // 
            // Variants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.variantsDataGridView);
            this.Name = "Variants";
            this.Text = "Варианты";
            this.Load += new System.EventHandler(this.Variants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.variantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NormalizationDataSet normalizationDataSet;
        private System.Windows.Forms.BindingSource variantsBindingSource;
        private NormalizationDataSetTableAdapters.VariantsTableAdapter variantsTableAdapter;
        private NormalizationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView variantsDataGridView;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}