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
    public partial class FormAbonnement : Form
    {
        public FormAbonnement()
        {
            InitializeComponent();
        }
        //Gestion_Club_Sport_FinalEntities1 cs = new Gestion_Club_Sport_FinalEntities1();
        BindingSource bs = new BindingSource();

        public void DGV()
        {
            DataGrid_TAbon.DataSource = bs;
            bs.DataSource = Program.cs.Type_abonnement.ToList();
        }

        private void FormAbonnement_Load(object sender, EventArgs e)
        {
            //Program.chargerDS();
            DGV();
            //bs.DataSource = Program.cs.Type_abonnement.Local;
            bs.DataSource = Program.ds.Tables["Type_abonnement"];
            Txtbx_CodeAbonnement.DataBindings.Add("text", bs, "CodeTAb");
            Textbox_DesA.DataBindings.Add("text", bs, "DescTAb");
            Textbox_TarifAb.DataBindings.Add("text", bs, "TarifTAb");
            Textbox_DureeTab.DataBindings.Add("text", bs, "DureeTAb");
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            var TAb = new Type_abonnement
            {
                CodeTAb = int.Parse(Txtbx_CodeAbonnement.Text),
                DescTAb = Textbox_DesA.Text,
                TarifTAb = decimal.Parse(Textbox_TarifAb.Text),
                DureeTAb = int.Parse(Textbox_DureeTab.Text),
            };
            Program.cs.Type_abonnement.Add(TAb);
            //bs.EndEdit();
            Program.cs.SaveChanges();

            DGV();

        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            var CodeTA = Program.cs.Type_abonnement.Find(int.Parse(Txtbx_CodeAbonnement.Text));
            if(CodeTA!=null)
            {
                CodeTA.DescTAb = Textbox_DesA.Text;
                CodeTA.TarifTAb = decimal.Parse(Textbox_TarifAb.Text);
                CodeTA.DureeTAb = int.Parse(Textbox_DureeTab.Text);

            }
            //bs.EndEdit();
            DGV();
            Program.cs.SaveChanges();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            var SupprimerTAb = Program.cs.Type_abonnement.Find(int.Parse(Txtbx_CodeAbonnement.Text));
            if (SupprimerTAb != null)
            {
                Program.cs.Type_abonnement.Remove(SupprimerTAb);
                Program.cs.SaveChanges();
                bs.RemoveCurrent();
                DGV();
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

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
