using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Club_Sport_Final
{
    public partial class FormAttestation : Form
    {
        public FormAttestation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //about1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //menu1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormImprimers_Load(object sender, EventArgs e)
        {
            comboBox_NumA.DisplayMember = "NumA";
            comboBox_NumA.DataSource = Program.ds.Tables["Adherent"];

        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            Attestation att = new Attestation();
            att.SetParameterValue("NumA", int.Parse(comboBox_NumA.Text));
            crystalReportViewer1.ReportSource = att;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
