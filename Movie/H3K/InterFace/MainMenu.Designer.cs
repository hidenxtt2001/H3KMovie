namespace H3K.InterFace
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.icon_mainmenu = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.form_born = new System.Windows.Forms.TableLayoutPanel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.history_show = new System.Windows.Forms.Button();
            this.favorite_show = new System.Windows.Forms.Button();
            this.account_infor = new System.Windows.Forms.Button();
            this.movie_show = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.action_panel = new System.Windows.Forms.Panel();
            this.loading_label = new System.Windows.Forms.Label();
            this.common = new System.Windows.Forms.Panel();
            this.movie_show_panel = new System.Windows.Forms.Panel();
            this.list_item_movie = new H3K.InterFace.Movie_Mange.SmoothScrollPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Panel();
            this.category_scroll = new System.Windows.Forms.Panel();
            this.genre23 = new System.Windows.Forms.Button();
            this.genre22 = new System.Windows.Forms.Button();
            this.genre21 = new System.Windows.Forms.Button();
            this.genre20 = new System.Windows.Forms.Button();
            this.genre19 = new System.Windows.Forms.Button();
            this.genre18 = new System.Windows.Forms.Button();
            this.genre17 = new System.Windows.Forms.Button();
            this.genre16 = new System.Windows.Forms.Button();
            this.genre15 = new System.Windows.Forms.Button();
            this.genre14 = new System.Windows.Forms.Button();
            this.genre13 = new System.Windows.Forms.Button();
            this.genre12 = new System.Windows.Forms.Button();
            this.genre11 = new System.Windows.Forms.Button();
            this.genre10 = new System.Windows.Forms.Button();
            this.genre9 = new System.Windows.Forms.Button();
            this.genre8 = new System.Windows.Forms.Button();
            this.genre7 = new System.Windows.Forms.Button();
            this.genre6 = new System.Windows.Forms.Button();
            this.genre5 = new System.Windows.Forms.Button();
            this.genre4 = new System.Windows.Forms.Button();
            this.genre3 = new System.Windows.Forms.Button();
            this.genre2 = new System.Windows.Forms.Button();
            this.genre1 = new System.Windows.Forms.Button();
            this.scroll_right = new System.Windows.Forms.Button();
            this.scroll_left = new System.Windows.Forms.Button();
            this.favorite_show_panel = new System.Windows.Forms.Panel();
            this.movies_list_favorite = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.account_infor_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.history_show_panel = new System.Windows.Forms.Panel();
            this.movies_list_history = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.control = new System.Windows.Forms.Panel();
            this.control_button = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search_panel = new System.Windows.Forms.Panel();
            this.search_input = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.form_born.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.action_panel.SuspendLayout();
            this.common.SuspendLayout();
            this.movie_show_panel.SuspendLayout();
            this.category.SuspendLayout();
            this.category_scroll.SuspendLayout();
            this.favorite_show_panel.SuspendLayout();
            this.account_infor_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.history_show_panel.SuspendLayout();
            this.control.SuspendLayout();
            this.control_button.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // icon_mainmenu
            // 
            this.icon_mainmenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon_mainmenu.ImageStream")));
            this.icon_mainmenu.TransparentColor = System.Drawing.Color.Transparent;
            this.icon_mainmenu.Images.SetKeyName(0, "icons8_cinema.ico");
            this.icon_mainmenu.Images.SetKeyName(1, "icons8_customer.ico");
            this.icon_mainmenu.Images.SetKeyName(2, "icons8_literature.ico");
            this.icon_mainmenu.Images.SetKeyName(3, "icons8_star_filled.ico");
            this.icon_mainmenu.Images.SetKeyName(4, "icons8_contact.ico");
            this.icon_mainmenu.Images.SetKeyName(5, "icons8_lock.ico");
            this.icon_mainmenu.Images.SetKeyName(6, "icons8_envelope.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_born
            // 
            this.form_born.ColumnCount = 2;
            this.form_born.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.form_born.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.form_born.Controls.Add(this.menu_panel, 0, 0);
            this.form_born.Controls.Add(this.action_panel, 1, 0);
            this.form_born.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_born.Location = new System.Drawing.Point(0, 0);
            this.form_born.Name = "form_born";
            this.form_born.RowCount = 1;
            this.form_born.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.form_born.Size = new System.Drawing.Size(1340, 768);
            this.form_born.TabIndex = 0;
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.history_show);
            this.menu_panel.Controls.Add(this.favorite_show);
            this.menu_panel.Controls.Add(this.account_infor);
            this.menu_panel.Controls.Add(this.movie_show);
            this.menu_panel.Controls.Add(this.panel8);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Margin = new System.Windows.Forms.Padding(0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(164, 768);
            this.menu_panel.TabIndex = 0;
            // 
            // history_show
            // 
            this.history_show.Dock = System.Windows.Forms.DockStyle.Top;
            this.history_show.FlatAppearance.BorderSize = 0;
            this.history_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.history_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.history_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_show.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_show.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.history_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history_show.ImageIndex = 2;
            this.history_show.ImageList = this.icon_mainmenu;
            this.history_show.Location = new System.Drawing.Point(0, 232);
            this.history_show.Name = "history_show";
            this.history_show.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.history_show.Size = new System.Drawing.Size(164, 40);
            this.history_show.TabIndex = 6;
            this.history_show.Text = "History";
            this.history_show.UseVisualStyleBackColor = true;
            this.history_show.Click += new System.EventHandler(this.mainbutton_show);
            // 
            // favorite_show
            // 
            this.favorite_show.Dock = System.Windows.Forms.DockStyle.Top;
            this.favorite_show.FlatAppearance.BorderSize = 0;
            this.favorite_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.favorite_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.favorite_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favorite_show.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_show.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.favorite_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favorite_show.ImageIndex = 3;
            this.favorite_show.ImageList = this.icon_mainmenu;
            this.favorite_show.Location = new System.Drawing.Point(0, 192);
            this.favorite_show.Name = "favorite_show";
            this.favorite_show.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.favorite_show.Size = new System.Drawing.Size(164, 40);
            this.favorite_show.TabIndex = 5;
            this.favorite_show.Text = "Favorite";
            this.favorite_show.UseVisualStyleBackColor = true;
            this.favorite_show.Click += new System.EventHandler(this.mainbutton_show);
            // 
            // account_infor
            // 
            this.account_infor.Dock = System.Windows.Forms.DockStyle.Top;
            this.account_infor.FlatAppearance.BorderSize = 0;
            this.account_infor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.account_infor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.account_infor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_infor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_infor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.account_infor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_infor.ImageIndex = 1;
            this.account_infor.ImageList = this.icon_mainmenu;
            this.account_infor.Location = new System.Drawing.Point(0, 152);
            this.account_infor.Name = "account_infor";
            this.account_infor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.account_infor.Size = new System.Drawing.Size(164, 40);
            this.account_infor.TabIndex = 3;
            this.account_infor.Text = "Account";
            this.account_infor.UseVisualStyleBackColor = true;
            this.account_infor.Click += new System.EventHandler(this.mainbutton_show);
            // 
            // movie_show
            // 
            this.movie_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(124)))), ((int)(((byte)(163)))));
            this.movie_show.Dock = System.Windows.Forms.DockStyle.Top;
            this.movie_show.FlatAppearance.BorderSize = 0;
            this.movie_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.movie_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.movie_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movie_show.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_show.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.movie_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movie_show.ImageIndex = 0;
            this.movie_show.ImageList = this.icon_mainmenu;
            this.movie_show.Location = new System.Drawing.Point(0, 112);
            this.movie_show.Name = "movie_show";
            this.movie_show.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.movie_show.Size = new System.Drawing.Size(164, 40);
            this.movie_show.TabIndex = 4;
            this.movie_show.Text = "Movies";
            this.movie_show.UseVisualStyleBackColor = false;
            this.movie_show.Click += new System.EventHandler(this.mainbutton_show);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::H3K.Properties.Resources.logo;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 112);
            this.panel8.TabIndex = 0;
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // action_panel
            // 
            this.action_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.action_panel.Controls.Add(this.loading_label);
            this.action_panel.Controls.Add(this.common);
            this.action_panel.Controls.Add(this.control);
            this.action_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.action_panel.Location = new System.Drawing.Point(164, 0);
            this.action_panel.Margin = new System.Windows.Forms.Padding(0);
            this.action_panel.Name = "action_panel";
            this.action_panel.Size = new System.Drawing.Size(1176, 768);
            this.action_panel.TabIndex = 1;
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loading_label.Location = new System.Drawing.Point(550, 385);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(96, 18);
            this.loading_label.TabIndex = 0;
            this.loading_label.Text = "Loading....";
            this.loading_label.Visible = false;
            // 
            // common
            // 
            this.common.Controls.Add(this.movie_show_panel);
            this.common.Controls.Add(this.favorite_show_panel);
            this.common.Controls.Add(this.account_infor_panel);
            this.common.Controls.Add(this.history_show_panel);
            this.common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.common.Location = new System.Drawing.Point(0, 42);
            this.common.Name = "common";
            this.common.Size = new System.Drawing.Size(1176, 726);
            this.common.TabIndex = 3;
            // 
            // movie_show_panel
            // 
            this.movie_show_panel.Controls.Add(this.list_item_movie);
            this.movie_show_panel.Controls.Add(this.panel1);
            this.movie_show_panel.Controls.Add(this.category);
            this.movie_show_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movie_show_panel.Location = new System.Drawing.Point(0, 0);
            this.movie_show_panel.Name = "movie_show_panel";
            this.movie_show_panel.Size = new System.Drawing.Size(1176, 726);
            this.movie_show_panel.TabIndex = 2;
            // 
            // list_item_movie
            // 
            this.list_item_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_item_movie.Location = new System.Drawing.Point(0, 70);
            this.list_item_movie.Name = "list_item_movie";
            this.list_item_movie.Size = new System.Drawing.Size(1176, 649);
            this.list_item_movie.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 719);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 7);
            this.panel1.TabIndex = 3;
            // 
            // category
            // 
            this.category.Controls.Add(this.category_scroll);
            this.category.Controls.Add(this.scroll_right);
            this.category.Controls.Add(this.scroll_left);
            this.category.Dock = System.Windows.Forms.DockStyle.Top;
            this.category.Location = new System.Drawing.Point(0, 0);
            this.category.Name = "category";
            this.category.Padding = new System.Windows.Forms.Padding(18);
            this.category.Size = new System.Drawing.Size(1176, 70);
            this.category.TabIndex = 1;
            // 
            // category_scroll
            // 
            this.category_scroll.Controls.Add(this.genre23);
            this.category_scroll.Controls.Add(this.genre22);
            this.category_scroll.Controls.Add(this.genre21);
            this.category_scroll.Controls.Add(this.genre20);
            this.category_scroll.Controls.Add(this.genre19);
            this.category_scroll.Controls.Add(this.genre18);
            this.category_scroll.Controls.Add(this.genre17);
            this.category_scroll.Controls.Add(this.genre16);
            this.category_scroll.Controls.Add(this.genre15);
            this.category_scroll.Controls.Add(this.genre14);
            this.category_scroll.Controls.Add(this.genre13);
            this.category_scroll.Controls.Add(this.genre12);
            this.category_scroll.Controls.Add(this.genre11);
            this.category_scroll.Controls.Add(this.genre10);
            this.category_scroll.Controls.Add(this.genre9);
            this.category_scroll.Controls.Add(this.genre8);
            this.category_scroll.Controls.Add(this.genre7);
            this.category_scroll.Controls.Add(this.genre6);
            this.category_scroll.Controls.Add(this.genre5);
            this.category_scroll.Controls.Add(this.genre4);
            this.category_scroll.Controls.Add(this.genre3);
            this.category_scroll.Controls.Add(this.genre2);
            this.category_scroll.Controls.Add(this.genre1);
            this.category_scroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category_scroll.Location = new System.Drawing.Point(78, 18);
            this.category_scroll.Name = "category_scroll";
            this.category_scroll.Size = new System.Drawing.Size(1020, 34);
            this.category_scroll.TabIndex = 2;
            // 
            // genre23
            // 
            this.genre23.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre23.FlatAppearance.BorderSize = 0;
            this.genre23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre23.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre23.Location = new System.Drawing.Point(2464, 0);
            this.genre23.Name = "genre23";
            this.genre23.Size = new System.Drawing.Size(112, 34);
            this.genre23.TabIndex = 21;
            this.genre23.Text = "Western";
            this.genre23.UseVisualStyleBackColor = true;
            this.genre23.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre22
            // 
            this.genre22.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre22.FlatAppearance.BorderSize = 0;
            this.genre22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre22.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre22.Location = new System.Drawing.Point(2352, 0);
            this.genre22.Name = "genre22";
            this.genre22.Size = new System.Drawing.Size(112, 34);
            this.genre22.TabIndex = 22;
            this.genre22.Text = "War";
            this.genre22.UseVisualStyleBackColor = true;
            this.genre22.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre21
            // 
            this.genre21.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre21.FlatAppearance.BorderSize = 0;
            this.genre21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre21.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre21.Location = new System.Drawing.Point(2240, 0);
            this.genre21.Name = "genre21";
            this.genre21.Size = new System.Drawing.Size(112, 34);
            this.genre21.TabIndex = 23;
            this.genre21.Text = "Thriller";
            this.genre21.UseVisualStyleBackColor = true;
            this.genre21.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre20
            // 
            this.genre20.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre20.FlatAppearance.BorderSize = 0;
            this.genre20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre20.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre20.Location = new System.Drawing.Point(2128, 0);
            this.genre20.Name = "genre20";
            this.genre20.Size = new System.Drawing.Size(112, 34);
            this.genre20.TabIndex = 24;
            this.genre20.Text = "Sport";
            this.genre20.UseVisualStyleBackColor = true;
            this.genre20.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre19
            // 
            this.genre19.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre19.FlatAppearance.BorderSize = 0;
            this.genre19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre19.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre19.Location = new System.Drawing.Point(2016, 0);
            this.genre19.Name = "genre19";
            this.genre19.Size = new System.Drawing.Size(112, 34);
            this.genre19.TabIndex = 20;
            this.genre19.Text = "Short";
            this.genre19.UseVisualStyleBackColor = true;
            this.genre19.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre18
            // 
            this.genre18.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre18.FlatAppearance.BorderSize = 0;
            this.genre18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre18.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre18.Location = new System.Drawing.Point(1904, 0);
            this.genre18.Name = "genre18";
            this.genre18.Size = new System.Drawing.Size(112, 34);
            this.genre18.TabIndex = 19;
            this.genre18.Text = "Sci-fi";
            this.genre18.UseVisualStyleBackColor = true;
            this.genre18.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre17
            // 
            this.genre17.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre17.FlatAppearance.BorderSize = 0;
            this.genre17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre17.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre17.Location = new System.Drawing.Point(1792, 0);
            this.genre17.Name = "genre17";
            this.genre17.Size = new System.Drawing.Size(112, 34);
            this.genre17.TabIndex = 18;
            this.genre17.Text = "Romance";
            this.genre17.UseVisualStyleBackColor = true;
            this.genre17.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre16
            // 
            this.genre16.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre16.FlatAppearance.BorderSize = 0;
            this.genre16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre16.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre16.Location = new System.Drawing.Point(1680, 0);
            this.genre16.Name = "genre16";
            this.genre16.Size = new System.Drawing.Size(112, 34);
            this.genre16.TabIndex = 17;
            this.genre16.Text = "Mystery";
            this.genre16.UseVisualStyleBackColor = true;
            this.genre16.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre15
            // 
            this.genre15.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre15.FlatAppearance.BorderSize = 0;
            this.genre15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre15.Location = new System.Drawing.Point(1568, 0);
            this.genre15.Name = "genre15";
            this.genre15.Size = new System.Drawing.Size(112, 34);
            this.genre15.TabIndex = 16;
            this.genre15.Text = "Musical";
            this.genre15.UseVisualStyleBackColor = true;
            this.genre15.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre14
            // 
            this.genre14.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre14.FlatAppearance.BorderSize = 0;
            this.genre14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre14.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre14.Location = new System.Drawing.Point(1456, 0);
            this.genre14.Name = "genre14";
            this.genre14.Size = new System.Drawing.Size(112, 34);
            this.genre14.TabIndex = 15;
            this.genre14.Text = "Music";
            this.genre14.UseVisualStyleBackColor = true;
            this.genre14.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre13
            // 
            this.genre13.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre13.FlatAppearance.BorderSize = 0;
            this.genre13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre13.Location = new System.Drawing.Point(1344, 0);
            this.genre13.Name = "genre13";
            this.genre13.Size = new System.Drawing.Size(112, 34);
            this.genre13.TabIndex = 14;
            this.genre13.Text = "Horror";
            this.genre13.UseVisualStyleBackColor = true;
            this.genre13.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre12
            // 
            this.genre12.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre12.FlatAppearance.BorderSize = 0;
            this.genre12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre12.Location = new System.Drawing.Point(1232, 0);
            this.genre12.Name = "genre12";
            this.genre12.Size = new System.Drawing.Size(112, 34);
            this.genre12.TabIndex = 13;
            this.genre12.Text = "History";
            this.genre12.UseVisualStyleBackColor = true;
            this.genre12.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre11
            // 
            this.genre11.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre11.FlatAppearance.BorderSize = 0;
            this.genre11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre11.Location = new System.Drawing.Point(1120, 0);
            this.genre11.Name = "genre11";
            this.genre11.Size = new System.Drawing.Size(112, 34);
            this.genre11.TabIndex = 12;
            this.genre11.Text = "Film-Noir";
            this.genre11.UseVisualStyleBackColor = true;
            this.genre11.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre10
            // 
            this.genre10.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre10.FlatAppearance.BorderSize = 0;
            this.genre10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre10.Location = new System.Drawing.Point(1008, 0);
            this.genre10.Name = "genre10";
            this.genre10.Size = new System.Drawing.Size(112, 34);
            this.genre10.TabIndex = 11;
            this.genre10.Text = "Fantasy";
            this.genre10.UseVisualStyleBackColor = true;
            this.genre10.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre9
            // 
            this.genre9.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre9.FlatAppearance.BorderSize = 0;
            this.genre9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre9.Location = new System.Drawing.Point(896, 0);
            this.genre9.Name = "genre9";
            this.genre9.Size = new System.Drawing.Size(112, 34);
            this.genre9.TabIndex = 10;
            this.genre9.Text = "Family";
            this.genre9.UseVisualStyleBackColor = true;
            this.genre9.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre8
            // 
            this.genre8.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre8.FlatAppearance.BorderSize = 0;
            this.genre8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre8.Location = new System.Drawing.Point(784, 0);
            this.genre8.Name = "genre8";
            this.genre8.Size = new System.Drawing.Size(112, 34);
            this.genre8.TabIndex = 9;
            this.genre8.Text = "Drama";
            this.genre8.UseVisualStyleBackColor = true;
            this.genre8.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre7
            // 
            this.genre7.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre7.FlatAppearance.BorderSize = 0;
            this.genre7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre7.Location = new System.Drawing.Point(672, 0);
            this.genre7.Name = "genre7";
            this.genre7.Size = new System.Drawing.Size(112, 34);
            this.genre7.TabIndex = 8;
            this.genre7.Text = "Document";
            this.genre7.UseVisualStyleBackColor = true;
            this.genre7.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre6
            // 
            this.genre6.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre6.FlatAppearance.BorderSize = 0;
            this.genre6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre6.Location = new System.Drawing.Point(560, 0);
            this.genre6.Name = "genre6";
            this.genre6.Size = new System.Drawing.Size(112, 34);
            this.genre6.TabIndex = 7;
            this.genre6.Text = "Crime";
            this.genre6.UseVisualStyleBackColor = true;
            this.genre6.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre5
            // 
            this.genre5.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre5.FlatAppearance.BorderSize = 0;
            this.genre5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre5.Location = new System.Drawing.Point(448, 0);
            this.genre5.Name = "genre5";
            this.genre5.Size = new System.Drawing.Size(112, 34);
            this.genre5.TabIndex = 6;
            this.genre5.Text = "Comedy";
            this.genre5.UseVisualStyleBackColor = true;
            this.genre5.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre4
            // 
            this.genre4.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre4.FlatAppearance.BorderSize = 0;
            this.genre4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre4.Location = new System.Drawing.Point(336, 0);
            this.genre4.Name = "genre4";
            this.genre4.Size = new System.Drawing.Size(112, 34);
            this.genre4.TabIndex = 5;
            this.genre4.Text = "Adventure";
            this.genre4.UseVisualStyleBackColor = true;
            this.genre4.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre3
            // 
            this.genre3.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre3.FlatAppearance.BorderSize = 0;
            this.genre3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre3.Location = new System.Drawing.Point(224, 0);
            this.genre3.Name = "genre3";
            this.genre3.Size = new System.Drawing.Size(112, 34);
            this.genre3.TabIndex = 4;
            this.genre3.Text = "Action";
            this.genre3.UseVisualStyleBackColor = true;
            this.genre3.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre2
            // 
            this.genre2.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre2.FlatAppearance.BorderSize = 0;
            this.genre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre2.Location = new System.Drawing.Point(112, 0);
            this.genre2.Name = "genre2";
            this.genre2.Size = new System.Drawing.Size(112, 34);
            this.genre2.TabIndex = 3;
            this.genre2.Text = "Animation";
            this.genre2.UseVisualStyleBackColor = true;
            this.genre2.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // genre1
            // 
            this.genre1.Dock = System.Windows.Forms.DockStyle.Left;
            this.genre1.FlatAppearance.BorderSize = 0;
            this.genre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.genre1.Location = new System.Drawing.Point(0, 0);
            this.genre1.Name = "genre1";
            this.genre1.Size = new System.Drawing.Size(112, 34);
            this.genre1.TabIndex = 2;
            this.genre1.Text = "All";
            this.genre1.UseVisualStyleBackColor = true;
            this.genre1.Click += new System.EventHandler(this.GenreChooseLoad);
            // 
            // scroll_right
            // 
            this.scroll_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.scroll_right.BackgroundImage = global::H3K.Properties.Resources.icons8_sort_right;
            this.scroll_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.scroll_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll_right.FlatAppearance.BorderSize = 0;
            this.scroll_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scroll_right.Location = new System.Drawing.Point(1098, 18);
            this.scroll_right.Name = "scroll_right";
            this.scroll_right.Size = new System.Drawing.Size(60, 34);
            this.scroll_right.TabIndex = 1;
            this.scroll_right.UseVisualStyleBackColor = false;
            this.scroll_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.scroll_right.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.scroll_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // scroll_left
            // 
            this.scroll_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.scroll_left.BackgroundImage = global::H3K.Properties.Resources.icons8_sort_left;
            this.scroll_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.scroll_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.scroll_left.FlatAppearance.BorderSize = 0;
            this.scroll_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scroll_left.Location = new System.Drawing.Point(18, 18);
            this.scroll_left.Name = "scroll_left";
            this.scroll_left.Size = new System.Drawing.Size(60, 34);
            this.scroll_left.TabIndex = 0;
            this.scroll_left.UseVisualStyleBackColor = false;
            this.scroll_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.scroll_left.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.scroll_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // favorite_show_panel
            // 
            this.favorite_show_panel.Controls.Add(this.movies_list_favorite);
            this.favorite_show_panel.Controls.Add(this.label3);
            this.favorite_show_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favorite_show_panel.Location = new System.Drawing.Point(0, 0);
            this.favorite_show_panel.Name = "favorite_show_panel";
            this.favorite_show_panel.Size = new System.Drawing.Size(1176, 726);
            this.favorite_show_panel.TabIndex = 4;
            // 
            // movies_list_favorite
            // 
            this.movies_list_favorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movies_list_favorite.Location = new System.Drawing.Point(0, 70);
            this.movies_list_favorite.Name = "movies_list_favorite";
            this.movies_list_favorite.Padding = new System.Windows.Forms.Padding(5);
            this.movies_list_favorite.Size = new System.Drawing.Size(1176, 656);
            this.movies_list_favorite.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1176, 70);
            this.label3.TabIndex = 1;
            this.label3.Text = "Movies Favorite";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // account_infor_panel
            // 
            this.account_infor_panel.Controls.Add(this.tableLayoutPanel1);
            this.account_infor_panel.Controls.Add(this.label1);
            this.account_infor_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account_infor_panel.Location = new System.Drawing.Point(0, 0);
            this.account_infor_panel.Name = "account_infor_panel";
            this.account_infor_panel.Size = new System.Drawing.Size(1176, 726);
            this.account_infor_panel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 656);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(124)))), ((int)(((byte)(163)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(578, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(49, 55, 49, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 546);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(696, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(50, 100, 50, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 456);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.textBox3);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.textBox4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 456);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.icon_mainmenu;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageIndex = 6;
            this.label5.ImageList = this.icon_mainmenu;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(169, 55);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageIndex = 4;
            this.label6.ImageList = this.icon_mainmenu;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(169, 100);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 25);
            this.textBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageIndex = 5;
            this.label7.ImageList = this.icon_mainmenu;
            this.label7.Location = new System.Drawing.Point(3, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(169, 145);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 25);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1176, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // history_show_panel
            // 
            this.history_show_panel.Controls.Add(this.movies_list_history);
            this.history_show_panel.Controls.Add(this.label2);
            this.history_show_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_show_panel.Location = new System.Drawing.Point(0, 0);
            this.history_show_panel.Name = "history_show_panel";
            this.history_show_panel.Size = new System.Drawing.Size(1176, 726);
            this.history_show_panel.TabIndex = 4;
            // 
            // movies_list_history
            // 
            this.movies_list_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movies_list_history.Location = new System.Drawing.Point(0, 70);
            this.movies_list_history.Name = "movies_list_history";
            this.movies_list_history.Padding = new System.Windows.Forms.Padding(5);
            this.movies_list_history.Size = new System.Drawing.Size(1176, 656);
            this.movies_list_history.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1176, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie History";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.control.Controls.Add(this.control_button);
            this.control.Controls.Add(this.search_panel);
            this.control.Dock = System.Windows.Forms.DockStyle.Top;
            this.control.Location = new System.Drawing.Point(0, 0);
            this.control.Name = "control";
            this.control.Padding = new System.Windows.Forms.Padding(6);
            this.control.Size = new System.Drawing.Size(1176, 42);
            this.control.TabIndex = 0;
            this.control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // control_button
            // 
            this.control_button.AutoSize = true;
            this.control_button.Controls.Add(this.button2);
            this.control_button.Controls.Add(this.button3);
            this.control_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.control_button.Location = new System.Drawing.Point(1110, 6);
            this.control_button.Name = "control_button";
            this.control_button.Size = new System.Drawing.Size(60, 30);
            this.control_button.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::H3K.Properties.Resources.icons8_subtract;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::H3K.Properties.Resources.icons8_delete;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(92)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(30, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.search_input);
            this.search_panel.Controls.Add(this.panel6);
            this.search_panel.Controls.Add(this.panel5);
            this.search_panel.Controls.Add(this.button1);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_panel.Location = new System.Drawing.Point(6, 6);
            this.search_panel.Name = "search_panel";
            this.search_panel.Padding = new System.Windows.Forms.Padding(5);
            this.search_panel.Size = new System.Drawing.Size(291, 30);
            this.search_panel.TabIndex = 1;
            // 
            // search_input
            // 
            this.search_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.search_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_input.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_input.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search_input.Location = new System.Drawing.Point(37, 5);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(237, 19);
            this.search_input.TabIndex = 1;
            this.search_input.Text = "Search";
            this.search_input.Enter += new System.EventHandler(this.search_input_Enter);
            this.search_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_input_KeyDown);
            this.search_input.Leave += new System.EventHandler(this.search_input_Leave);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(274, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 20);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(27, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 20);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1340, 768);
            this.Controls.Add(this.form_born);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.form_born.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.action_panel.ResumeLayout(false);
            this.action_panel.PerformLayout();
            this.common.ResumeLayout(false);
            this.movie_show_panel.ResumeLayout(false);
            this.category.ResumeLayout(false);
            this.category_scroll.ResumeLayout(false);
            this.favorite_show_panel.ResumeLayout(false);
            this.account_infor_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.history_show_panel.ResumeLayout(false);
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.control_button.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList icon_mainmenu;
        private System.Windows.Forms.TableLayoutPanel form_born;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button history_show;
        private System.Windows.Forms.Button favorite_show;
        private System.Windows.Forms.Button account_infor;
        private System.Windows.Forms.Button movie_show;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel action_panel;
        private System.Windows.Forms.Panel common;
        private System.Windows.Forms.Panel account_infor_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel favorite_show_panel;
        private System.Windows.Forms.FlowLayoutPanel movies_list_favorite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel history_show_panel;
        private System.Windows.Forms.FlowLayoutPanel movies_list_history;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel control;
        private System.Windows.Forms.Panel control_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel movie_show_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel category;
        private System.Windows.Forms.Panel category_scroll;
        private System.Windows.Forms.Button genre23;
        private System.Windows.Forms.Button genre22;
        private System.Windows.Forms.Button genre21;
        private System.Windows.Forms.Button genre20;
        private System.Windows.Forms.Button genre19;
        private System.Windows.Forms.Button genre18;
        private System.Windows.Forms.Button genre17;
        private System.Windows.Forms.Button genre16;
        private System.Windows.Forms.Button genre15;
        private System.Windows.Forms.Button genre14;
        private System.Windows.Forms.Button genre13;
        private System.Windows.Forms.Button genre12;
        private System.Windows.Forms.Button genre11;
        private System.Windows.Forms.Button genre10;
        private System.Windows.Forms.Button genre9;
        private System.Windows.Forms.Button genre8;
        private System.Windows.Forms.Button genre7;
        private System.Windows.Forms.Button genre6;
        private System.Windows.Forms.Button genre5;
        private System.Windows.Forms.Button genre4;
        private System.Windows.Forms.Button genre3;
        private System.Windows.Forms.Button genre2;
        private System.Windows.Forms.Button genre1;
        private System.Windows.Forms.Button scroll_right;
        private System.Windows.Forms.Button scroll_left;
        private Movie_Mange.SmoothScrollPanel list_item_movie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label loading_label;
    }
}