namespace Gestion_Club_Sport_Final
{
    partial class FormSalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalle));
            this.panelRight = new System.Windows.Forms.Panel();
            this.DataGrid_salle = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.Textbox_CodeRechSalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button_next = new System.Windows.Forms.Button();
            this.Txtbx_NomSalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.Textbox_CodeSalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_salle)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.DataGrid_salle);
            this.panelRight.Controls.Add(this.button_Rechercher);
            this.panelRight.Controls.Add(this.button_previous);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.button_last);
            this.panelRight.Controls.Add(this.button_first);
            this.panelRight.Controls.Add(this.Textbox_CodeRechSalle);
            this.panelRight.Controls.Add(this.button_next);
            this.panelRight.Controls.Add(this.Txtbx_NomSalle);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.Textbox_CodeSalle);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.label21);
            this.panelRight.Controls.Add(this.label22);
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelRight.Location = new System.Drawing.Point(156, -24);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(954, 488);
            this.panelRight.TabIndex = 56;
            // 
            // DataGrid_salle
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_salle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_salle.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_salle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_salle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_salle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_salle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_salle.DoubleBuffered = true;
            this.DataGrid_salle.EnableHeadersVisualStyles = false;
            this.DataGrid_salle.HeaderBgColor = System.Drawing.Color.Coral;
            this.DataGrid_salle.HeaderForeColor = System.Drawing.Color.Coral;
            this.DataGrid_salle.Location = new System.Drawing.Point(385, 162);
            this.DataGrid_salle.Name = "DataGrid_salle";
            this.DataGrid_salle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_salle.Size = new System.Drawing.Size(433, 250);
            this.DataGrid_salle.TabIndex = 75;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.BackColor = System.Drawing.Color.LightGray;
            this.button_Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rechercher.Image = global::Gestion_Club_Sport_Final.Properties.Resources.search_btn_data;
            this.button_Rechercher.Location = new System.Drawing.Point(222, 283);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(129, 31);
            this.button_Rechercher.TabIndex = 70;
            this.button_Rechercher.Text = "    Rechercher";
            this.button_Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Rechercher.UseVisualStyleBackColor = false;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.Transparent;
            this.button_previous.Location = new System.Drawing.Point(122, 374);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(67, 47);
            this.button_previous.TabIndex = 71;
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(26, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 21);
            this.label5.TabIndex = 68;
            this.label5.Text = "Code Salle Recherche :";
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.Color.Transparent;
            this.button_last.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.kisspng_button_computer_icons_iconfinder_clip_art_first_aid_clipart_5aad2e6e1701c91;
            this.button_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_last.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.ForeColor = System.Drawing.Color.Transparent;
            this.button_last.Location = new System.Drawing.Point(268, 368);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(83, 57);
            this.button_last.TabIndex = 72;
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
            this.button_first.Location = new System.Drawing.Point(30, 368);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(86, 56);
            this.button_first.TabIndex = 74;
            this.button_first.UseVisualStyleBackColor = false;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // Textbox_CodeRechSalle
            // 
            this.Textbox_CodeRechSalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeRechSalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeRechSalle.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeRechSalle.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeRechSalle.HintText = "Code Salle";
            this.Textbox_CodeRechSalle.isPassword = false;
            this.Textbox_CodeRechSalle.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeRechSalle.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeRechSalle.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeRechSalle.LineThickness = 3;
            this.Textbox_CodeRechSalle.Location = new System.Drawing.Point(30, 283);
            this.Textbox_CodeRechSalle.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeRechSalle.Name = "Textbox_CodeRechSalle";
            this.Textbox_CodeRechSalle.Size = new System.Drawing.Size(138, 31);
            this.Textbox_CodeRechSalle.TabIndex = 69;
            this.Textbox_CodeRechSalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Next;
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.Transparent;
            this.button_next.Location = new System.Drawing.Point(195, 374);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 73;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // Txtbx_NomSalle
            // 
            this.Txtbx_NomSalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtbx_NomSalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtbx_NomSalle.ForeColor = System.Drawing.Color.Black;
            this.Txtbx_NomSalle.HintForeColor = System.Drawing.Color.Empty;
            this.Txtbx_NomSalle.HintText = "Nom Salle";
            this.Txtbx_NomSalle.isPassword = false;
            this.Txtbx_NomSalle.LineFocusedColor = System.Drawing.Color.Coral;
            this.Txtbx_NomSalle.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Txtbx_NomSalle.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Txtbx_NomSalle.LineThickness = 3;
            this.Txtbx_NomSalle.Location = new System.Drawing.Point(44, 187);
            this.Txtbx_NomSalle.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_NomSalle.Name = "Txtbx_NomSalle";
            this.Txtbx_NomSalle.Size = new System.Drawing.Size(247, 31);
            this.Txtbx_NomSalle.TabIndex = 1;
            this.Txtbx_NomSalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txtbx_NomSalle.OnValueChanged += new System.EventHandler(this.Txtbx_NomSalle_OnValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(139, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Salle";
            // 
            // Textbox_CodeSalle
            // 
            this.Textbox_CodeSalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_CodeSalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_CodeSalle.ForeColor = System.Drawing.Color.Black;
            this.Textbox_CodeSalle.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_CodeSalle.HintText = "Code Salle";
            this.Textbox_CodeSalle.isPassword = false;
            this.Textbox_CodeSalle.LineFocusedColor = System.Drawing.Color.Coral;
            this.Textbox_CodeSalle.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Textbox_CodeSalle.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_CodeSalle.LineThickness = 3;
            this.Textbox_CodeSalle.Location = new System.Drawing.Point(44, 111);
            this.Textbox_CodeSalle.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_CodeSalle.Name = "Textbox_CodeSalle";
            this.Textbox_CodeSalle.Size = new System.Drawing.Size(247, 31);
            this.Textbox_CodeSalle.TabIndex = 0;
            this.Textbox_CodeSalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_CodeSalle.OnValueChanged += new System.EventHandler(this.Textbox_CodeSalle_OnValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(40, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nom Salle :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(40, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Code Salle :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(805, 24);
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
            this.panelLeft.BackColor = System.Drawing.Color.Purple;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(986, 464);
            this.panelLeft.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_Supprimer);
            this.panel1.Controls.Add(this.Button_Modifier);
            this.panel1.Controls.Add(this.button_Nouveau);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 691);
            this.panel1.TabIndex = 62;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Supprimer.FlatAppearance.BorderSize = 0;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.ForeColor = System.Drawing.Color.White;
            this.button_Supprimer.Image = global::Gestion_Club_Sport_Final.Properties.Resources.delete_btn;
            this.button_Supprimer.Location = new System.Drawing.Point(5, 341);
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
            this.Button_Modifier.Location = new System.Drawing.Point(3, 283);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_Club_Sport_Final.Properties.Resources.hotel;
            this.pictureBox2.Location = new System.Drawing.Point(9, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 464);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalle";
            this.Load += new System.EventHandler(this.FormSalle_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_salle)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtbx_NomSalle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeSalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_CodeRechSalle;
        private System.Windows.Forms.Button button_next;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_salle;
    }
}