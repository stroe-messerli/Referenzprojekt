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
            this.spielEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spielStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenschaftenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielEntfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spieleAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spieleAnzeigenToolStripMenuItem1,
            this.gToolStripMenuItem,
            this.spielHinzufügenToolStripMenuItem,
            this.spielEntfernenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 76);
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
            // spielEntfernenToolStripMenuItem
            // 
            this.spielEntfernenToolStripMenuItem.Image = global::Gaming_Library.Properties.Resources.delete;
            this.spielEntfernenToolStripMenuItem.Name = "spielEntfernenToolStripMenuItem";
            this.spielEntfernenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spielEntfernenToolStripMenuItem.Text = "Spiel entfernen";
            this.spielEntfernenToolStripMenuItem.Click += new System.EventHandler(this.spielEntfernenToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spiele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.genre,
            this.publicationyear,
            this.image});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(408, 152);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // title
            // 
            this.title.HeaderText = "Titel";
            this.title.Name = "title";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // publicationyear
            // 
            this.publicationyear.HeaderText = "Erscheinungsjahr";
            this.publicationyear.Name = "publicationyear";
            // 
            // image
            // 
            this.image.HeaderText = "Bild";
            this.image.Name = "image";
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.spielStartenToolStripMenuItem.Name = "spielStartenToolStripMenuItem";
            this.spielStartenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.spielStartenToolStripMenuItem.Text = "Spiel starten";
            // 
            // eigenschaftenToolStripMenuItem
            // 
            this.eigenschaftenToolStripMenuItem.Name = "eigenschaftenToolStripMenuItem";
            this.eigenschaftenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eigenschaftenToolStripMenuItem.Text = "Eigenschaften";
            // 
            // spielEntfernenToolStripMenuItem1
            // 
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataSource = typeof(Gaming_Library.BL.UseCase.Entity.GameData);
            // 
            // LibraryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(424, 307);
            this.Name = "LibraryDialog";
            this.Text = "Bibliothek";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielEntfernenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem spielStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenschaftenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielEntfernenToolStripMenuItem1;
        private ToolStripMenuItem spieleAnzeigenToolStripMenuItem1;
        private ToolStripSeparator gToolStripMenuItem;
        private ToolStripMenuItem spieleAnzeigenToolStripMenuItem;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn publicationyear;
        private DataGridViewImageColumn image;
        private GroupBox groupBox1;
    }
}