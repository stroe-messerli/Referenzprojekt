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
            this.olvColumn0 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spielStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenschaftenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielEntfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spieleAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesImageList = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gameDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // olvColumn0
            // 
            this.olvColumn0.AspectName = "Title";
            this.olvColumn0.FillsFreeSpace = true;
            this.olvColumn0.Groupable = false;
            this.olvColumn0.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn0.IsEditable = false;
            this.olvColumn0.Tag = "1";
            this.olvColumn0.Text = "Spiel";
            this.olvColumn0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn0.Width = 247;
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
            this.spielStartenToolStripMenuItem.Image = global::Gaming_Library.Properties.Resources.round_play_button;
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(342, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Statistiken";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn0);
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.White;
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.BackColor = System.Drawing.Color.LightGray;
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn0,
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.HideSelection = false;
            this.objectListView1.LargeImageList = this.gamesImageList;
            this.objectListView1.Location = new System.Drawing.Point(0, 93);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(0);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.RowHeight = 60;
            this.objectListView1.Size = new System.Drawing.Size(808, 348);
            this.objectListView1.SmallImageList = this.gamesImageList;
            this.objectListView1.SortGroupItemsByPrimaryColumn = false;
            this.objectListView1.TabIndex = 8;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SizeChanged += new System.EventHandler(this.objectListView1_SizeChanged);
            this.objectListView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.objectListView1_MouseDown);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.ImageAspectName = "Image";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.MaximumWidth = 110;
            this.olvColumn3.MinimumWidth = 110;
            this.olvColumn3.Sortable = false;
            this.olvColumn3.Text = "";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.Width = 110;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Genre";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Tag = "1";
            this.olvColumn1.Text = "Genre";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Width = 271;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "YearOfPublication";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Groupable = false;
            this.olvColumn2.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Tag = "1";
            this.olvColumn2.Text = "Erscheinungsjahr";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Width = 466;
            // 
            // gamesImageList
            // 
            this.gamesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gamesImageList.ImageStream")));
            this.gamesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.gamesImageList.Images.SetKeyName(0, "add.png");
            this.gamesImageList.Images.SetKeyName(1, "delete.png");
            this.gamesImageList.Images.SetKeyName(2, "die-einstellungen.ico");
            this.gamesImageList.Images.SetKeyName(3, "die-einstellungen.png");
            this.gamesImageList.Images.SetKeyName(4, "expand-button.png");
            this.gamesImageList.Images.SetKeyName(5, "image(1).png");
            this.gamesImageList.Images.SetKeyName(6, "round-play-button.png");
            this.gamesImageList.Images.SetKeyName(7, "show.png");
            this.gamesImageList.Images.SetKeyName(8, "shrink-button.png");
            this.gamesImageList.Images.SetKeyName(9, "shrink-white.png");
            this.gamesImageList.Images.SetKeyName(10, "spiele.ico");
            this.gamesImageList.Images.SetKeyName(11, "start.png");
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(674, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Suchen  🔍";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(674, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 20);
            this.button4.TabIndex = 11;
            this.button4.Text = "Stuff";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 91);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Location = new System.Drawing.Point(10, 31);
            this.panel3.MaximumSize = new System.Drawing.Size(124, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 0);
            this.panel3.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Image = global::Gaming_Library.Properties.Resources.plus_dark;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 28);
            this.button7.TabIndex = 18;
            this.button7.Text = "Hinzufügen";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button7_MouseClick);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Gaming_Library.Properties.Resources.expand_white;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Spiele";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::Gaming_Library.Properties.Resources.image_1_;
            this.button3.Location = new System.Drawing.Point(10, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Filtern ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox16);
            this.panel1.Controls.Add(this.checkBox15);
            this.panel1.Controls.Add(this.checkBox14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox13);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(4000, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 0);
            this.panel1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(635, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "hier tags eingeben";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tags";
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(517, 38);
            this.checkBox16.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(95, 17);
            this.checkBox16.TabIndex = 21;
            this.checkBox16.Text = "Controller (voll)";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(517, 56);
            this.checkBox15.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(41, 17);
            this.checkBox15.TabIndex = 20;
            this.checkBox15.Text = "VR";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(517, 20);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(119, 17);
            this.checkBox14.TabIndex = 19;
            this.checkBox14.Text = "Controller (teilweise)";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hardware Support";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Spieler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Genre";
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(320, 20);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(80, 17);
            this.checkBox13.TabIndex = 15;
            this.checkBox13.Text = "Mehrspieler";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(320, 56);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(77, 17);
            this.checkBox12.TabIndex = 14;
            this.checkBox12.Text = "Kooperativ";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(192, 56);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(56, 17);
            this.checkBox11.TabIndex = 13;
            this.checkBox11.Text = "Sports";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 20);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Action";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(101, 56);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(74, 17);
            this.checkBox10.TabIndex = 11;
            this.checkBox10.Text = "Simulation";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(320, 38);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(84, 17);
            this.checkBox9.TabIndex = 10;
            this.checkBox9.Text = "Einzelspieler";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(192, 74);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(65, 17);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Text = "Strategy";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(10, 38);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(75, 17);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Adventure";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(10, 56);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(58, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Casual";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(10, 74);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(49, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Indie";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(101, 20);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Racing";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(635, -28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Zurücksetzen";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button6_MouseClick);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(728, -28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Anwenden";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(101, 38);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "RPG";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(101, 74);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Massively MP";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(808, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 5000);
            this.MinimumSize = new System.Drawing.Size(824, 473);
            this.Name = "LibraryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliothek";
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem spielStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenschaftenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielEntfernenToolStripMenuItem1;
        private ToolStripMenuItem spieleAnzeigenToolStripMenuItem;
        private Button button2;
        private BindingSource gameDataBindingSource1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private Button button3;
        private TextBox textBox1;
        private ImageList gamesImageList;
        private Button button4;
        private Timer timer1;
        private Panel panel2;
        private BrightIdeasSoftware.OLVColumn olvColumn0;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private Button button1;
        private Timer timer2;
        private Panel panel3;
        private Button button7;
        private Panel panel1;
        private TextBox textBox2;
        private Label label4;
        private CheckBox checkBox16;
        private CheckBox checkBox15;
        private CheckBox checkBox14;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox13;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox1;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private Button button6;
        private Button button5;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
    }
}