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
using Gaming_Library.BL.UseCase.Entity.Types;
using System.IO;

namespace Gaming_Library.FE.Dialog.Framework.UserInterface
{
    public partial class GameProperties : Form
    {
        private bool isPropertiesViewCollapsed = true;

        private readonly Adapter.Controller.IController _controller;
        private readonly Adapter.View.Model.GameData _game;
        private readonly int _gameIndex;

        public GameProperties(Adapter.Controller.IController controller, Adapter.View.Model.GameData game)
        {
            _game = game;
            //_gameIndex = _game..Count - 1;
            _controller = controller;
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveProperties_Click(object sender, EventArgs e)
        {
            _game.Attributes.HasFullControllerSupport = controllerFull.Checked;
            _game.Attributes.HasPartialControllerSupport = controllerPart.Checked;
            _game.Attributes.IsCooperative = isCoop.Checked;
            _game.Attributes.IsMultiPlayer = isMultiPlayer.Checked;
            _game.Attributes.IsSinglePlayer = isSinglePlayer.Checked;
            _game.Attributes.IsVRSupportive = isVR.Checked;
            _game.Attributes.HasAchievements = true;
            _game.Publisher = publisher.Text;
            _game.Tags = tags.Text.Split(',').ToArray();
            _game.Genre = (string)genresCombo.SelectedItem;
            _game.Location = locationPath.Text;
            _game.Title = title.Text;
            _game.Year = publicationYear.Text;

            //check if adding or modifying
            _controller.AddGame(_game);
            Close();
        }

        private void searchForTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                _game.Image = new Bitmap(ofd.FileName);
                _game.Image = ResizeImage(_game.Image);
                imagePath.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private Bitmap ResizeImage(Bitmap image)
        {
            return new Bitmap(image, new Size(110, 62));
        }

        private void buttonSetFolderPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                locationPath.Text = ofd.FileName;
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

        private void AdjustComponents(int adjustment)
        {
            Height += adjustment;
            Width += adjustment;
        }
    }
}
