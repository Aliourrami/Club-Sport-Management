namespace Gestion_Club_Sport_Final
{
    partial class FormPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlan));
            this.DataGrid_Plan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labeldi = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.Datepicker_DatePlan = new System.Windows.Forms.DateTimePicker();
            this.dtp_HeureDebut = new System.Windows.Forms.DateTimePicker();
            this.DTP_HeureFin = new System.Windows.Forms.DateTimePicker();
            this.Cmbbx_CodeActiviter = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbx_NumSal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Plan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_Plan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Plan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Plan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Plan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Plan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Plan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Plan.DoubleBuffered = true;
            this.DataGrid_Plan.EnableHeadersVisualStyles = false;
            this.DataGrid_Plan.HeaderBgColor = System.Drawing.Color.Coral;
            this.DataGrid_Plan.HeaderForeColor = System.Drawing.Color.Coral;
            this.DataGrid_Plan.Location = new System.Drawing.Point(505, 133);
            this.DataGrid_Plan.Name = "DataGrid_Plan";
            this.DataGrid_Plan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Plan.Size = new System.Drawing.Size(511, 311);
            this.DataGrid_Plan.TabIndex = 56;
            this.DataGrid_Plan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Plan_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(125, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Planing";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(190, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Activiter :";
            // 
            // labeldi
            // 
            this.labeldi.AutoSize = true;
            this.labeldi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labeldi.Location = new System.Drawing.Point(185, 133);
            this.labeldi.Name = "labeldi";
            this.labeldi.Size = new System.Drawing.Size(89, 21);
            this.labeldi.TabIndex = 0;
            this.labeldi.Text = "Heure Fin :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(107, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Date Plan :";
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
            this.panel1.Size = new System.Drawing.Size(160, 467);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Club_Sport_Final.Properties.Resources.Plan;
            this.pictureBox1.Location = new System.Drawing.Point(9, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button_previous);
            this.panelRight.Controls.Add(this.button_last);
            this.panelRight.Controls.Add(this.button_first);
            this.panelRight.Controls.Add(this.button_next);
            this.panelRight.Controls.Add(this.Datepicker_DatePlan);
            this.panelRight.Controls.Add(this.dtp_HeureDebut);
            this.panelRight.Controls.Add(this.DTP_HeureFin);
            this.panelRight.Controls.Add(this.Cmbbx_CodeActiviter);
            this.panelRight.Controls.Add(this.comboBox2);
            this.panelRight.Controls.Add(this.cmbx_NumSal);
            this.panelRight.Controls.Add(this.label13);
            this.panelRight.Controls.Add(this.label19);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.labeldi);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label18);
            this.panelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelRight.Location = new System.Drawing.Point(159, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(340, 467);
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
            this.button_previous.Location = new System.Drawing.Point(100, 351);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(67, 47);
            this.button_previous.TabIndex = 75;
            this.button_previous.UseVisualStyleBackColor = false;
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.Color.Transparent;
            this.button_last.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.kisspng_button_computer_icons_iconfinder_clip_art_first_aid_clipart_5aad2e6e1701c91;
            this.button_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_last.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.ForeColor = System.Drawing.Color.Transparent;
            this.button_last.Location = new System.Drawing.Point(246, 345);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(83, 57);
            this.button_last.TabIndex = 76;
            this.button_last.UseVisualStyleBackColor = false;
            // 
            // button_first
            // 
            this.button_first.BackColor = System.Drawing.Color.Transparent;
            this.button_first.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.kisspng_button_computer_icons_iconfinder_clip_art_first_aid_clipart_5aad2e6e1701c9_5299002815212990540942;
            this.button_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_first.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_first.ForeColor = System.Drawing.Color.Transparent;
            this.button_first.Location = new System.Drawing.Point(8, 345);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(86, 56);
            this.button_first.TabIndex = 78;
            this.button_first.UseVisualStyleBackColor = false;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = global::Gestion_Club_Sport_Final.Properties.Resources.Next;
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.Transparent;
            this.button_next.Location = new System.Drawing.Point(173, 351);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(67, 47);
            this.button_next.TabIndex = 77;
            this.button_next.UseVisualStyleBackColor = false;
            // 
            // Datepicker_DatePlan
            // 
            this.Datepicker_DatePlan.Location = new System.Drawing.Point(58, 93);
            this.Datepicker_DatePlan.Name = "Datepicker_DatePlan";
            this.Datepicker_DatePlan.Size = new System.Drawing.Size(200, 20);
            this.Datepicker_DatePlan.TabIndex = 66;
            // 
            // dtp_HeureDebut
            // 
            this.dtp_HeureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_HeureDebut.Location = new System.Drawing.Point(22, 157);
            this.dtp_HeureDebut.Name = "dtp_HeureDebut";
            this.dtp_HeureDebut.Size = new System.Drawing.Size(114, 20);
            this.dtp_HeureDebut.TabIndex = 65;
            // 
            // DTP_HeureFin
            // 
            this.DTP_HeureFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_HeureFin.Location = new System.Drawing.Point(189, 157);
            this.DTP_HeureFin.Name = "DTP_HeureFin";
            this.DTP_HeureFin.Size = new System.Drawing.Size(129, 20);
            this.DTP_HeureFin.TabIndex = 64;
            // 
            // Cmbbx_CodeActiviter
            // 
            this.Cmbbx_CodeActiviter.FormattingEnabled = true;
            this.Cmbbx_CodeActiviter.Location = new System.Drawing.Point(189, 225);
            this.Cmbbx_CodeActiviter.Name = "Cmbbx_CodeActiviter";
            this.Cmbbx_CodeActiviter.Size = new System.Drawing.Size(121, 21);
            this.Cmbbx_CodeActiviter.TabIndex = 63;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(100, 292);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 62;
            // 
            // cmbx_NumSal
            // 
            this.cmbx_NumSal.FormattingEnabled = true;
            this.cmbx_NumSal.Location = new System.Drawing.Point(21, 225);
            this.cmbx_NumSal.Name = "cmbx_NumSal";
            this.cmbx_NumSal.Size = new System.Drawing.Size(121, 21);
            this.cmbx_NumSal.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Heure Debut :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Num Salle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(128, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groupe :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(999, 0);
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
            this.panelLeft.Controls.Add(this.DataGrid_Plan);
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.label22);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1024, 467);
            this.panelLeft.TabIndex = 52;
            // 
            // FormPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 467);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.FormPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Plan)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Ajouter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Plan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labeldi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Nouveau;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Datepicker_DatePlan;
        private System.Windows.Forms.DateTimePicker dtp_HeureDebut;
        private System.Windows.Forms.DateTimePicker DTP_HeureFin;
        private System.Windows.Forms.ComboBox Cmbbx_CodeActiviter;
        private System.Windows.Forms.ComboBox cmbx_NumSal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
    }
}