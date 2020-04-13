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
    public partial class FormAbonner : Form
    {
        public FormAbonner()
        {
            InitializeComponent();
        }
        //Gestion_Club_Sport_FinalEntities1 cs = new Gestion_Club_Sport_FinalEntities1();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BindingSource bs = new BindingSource();
        public void DGV()
        {
            //DGV_Abonner.DataSource = Program.ds.Tables["Abonner"];
            DGV_Abonner.DataSource = Program.cs.Abonners.ToList();

        }

        private void FormAbonner_Load(object sender, EventArgs e)
        {
            DGV();
            //bs.DataSource=Program.ds.Tables["Abonner"];
            bs.DataSource = Program.cs.Abonners.Local;
            Textbox_CodeAbonner.DataBindings.Add("text", bs, "CodeAb");
            cmbx_CodeTAbonner.DataBindings.Add("SelectedValue", bs, "CodeTab");
            comboBoxDureeAbonner.DataBindings.Add("SelectedValue", bs, "DureeAb");
            Cmbbx_NumAdhérent.DataBindings.Add("SelectedValue", bs, "NumA");

            cmbx_CodeTAbonner.ValueMember = "CodeTab";
            //cmbx_CodeTAbonner.DisplayMember = "";
            cmbx_CodeTAbonner.DataSource = Program.cs.Type_abonnement.ToList();

            //comboBoxDureeAbonner.ValueMember = "CodeTab";
            ////cmbx_CodeTAbonner.DisplayMember = "";
            //comboBoxDureeAbonner.DataSource = cs.Type_abonnement.ToList();

            Cmbbx_NumAdhérent.ValueMember = "NumA";
            Cmbbx_NumAdhérent.DisplayMember = "NomA";
            Cmbbx_NumAdhérent.DataSource = Program.cs.Adherents.ToList();

        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            Program.cs.SaveChanges();
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            Program.cs.SaveChanges();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            Program.cs.SaveChanges();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
