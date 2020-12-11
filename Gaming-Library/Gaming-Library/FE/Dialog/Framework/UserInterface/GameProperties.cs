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
using BrightIdeasSoftware;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.FE.Dialog.Framework.UserInterface
{
    public partial class GameProperties : Form
    {
        private bool isPropertiesViewCollapsed = true;
        private Adapter.Controller.IController _controller;
        private int _gameIndex;

        public GameProperties(Adapter.Controller.IController controller, int nextGameIndex)
        {
            _gameIndex = nextGameIndex;
            _controller = controller;
            _controller.AddGame();
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.DeleteGame(_gameIndex);
            Close();
        }

        private void saveProperties_Click(object sender, EventArgs e)
        {
            _controller
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                //request to controller with ofd.FileName
            }
        }

        private void buttonSetFolderPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                //request to controller with ofd.FileName
            }
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            if (isPropertiesViewCollapsed) {
                Height = MaximumSize.Height;
                Width = MaximumSize.Width;
                panel1.Visible = true;
                isPropertiesViewCollapsed = false;
                buttonProperties.Image = Properties.Resources.shrink_white;
            } else {
                Height = MinimumSize.Height;
                Width = MinimumSize.Width;
                panel1.Visible = false;
                isPropertiesViewCollapsed = true;
                buttonProperties.Image = Properties.Resources.expand_white;
            }

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
