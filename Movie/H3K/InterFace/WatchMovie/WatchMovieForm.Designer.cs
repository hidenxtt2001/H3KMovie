namespace H3K.InterFace
{
    partial class WatchMovieForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.poster = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rating = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(401, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Watch Movie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // poster
            // 
            this.poster.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.poster.Location = new System.Drawing.Point(13, 41);
            this.poster.Margin = new System.Windows.Forms.Padding(4);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(335, 449);
            this.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster.TabIndex = 0;
            this.poster.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.content);
            this.panel1.Controls.Add(this.director);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(394, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 374);
            this.panel1.TabIndex = 6;
            // 
            // rating
            // 
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(193)))), ((int)(((byte)(92)))));
            this.rating.Location = new System.Drawing.Point(110, 9);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(171, 28);
            this.rating.TabIndex = 3;
            this.rating.Text = "label4";
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(6, 155);
            this.content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(748, 203);
            this.content.TabIndex = 2;
            this.content.Text = "label3";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director.ForeColor = System.Drawing.Color.White;
            this.director.Location = new System.Drawing.Point(7, 111);
            this.director.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(69, 23);
            this.director.TabIndex = 1;
            this.director.Text = "director";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(4, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(769, 111);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // WatchMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1219, 514);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poster);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WatchMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H3K Watch Movie Online";
            this.Load += new System.EventHandler(this.WatchMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label title;
    }
}