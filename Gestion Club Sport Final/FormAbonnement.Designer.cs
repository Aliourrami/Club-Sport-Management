namespace Gestion_Club_Sport_Final
{
    partial class FormAbonnement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbonnement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txtbx_CodeAbonnement = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.Textbox_DureeTab = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_TarifAb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DataGrid_TAbon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelRight = new System.Windows.Forms.Panel();
            this.Textbox_DesA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TAbon)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_Supprimer);
            this.panel1.Controls.Add(this.Button_Modifier);
            this.panel1.Controls.Add(this.button_Nouveau);
            this.panel1.Controls.Add(this.button_Ajouter);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 670);
            this.panel1.TabIndex = 5;
            // 
            // Txtbx_CodeAbonnement
            // 
            this.Txtbx_CodeAbonnement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtbx_CodeAbonnement.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtbx_CodeAbonnement.ForeColor = System.Drawing.Color.Black;
            this.Txtbx_CodeAbonnement.HintForeColor = System.Drawing.Color.Empty;
            this.Txtbx_CodeAbonnement.HintText = "Code Abonnement";
            this.Txtbx_CodeAbonnement.isPassword = false;
            this.Txtbx_CodeAbonnement.LineFocusedColor = System.Drawing.Color.Coral;
            this.Txtbx_CodeAbonnement.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Txtbx_CodeAbonnement.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Txtbx_CodeAbonnement.LineThickness = 3;
            this.Txtbx_CodeAbonnement.Location = new System.Drawing.Point(92, 64);
            this.Txtbx_CodeAbonnement.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_CodeAbonnement.Name = "Txtbx_CodeAbonnement";
            this.Txtbx_CodeAbonnement.Size = new System.Drawing.Size(151, 31);
            this.Txtbx_CodeAbonnement.TabIndex = 68;
            this.Txtbx_CodeAbonnement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(45, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Abonnement";
            // 
            // Textbox_DureeTab
            // 
            this.Textbox_DureeTab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_DureeTab.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_DureeTab.ForeColor = System.Drawing.Color.Black;
            this.Textbox_DureeTab.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_DureeTab.HintText = "Duree Abonnement ";
            this.Textbox_DureeTab.isPassword = false;
            this.Textbox_DureeTab.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_DureeTab.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_DureeTab.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_DureeTab.LineThickness = 3;
            this.Textbox_DureeTab.Location = new System.Drawing.Point(52, 257);
            this.Textbox_DureeTab.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_DureeTab.Name = "Textbox_DureeTab";
            this.Textbox_DureeTab.Size = new System.Drawing.Size(138, 31);
            this.Textbox_DureeTab.TabIndex = 1;
            this.Textbox_DureeTab.Text = "Duree Abonnement";
            this.Textbox_DureeTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox_TarifAb
            // 
            this.Textbox_TarifAb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_TarifAb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_TarifAb.ForeColor = System.Drawing.Color.Black;
            this.Textbox_TarifAb.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_TarifAb.HintText = "Nom";
            this.Textbox_TarifAb.isPassword = false;
            this.Textbox_TarifAb.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_TarifAb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_TarifAb.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_TarifAb.LineThickness = 3;
            this.Textbox_TarifAb.Location = new System.Drawing.Point(52, 198);
            this.Textbox_TarifAb.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_TarifAb.Name = "Textbox_TarifAb";
            this.Textbox_TarifAb.Size = new System.Drawing.Size(138, 31);
            this.Textbox_TarifAb.TabIndex = 0;
            this.Textbox_TarifAb.Text = "Tarif Abonnement";
            this.Textbox_TarifAb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(48, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description Abonnement :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(48, 240);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(175, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Duree Abonnement :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(48, 181);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tarif Abonnement :";
            // 
            // DataGrid_TAbon
            // 
            this.DataGrid_TAbon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_TAbon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_TAbon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_TAbon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_TAbon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_TAbon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_TAbon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TAbon.DoubleBuffered = true;
            this.DataGrid_TAbon.EnableHeadersVisualStyles = false;
            this.DataGrid_TAbon.HeaderBgColor = System.Drawing.Color.Coral;
            this.DataGrid_TAbon.HeaderForeColor = System.Drawing.Color.Coral;
            this.DataGrid_TAbon.Location = new System.Drawing.Point(505, 133);
            this.DataGrid_TAbon.Name = "DataGrid_TAbon";
            this.DataGrid_TAbon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_TAbon.Size = new System.Drawing.Size(511, 311);
            this.DataGrid_TAbon.TabIndex = 56;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button_previous);
            this.panelRight.Controls.Add(this.button_last);
            this.panelRight.Controls.Add(this.button_first);
            this.panelRight.Controls.Add(this.button_next);
            this.panelRight.Controls.Add(this.Txtbx_CodeAbonnement);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.Textbox_DesA);
            this.panelRight.Controls.Add(this.Textbox_DureeTab);
            this.panelRight.Controls.Add(this.Textbox_TarifAb);
            this.panelRight.Controls.Add(this.label20);
            this.panelRight.Controls.Add(this.label21);
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelRight.Location = new System.Drawing.Point(159, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(340, 591);
            this.panelRight.TabIndex = 52;
            // 
            // Textbox_DesA
            // 
            this.Textbox_DesA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_DesA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_DesA.ForeColor = System.Drawing.Color.Black;
            this.Textbox_DesA.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_DesA.HintText = "Description Abonnement";
            this.Textbox_DesA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Textbox_DesA.isPassword = false;
            this.Textbox_DesA.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_DesA.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_DesA.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_DesA.LineThickness = 3;
            this.Textbox_DesA.Location = new System.Drawing.Point(52, 126);
            this.Textbox_DesA.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_DesA.Name = "Textbox_DesA";
            this.Textbox_DesA.Size = new System.Drawing.Size(266, 40);
            this.Textbox_DesA.TabIndex = 1;
            this.Textbox_DesA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(1000, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 30);
            this.label22.TabIndex = 0;
            this.label22.Text = "x";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.DataGrid_TAbon);
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.label22);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1028, 529);
            this.panelLeft.TabIndex = 52;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Transparent;
            this.button_previous.Location = new System.Drawing.Point(98, 337);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(67, 47);
            this.button_previous.TabIndex = 75;
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.Color.Transparent;
            this.button_last.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.kisspng_button_computer_icons_iconfinder_clip_art_first_aid_clipart_5aad2e6e1701c91;
            this.button_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_last.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.ForeColor = System.Drawing.Color.Transparent;
            this.button_last.Location = new System.Drawing.Point(244, 331);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(83, 57);
            this.button_last.TabIndex = 76;
            this.button_last.UseVisualStyleBackColor = false;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_first
            // 
            this.button_first.BackColor = System.Drawing.Color.Transparent;
            this.button_first.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.kisspng_button_computer_icons_iconfinder_clip_art_first_aid_clipart_5aad2e6e1701c9_5299002815212990540942;
            this.button_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_first.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_first.ForeColor = System.Drawing.Color.Transparent;
            this.button_first.Location = new System.Drawing.Point(6, 331);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(86, 56);
            this.button_first.TabIndex = 78;
            this.button_first.UseVisualStyleBackColor = false;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Next;
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.Transparent;
            this.button_next.Location = new System.Drawing.Point(171, 337);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 77;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Supprimer.FlatAppearance.BorderSize = 0;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.ForeColor = System.Drawing.Color.White;
            this.button_Supprimer.Image = global::Gestion_Club_Sport_Final.Properties.Resources.delete_btn;
            this.button_Supprimer.Location = new System.Drawing.Point(3, 403);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(150, 55);
            this.button_Supprimer.TabIndex = 2;
            this.button_Supprimer.Text = "    Supprimer";
            this.button_Supprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Supprimer.UseVisualStyleBackColor = false;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // Button_Modifier
            // 
            this.Button_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Modifier.FlatAppearance.BorderSize = 0;
            this.Button_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modifier.ForeColor = System.Drawing.Color.White;
            this.Button_Modifier.Image = global::Gestion_Club_Sport_Final.Properties.Resources.edit_btn;
            this.Button_Modifier.Location = new System.Drawing.Point(3, 345);
            this.Button_Modifier.Name = "Button_Modifier";
            this.Button_Modifier.Size = new System.Drawing.Size(150, 55);
            this.Button_Modifier.TabIndex = 2;
            this.Button_Modifier.Text = "    Modifier";
            this.Button_Modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Modifier.UseVisualStyleBackColor = false;
            this.Button_Modifier.Click += new System.EventHandler(this.Button_Modifier_Click);
            // 
            // button_Nouveau
            // 
            this.button_Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Nouveau.FlatAppearance.BorderSize = 0;
            this.button_Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Nouveau.ForeColor = System.Drawing.Color.White;
            this.button_Nouveau.Image = ((System.Drawing.Image)(resources.GetObject("button_Nouveau.Image")));
            this.button_Nouveau.Location = new System.Drawing.Point(3, 222);
            this.button_Nouveau.Name = "button_Nouveau";
            this.button_Nouveau.Size = new System.Drawing.Size(150, 55);
            this.button_Nouveau.TabIndex = 2;
            this.button_Nouveau.Text = "    Nouveau";
            this.button_Nouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Nouveau.UseVisualStyleBackColor = false;
            this.button_Nouveau.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Ajouter.FlatAppearance.BorderSize = 0;
            this.button_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajouter.ForeColor = System.Drawing.Color.White;
            this.button_Ajouter.Image = global::Gestion_Club_Sport_Final.Properties.Resources.add_btn;
            this.button_Ajouter.Location = new System.Drawing.Point(3, 283);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(150, 55);
            this.button_Ajouter.TabIndex = 2;
            this.button_Ajouter.Text = "    Ajouter";
            this.button_Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Ajouter.UseVisualStyleBackColor = false;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Club_Sport_Final.Properties.Resources.subscription;
            this.pictureBox1.Location = new System.Drawing.Point(9, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 529);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbonnement";
            this.Load += new System.EventHandler(this.FormAbonnement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TAbon)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtbx_CodeAbonnement;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelLeft;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_TAbon;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_DesA;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_DureeTab;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_TarifAb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
    }
}