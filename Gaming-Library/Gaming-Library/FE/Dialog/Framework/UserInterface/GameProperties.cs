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

        public GameProperties(Adapter.Controller.IController controller, Adapter.View.Model.GameData game, int gameIndex = -1)
        {
            _gameIndex = gameIndex;
            _game = game;
            _controller = controller;

            InitializeComponent();
            SetupTooltips();

            if (_gameIndex >= 0) {
                SetupControls();
            }
        }

        private void SetupTooltips()
        {
            toolTip1.SetToolTip(locationPath, "Der lokale Pfad der .exe-Datei");
        }

        private void SetupControls()
        {
            controllerFull.Checked = _game.Attributes.HasFullControllerSupport;
            controllerPart.Checked = _game.Attributes.HasPartialControllerSupport;
            isCoop.Checked = _game.Attributes.IsCooperative;
            isMultiPlayer.Checked = _game.Attributes.IsMultiPlayer;
            isSinglePlayer.Checked = _game.Attributes.IsSinglePlayer;
            isVR.Checked = _game.Attributes.IsVRSupportive;
            publisher.Text = _game.Publisher;
            tags.Text = string.Join(",", _game.Tags);
            genresCombo.Items.Add(_game.Genre);
            locationPath.Text = _game.Location;
            title.Text = _game.Title;
            publicationYear.Text = _game.Year;
            imagePath.Text = Path.GetFileName(_game.ImagePath);
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

            if (_gameIndex >= 0) {
                _controller.ModifyGame(_gameIndex, _game);
            } else {
                _controller.AddGame(_game);
            }
            Close();
        }

        private void searchForTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                try {
                    _game.Image = new Bitmap(ofd.FileName);
                } catch (ArgumentException) {
                    MessageBox.Show(
                    "Ausgewähltes Bild ist zu gross.\nVerkleinern Sie es, oder wählen Sie ein anderes Bild!",
                    "Information",
                    MessageBoxButtons.OK);
                    return;
                }
                _game.Image = ResizeImage(_game.Image);
                _game.ImagePath = ofd.FileName;
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
