using System;
using System.Drawing;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Gaming_Library.FE.Dialog.Framework.UserInterface;
using Gaming_Library.Properties;

namespace Gaming_Library
{
    public partial class LibraryDialog : Form
    {
        private bool resizing = false;
        private bool isPanelCollapsed = true;
        public LibraryDialog()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //request to controller to return data from DA as list of viewmodels

            //objectListView1.SetObjects(listofViewModels);
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
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void spielEntfernenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            //request to controller
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs eventArguments)
        {
            //start game
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs eventArguments)
        {
            //// Ignore if a column or row header is clicked
            //if (eventArguments.RowIndex != -1 && eventArguments.ColumnIndex != -1) {
            //    if (eventArguments.Button == MouseButtons.Right) {
            //        dataGridView1.CurrentCell = (sender as DataGridView).Rows[eventArguments.RowIndex].Cells[eventArguments.ColumnIndex];

            //        // Get mouse position relative to the vehicles grid
            //        var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

            //        // Show the context menu
            //        contextMenuStrip2.Show(dataGridView1, relativeMousePosition);
            //    }
            //}
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == Settings.Default.SearchField) {
                textBox1.Text = "";
                textBox1.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.SearchField;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void objectListView1_SizeChanged(object sender, EventArgs e)
        {
            if (resizing) {
                return;
            }
            // Set the resizing flag
            resizing = true;

            ObjectListView objectListView = sender as ObjectListView;
            if (objectListView != null) {
                float totalColumnWidth = 0;

                // Get the sum of all column tags
                for (int i = 0; i < objectListView.Columns.Count; i++) {
                    totalColumnWidth += Convert.ToInt32(objectListView.Columns[i].Tag);
                }

                // Calculate the percentage of space each column should 
                // occupy in reference to the other columns and then set the 
                // width of the column to that percentage of the visible space.
                for (int i = 0; i < objectListView.Columns.Count; i++) {
                    float colPercentage = (Convert.ToInt32(objectListView.Columns[i].Tag) / totalColumnWidth);

                    objectListView.Columns[i].Width = (int)(colPercentage * objectListView.ClientRectangle.Width);
                }
            }
            resizing = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void setObjectListAnchorForFilterPanel()
        {
            //we need to remove the top-anchor to be able to move the objectlist further down
            objectListView1.Anchor =
                AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }
        private void resetObjectListAnchor()
        {
            objectListView1.Anchor =
                AnchorStyles.Top
                | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }

        private void AdjustComponents(int adjustment)
        {
            //if (WindowState == FormWindowState.Maximized) {
            objectListView1.Location = new Point(
                objectListView1.Location.X,
                objectListView1.Location.Y + adjustment
                );
            panel1.Height += adjustment;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setObjectListAnchorForFilterPanel();

            if (isPanelCollapsed) {

                AdjustComponents(4);
                if (panel1.Height == panel1.MaximumSize.Height) {
                    isPanelCollapsed = false;
                    timer1.Stop();
                }
            } else if (!isPanelCollapsed) {
                AdjustComponents(-4);
                if (panel1.Height == 0) {
                    isPanelCollapsed = true;
                    timer1.Stop();
                }
            }

            resetObjectListAnchor();
        }
    }
}
