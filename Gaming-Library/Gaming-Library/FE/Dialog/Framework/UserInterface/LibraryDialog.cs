using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Gaming_Library.BL.UseCase.Entity;
using Gaming_Library.BL.UseCase.Entity.Types;
using Gaming_Library.FE.Dialog.Adapter.View;
using Gaming_Library.FE.Dialog.Framework.UserInterface;
using Gaming_Library.Properties;

namespace Gaming_Library
{
    public partial class LibraryDialog : Form, IView
    {
        private bool isDropdownCollapsed = true;
        private bool isFilterViewCollapsed = true;

        public LibraryDialog()
        {
            Settings.Default.Reset();
            InitializeComponent();
            if (!Settings.Default.FilterViewCollapsed) {
                timer1.Start();
            }
            LoadData();
        }

        public void UpdateView()
        {
            Update();
        }


        private void LoadData()
        {
            //request to controller to return data from DA as list of viewmodels
            var listOfViewModels = createTestObjects();
            gameListView.SetObjects(listOfViewModels);

        }

        private ViewModel[] createTestObjects()
        {
            ViewModel[] viewModels = new ViewModel[2];
            viewModels[0] = new ViewModel();
            viewModels[1] = new ViewModel();
            viewModels[0].Game.Genre = "Action";
            viewModels[0].Game.Title = "Among Us";
            viewModels[0].Game.Year = "01.01.2018";
            viewModels[0].Game.Image = new BL.UseCase.Entity.Types.Image(Resources.amongus);
            viewModels[1].Game.Genre = "Action";
            viewModels[1].Game.Title = "Counter Strike:Global Offensive";
            viewModels[1].Game.Year = "01.01.2012";
            viewModels[1].Game.Image = new BL.UseCase.Entity.Types.Image(Resources.csgo);
            return viewModels;
        }

        private void spielHinzufügenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void eigenschaftenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.TextAlign = HorizontalAlignment.Left;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = Settings.Default.SearchField;
            textBoxSearch.TextAlign = HorizontalAlignment.Right;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleFirstAccess();
            timer1.Start();
        }

        private void HandleFirstAccess()
        {
            if (Settings.Default.IsFirstAccess) {
                DialogResult dialogResult = MessageBox.Show(
                    "Möchten Sie die Filter-View zu Beginn anzeigen lassen?\n",
                    "Filter-View",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Settings.Default.FilterViewCollapsed = false;
                }
                Settings.Default.IsFirstAccess = false;
                Settings.Default.Save();
            }
        }
        private void setObjectListAnchorsForFilterPanel()
        {
            //we need to remove the top-anchor to be able to move the objectlist further down
            gameListView.Anchor =
                AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }

        private void resetObjectListAnchors()
        {
            gameListView.Anchor =
                AnchorStyles.Top
                | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }

        private void AdjustComponents(int adjustment)
        {
            //if (WindowState == FormWindowState.Maximized) {
            gameListView.Location = new Point(
                gameListView.Location.X,
                gameListView.Location.Y + adjustment
                );
            panel1.Height += adjustment;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setObjectListAnchorsForFilterPanel();

            if (isFilterViewCollapsed) {
                buttonShowFilter.Image = Properties.Resources.shrink_white;
                AdjustComponents(5);
                if (panel1.Height == panel1.MaximumSize.Height) {
                    isFilterViewCollapsed = false;
                    timer1.Stop();
                }
            } else if (!isFilterViewCollapsed) {
                buttonShowFilter.Image = Properties.Resources.expand_white;
                AdjustComponents(-5);
                if (panel1.Height == panel1.MinimumSize.Height) {
                    isFilterViewCollapsed = true;
                    timer1.Stop();
                }
            }

            resetObjectListAnchors();
        }

        private void objectListView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                //ignore, if no row is selected
                if (gameListView.SelectedItem != null) {
                    var mousePosition = gameListView.PointToClient(Cursor.Position);
                    contextMenuStrip2.Show(gameListView, mousePosition);
                }
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            //hide button after action was requested
            timer2.Start();
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs eventArguments)
        {
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isDropdownCollapsed) {
                buttonGames.Image = Properties.Resources.shrink_white;
                panel3.Height += 2;
                if (panel3.Height == panel3.MaximumSize.Height) {
                    isDropdownCollapsed = false;
                    timer2.Stop();
                }
            } else if (!isDropdownCollapsed) {
                buttonGames.Image = Properties.Resources.expand_white;
                panel3.Height -= 2;
                if (panel3.Height == panel3.MinimumSize.Height) {
                    isDropdownCollapsed = true;
                    timer2.Stop();
                }
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearchTags.Text = "";
            textBoxSearchTags.Font = new Font(textBoxSearchTags.Font, FontStyle.Regular);
            textBoxSearchTags.ForeColor = Color.Black;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearchTags.Text = Settings.Default.FilterField;
            textBoxSearchTags.Font = new Font(textBoxSearchTags.Font, FontStyle.Italic);
            textBoxSearchTags.ForeColor = Color.Gray;

            checkAction.Checked = false;
            checkMMP.Checked = false;
            checkRPG.Checked = false;
            checkRacing.Checked = false;
            checkIndie.Checked = false;
            checkCasual.Checked = false;
            checkAdventure.Checked = false;
            checkStrategy.Checked = false;
            checkSinglePlayer.Checked = false;
            checkSimulation.Checked = false;
            checkSports.Checked = false;
            checkCoop.Checked = false;
            checkMultiplayer.Checked = false;
            checkControllerPartial.Checked = false;
            checkVR.Checked = false;
            checkControllerFull.Checked = false;
        }

        private void gameListView_DoubleClick(object sender, EventArgs e)
        {
            //request to controller
            Process.Start("steam://rungameid/945360");
        }

        private void spielEntfernenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //request to controller for removal of the item in DA, so the FE can be updated 
            //using LoadObjects()
            gameListView.Items.Remove(gameListView.SelectedItem);
            gameListView.Update();
            Update();
        }

        private void spielStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //request to controller
            Process.Start("steam://rungameid/945360");
        }
    }
}
