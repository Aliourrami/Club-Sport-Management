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
    public partial class FormCréneau : Form
    {
        public FormCréneau()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        private void Actualiser_dgv()
        {
            DataGrid_Créneau.DataSource = Program.execute_select("select * from Créneau");
        }
        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void Creneau_Load(object sender, EventArgs e)
        {
            Actualiser_dgv();
            bs.DataSource = Program.execute_select("select * from Créneau");
            Textbox_CodeCréneau.DataBindings.Add("text", bs, "CodeC");
            dtp_HeureD_Créneau.DataBindings.Add("value", bs, "HeureD");
            dtp_HeureFin_Créneau.DataBindings.Add("value", bs, "HeureF");
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            string req = string.Format(@"insert  into Créneau values ( {0} , '{1}' , '{2}')", Textbox_CodeCréneau.Text,
                                        dtp_HeureD_Créneau.Value.Hour, dtp_HeureFin_Créneau.Value.Hour);
            Program.Execute_MAJ(req);
            Actualiser_dgv();
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            string req = string.Format(@"update Créneau 
                                            set HeureD = '{0}' ,
                                            HeureF = '{1}'",
                                            dtp_HeureD_Créneau.Value,
                                            dtp_HeureFin_Créneau.Value
                                            );

            Program.Execute_MAJ(req);
            Actualiser_dgv();

        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            string req = string.Format(@"delete Créneau where CodeC = {0}", Textbox_CodeCréneau.Text);

            Program.Execute_MAJ(req);
            Actualiser_dgv();
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
        private void button_first_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
