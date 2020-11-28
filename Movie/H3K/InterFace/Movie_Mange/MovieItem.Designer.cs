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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieItem));
            this.poster = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poster
            // 
            this.poster.BackColor = System.Drawing.Color.Black;
            this.poster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("poster.BackgroundImage")));
            this.poster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poster.Dock = System.Windows.Forms.DockStyle.Top;
            this.poster.Location = new System.Drawing.Point(5, 5);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(150, 185);
            this.poster.TabIndex = 0;
            this.poster.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.poster.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(5, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poster);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MovieItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(160, 229);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel poster;
        private System.Windows.Forms.Label label1;
    }
}
