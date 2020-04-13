using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Club_Sport_Final
{
    public partial class Statistique : UserControl
    {
        public Statistique()
        {
            InitializeComponent();
            //timer1.Start();
        }
        
           
        //Gestion_Club_Sport_FinalEntities1 cs = new Gestion_Club_Sport_FinalEntities1();
        private void Statistique_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Program.chargerDS();
            bunifuCustomDataGrid1.DataSource = Program.ds.Tables["Planifier"];
            nbrAd.Text = Program.ds.Tables["Adherent"].Rows.Count.ToString();
            //bunifuDatepicker1.Value = DateTime.Now;
            nbrE.Text = Program.ds.Tables["Entraineur"].Rows.Count.ToString();
            nbrG.Text = Program.ds.Tables["Groupe"].Rows.Count.ToString();
            nbrs.Text = Program.ds.Tables["Salle"].Rows.Count.ToString();
            nbrAc.Text = Program.ds.Tables["Activite"].Rows.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            this.labeltime.Text = d.ToString();
            timer1.Start();
        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }

        private void Panel22_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
