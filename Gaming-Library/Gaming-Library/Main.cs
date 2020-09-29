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

namespace Gaming_Library
{
    public partial class Main : Form
    {
        public Main()
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
    }
}
