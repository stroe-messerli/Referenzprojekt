using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Gaming_Library.FE.Dialog.Framework.UserInterface;

namespace Gaming_Library
{
    public partial class LibraryDialog : Form
    {
        public LibraryDialog()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }

        private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (!contextMenuStrip1.Bounds.Contains(MousePosition)) {
                contextMenuStrip1.Hide();
            }
        }

        private void spielHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void spielEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 0, 62, Width, 62);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //start game
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1) {
                if (e.Button == MouseButtons.Right) {
                    this.dataGridView1.CurrentCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip2.Show(dataGridView1, relativeMousePosition);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var propertiesForm = new GameProperties();
            propertiesForm.Show();
        }
    }
}
