using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Club_Sport_Final
{
    public partial class FormEntraineur : Form
    {
        public FormEntraineur()
        {
            InitializeComponent();
        }
        //Gestion_Club_Sport_FinalEntities1 cs = new Gestion_Club_Sport_FinalEntities1();
        BindingSource bs = new BindingSource();

        private void MAJ_DGV()
        {
            //DataGrid_Entr.DataSource = Program.ds.Tables["Entraineur"];
            DataGrid_Entr.DataSource = Program.cs.Entraineurs.ToList();
        }

        private void FormEntraineur_Load(object sender, EventArgs e)
        {

            //Program.chargerDS();
            MAJ_DGV();
            bs.DataSource = Program.ds.Tables["Entraineur"];
            //bs.DataSource = cs.Entraineurs.Local;
            Txtbx_NumE.DataBindings.Add("text", bs, "NumE");
            Textbox_NomE.DataBindings.Add("text", bs, "NomE");
            Textbox_PrenomE.DataBindings.Add("text", bs, "PrenomE");
            Textbox_LibelleE.DataBindings.Add("text", bs, "LibelleE");
            Datepicker_DNE.DataBindings.Add("text", bs, "DateN");
            Cmbbx_SexeE.DataBindings.Add("text", bs, "Sexe");

            DTP_DateIE.Value = DateTime.Today;
            Cmbbx_SexeE.Items.Add("Masculin");
            Cmbbx_SexeE.Items.Add("Féminin");
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button_Ajouter_Click_1(object sender, EventArgs e)
        {
            var entr = new Entraineur
            {
                NumE = int.Parse(Txtbx_NumE.Text),
                NomE = Textbox_NomE.Text,
                PrenomE = Textbox_PrenomE.Text,
                LibelleE = Textbox_LibelleE.Text,
                DateN = Datepicker_DNE.Value,
                Sexe = Cmbbx_SexeE.Text
            };
            Program.cs.Entraineurs.Add(entr);
            Program.cs.SaveChanges();
            //Save();
            MAJ_DGV();
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            var Entr = Program.cs.Entraineurs.Find(int.Parse(Txtbx_NumE.Text));
            if(Entr!=null)
            {
                Entr.NumE = int.Parse(Txtbx_NumE.Text);
                Entr.NomE = Textbox_NomE.Text;
                Entr.PrenomE = Textbox_PrenomE.Text;
                Entr.LibelleE = Textbox_LibelleE.Text;
                Entr.DateN = Datepicker_DNE.Value;
                Entr.Sexe = Cmbbx_SexeE.Text;
                Program.cs.SaveChanges();
                MAJ_DGV();
            }
            //bs.EndEdit();
            
            //Save();
            
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {

            var SupprimereEnte = Program.cs.Entraineurs.Find(int.Parse(Txtbx_NumE.Text));
            if (SupprimereEnte != null)
            {
                Program.cs.Entraineurs.Remove(SupprimereEnte);
                Program.cs.SaveChanges();
                bs.RemoveCurrent();
                MAJ_DGV();
            }
  
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {

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

        public void Save()
        {
            SqlCommandBuilder sc = new SqlCommandBuilder(Program.da_entraineur);
            Program.da_entraineur.Update(Program.ds.Tables["Entraineur"]);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DTP_Date_Inscription_onValueChanged(object sender, EventArgs e)
        {

        }

        private void Datepicker_DN_onValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmbbx_Sexe_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_Username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_PasswordC_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_Password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_Prenom_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_Nom_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void labeldi_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}
