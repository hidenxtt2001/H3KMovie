namespace H3K.InterFace.Movie_Mange
{
    partial class MovieItem
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradientPanel1 = new H3K.InterFace.Movie_Mange.GradientPanel();
            this.poster = new System.Windows.Forms.Panel();
            this.poster.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBotton = System.Drawing.Color.Black;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Transparent;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 142);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Opacity = 80;
            this.gradientPanel1.Size = new System.Drawing.Size(154, 81);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.gradientPanel1.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // poster
            // 
            this.poster.Controls.Add(this.gradientPanel1);
            this.poster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poster.Location = new System.Drawing.Point(3, 3);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(154, 223);
            this.poster.TabIndex = 1;
            this.poster.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.poster.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.poster);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MovieItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(160, 229);
            this.poster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel poster;
    }
}
