﻿namespace H3K.InterFace.Movie_Mange
{
    partial class AlbumMovies
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
            this.poster = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.poster.SuspendLayout();
            this.SuspendLayout();
            // 
            // poster
            // 
            this.poster.BackColor = System.Drawing.Color.Black;
            this.poster.Controls.Add(this.label2);
            this.poster.Controls.Add(this.label1);
            this.poster.Controls.Add(this.panel1);
            this.poster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poster.Location = new System.Drawing.Point(6, 6);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(277, 396);
            this.poster.TabIndex = 8;
            this.poster.Click += new System.EventHandler(this.AlbumControl_Click);
            this.poster.Paint += new System.Windows.Forms.PaintEventHandler(this.poster_Paint);
            this.poster.MouseLeave += new System.EventHandler(this.poster_MouseLeave);
            this.poster.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 101);
            this.label2.TabIndex = 4;
            this.label2.Text = "Content";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.AlbumControl_Click);
            this.label2.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.AlbumControl_Click);
            this.label1.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(28, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.AlbumControl_Click);
            this.panel1.MouseHover += new System.EventHandler(this.poster_MouseHover);
            // 
            // AlbumMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.poster);
            this.Name = "AlbumMovies";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(289, 408);
            this.Click += new System.EventHandler(this.AlbumControl_Click);
            this.poster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel poster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
