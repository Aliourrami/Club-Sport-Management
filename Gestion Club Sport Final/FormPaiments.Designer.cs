namespace Gestion_Club_Sport_Final
{
    partial class FormPaiments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaiments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_CodeRechPai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DGV_Paiment = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.comboBoxModePaiment = new System.Windows.Forms.ComboBox();
            this.comboBoxMontant = new System.Windows.Forms.ComboBox();
            this.Cmbbx_NumAdhérent = new System.Windows.Forms.ComboBox();
            this.cmbx_CodeAbonner = new System.Windows.Forms.ComboBox();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Paiment)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(160, 452);
            this.panel1.TabIndex = 5;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Supprimer.FlatAppearance.BorderSize = 0;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.ForeColor = System.Drawing.Color.White;
            this.button_Supprimer.Image = global::Gestion_Club_Sport_Final.Properties.Resources.delete_btn;
            this.button_Supprimer.Location = new System.Drawing.Point(3, 397);
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
            this.Button_Modifier.Location = new System.Drawing.Point(3, 339);
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
            this.button_Nouveau.Location = new System.Drawing.Point(3, 216);
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
            this.button_Ajouter.Location = new System.Drawing.Point(3, 277);
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
            this.pictureBox1.Image = global::Gestion_Club_Sport_Final.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(9, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Code Adhérent :";
            // 
            // Textbox_CodeRechPai
            // 
            this.Textbox_CodeRechPai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeRechPai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeRechPai.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeRechPai.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeRechPai.HintText = "Code Adhérent";
            this.Textbox_CodeRechPai.isPassword = false;
            this.Textbox_CodeRechPai.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeRechPai.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeRechPai.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeRechPai.LineThickness = 3;
            this.Textbox_CodeRechPai.Location = new System.Drawing.Point(38, 309);
            this.Textbox_CodeRechPai.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeRechPai.Name = "Textbox_CodeRechPai";
            this.Textbox_CodeRechPai.Size = new System.Drawing.Size(138, 31);
            this.Textbox_CodeRechPai.TabIndex = 54;
            this.Textbox_CodeRechPai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(72, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Paiment";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(12, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mode Paiment :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(12, 170);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Montant :";
            // 
            // DGV_Paiment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Paiment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Paiment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Paiment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Paiment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Paiment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Paiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Paiment.DoubleBuffered = true;
            this.DGV_Paiment.EnableHeadersVisualStyles = false;
            this.DGV_Paiment.HeaderBgColor = System.Drawing.Color.Coral;
            this.DGV_Paiment.HeaderForeColor = System.Drawing.Color.Coral;
            this.DGV_Paiment.Location = new System.Drawing.Point(516, 90);
            this.DGV_Paiment.Name = "DGV_Paiment";
            this.DGV_Paiment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Paiment.Size = new System.Drawing.Size(446, 311);
            this.DGV_Paiment.TabIndex = 56;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button_previous);
            this.panelRight.Controls.Add(this.button_last);
            this.panelRight.Controls.Add(this.button_first);
            this.panelRight.Controls.Add(this.button_next);
            this.panelRight.Controls.Add(this.comboBoxModePaiment);
            this.panelRight.Controls.Add(this.comboBoxMontant);
            this.panelRight.Controls.Add(this.Cmbbx_NumAdhérent);
            this.panelRight.Controls.Add(this.cmbx_CodeAbonner);
            this.panelRight.Controls.Add(this.button_Rechercher);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.Textbox_CodeRechPai);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label18);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.label20);
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelRight.Location = new System.Drawing.Point(159, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(340, 452);
            this.panelRight.TabIndex = 52;
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Transparent;
            this.button_previous.Location = new System.Drawing.Point(99, 379);
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
            this.button_last.Location = new System.Drawing.Point(245, 373);
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
            this.button_first.Location = new System.Drawing.Point(7, 373);
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
            this.button_next.Location = new System.Drawing.Point(172, 379);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 93;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // comboBoxModePaiment
            // 
            this.comboBoxModePaiment.FormattingEnabled = true;
            this.comboBoxModePaiment.Location = new System.Drawing.Point(42, 255);
            this.comboBoxModePaiment.Name = "comboBoxModePaiment";
            this.comboBoxModePaiment.Size = new System.Drawing.Size(199, 21);
            this.comboBoxModePaiment.TabIndex = 59;
            // 
            // comboBoxMontant
            // 
            this.comboBoxMontant.FormattingEnabled = true;
            this.comboBoxMontant.Location = new System.Drawing.Point(42, 194);
            this.comboBoxMontant.Name = "comboBoxMontant";
            this.comboBoxMontant.Size = new System.Drawing.Size(199, 21);
            this.comboBoxMontant.TabIndex = 62;
            this.comboBoxMontant.SelectedIndexChanged += new System.EventHandler(this.comboBoxMontant_SelectedIndexChanged);
            // 
            // Cmbbx_NumAdhérent
            // 
            this.Cmbbx_NumAdhérent.FormattingEnabled = true;
            this.Cmbbx_NumAdhérent.Location = new System.Drawing.Point(42, 90);
            this.Cmbbx_NumAdhérent.Name = "Cmbbx_NumAdhérent";
            this.Cmbbx_NumAdhérent.Size = new System.Drawing.Size(199, 21);
            this.Cmbbx_NumAdhérent.TabIndex = 61;
            this.Cmbbx_NumAdhérent.SelectedIndexChanged += new System.EventHandler(this.Cmbbx_NumAdhérent_SelectedIndexChanged);
            this.Cmbbx_NumAdhérent.TextChanged += new System.EventHandler(this.Cmbbx_NumAdhérent_TextChanged);
            // 
            // cmbx_CodeAbonner
            // 
            this.cmbx_CodeAbonner.FormattingEnabled = true;
            this.cmbx_CodeAbonner.Location = new System.Drawing.Point(42, 141);
            this.cmbx_CodeAbonner.Name = "cmbx_CodeAbonner";
            this.cmbx_CodeAbonner.Size = new System.Drawing.Size(199, 21);
            this.cmbx_CodeAbonner.TabIndex = 61;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.BackColor = System.Drawing.Color.LightGray;
            this.button_Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rechercher.Image = global::Gestion_Club_Sport_Final.Properties.Resources.search_btn_data;
            this.button_Rechercher.Location = new System.Drawing.Point(200, 309);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(111, 31);
            this.button_Rechercher.TabIndex = 55;
            this.button_Rechercher.Text = "    Rechercher";
            this.button_Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Rechercher.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Abonner :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(16, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Num Adhérent :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label22.Location = new System.Drawing.Point(991, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 30);
            this.label22.TabIndex = 0;
            this.label22.Text = "x";
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
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.DGV_Paiment);
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.label22);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(984, 451);
            this.panelLeft.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(959, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 57;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormPaiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPaiments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPaiments";
            this.Load += new System.EventHandler(this.FormPaiments_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Paiment)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeRechPai;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Paiment;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmbbx_NumAdhérent;
        private System.Windows.Forms.ComboBox cmbx_CodeAbonner;
        private System.Windows.Forms.ComboBox comboBoxModePaiment;
        private System.Windows.Forms.ComboBox comboBoxMontant;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
    }
}