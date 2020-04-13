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
    public partial class FormRB : Form
    {
        public FormRB()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormFacture ff = new FormFacture();
            ff.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormAttestation fi = new FormAttestation();
            fi.Show();
        }

        private void FormRB_Load(object sender, EventArgs e)
        {

        }
    }
}
