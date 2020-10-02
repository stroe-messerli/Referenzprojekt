using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gaming_Library.FE.Dialog.Framework.UserInterface
{
    public partial class GameProperties : Form
    {
        private bool isPropertiesViewCollapsed = true;
        public GameProperties()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                //request to controller with ofd.FileName
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveProperties_Click(object sender, EventArgs e)
        {
            //request to controller
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                //request to controller with ofd.FileName
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetImagePath_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetFolderPath_Click(object sender, EventArgs e)
        {

        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AdjustComponents(int adjustment)
        {
            Height += adjustment;
            Width += adjustment;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPropertiesViewCollapsed) {
                buttonProperties.Image = Properties.Resources.shrink_white;
                AdjustComponents(10);
                if (panel1.Height == panel1.MaximumSize.Height) {
                    isPropertiesViewCollapsed = false;
                    timer1.Stop();
                }
            } else if (!isPropertiesViewCollapsed) {
                buttonProperties.Image = Properties.Resources.expand_white;
                AdjustComponents(-10);
                if (panel1.Height == panel1.MinimumSize.Height) {
                    isPropertiesViewCollapsed = true;
                    timer1.Stop();
                }
            }
        }
    }
}
