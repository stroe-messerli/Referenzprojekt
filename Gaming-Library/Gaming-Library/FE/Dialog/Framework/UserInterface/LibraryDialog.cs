using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        private void button1_MouseHover(object sender, EventArgs eventArguments)
        {
            contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }

        private void contextMenuStrip1_MouseLeave(object sender, EventArgs eventArguments)
        {
            contextMenuStrip1.Hide();
        }

        private void button1_MouseLeave(object sender, EventArgs eventArguments)
        {
            if (!contextMenuStrip1.Bounds.Contains(MousePosition)) {
                contextMenuStrip1.Hide();
            }
        }

        private void spielHinzufügenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            //request an controller
        }

        private void spielEntfernenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            //request an controller
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs eventArguments)
        {
            //start game
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs eventArguments)
        {
            // Ignore if a column or row header is clicked
            if (eventArguments.RowIndex != -1 && eventArguments.ColumnIndex != -1) {
                if (eventArguments.Button == MouseButtons.Right) {
                    dataGridView1.CurrentCell = (sender as DataGridView).Rows[eventArguments.RowIndex].Cells[eventArguments.ColumnIndex];

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

                    // Show the context menu
                    contextMenuStrip2.Show(dataGridView1, relativeMousePosition);
                }
            }
        }

        private void button1_Click(object sender, EventArgs eventArguments)
        {
            if (contextMenuStrip1.Visible) {
                contextMenuStrip1.Hide();
                return;
            }
            contextMenuStrip1.Show();
        }

        private void eigenschaftenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }
    }
}
