namespace Gestion_Club_Sport_Final
{
    partial class FormEntraineur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntraineur));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.DataGrid_Entr = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.Txtbx_NumE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cmbbx_SexeE = new System.Windows.Forms.ComboBox();
            this.DTP_DateIE = new System.Windows.Forms.DateTimePicker();
            this.Datepicker_DNE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.Textbox_CodeRechEntr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.Textbox_LibelleE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_PrenomE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_NomE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Entr)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panelLeft.Controls.Add(this.DataGrid_Entr);
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.label22);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1028, 467);
            this.panelLeft.TabIndex = 51;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // DataGrid_Entr
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Entr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Entr.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Entr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Entr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Entr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Entr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Entr.DoubleBuffered = true;
            this.DataGrid_Entr.EnableHeadersVisualStyles = false;
            this.DataGrid_Entr.HeaderBgColor = System.Drawing.Color.Coral;
            this.DataGrid_Entr.HeaderForeColor = System.Drawing.Color.Coral;
            this.DataGrid_Entr.Location = new System.Drawing.Point(505, 133);
            this.DataGrid_Entr.Name = "DataGrid_Entr";
            this.DataGrid_Entr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Entr.Size = new System.Drawing.Size(511, 311);
            this.DataGrid_Entr.TabIndex = 56;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button_previous);
            this.panelRight.Controls.Add(this.button_last);
            this.panelRight.Controls.Add(this.button_first);
            this.panelRight.Controls.Add(this.button_next);
            this.panelRight.Controls.Add(this.Txtbx_NumE);
            this.panelRight.Controls.Add(this.Cmbbx_SexeE);
            this.panelRight.Controls.Add(this.DTP_DateIE);
            this.panelRight.Controls.Add(this.Datepicker_DNE);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.button_Rechercher);
            this.panelRight.Controls.Add(this.Textbox_CodeRechEntr);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.Textbox_LibelleE);
            this.panelRight.Controls.Add(this.Textbox_PrenomE);
            this.panelRight.Controls.Add(this.Textbox_NomE);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.label20);
            this.panelRight.Controls.Add(this.label21);
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelRight.Location = new System.Drawing.Point(159, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(340, 591);
            this.panelRight.TabIndex = 52;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Transparent;
            this.button_previous.Location = new System.Drawing.Point(104, 404);
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
            this.button_last.Location = new System.Drawing.Point(250, 398);
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
            this.button_first.Location = new System.Drawing.Point(12, 398);
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
            this.button_next.Location = new System.Drawing.Point(177, 404);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 93;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // Txtbx_NumE
            // 
            this.Txtbx_NumE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtbx_NumE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtbx_NumE.ForeColor = System.Drawing.Color.Black;
            this.Txtbx_NumE.HintForeColor = System.Drawing.Color.Empty;
            this.Txtbx_NumE.HintText = "Num Entraineur";
            this.Txtbx_NumE.isPassword = false;
            this.Txtbx_NumE.LineFocusedColor = System.Drawing.Color.Coral;
            this.Txtbx_NumE.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Txtbx_NumE.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Txtbx_NumE.LineThickness = 3;
            this.Txtbx_NumE.Location = new System.Drawing.Point(35, 67);
            this.Txtbx_NumE.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_NumE.Name = "Txtbx_NumE";
            this.Txtbx_NumE.Size = new System.Drawing.Size(235, 31);
            this.Txtbx_NumE.TabIndex = 68;
            this.Txtbx_NumE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Cmbbx_SexeE
            // 
            this.Cmbbx_SexeE.FormattingEnabled = true;
            this.Cmbbx_SexeE.Location = new System.Drawing.Point(35, 314);
            this.Cmbbx_SexeE.Name = "Cmbbx_SexeE";
            this.Cmbbx_SexeE.Size = new System.Drawing.Size(192, 21);
            this.Cmbbx_SexeE.TabIndex = 67;
            // 
            // DTP_DateIE
            // 
            this.DTP_DateIE.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DateIE.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.DTP_DateIE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DateIE.Location = new System.Drawing.Point(192, 261);
            this.DTP_DateIE.Name = "DTP_DateIE";
            this.DTP_DateIE.Size = new System.Drawing.Size(101, 20);
            this.DTP_DateIE.TabIndex = 65;
            // 
            // Datepicker_DNE
            // 
            this.Datepicker_DNE.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datepicker_DNE.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.Datepicker_DNE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datepicker_DNE.Location = new System.Drawing.Point(35, 261);
            this.Datepicker_DNE.Name = "Datepicker_DNE";
            this.Datepicker_DNE.Size = new System.Drawing.Size(101, 20);
            this.Datepicker_DNE.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sexe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(179, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Date Inscription :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(15, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Date Naissance :";
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.BackColor = System.Drawing.Color.LightGray;
            this.button_Rechercher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rechercher.ForeColor = System.Drawing.Color.White;
            this.button_Rechercher.Image = global::Gestion_Club_Sport_Final.Properties.Resources.search_btn_data;
            this.button_Rechercher.Location = new System.Drawing.Point(169, 356);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(138, 33);
            this.button_Rechercher.TabIndex = 55;
            this.button_Rechercher.Text = "    Rechercher";
            this.button_Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Rechercher.UseVisualStyleBackColor = false;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // Textbox_CodeRechEntr
            // 
            this.Textbox_CodeRechEntr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeRechEntr.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeRechEntr.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeRechEntr.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeRechEntr.HintText = "Code Entr Rech";
            this.Textbox_CodeRechEntr.isPassword = false;
            this.Textbox_CodeRechEntr.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeRechEntr.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeRechEntr.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeRechEntr.LineThickness = 3;
            this.Textbox_CodeRechEntr.Location = new System.Drawing.Point(19, 356);
            this.Textbox_CodeRechEntr.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeRechEntr.Name = "Textbox_CodeRechEntr";
            this.Textbox_CodeRechEntr.Size = new System.Drawing.Size(128, 31);
            this.Textbox_CodeRechEntr.TabIndex = 54;
            this.Textbox_CodeRechEntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(72, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Entraineur";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Textbox_LibelleE
            // 
            this.Textbox_LibelleE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_LibelleE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_LibelleE.ForeColor = System.Drawing.Color.Black;
            this.Textbox_LibelleE.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_LibelleE.HintText = "Libelle Entraineur";
            this.Textbox_LibelleE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Textbox_LibelleE.isPassword = false;
            this.Textbox_LibelleE.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_LibelleE.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_LibelleE.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_LibelleE.LineThickness = 3;
            this.Textbox_LibelleE.Location = new System.Drawing.Point(20, 185);
            this.Textbox_LibelleE.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_LibelleE.Name = "Textbox_LibelleE";
            this.Textbox_LibelleE.Size = new System.Drawing.Size(266, 31);
            this.Textbox_LibelleE.TabIndex = 1;
            this.Textbox_LibelleE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_LibelleE.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // Textbox_PrenomE
            // 
            this.Textbox_PrenomE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_PrenomE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_PrenomE.ForeColor = System.Drawing.Color.Black;
            this.Textbox_PrenomE.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_PrenomE.HintText = "Prenom";
            this.Textbox_PrenomE.isPassword = false;
            this.Textbox_PrenomE.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_PrenomE.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_PrenomE.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_PrenomE.LineThickness = 3;
            this.Textbox_PrenomE.Location = new System.Drawing.Point(183, 133);
            this.Textbox_PrenomE.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_PrenomE.Name = "Textbox_PrenomE";
            this.Textbox_PrenomE.Size = new System.Drawing.Size(134, 31);
            this.Textbox_PrenomE.TabIndex = 1;
            this.Textbox_PrenomE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_PrenomE.OnValueChanged += new System.EventHandler(this.Textbox_Prenom_OnValueChanged);
            // 
            // Textbox_NomE
            // 
            this.Textbox_NomE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_NomE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_NomE.ForeColor = System.Drawing.Color.Black;
            this.Textbox_NomE.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_NomE.HintText = "Nom";
            this.Textbox_NomE.isPassword = false;
            this.Textbox_NomE.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_NomE.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_NomE.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_NomE.LineThickness = 3;
            this.Textbox_NomE.Location = new System.Drawing.Point(20, 133);
            this.Textbox_NomE.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_NomE.Name = "Textbox_NomE";
            this.Textbox_NomE.Size = new System.Drawing.Size(138, 31);
            this.Textbox_NomE.TabIndex = 0;
            this.Textbox_NomE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_NomE.OnValueChanged += new System.EventHandler(this.Textbox_Nom_OnValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(16, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Libelle Entraineur :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(179, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Prenom :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(16, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Nom :";
            this.label21.Click += new System.EventHandler(this.label21_Click);
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
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Club_Sport_Final.Properties.Resources.coach__1_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormEntraineur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 467);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntraineur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEntraineur";
            this.Load += new System.EventHandler(this.FormEntraineur_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Entr)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_PrenomE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_NomE;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_LibelleE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Entr;
        private System.Windows.Forms.Button button_Rechercher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeRechEntr;
        private System.Windows.Forms.ComboBox Cmbbx_SexeE;
        private System.Windows.Forms.DateTimePicker DTP_DateIE;
        private System.Windows.Forms.DateTimePicker Datepicker_DNE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtbx_NumE;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
    }
}