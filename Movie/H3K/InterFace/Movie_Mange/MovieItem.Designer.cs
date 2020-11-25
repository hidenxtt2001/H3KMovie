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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 236);
            this.title.MaximumSize = new System.Drawing.Size(200, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(6);
            this.title.Size = new System.Drawing.Size(54, 26);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Dock = System.Windows.Forms.DockStyle.Top;
            this.director.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director.Location = new System.Drawing.Point(0, 262);
            this.director.MaximumSize = new System.Drawing.Size(200, 0);
            this.director.Name = "director";
            this.director.Padding = new System.Windows.Forms.Padding(6);
            this.director.Size = new System.Drawing.Size(75, 26);
            this.director.TabIndex = 2;
            this.director.Text = "Director";
            this.director.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.director);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MovieItem";
            this.Size = new System.Drawing.Size(200, 288);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label director;
    }
}
