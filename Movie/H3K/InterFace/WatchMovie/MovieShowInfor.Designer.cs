namespace H3K.InterFace.WatchMovie
{
    partial class MovieShowInfor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.poster = new System.Windows.Forms.Panel();
            this.infor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.watch_movie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gradientPanel1 = new H3K.InterFace.WatchMovie.GradientPanel();
            this.director = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rating = new H3K.InterFace.WatchMovie.RatingStar();
            this.tableLayoutPanel1.SuspendLayout();
            this.poster.SuspendLayout();
            this.infor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.83827F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.16173F));
            this.tableLayoutPanel1.Controls.Add(this.poster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.infor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // poster
            // 
            this.poster.BackColor = System.Drawing.Color.Transparent;
            this.poster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poster.Controls.Add(this.gradientPanel1);
            this.poster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poster.Location = new System.Drawing.Point(0, 0);
            this.poster.Margin = new System.Windows.Forms.Padding(0);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(340, 483);
            this.poster.TabIndex = 1;
            // 
            // infor
            // 
            this.infor.Controls.Add(this.button2);
            this.infor.Controls.Add(this.watch_movie);
            this.infor.Controls.Add(this.title);
            this.infor.Controls.Add(this.panel1);
            this.infor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infor.Location = new System.Drawing.Point(343, 3);
            this.infor.Name = "infor";
            this.infor.Padding = new System.Windows.Forms.Padding(60);
            this.infor.Size = new System.Drawing.Size(532, 477);
            this.infor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.content);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(60, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 241);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.panel2.Size = new System.Drawing.Size(15, 241);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(397, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(15, 241);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 100);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 100);
            this.panel5.TabIndex = 1;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.Snow;
            this.content.Location = new System.Drawing.Point(15, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(382, 241);
            this.content.TabIndex = 2;
            this.content.Text = "Content";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(484, 54);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // watch_movie
            // 
            this.watch_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.watch_movie.FlatAppearance.BorderSize = 0;
            this.watch_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch_movie.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watch_movie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.watch_movie.Location = new System.Drawing.Point(60, 357);
            this.watch_movie.Name = "watch_movie";
            this.watch_movie.Size = new System.Drawing.Size(176, 57);
            this.watch_movie.TabIndex = 2;
            this.watch_movie.Text = "Watch";
            this.watch_movie.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::H3K.Properties.Resources.icons8_delete;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(490, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBotton = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.director);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.rating);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 146);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Opacity = 180;
            this.gradientPanel1.Size = new System.Drawing.Size(340, 337);
            this.gradientPanel1.TabIndex = 1;
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director.ForeColor = System.Drawing.Color.LightCyan;
            this.director.Location = new System.Drawing.Point(33, 299);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(81, 19);
            this.director.TabIndex = 2;
            this.director.Text = "Director";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Director by";
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.Location = new System.Drawing.Point(12, 236);
            this.rating.Name = "rating";
            this.rating.Point = 50;
            this.rating.Size = new System.Drawing.Size(175, 35);
            this.rating.TabIndex = 0;
            // 
            // MovieShowInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieShowInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieShowInfor";
            this.Load += new System.EventHandler(this.MovieShowInfor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.poster.ResumeLayout(false);
            this.infor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel poster;
        private GradientPanel gradientPanel1;
        private RatingStar rating;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button watch_movie;
        private System.Windows.Forms.Button button2;
    }
}