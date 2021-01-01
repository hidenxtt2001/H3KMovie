namespace H3K.InterFace.Sign_Form
{
    partial class Code_reset_from
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
            this.button9 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.code_reset = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Reset_Password = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::H3K.Properties.Resources.icons8_delete;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(116)))), ((int)(((byte)(237)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(116)))), ((int)(((byte)(237)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(452, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 32);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Location = new System.Drawing.Point(132, 116);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(231, 1);
            this.panel12.TabIndex = 10;
            // 
            // code_reset
            // 
            this.code_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(147)))), ((int)(((byte)(191)))));
            this.code_reset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code_reset.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.code_reset.Location = new System.Drawing.Point(132, 85);
            this.code_reset.Name = "code_reset";
            this.code_reset.Size = new System.Drawing.Size(231, 23);
            this.code_reset.TabIndex = 8;
            this.code_reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpassword_forgot_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(132, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Code Reset Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reset_Password
            // 
            this.Reset_Password.BackColor = System.Drawing.Color.Transparent;
            this.Reset_Password.FlatAppearance.BorderSize = 3;
            this.Reset_Password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(116)))), ((int)(((byte)(237)))));
            this.Reset_Password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(116)))), ((int)(((byte)(237)))));
            this.Reset_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Password.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reset_Password.Location = new System.Drawing.Point(149, 260);
            this.Reset_Password.Name = "Reset_Password";
            this.Reset_Password.Size = new System.Drawing.Size(193, 45);
            this.Reset_Password.TabIndex = 11;
            this.Reset_Password.Text = "Submit Code";
            this.Reset_Password.UseVisualStyleBackColor = false;
            this.Reset_Password.Click += new System.EventHandler(this.Reset_Password_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(132, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 1);
            this.panel1.TabIndex = 14;
            // 
            // new_password
            // 
            this.new_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(147)))), ((int)(((byte)(191)))));
            this.new_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_password.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.new_password.Location = new System.Drawing.Point(132, 200);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(231, 23);
            this.new_password.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(132, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Code_reset_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(147)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(494, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_Password);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.code_reset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Code_reset_from";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code_Submit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox code_reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Reset_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Label label1;
    }
}