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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            statistique1.BringToFront();
            labelTitle.Text = "Dashboard";
        }
        GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        private void menu1_Load(object sender, EventArgs e)
        {
            Program.chargerDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_sys_Click(object sender, EventArgs e)
        {

        }

        private void button_dash_Click(object sender, EventArgs e)
        {
            statistique1.BringToFront();
            labelTitle.Text = "Dashboard";
            pnlStats.Top = button_dash.Top;
            pnlStats.Height = button_dash.Height;
            //pnlDashboard.Visible = True;
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            /*this.Hide();*/
            FormAbout fa = new FormAbout();
            fa.Show();
            labelTitle.Text = "About Us";
            pnlStats.Top = button_about.Top;
            pnlStats.Height = button_about.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statistique1_Load(object sender, EventArgs e)
        {
            //bunifuCustomDataGrid1.DataSource = cs.Planifiers.ToList();
            //bunifuDatepicker1.Value = DateTime.Now;
            //nbr_adh.Text = cs.Adherents.Count().ToString();
            //nbr_entr.Text = cs.Entraineurs.Count().ToString();
            //nbr_grp.Text = cs.Groupes.Count().ToString();
            //nbr_salle.Text = cs.Salles.Count().ToString();
        }

        private void pnlStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Sys_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_system_Click(object sender, EventArgs e)
        {
            menu1.BringToFront();
            labelTitle.Text = "Gerer La System Du Sport";
            pnlStats.Top = btn_system.Top;
            pnlStats.Height = btn_system.Height;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
