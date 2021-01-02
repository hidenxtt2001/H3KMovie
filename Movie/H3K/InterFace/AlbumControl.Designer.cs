namespace H3K
{
    partial class AlbumControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumControl));
            this.hover_icon = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hover_icon
            // 
            this.hover_icon.BackColor = System.Drawing.Color.Black;
            this.hover_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hover_icon.BackgroundImage")));
            this.hover_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hover_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hover_icon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hover_icon.Location = new System.Drawing.Point(0, 0);
            this.hover_icon.Name = "hover_icon";
            this.hover_icon.Size = new System.Drawing.Size(229, 354);
            this.hover_icon.TabIndex = 0;
            this.hover_icon.Visible = false;
            this.hover_icon.Click += new System.EventHandler(this.AlbumControl_Click);
            this.hover_icon.MouseLeave += new System.EventHandler(this.hover_icon_MouseLeave);
            // 
            // AlbumControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.hover_icon);
            this.Name = "AlbumControl";
            this.Size = new System.Drawing.Size(229, 354);
            this.Load += new System.EventHandler(this.Album_Control_Load);
            this.Click += new System.EventHandler(this.AlbumControl_Click);
            this.MouseEnter += new System.EventHandler(this.Album_Control_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hover_icon;
    }
}
