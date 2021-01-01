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
                this.Content = null;
                this.title = null;
                this.ImageBackgournd = null;
                this.Director = null;
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
            this.title = new System.Windows.Forms.Label();
            this.poster = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(5, 190);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(143, 34);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.watch_click);
            this.title.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.title.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // poster
            // 
            this.poster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(147)))), ((int)(((byte)(191)))));
            this.poster.BackgroundImage = global::H3K.Properties.Resources.icons8_film_reel_64;
            this.poster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.poster.Dock = System.Windows.Forms.DockStyle.Top;
            this.poster.Location = new System.Drawing.Point(5, 5);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(143, 185);
            this.poster.TabIndex = 0;
            this.poster.Click += new System.EventHandler(this.watch_click);
            this.poster.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.poster.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.title);
            this.Controls.Add(this.poster);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MovieItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(153, 229);
            this.Load += new System.EventHandler(this.MovieItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel poster;
        private System.Windows.Forms.Label title;
    }
}
