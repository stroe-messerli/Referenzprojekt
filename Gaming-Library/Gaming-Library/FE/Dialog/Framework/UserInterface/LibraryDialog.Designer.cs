using System.Windows.Forms;

namespace Gaming_Library
{
    partial class LibraryDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryDialog));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spieleAnzeigenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.spielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spielStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenschaftenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielEntfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spieleAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn0 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesImageList = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gameDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spieleAnzeigenToolStripMenuItem1,
            this.gToolStripMenuItem,
            this.spielHinzufügenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 54);
            this.contextMenuStrip1.MouseLeave += new System.EventHandler(this.contextMenuStrip1_MouseLeave);
            // 
            // spieleAnzeigenToolStripMenuItem1
            // 
            this.spieleAnzeigenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("spieleAnzeigenToolStripMenuItem1.Image")));
            this.spieleAnzeigenToolStripMenuItem1.Name = "spieleAnzeigenToolStripMenuItem1";
            this.spieleAnzeigenToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.spieleAnzeigenToolStripMenuItem1.Text = "Spiele anzeigen";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(159, 6);
            // 
            // spielHinzufügenToolStripMenuItem
            // 
            this.spielHinzufügenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("spielHinzufügenToolStripMenuItem.Image")));
            this.spielHinzufügenToolStripMenuItem.Name = "spielHinzufügenToolStripMenuItem";
            this.spielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spielHinzufügenToolStripMenuItem.Text = "Spiel hinzufügen";
            this.spielHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.spielHinzufügenToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielStartenToolStripMenuItem,
            this.eigenschaftenToolStripMenuItem,
            this.spielEntfernenToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(154, 70);
            // 
            // spielStartenToolStripMenuItem
            // 
            this.spielStartenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("spielStartenToolStripMenuItem.Image")));
            this.spielStartenToolStripMenuItem.Name = "spielStartenToolStripMenuItem";
            this.spielStartenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.spielStartenToolStripMenuItem.Text = "Spiel starten";
            // 
            // eigenschaftenToolStripMenuItem
            // 
            this.eigenschaftenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eigenschaftenToolStripMenuItem.Image")));
            this.eigenschaftenToolStripMenuItem.Name = "eigenschaftenToolStripMenuItem";
            this.eigenschaftenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eigenschaftenToolStripMenuItem.Text = "Eigenschaften";
            this.eigenschaftenToolStripMenuItem.Click += new System.EventHandler(this.eigenschaftenToolStripMenuItem_Click);
            // 
            // spielEntfernenToolStripMenuItem1
            // 
            this.spielEntfernenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("spielEntfernenToolStripMenuItem1.Image")));
            this.spielEntfernenToolStripMenuItem1.Name = "spielEntfernenToolStripMenuItem1";
            this.spielEntfernenToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.spielEntfernenToolStripMenuItem1.Text = "Spiel entfernen";
            // 
            // spieleAnzeigenToolStripMenuItem
            // 
            this.spieleAnzeigenToolStripMenuItem.Name = "spieleAnzeigenToolStripMenuItem";
            this.spieleAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spieleAnzeigenToolStripMenuItem.Text = "Spiele anzeigen";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Image = global::Gaming_Library.Properties.Resources.expand_button;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Spiele";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(338, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Statistiken";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn0);
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn0,
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(0, 80);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(800, 482);
            this.objectListView1.SmallImageList = this.gamesImageList;
            this.objectListView1.TabIndex = 8;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_CellClick);
            this.objectListView1.SizeChanged += new System.EventHandler(this.objectListView1_SizeChanged);
            this.objectListView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.objectListView1_MouseDown);
            // 
            // olvColumn0
            // 
            this.olvColumn0.AspectName = "Title";
            this.olvColumn0.Tag = "1";
            this.olvColumn0.Text = "Titel";
            this.olvColumn0.Width = 144;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Genre";
            this.olvColumn1.Tag = "1";
            this.olvColumn1.Text = "Genre";
            this.olvColumn1.Width = 188;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "YearOfPublication";
            this.olvColumn2.Tag = "1";
            this.olvColumn2.Text = "Erscheinungsjahr";
            this.olvColumn2.Width = 231;
            // 
            // gamesImageList
            // 
            this.gamesImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.gamesImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.gamesImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(666, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Suchen  🔍";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.button3.Image = global::Gaming_Library.Properties.Resources.expand_button1;
            this.button3.Location = new System.Drawing.Point(10, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Filtern ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.DarkMagenta;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(666, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 20);
            this.button4.TabIndex = 11;
            this.button4.Text = "Stuff";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.MaximumSize = new System.Drawing.Size(4000, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 0);
            this.panel1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(627, -28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Zurücksetzen";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(720, -28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Anwenden";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(184, 3);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Multiplayer";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(98, 3);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Action";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 3);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Horror";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 13;
            // 
            // gameDataBindingSource1
            // 
            this.gameDataBindingSource1.DataSource = typeof(Gaming_Library.BL.UseCase.Entity.GameData);
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataSource = typeof(Gaming_Library.BL.UseCase.Entity.GameData);
            // 
            // LibraryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 5000);
            this.MinimumSize = new System.Drawing.Size(524, 473);
            this.Name = "LibraryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliothek";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem spielStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenschaftenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielEntfernenToolStripMenuItem1;
        private ToolStripMenuItem spieleAnzeigenToolStripMenuItem1;
        private ToolStripSeparator gToolStripMenuItem;
        private ToolStripMenuItem spieleAnzeigenToolStripMenuItem;
        private Button button1;
        private Button button2;
        private BindingSource gameDataBindingSource1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn0;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private Button button3;
        private TextBox textBox1;
        private ImageList gamesImageList;
        private Button button4;
        private Timer timer1;
        private Panel panel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button5;
        private Button button6;
        private Panel panel2;
    }
}