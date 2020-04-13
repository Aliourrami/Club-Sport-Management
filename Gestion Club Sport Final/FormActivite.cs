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
    public partial class FormActivite : Form
    {
        public FormActivite()
        {
            InitializeComponent();
        }
        GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        BindingSource bs = new BindingSource();

        public void MAJ_DGV()
        {
            DataGrid_Adh.DataSource = bs;
            //DataGrid_Adh.DataSource= cs.Activites.ToList();
            bs.DataSource= cs.Activites.ToList();
        }

        private void FormActivite_Load(object sender, EventArgs e)
        {
            MAJ_DGV();
            cs.Activites.ToList();
            bs.DataSource = cs.Activites.Local;
            Textbox_CodeAct.DataBindings.Add(new Binding("text", bs, "CodeAct"));
            Textbox_LibelleAct.DataBindings.Add(new Binding("text", bs, "LibelleAct"));
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            Textbox_CodeAct.Text = "";
            Textbox_LibelleAct.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var act = new Activite
            {
                CodeAct = int.Parse(Textbox_CodeAct.Text),
                LibelleAct = Textbox_LibelleAct.Text
            };
            if (act != null)
            {
                cs.Activites.Add(act);
                cs.SaveChanges();
                MessageBox.Show("Bien Ajouter");
                MAJ_DGV();
            }
            else
                MessageBox.Show("Deja Ajouter (y)"); button_Ajouter.Text = "Nouveau";
            //cs.SaveChanges();
            //bs.EndEdit();

            //MessageBox.Show("Bien Ajouter");
            //MAJ_DGV();

        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            var Act = cs.Activites.Find(int.Parse(Textbox_CodeAct.Text));
            if(Act!=null)
            {
                Act.LibelleAct = Textbox_LibelleAct.Text;
                bs.EndEdit();
                cs.SaveChanges();
                MessageBox.Show("Bien Modifier");
                MAJ_DGV();
            }


        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            cs.SaveChanges();
            MAJ_DGV();
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            bs.Position= bs.IndexOf(cs.Activites.Find(int.Parse(Textbox_CodeRechActivite.Text)));
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
