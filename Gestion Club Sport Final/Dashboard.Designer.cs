namespace Gestion_Club_Sport_Final
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.btn_system = new System.Windows.Forms.Button();
            this.button_dash = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.statistique1 = new Gestion_Club_Sport_Final.Statistique();
            this.menu1 = new Gestion_Club_Sport_Final.Menu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(175, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(152, 19);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Dashboard Admin";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gray;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(973, 13);
            this.panelHeader.TabIndex = 12;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pnlStats);
            this.panel1.Controls.Add(this.btn_system);
            this.panel1.Controls.Add(this.button_dash);
            this.panel1.Controls.Add(this.button_about);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 588);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlStats.Location = new System.Drawing.Point(0, 179);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(10, 37);
            this.pnlStats.TabIndex = 6;
            this.pnlStats.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStats_Paint);
            // 
            // btn_system
            // 
            this.btn_system.FlatAppearance.BorderSize = 0;
            this.btn_system.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_system.ForeColor = System.Drawing.Color.White;
            this.btn_system.Image = global::Gestion_Club_Sport_Final.Properties.Resources.Webp_net_resizeimage__2_;
            this.btn_system.Location = new System.Drawing.Point(0, 239);
            this.btn_system.Name = "btn_system";
            this.btn_system.Size = new System.Drawing.Size(169, 37);
            this.btn_system.TabIndex = 1;
            this.btn_system.Text = "    Gerer System";
            this.btn_system.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_system.UseVisualStyleBackColor = true;
            this.btn_system.Click += new System.EventHandler(this.btn_system_Click);
            // 
            // button_dash
            // 
            this.button_dash.FlatAppearance.BorderSize = 0;
            this.button_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dash.ForeColor = System.Drawing.Color.White;
            this.button_dash.Image = global::Gestion_Club_Sport_Final.Properties.Resources.Dashboard;
            this.button_dash.Location = new System.Drawing.Point(0, 179);
            this.button_dash.Name = "button_dash";
            this.button_dash.Size = new System.Drawing.Size(169, 37);
            this.button_dash.TabIndex = 1;
            this.button_dash.Text = "    Dashboard";
            this.button_dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dash.UseVisualStyleBackColor = true;
            this.button_dash.Click += new System.EventHandler(this.button_dash_Click);
            // 
            // button_about
            // 
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.ForeColor = System.Drawing.Color.White;
            this.button_about.Image = ((System.Drawing.Image)(resources.GetObject("button_about.Image")));
            this.button_about.Location = new System.Drawing.Point(0, 295);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(169, 37);
            this.button_about.TabIndex = 1;
            this.button_about.Text = "    About Us";
            this.button_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Club_Sport_Final.Properties.Resources.unnamed1;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.OrangeRed;
            this.button6.Image = global::Gestion_Club_Sport_Final.Properties.Resources.Webp_net_resizeimage__3_;
            this.button6.Location = new System.Drawing.Point(926, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 41);
            this.button6.TabIndex = 13;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // statistique1
            // 
            this.statistique1.Location = new System.Drawing.Point(170, 59);
            this.statistique1.Name = "statistique1";
            this.statistique1.Size = new System.Drawing.Size(803, 547);
            this.statistique1.TabIndex = 16;
            this.statistique1.Load += new System.EventHandler(this.statistique1_Load);
            // 
            // menu1
            // 
            this.menu1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu1.Location = new System.Drawing.Point(169, 59);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(805, 529);
            this.menu1.TabIndex = 15;
            this.menu1.Load += new System.EventHandler(this.menu1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.statistique1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private Menu menu1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button button_dash;
        private Statistique statistique1;
        internal System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Button btn_system;
        private System.Windows.Forms.Button button_about;
    }
}