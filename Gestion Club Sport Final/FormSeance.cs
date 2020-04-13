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
    public partial class FormSeance : Form
    {
        public FormSeance()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();

        private void act_dgv()
        {
            DGV_Seance.DataSource = Program.execute_select("select * from seance");


        }

        private void seance_Load(object sender, EventArgs e)
        {
            act_dgv();
            cmbx_Créneau.DisplayMember = "CodeC";
            cmbx_Créneau.DataSource = Program.execute_select("select * from Créneau");

            comboBox_Jours.DisplayMember = "NomJ";
            comboBox_Jours.ValueMember = "NumJ";
            comboBox_Jours.DataSource = Program.execute_select("select * from Jours");

            comboBox_Groupe.DisplayMember = "DescriptionG";
            comboBox_Groupe.DisplayMember = "CodeG";
            comboBox_Groupe.DataSource = Program.execute_select("select * from Groupe ");

            comboBox_Activite.DisplayMember = "LibelleAct";
            comboBox_Activite.ValueMember = "CodeAct";
            comboBox_Activite.DataSource = Program.execute_select("select * from Activite");

            comboBox_Entraineur.DisplayMember = "NomE";
            comboBox_Entraineur.ValueMember = "NumE";
            comboBox_Entraineur.DataSource = Program.execute_select("select * from Entraineur");


            bs.DataSource = Program.execute_select("select * from seance");
            Textbox_NumSeance.DataBindings.Add("text", bs, "NumSc");
            cmbx_Créneau.DataBindings.Add("text", bs, "Créneau");
            comboBox_Jours.DataBindings.Add("SelectedValue", bs, "Jours");
            comboBox_Groupe.DataBindings.Add("text", bs, "Groupe");
            comboBox_Activite.DataBindings.Add("SelectedValue", bs, "Activite");
            comboBox_Entraineur.DataBindings.Add("SelectedValue", bs, "Entraineur");
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            string req = string.Format(@"insert into Seance values ({0},{1},{2},{3},{4},{5})",
                                            Textbox_NumSeance.Text, cmbx_Créneau.Text,
                                            comboBox_Jours.SelectedValue.ToString(),
                                            comboBox_Groupe.SelectedValue.ToString(),
                                            comboBox_Activite.SelectedValue.ToString(),
                                            comboBox_Entraineur.SelectedValue.ToString());

            Program.Execute_MAJ(req);
            act_dgv();
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            string req = string.Format(@"update Seance 
                                            set Créneau = {0},
                                            Jours = {1},
                                            Groupe = {2} ,
                                            Activite = {3} ,
                                            Entraineur = {4} 
                                            where NumSc = {5}", cmbx_Créneau.Text,
                                            comboBox_Jours.SelectedValue.ToString(),
                                            comboBox_Groupe.SelectedValue.ToString(),
                                            comboBox_Activite.SelectedValue.ToString(),
                                            comboBox_Entraineur.SelectedValue.ToString(),
                                            Textbox_NumSeance.Text);

            Program.Execute_MAJ(req);
            act_dgv();

        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            string req = string.Format(@"delete seance where NumSc = {0}", Textbox_NumSeance.Text);
            Program.Execute_MAJ(req);
            act_dgv();
        }

        private void button_recherche_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Find("NumSc", Textbox_CodeRechActivite.Text);
        }

        private void button_Premier_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button_Precedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button_Suivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button_Dernier_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormSeance_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_rech_Seance_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_Groupe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
