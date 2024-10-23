namespace NDBtest
{
    partial class KeyAtr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyAtr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.keyAttributesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.keyAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normalizationDataSet = new NDBtest.NormalizationDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.keyAttributesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.keyAttributesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyAttributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.KeyAttributesTableAdapter();
            this.tableAdapterManager = new NDBtest.NormalizationDataSetTableAdapters.TableAdapterManager();
            this.attributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.AttributesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingNavigator)).BeginInit();
            this.keyAttributesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keyAttributesBindingNavigator
            // 
            this.keyAttributesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.keyAttributesBindingNavigator.BindingSource = this.keyAttributesBindingSource;
            this.keyAttributesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.keyAttributesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.keyAttributesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.keyAttributesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.keyAttributesBindingNavigatorSaveItem});
            this.keyAttributesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.keyAttributesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.keyAttributesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.keyAttributesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.keyAttributesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.keyAttributesBindingNavigator.Name = "keyAttributesBindingNavigator";
            this.keyAttributesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.keyAttributesBindingNavigator.Size = new System.Drawing.Size(1581, 31);
            this.keyAttributesBindingNavigator.TabIndex = 1;
            this.keyAttributesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // keyAttributesBindingSource
            // 
            this.keyAttributesBindingSource.DataMember = "KeyAttributes";
            this.keyAttributesBindingSource.DataSource = this.normalizationDataSet;
            // 
            // normalizationDataSet
            // 
            this.normalizationDataSet.DataSetName = "NormalizationDataSet";
            this.normalizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // keyAttributesBindingNavigatorSaveItem
            // 
            this.keyAttributesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.keyAttributesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("keyAttributesBindingNavigatorSaveItem.Image")));
            this.keyAttributesBindingNavigatorSaveItem.Name = "keyAttributesBindingNavigatorSaveItem";
            this.keyAttributesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.keyAttributesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.keyAttributesBindingNavigatorSaveItem.Click += new System.EventHandler(this.keyAttributesBindingNavigatorSaveItem_Click);
            // 
            // keyAttributesDataGridView
            // 
            this.keyAttributesDataGridView.AutoGenerateColumns = false;
            this.keyAttributesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyAttributesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.keyAttributesDataGridView.DataSource = this.keyAttributesBindingSource;
            this.keyAttributesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyAttributesDataGridView.Location = new System.Drawing.Point(0, 31);
            this.keyAttributesDataGridView.Name = "keyAttributesDataGridView";
            this.keyAttributesDataGridView.RowHeadersWidth = 51;
            this.keyAttributesDataGridView.RowTemplate.Height = 24;
            this.keyAttributesDataGridView.Size = new System.Drawing.Size(1581, 427);
            this.keyAttributesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fd";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "№ функциональной зависимости";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "k_name";
            this.dataGridViewTextBoxColumn2.DataSource = this.attributesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "attribute_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Атрибут";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_attribute";
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "Attributes";
            this.attributesBindingSource.DataSource = this.normalizationDataSet;
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
            // keyAttributesTableAdapter
            // 
            this.keyAttributesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttributesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KeyAttributesTableAdapter = this.keyAttributesTableAdapter;
            this.tableAdapterManager.NotKeyAttributesTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NDBtest.NormalizationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.VariantsTableAdapter = null;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // KeyAtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 458);
            this.Controls.Add(this.keyAttributesDataGridView);
            this.Controls.Add(this.keyAttributesBindingNavigator);
            this.Name = "KeyAtr";
            this.Text = "Ключевые атрибуты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeyAtr_FormClosed);
            this.Load += new System.EventHandler(this.KeyAtr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingNavigator)).EndInit();
            this.keyAttributesBindingNavigator.ResumeLayout(false);
            this.keyAttributesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAttributesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NormalizationDataSet normalizationDataSet;
        private System.Windows.Forms.BindingSource keyAttributesBindingSource;
        private NormalizationDataSetTableAdapters.KeyAttributesTableAdapter keyAttributesTableAdapter;
        private NormalizationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator keyAttributesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton keyAttributesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView keyAttributesDataGridView;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private NormalizationDataSetTableAdapters.AttributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}