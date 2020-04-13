namespace Gestion_Club_Sport_Final
{
    partial class FormJours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJours));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_CodeRechActivite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numJ = new System.Windows.Forms.Label();
            this.button_Rech_Jour = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Textbox_NumJ = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txtbx_NomJ = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DataGrid_Jours = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Jours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(928, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label8.Location = new System.Drawing.Point(1195, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 30);
            this.label8.TabIndex = 65;
            this.label8.Text = "x";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Num Jour :";
            // 
            // Textbox_CodeRechActivite
            // 
            this.Textbox_CodeRechActivite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeRechActivite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeRechActivite.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeRechActivite.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeRechActivite.HintText = "Num Jour";
            this.Textbox_CodeRechActivite.isPassword = false;
            this.Textbox_CodeRechActivite.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeRechActivite.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeRechActivite.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeRechActivite.LineThickness = 3;
            this.Textbox_CodeRechActivite.Location = new System.Drawing.Point(20, 263);
            this.Textbox_CodeRechActivite.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeRechActivite.Name = "Textbox_CodeRechActivite";
            this.Textbox_CodeRechActivite.Size = new System.Drawing.Size(138, 31);
            this.Textbox_CodeRechActivite.TabIndex = 59;
            this.Textbox_CodeRechActivite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_previous);
            this.panel2.Controls.Add(this.button_last);
            this.panel2.Controls.Add(this.button_first);
            this.panel2.Controls.Add(this.button_next);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.numJ);
            this.panel2.Controls.Add(this.button_Rech_Jour);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Textbox_CodeRechActivite);
            this.panel2.Controls.Add(this.Textbox_NumJ);
            this.panel2.Controls.Add(this.Txtbx_NomJ);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panel2.Location = new System.Drawing.Point(159, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 458);
            this.panel2.TabIndex = 67;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Transparent;
            this.button_previous.Location = new System.Drawing.Point(109, 348);
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
            this.button_last.Location = new System.Drawing.Point(255, 342);
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
            this.button_first.Location = new System.Drawing.Point(17, 342);
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
            this.button_next.Location = new System.Drawing.Point(182, 348);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 77;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(123, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Jours";
            // 
            // numJ
            // 
            this.numJ.AutoSize = true;
            this.numJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numJ.Location = new System.Drawing.Point(44, 87);
            this.numJ.Name = "numJ";
            this.numJ.Size = new System.Drawing.Size(92, 21);
            this.numJ.TabIndex = 0;
            this.numJ.Text = "Num Jour :";
            // 
            // button_Rech_Jour
            // 
            this.button_Rech_Jour.BackColor = System.Drawing.Color.LightGray;
            this.button_Rech_Jour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rech_Jour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rech_Jour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rech_Jour.Image = global::Gestion_Club_Sport_Final.Properties.Resources.search_btn_data;
            this.button_Rech_Jour.Location = new System.Drawing.Point(182, 263);
            this.button_Rech_Jour.Name = "button_Rech_Jour";
            this.button_Rech_Jour.Size = new System.Drawing.Size(122, 31);
            this.button_Rech_Jour.TabIndex = 60;
            this.button_Rech_Jour.Text = "    Rechercher";
            this.button_Rech_Jour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Rech_Jour.UseVisualStyleBackColor = false;
            this.button_Rech_Jour.Click += new System.EventHandler(this.button_Rech_Jour_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(44, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = " Nom Jour :";
            // 
            // Textbox_NumJ
            // 
            this.Textbox_NumJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_NumJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_NumJ.ForeColor = System.Drawing.Color.Black;
            this.Textbox_NumJ.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_NumJ.HintText = "Num Jour";
            this.Textbox_NumJ.isPassword = false;
            this.Textbox_NumJ.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_NumJ.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_NumJ.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_NumJ.LineThickness = 3;
            this.Textbox_NumJ.Location = new System.Drawing.Point(48, 110);
            this.Textbox_NumJ.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_NumJ.Name = "Textbox_NumJ";
            this.Textbox_NumJ.Size = new System.Drawing.Size(247, 31);
            this.Textbox_NumJ.TabIndex = 0;
            this.Textbox_NumJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtbx_NomJ
            // 
            this.Txtbx_NomJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtbx_NomJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtbx_NomJ.ForeColor = System.Drawing.Color.Black;
            this.Txtbx_NomJ.HintForeColor = System.Drawing.Color.Empty;
            this.Txtbx_NomJ.HintText = "Nom Jour";
            this.Txtbx_NomJ.isPassword = false;
            this.Txtbx_NomJ.LineFocusedColor = System.Drawing.Color.Coral;
            this.Txtbx_NomJ.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Txtbx_NomJ.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Txtbx_NomJ.LineThickness = 3;
            this.Txtbx_NomJ.Location = new System.Drawing.Point(48, 174);
            this.Txtbx_NomJ.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_NomJ.Name = "Txtbx_NomJ";
            this.Txtbx_NomJ.Size = new System.Drawing.Size(247, 31);
            this.Txtbx_NomJ.TabIndex = 1;
            this.Txtbx_NomJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_Supprimer);
            this.panel1.Controls.Add(this.Button_Modifier);
            this.panel1.Controls.Add(this.button_Nouveau);
            this.panel1.Controls.Add(this.button_Ajouter);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 458);
            this.panel1.TabIndex = 66;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_Club_Sport_Final.Properties.Resources.Circle_icons_calendar_svg;
            this.pictureBox2.Location = new System.Drawing.Point(9, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // DataGrid_Jours
            // 
            this.DataGrid_Jours.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Jours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Jours.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Jours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Jours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Jours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Jours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Jours.DoubleBuffered = true;
            this.DataGrid_Jours.EnableHeadersVisualStyles = false;
            this.DataGrid_Jours.HeaderBgColor = System.Drawing.Color.Coral;
            this.DataGrid_Jours.HeaderForeColor = System.Drawing.Color.Coral;
            this.DataGrid_Jours.Location = new System.Drawing.Point(526, 109);
            this.DataGrid_Jours.Name = "DataGrid_Jours";
            this.DataGrid_Jours.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Jours.Size = new System.Drawing.Size(416, 250);
            this.DataGrid_Jours.TabIndex = 68;
            this.DataGrid_Jours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Jours_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormJours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGrid_Jours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJours";
            this.Load += new System.EventHandler(this.FormJours_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Jours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Rech_Jour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label numJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeRechActivite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_NumJ;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtbx_NomJ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Ajouter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Jours;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
    }
}