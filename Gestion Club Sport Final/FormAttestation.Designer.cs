namespace Gestion_Club_Sport_Final
{
    partial class FormAttestation
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
            this.comboBox_NumA = new System.Windows.Forms.ComboBox();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Attestation1 = new Gestion_Club_Sport_Final.Attestation();
            this.SuspendLayout();
            // 
            // comboBox_NumA
            // 
            this.comboBox_NumA.FormattingEnabled = true;
            this.comboBox_NumA.Location = new System.Drawing.Point(539, 63);
            this.comboBox_NumA.Name = "comboBox_NumA";
            this.comboBox_NumA.Size = new System.Drawing.Size(146, 21);
            this.comboBox_NumA.TabIndex = 1;
            // 
            // button_Afficher
            // 
            this.button_Afficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.button_Afficher.FlatAppearance.BorderSize = 0;
            this.button_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Afficher.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Afficher.ForeColor = System.Drawing.Color.Transparent;
            this.button_Afficher.Location = new System.Drawing.Point(691, 59);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(94, 30);
            this.button_Afficher.TabIndex = 7;
            this.button_Afficher.Text = "Afficher";
            this.button_Afficher.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Afficher.UseVisualStyleBackColor = false;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label13.Location = new System.Drawing.Point(379, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 39);
            this.label13.TabIndex = 1;
            this.label13.Text = "Attestation";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.crystalReportViewer1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label22.Location = new System.Drawing.Point(915, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 30);
            this.label22.TabIndex = 15;
            this.label22.Text = "x";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 40);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Attestation1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(939, 508);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormAttestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 548);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.comboBox_NumA);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttestation";
            this.Text = "FormImprimers";
            this.Load += new System.EventHandler(this.FormImprimers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Attestation Attestation1;
        private System.Windows.Forms.ComboBox comboBox_NumA;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label22;
    }
}