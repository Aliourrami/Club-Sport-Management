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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_AjtAdh_Click(object sender, EventArgs e)
        {
            FormAdherent fa = new FormAdherent();
            fa.Show();
        }

        private void Button_AjtEntr_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Salle_Click(object sender, EventArgs e)
        {

        }

        private void Button_Abonnements_Click(object sender, EventArgs e)
        {

        }

        private void Button_Activité_Click(object sender, EventArgs e)
        {

        }

        private void Button_Plan_Click(object sender, EventArgs e)
        {

        }

        private void Button_Groupe_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            FormPaiments fp = new FormPaiments();
            fp.Show();
        }

        private void Button_Imprimers_Click(object sender, EventArgs e)
        {
            FormRB fRB = new FormRB();
            fRB.Show();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormAbonnement fa = new FormAbonnement();
            fa.Show();
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            
            FormPaiments fp = new FormPaiments();
            fp.Show();
        }

        private void Button_AjtAdh_Click_1(object sender, EventArgs e)
        {
            FormAdherent fa = new FormAdherent();
            fa.Show();
        }

        private void Button_AjtEntr_Click_1(object sender, EventArgs e)
        {
            
            FormEntraineur fe = new FormEntraineur();
            fe.Show();
        }

        private void Button_Imprimers_Click_1(object sender, EventArgs e)
        {
            
            FormRB rB = new FormRB();
            rB.Show();
        }

        private void Button_Abonnements_Click_1(object sender, EventArgs e)
        {
            
            FormAbonnement fab = new FormAbonnement();
            fab.Show();
        }

        private void Button_Salle_Click_1(object sender, EventArgs e)
        {
            
            FormSalle fs = new FormSalle();
            fs.Show();
        }

        private void Button_Groupe_Click_1(object sender, EventArgs e)
        {
            
            FormGroupe fg = new FormGroupe();
            fg.Show();
        }

        private void Button_Activité_Click_1(object sender, EventArgs e)
        {
            
            FormActivite fat = new FormActivite();
            fat.Show();
        }

        private void Button_Plan_Click_1(object sender, EventArgs e)
        {
            
            FormPlan fp = new FormPlan();
            fp.Show();
        }

        private void Button_Abonner_Click(object sender, EventArgs e)
        {
            
            FormAbonner fab = new FormAbonner();
            fab.Show();
        }

        private void Button_Seance_Click(object sender, EventArgs e)
        {
            
            FormSeance fs = new FormSeance();
            fs.Show();
        }

        private void Button_Resume_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Jours_Click(object sender, EventArgs e)
        {
            
            FormJours fj = new FormJours();
            fj.Show();
        }

        private void Button_Créneau_Click(object sender, EventArgs e)
        {
            
            FormCréneau fc = new FormCréneau();
            fc.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
