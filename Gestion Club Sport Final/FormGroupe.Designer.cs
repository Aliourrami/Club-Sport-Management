namespace Gestion_Club_Sport_Final
{
    partial class FormGroupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txtbx_DesG = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_CodeG = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.cmbx_salleG = new System.Windows.Forms.ComboBox();
            this.Cmbbx_EntrG = new System.Windows.Forms.ComboBox();
            this.cmbx_ActiviteG = new System.Windows.Forms.ComboBox();
            this.DGV_EntraineurG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_CodeRechActivite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EntraineurG)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(984, 484);
            this.panelLeft.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_Supprimer);
            this.panel1.Controls.Add(this.Button_Modifier);
            this.panel1.Controls.Add(this.button_Nouveau);
            this.panel1.Controls.Add(this.button_Ajouter);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 691);
            this.panel1.TabIndex = 62;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Supprimer.FlatAppearance.BorderSize = 0;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.ForeColor = System.Drawing.Color.White;
            this.button_Supprimer.Image = global::Gestion_Club_Sport_Final.Properties.Resources.delete_btn;
            this.button_Supprimer.Location = new System.Drawing.Point(0, 403);
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
            this.Button_Modifier.Location = new System.Drawing.Point(0, 345);
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
            this.button_Nouveau.Location = new System.Drawing.Point(0, 222);
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
            this.button_Ajouter.Location = new System.Drawing.Point(0, 283);
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
            this.pictureBox2.Image = global::Gestion_Club_Sport_Final.Properties.Resources.team;
            this.pictureBox2.Location = new System.Drawing.Point(6, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(216, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Groupe";
            // 
            // Txtbx_DesG
            // 
            this.Txtbx_DesG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtbx_DesG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtbx_DesG.ForeColor = System.Drawing.Color.Black;
            this.Txtbx_DesG.HintForeColor = System.Drawing.Color.Empty;
            this.Txtbx_DesG.HintText = "Description Groupe";
            this.Txtbx_DesG.isPassword = false;
            this.Txtbx_DesG.LineFocusedColor = System.Drawing.Color.Coral;
            this.Txtbx_DesG.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Txtbx_DesG.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Txtbx_DesG.LineThickness = 3;
            this.Txtbx_DesG.Location = new System.Drawing.Point(45, 225);
            this.Txtbx_DesG.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_DesG.Name = "Txtbx_DesG";
            this.Txtbx_DesG.Size = new System.Drawing.Size(192, 31);
            this.Txtbx_DesG.TabIndex = 1;
            this.Txtbx_DesG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox_CodeG
            // 
            this.Textbox_CodeG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeG.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeG.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeG.HintText = "Code Groupe";
            this.Textbox_CodeG.isPassword = false;
            this.Textbox_CodeG.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeG.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeG.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeG.LineThickness = 3;
            this.Textbox_CodeG.Location = new System.Drawing.Point(45, 103);
            this.Textbox_CodeG.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeG.Name = "Textbox_CodeG";
            this.Textbox_CodeG.Size = new System.Drawing.Size(192, 31);
            this.Textbox_CodeG.TabIndex = 0;
            this.Textbox_CodeG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(36, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Entraineur :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(36, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Code Groupe :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(797, 2);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(36, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description Groupe :";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button_previous);
            this.panelRight.Controls.Add(this.button_last);
            this.panelRight.Controls.Add(this.button_first);
            this.panelRight.Controls.Add(this.button_next);
            this.panelRight.Controls.Add(this.cmbx_salleG);
            this.panelRight.Controls.Add(this.Cmbbx_EntrG);
            this.panelRight.Controls.Add(this.cmbx_ActiviteG);
            this.panelRight.Controls.Add(this.DGV_EntraineurG);
            this.panelRight.Controls.Add(this.button_Rechercher);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.Textbox_CodeRechActivite);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.Txtbx_DesG);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.Textbox_CodeG);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label18);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.label21);
            this.panelRight.Controls.Add(this.label22);
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRight.Location = new System.Drawing.Point(159, -3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(825, 486);
            this.panelRight.TabIndex = 54;
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Transparent;
            this.button_previous.Location = new System.Drawing.Point(108, 426);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(67, 47);
            this.button_previous.TabIndex = 91;
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
            this.button_last.Location = new System.Drawing.Point(254, 420);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(83, 57);
            this.button_last.TabIndex = 92;
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
            this.button_first.Location = new System.Drawing.Point(16, 420);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(86, 56);
            this.button_first.TabIndex = 94;
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
            this.button_next.Location = new System.Drawing.Point(181, 426);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 93;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // cmbx_salleG
            // 
            this.cmbx_salleG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.cmbx_salleG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_salleG.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbx_salleG.FormattingEnabled = true;
            this.cmbx_salleG.Location = new System.Drawing.Point(45, 350);
            this.cmbx_salleG.Name = "cmbx_salleG";
            this.cmbx_salleG.Size = new System.Drawing.Size(192, 21);
            this.cmbx_salleG.TabIndex = 76;
            // 
            // Cmbbx_EntrG
            // 
            this.Cmbbx_EntrG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.Cmbbx_EntrG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbbx_EntrG.ForeColor = System.Drawing.SystemColors.Window;
            this.Cmbbx_EntrG.FormattingEnabled = true;
            this.Cmbbx_EntrG.Location = new System.Drawing.Point(45, 294);
            this.Cmbbx_EntrG.Name = "Cmbbx_EntrG";
            this.Cmbbx_EntrG.Size = new System.Drawing.Size(192, 21);
            this.Cmbbx_EntrG.TabIndex = 76;
            // 
            // cmbx_ActiviteG
            // 
            this.cmbx_ActiviteG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.cmbx_ActiviteG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_ActiviteG.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbx_ActiviteG.FormattingEnabled = true;
            this.cmbx_ActiviteG.Location = new System.Drawing.Point(45, 171);
            this.cmbx_ActiviteG.Name = "cmbx_ActiviteG";
            this.cmbx_ActiviteG.Size = new System.Drawing.Size(192, 21);
            this.cmbx_ActiviteG.TabIndex = 76;
            this.cmbx_ActiviteG.SelectedIndexChanged += new System.EventHandler(this.cmbx_ActiviteG_SelectedIndexChanged);
            // 
            // DGV_EntraineurG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_EntraineurG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_EntraineurG.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_EntraineurG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_EntraineurG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_EntraineurG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_EntraineurG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EntraineurG.DoubleBuffered = true;
            this.DGV_EntraineurG.EnableHeadersVisualStyles = false;
            this.DGV_EntraineurG.HeaderBgColor = System.Drawing.Color.Coral;
            this.DGV_EntraineurG.HeaderForeColor = System.Drawing.Color.Coral;
            this.DGV_EntraineurG.Location = new System.Drawing.Point(328, 155);
            this.DGV_EntraineurG.Name = "DGV_EntraineurG";
            this.DGV_EntraineurG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_EntraineurG.Size = new System.Drawing.Size(485, 250);
            this.DGV_EntraineurG.TabIndex = 75;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.BackColor = System.Drawing.Color.LightGray;
            this.button_Rechercher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rechercher.Image = global::Gestion_Club_Sport_Final.Properties.Resources.search_btn_data;
            this.button_Rechercher.Location = new System.Drawing.Point(599, 96);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(150, 38);
            this.button_Rechercher.TabIndex = 70;
            this.button_Rechercher.Text = "    Rechercher";
            this.button_Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Rechercher.UseVisualStyleBackColor = false;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(324, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 21);
            this.label5.TabIndex = 68;
            this.label5.Text = "Code Groupe Rechercher :";
            // 
            // Textbox_CodeRechActivite
            // 
            this.Textbox_CodeRechActivite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeRechActivite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeRechActivite.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeRechActivite.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeRechActivite.HintText = "Code Groupe Rechercher :";
            this.Textbox_CodeRechActivite.isPassword = false;
            this.Textbox_CodeRechActivite.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeRechActivite.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeRechActivite.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeRechActivite.LineThickness = 3;
            this.Textbox_CodeRechActivite.Location = new System.Drawing.Point(351, 103);
            this.Textbox_CodeRechActivite.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeRechActivite.Name = "Textbox_CodeRechActivite";
            this.Textbox_CodeRechActivite.Size = new System.Drawing.Size(208, 31);
            this.Textbox_CodeRechActivite.TabIndex = 69;
            this.Textbox_CodeRechActivite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(36, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activite :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(36, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salle :";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.button_last;
            // 
            // FormGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroupe";
            this.Load += new System.EventHandler(this.FormGroupe_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EntraineurG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtbx_DesG;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeG;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeRechActivite;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_EntraineurG;
        private System.Windows.Forms.ComboBox cmbx_salleG;
        private System.Windows.Forms.ComboBox Cmbbx_EntrG;
        private System.Windows.Forms.ComboBox cmbx_ActiviteG;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}