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
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
        }
        GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        BindingSource bs = new BindingSource();

        public void DGV()
        {
            DGV_EntraineurG.DataSource = cs.Groupes.ToList();
        }

        private void FormGroupe_Load(object sender, EventArgs e)
        {
            //Program.chargerDS();
            DGV();
            bs.DataSource = Program.ds.Tables["Groupe"];
            Textbox_CodeG.DataBindings.Add("text", bs, "CodeG");
            cmbx_ActiviteG.DataBindings.Add("SelectedValue", bs, "Activite");
            Txtbx_DesG.DataBindings.Add("text", bs, "DescriptionG");
            Cmbbx_EntrG.DataBindings.Add("SelectedValue", bs, "Entraineur");
            cmbx_salleG.DataBindings.Add("SelectedValue", bs, "Salle");

            ////
            cmbx_ActiviteG.ValueMember = "CodeAct";
            cmbx_ActiviteG.DisplayMember = "LibelleAct";
            cmbx_ActiviteG.DataSource = Program.ds.Tables["Activite"];
            //
            Cmbbx_EntrG.ValueMember = "NumE";
            Cmbbx_EntrG.DisplayMember = "LibelleE";
            Cmbbx_EntrG.DataSource = Program.ds.Tables["Entraineur"];

            ////
            cmbx_salleG.ValueMember = "NumS";
            cmbx_salleG.DisplayMember = "NomS";
            cmbx_salleG.DataSource = Program.ds.Tables["Salle"];
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            //Textbox_CodeG.Text = "";
            ////cmbx_Activite.selectedValue = 0;
            //Txtbx_DesG.Text = "";

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            var group = new Groupe
            {
                CodeG = int.Parse(Textbox_CodeG.Text),
                Activite = (int)cmbx_ActiviteG.SelectedValue,
                DescriptionG = Txtbx_DesG.Text,
                Entraineur = (int)Cmbbx_EntrG.SelectedValue,
                Salle = (int)cmbx_salleG.SelectedValue,
            };
            if(group!=null)
            {
                cs.Groupes.Add(group);
                //bs.EndEdit();
                cs.SaveChanges();
                DGV();
            }
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {


            var code = cs.Groupes.Find(int.Parse(Textbox_CodeG.Text));
            if(code != null)
            {
                code.Activite = (int)cmbx_ActiviteG.SelectedValue;
                code.DescriptionG = Txtbx_DesG.Text;
                code.Entraineur = (int)Cmbbx_EntrG.SelectedValue;
                code.Salle = (int)cmbx_salleG.SelectedValue;
                cs.SaveChanges();
                //bs.EndEdit();
                MessageBox.Show("Bien Modifier");
            }
            else
            {
                MessageBox.Show("Client inexistant");
            }
           
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            
            bs.RemoveCurrent();
            cs.SaveChanges();
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            bs.Position = bs.IndexOf(cs.Groupes.Find(int.Parse(Textbox_CodeRechActivite.Text)));
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

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbx_ActiviteG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
