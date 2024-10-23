namespace NDBtest
{
    partial class NotKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotKeys));
            this.normalizationDataSet = new NDBtest.NormalizationDataSet();
            this.notKeyAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notKeyAttributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.NotKeyAttributesTableAdapter();
            this.tableAdapterManager = new NDBtest.NormalizationDataSetTableAdapters.TableAdapterManager();
            this.notKeyAttributesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.notKeyAttributesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.notKeyAttributesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesTableAdapter = new NDBtest.NormalizationDataSetTableAdapters.AttributesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingNavigator)).BeginInit();
            this.notKeyAttributesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // normalizationDataSet
            // 
            this.normalizationDataSet.DataSetName = "NormalizationDataSet";
            this.normalizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttributesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KeyAttributesTableAdapter = null;
            this.tableAdapterManager.NotKeyAttributesTableAdapter = this.notKeyAttributesTableAdapter;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NDBtest.NormalizationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.VariantsTableAdapter = null;
            // 
            // notKeyAttributesBindingNavigator
            // 
            this.notKeyAttributesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notKeyAttributesBindingNavigator.BindingSource = this.notKeyAttributesBindingSource;
            this.notKeyAttributesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notKeyAttributesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notKeyAttributesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notKeyAttributesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notKeyAttributesBindingNavigatorSaveItem});
            this.notKeyAttributesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notKeyAttributesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notKeyAttributesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notKeyAttributesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notKeyAttributesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notKeyAttributesBindingNavigator.Name = "notKeyAttributesBindingNavigator";
            this.notKeyAttributesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notKeyAttributesBindingNavigator.Size = new System.Drawing.Size(1122, 31);
            this.notKeyAttributesBindingNavigator.TabIndex = 0;
            this.notKeyAttributesBindingNavigator.Text = "bindingNavigator1";
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
            // notKeyAttributesBindingNavigatorSaveItem
            // 
            this.notKeyAttributesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notKeyAttributesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notKeyAttributesBindingNavigatorSaveItem.Image")));
            this.notKeyAttributesBindingNavigatorSaveItem.Name = "notKeyAttributesBindingNavigatorSaveItem";
            this.notKeyAttributesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.notKeyAttributesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.notKeyAttributesBindingNavigatorSaveItem.Click += new System.EventHandler(this.notKeyAttributesBindingNavigatorSaveItem_Click);
            // 
            // notKeyAttributesDataGridView
            // 
            this.notKeyAttributesDataGridView.AutoGenerateColumns = false;
            this.notKeyAttributesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notKeyAttributesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.notKeyAttributesDataGridView.DataSource = this.notKeyAttributesBindingSource;
            this.notKeyAttributesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notKeyAttributesDataGridView.Location = new System.Drawing.Point(0, 31);
            this.notKeyAttributesDataGridView.Name = "notKeyAttributesDataGridView";
            this.notKeyAttributesDataGridView.RowHeadersWidth = 51;
            this.notKeyAttributesDataGridView.RowTemplate.Height = 24;
            this.notKeyAttributesDataGridView.Size = new System.Drawing.Size(1122, 419);
            this.notKeyAttributesDataGridView.TabIndex = 1;
            this.notKeyAttributesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.notKeyAttributesDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fd";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ функциональной зависимости";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 255;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nk_name";
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
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // NotKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.notKeyAttributesDataGridView);
            this.Controls.Add(this.notKeyAttributesBindingNavigator);
            this.Name = "NotKeys";
            this.Text = "Неключевые атрибуты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NotKeys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.normalizationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesBindingNavigator)).EndInit();
            this.notKeyAttributesBindingNavigator.ResumeLayout(false);
            this.notKeyAttributesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notKeyAttributesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NormalizationDataSet normalizationDataSet;
        private System.Windows.Forms.BindingSource notKeyAttributesBindingSource;
        private NormalizationDataSetTableAdapters.NotKeyAttributesTableAdapter notKeyAttributesTableAdapter;
        private NormalizationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notKeyAttributesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notKeyAttributesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView notKeyAttributesDataGridView;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private NormalizationDataSetTableAdapters.AttributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}