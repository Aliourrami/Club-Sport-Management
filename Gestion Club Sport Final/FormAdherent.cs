using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Club_Sport_Final
{
    public partial class FormAdherent : Form
    {
        public FormAdherent()
        {
            InitializeComponent();
        }

        //BindingSource bs2 = new BindingSource();
        //BindingSource bs3 = new BindingSource();
        GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        BindingSource bs = new BindingSource();
        private void MAJ_DGV()
        {
            //bs.DataSource = Program.ds.Tables["Adherent"];
            DataGrid_Adh.DataSource = bs;
            bs.DataSource = cs.Adherents.ToList();

            //bs.DataSource = Program.ds.Tables["Adherent"];
            //DataGrid_Adh.DataSource = Program.ds.Tables["Adherent"] ;
            //DataGrid_Adh.DataSource = cs.Adherents.ToList();

            //DataGrid_Adh.DataSource = cs.Adherents.Select(p => p.NumA).ToList();
            /*+ p.NomA + p.PrenomA + p.DateN + p.DateI + p.Sexe + p.Adresse + p.VilleA + p.Tel + p.Groupe + p.CodeAct*/
        }
        private void FormAdherent_Load(object sender, EventArgs e)
        {
            //Program.chargerDS();
            //Program.CharGerDSS();
            MAJ_DGV();


            //new Adherent().

            //bs.DataSource = cs.Adherents.ToList();
            bs.DataSource = Program.ds.Tables["Adherent"];
            //bs.DataSource = cs.Adherents.Local;

            Txtbx_NumA.DataBindings.Add(new Binding("text", bs, "NumA"));
            Textbox_Nomad.DataBindings.Add(new Binding("text", bs, "NomA"));
            Textbox_Prenom.DataBindings.Add(new Binding("text", bs, "PrenomA"));
            Datepicker_DN.DataBindings.Add(new Binding("text", bs, "DateN"));
            DTP_Date_Inscription.DataBindings.Add(new Binding("text", bs, "DateI"));
            Cmbbx_sexe.DataBindings.Add(new Binding("text", bs, "Sexe"));
            Textbox_Adresse.DataBindings.Add(new Binding("text", bs, "Adresse"));
            Textbox_Ville.DataBindings.Add(new Binding("text", bs, "VilleA"));
            Textbox_Tel.DataBindings.Add(new Binding("text", bs, "Tel"));
            //comboBox_Group.DataBindings.Add("text", bs, "groupe", true);
            //comboBox_Activite.DataBindings.Add("text", bs, "codeAct", true);
            comboBox_Group.DataBindings.Add(new Binding("SelectedValue", bs, "groupe"));
            comboBox_Activite.DataBindings.Add(new Binding("SelectedValue", bs, "codeAct"));

            //Textbox_CodeAdhérent.DataBindings.Add("text", bs, "NumA");
            //Textbox_Nomad.DataBindings.Add("text", bs, "NomA");
            //Textbox_Prenom.DataBindings.Add("text", bs, "PrenomA");
            //Datepicker_DN.DataBindings.Add("text", bs, "DateN");
            //DTP_Date_Inscription.DataBindings.Add("text", bs, "DateI");
            //Cmbbx_sexe.DataBindings.Add("text", bs, "Sexe");
            //Textbox_Adresse.DataBindings.Add("text", bs, "Adresse");
            //Textbox_Ville.DataBindings.Add("text", bs, "VilleA");
            //Textbox_Tel.DataBindings.Add("text", bs, "Tel");
            //comboBox_Group.DataBindings.Add("text", bs, "groupe");
            //comboBox_Activite.DataBindings.Add("text", bs, "codeAct");

            comboBox_Group.ValueMember = "CodeG";
            comboBox_Group.DisplayMember = "DescriptionG";
            //comboBox_Group.DataSource = Program.ds.Tables["Groupe"];
            comboBox_Group.DataSource = cs.Groupes.ToList();
            //comboBox_Group.DataSource = cs.Groupes.Select(x => x.DescriptionG).ToList();

            ////
            comboBox_Activite.ValueMember = "CodeAct";
            comboBox_Activite.DisplayMember = "LibelleAct";
            //comboBox_Activite.DataSource = cs.Activites.Local;
            //comboBox_Activite.DataSource = Program.ds.Tables["Activite"];
            //comboBox_Activite.DataSource = cs.Activites.Select(x => x.LibelleAct).ToList();
            comboBox_Activite.DataSource = cs.Activites.ToList();

            DTP_Date_Inscription.Value = DateTime.Today;
            Cmbbx_sexe.Items.Add("Masculin");
            Cmbbx_sexe.Items.Add("Féminin");
            //bs.DataSource = cs.Groupes.ToList();
            //bs.DataSource = cs.Activites.ToList();





            //comboBox_Group.DataBindings.Add("text", bs2, "DescriptionG", true);
            //comboBox_Activite.DataBindings.Add("text", bs3, "LibelleAct", true);
            //CmbxActiviter.DataSource = cs.Activites.Select(x => x.CodeAct).ToList();

            //.Select(x => x.DescriptionG)

            //cmbx_Groupe.DisplayMember = "DescriptionG";
            //cmbx_Groupe.DataSource = cs.Groupes.ToList();
            //var NomGrp = ((from g in cs.Groupes
            //               where g.CodeG.Equals(cmbx_Groupe.SelectedItem)
            //               select g.DescriptionG)).ToList();
            /* select new { g.DescriptionG }*/
            //cmbx_Groupe.SelectedValue = 0;
            ////Cmbbx_Sexe.selectedValue = 0;
            //CmbxActiviter.SelectedValue = 0;
        }

        private void Button_Ajouter_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            var Adh = new Adherent
            {
                NumA = int.Parse(Txtbx_NumA.Text),
                NomA = Textbox_Nomad.Text,
                PrenomA = Textbox_Prenom.Text,
                DateN = Datepicker_DN.Value,
                DateI = DTP_Date_Inscription.Value,
                Sexe = Cmbbx_sexe.Text,
                Adresse = Textbox_Adresse.Text,
                VilleA = Textbox_Ville.Text,
                Tel = Textbox_Tel.Text,
                Groupe = (int)(comboBox_Group.SelectedValue),
                CodeAct = (int)(comboBox_Activite.SelectedValue)
            };
            cs.Adherents.Add(Adh);
            cs.SaveChanges();
            //bs.EndEdit();
            MAJ_DGV();
                MessageBox.Show("Adhérent Bien Ajouter");
            //}
            //catch
            //{ MessageBox.Show("Ereurr"); }
        }

        private void button_Nouveau_Click_1(object sender, EventArgs e)
        {
            bs.AddNew();
            //Txtbx_NumA.Text = "";
            //Textbox_Nomad.Text = "";
            //Textbox_Prenom.Text = "";
            //Datepicker_DN.Text = "";
            //DTP_Date_Inscription.Text = "";
            //Cmbbx_sexe.Text = "";
            //Textbox_Adresse.Text = "";
            //Textbox_Ville.Text = "";
            //Textbox_Tel.Text = "";
            //comboBox_Group.Text = "";
            //comboBox_Activite.Text="";
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                var NumA = cs.Adherents.Find(int.Parse(Txtbx_NumA.Text));
                if (NumA != null)
                {
                    NumA.NomA = Textbox_Nomad.Text;
                    NumA.PrenomA = Textbox_Prenom.Text;
                    NumA.DateN = Datepicker_DN.Value;
                    NumA.DateI = DTP_Date_Inscription.Value;
                    NumA.Sexe = Cmbbx_sexe.Text;
                    NumA.Adresse = Textbox_Adresse.Text;
                    NumA.VilleA = Textbox_Ville.Text;
                    NumA.Tel = Textbox_Tel.Text;
                    NumA.Groupe = (int)(comboBox_Group.SelectedValue);
                    NumA.CodeAct = (int)(comboBox_Activite.SelectedValue);
                    cs.SaveChanges();
                    MAJ_DGV();
                    //bs.EndEdit();
                    MessageBox.Show("Bien Modifier");
                }
            }catch ( Exception ex )
            {                          
                    MessageBox.Show(ex.Message);
            }
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                bs.Position = bs.IndexOf(cs.Adherents.Find(int.Parse(Textbox_CodeRechAdhérent.Text)));
                //bs.Position = Program.ds.Tables["Adherent"].Rows.Find(int.Parse(Textbox_CodeRechAdhérent.Text))
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void button_first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {


            var SupprimerAdh = cs.Adherents.Find(int.Parse(Txtbx_NumA.Text));
            if (SupprimerAdh != null)
            {
                cs.Adherents.Remove(SupprimerAdh);
                cs.SaveChanges();
                bs.RemoveCurrent();
                MAJ_DGV();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void Cmbbx_Sexe_onItemSelected(object sender, EventArgs e)
        {

        }

        private void cmbx_Groupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try { 
            ////cmbx_Groupe.ValueMember = "CodeG";
            //    var cl = cs.Groupes.Find(cmbx_Groupe.Text);
            //    Textbox_Nom_Groupe.Text = cl.DescriptionG.ToString();
            //    //MessageBox.Show(cl.ToString());
            //}catch { }
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Textbox_Adresse_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected_1(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Nouveau_Click(object sender, EventArgs e)
        {


        }



        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbxActiviter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Activite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tbx_groupe.Text = Program.ds.Tables["Groupe"].Rows.Find(comboBox_Group.Text).ToString();
        }

        private void Cmbbx_sexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
