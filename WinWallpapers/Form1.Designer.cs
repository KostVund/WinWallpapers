namespace WinWallpapers
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.exit_icon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WinWallpapers.Properties.Resources.image2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.exit_icon);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 535);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 535);
            this.panel1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.button_exit);
            this.Menu.Controls.Add(this.button_settings);
            this.Menu.Controls.Add(this.button_start);
            this.Menu.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.Location = new System.Drawing.Point(85, 144);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(122, 182);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // button_start
            // 
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_start.Location = new System.Drawing.Point(6, 41);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(110, 27);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            // 
            // button_settings
            // 
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button_settings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_settings.Location = new System.Drawing.Point(6, 79);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(110, 27);
            this.button_settings.TabIndex = 2;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_exit.Location = new System.Drawing.Point(6, 117);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(110, 27);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // exit_icon
            // 
            this.exit_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_icon.BackgroundImage = global::WinWallpapers.Properties.Resources.pngwing_com;
            this.exit_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_icon.Location = new System.Drawing.Point(773, 3);
            this.exit_icon.Name = "exit_icon";
            this.exit_icon.Size = new System.Drawing.Size(24, 24);
            this.exit_icon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "WallpapersHub";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel exit_icon;
        private Panel panel1;
        private Label label1;
        private GroupBox Menu;
        private Button button_exit;
        private Button button_settings;
        private Button button_start;
    }
}