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
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            Facture fa = new Facture();
            fa.SetParameterValue("ab.NumA", int.Parse(comboBox_NumA.Text));
            crystalReportViewer1.ReportSource = fa;
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            comboBox_NumA.DisplayMember = "NumA";
            comboBox_NumA.DataSource = Program.ds.Tables["Adherent"];
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
