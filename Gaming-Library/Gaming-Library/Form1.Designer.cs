namespace Gaming_Library
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            this.ratingControl1 = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.SuspendLayout();
            // 
            // ratingControl1
            // 
            this.ratingControl1.ApplyGradientColors = false;
            this.ratingControl1.Images = customImageCollection1;
            this.ratingControl1.Location = new System.Drawing.Point(50, 65);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.ResetButton = resetButton1;
            this.ratingControl1.Size = new System.Drawing.Size(148, 27);
            this.ratingControl1.TabIndex = 0;
            this.ratingControl1.Text = "ratingControl1";
            this.ratingControl1.ThemeName = "Default";
            this.ratingControl1.Value = 3F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.ratingControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RatingControl ratingControl1;
    }
}

