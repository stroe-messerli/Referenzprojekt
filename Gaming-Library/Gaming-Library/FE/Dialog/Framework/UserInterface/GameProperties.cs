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
    }
}
