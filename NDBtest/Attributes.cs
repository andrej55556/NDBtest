using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace NDBtest
{
    public partial class Attributes : Form
    {
        public Attributes(/*int var*/)//передать сюда вариант
        {
            InitializeComponent();
            //this.var = var;

           /* using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                cn.OpenConnection();
                var sql = "select v.name from \"Variants\" v \r\nwhere v.id  = @var";

                var cmd = cn.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@var", var);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    label1.Text = dr["name"].ToString();
                }
                cn.Dispose();
                dr.Dispose();
            }*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.NotKeyAttributes". При необходимости она может быть перемещена или удалена.
                this.notKeyAttributesTableAdapter.Fill(this.normalizationDataSet.NotKeyAttributes);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.KeyAttributes". При необходимости она может быть перемещена или удалена.
                this.keyAttributesTableAdapter.Fill(this.normalizationDataSet.KeyAttributes);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.Attributes". При необходимости она может быть перемещена или удалена.
                this.attributesTableAdapter.Fill(this.normalizationDataSet.Attributes);


                this.normalizationDataSet.Attributes.variantColumn.DefaultValue = Global.variant;
                this.normalizationDataSet.KeyAttributes.variantColumn.DefaultValue = Global.variant;
                this.normalizationDataSet.NotKeyAttributes.variantColumn.DefaultValue = Global.variant;

                /*string filterExpression = $"variant = {Global.variant}";
                notKeyAttributesBindingSource.Filter = filterExpression;
                keyAttributesBindingSource.Filter = filterExpression;
                attributesBindingSource.Filter = filterExpression;*/

                DataView view = new DataView(this.normalizationDataSet.Attributes);
                view.RowFilter = $"variant = {Global.variant}";
                dataGridView1.DataSource = view;

                /*DataView view2 = new DataView(this.normalizationDataSet.KeyAttributes);
                view2.RowFilter = $"variant = {Global.variant}";
                dataGridView2.DataSource = view;

                DataView view3 = new DataView(this.normalizationDataSet.NotKeyAttributes);
                view3.RowFilter = $"variant = {Global.variant}";
                dataGridView3.DataSource = view;*/



                //dataGridView1.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.attributesBindingSource.EndEdit();
            this.attributesTableAdapter.Update(this.normalizationDataSet);
        }

       /* private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            *//*Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            int rowIndexOfItemUnderMouseToDrop = dataGridView2.HitTest(clientPoint.X, clientPoint.Y).RowIndex;


            DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
            //dataGridView2.Rows.RemoveAt(rowIndexFromMouseDown);
            dataGridView2.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);*/
            /*DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
            MessageBox.Show(rowToMove.Cells.ToString());*//*

            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = dataGridView1.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                //dataGridView1.Rows.RemoveAt(rowIndexFromMouseDown);
                dataGridView2.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
            }
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGridView1.DoDragDrop(
                          dataGridView1.Rows[rowIndexFromMouseDown],
                          DragDropEffects.Move);
                }
            }
        }

        private void dataGridView2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            *//*try 
            {
                dataGridView3.UpdateCellValue(1,e.RowIndex);
                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }*//*
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.keyAttributesBindingSource.EndEdit();
            this.keyAttributesTableAdapter.Update(this.normalizationDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.notKeyAttributesBindingSource.EndEdit();
            this.notKeyAttributesTableAdapter.Update(this.normalizationDataSet);
        }
    }
}
