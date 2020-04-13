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
    public partial class FormSalle : Form
    {
        public FormSalle()
        {
            InitializeComponent();
        }

        GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        BindingSource bs = new BindingSource();
        private void Txtbx_NomSalle_OnValueChanged(object sender, EventArgs e)
        {

        }

        public void DGV()
        {
            DataGrid_salle.DataSource = cs.Salles.ToList();
        }

        private void FormSalle_Load(object sender, EventArgs e)
        {
            DGV();
            cs.Salles.ToList();
            bs.DataSource = cs.Salles.Local;
            Textbox_CodeSalle.DataBindings.Add(new Binding("text", bs, "NumS", true));
            Txtbx_NomSalle.DataBindings.Add(new Binding("text", bs, "NomS", true));
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            bs.Position = bs.IndexOf(cs.Salles.Find(int.Parse(Textbox_CodeRechSalle.Text)));
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            if (button_Nouveau.Text== "    Nouveau")
            {
                //bs.AddNew();
                Textbox_CodeSalle.Text = "";
                Txtbx_NomSalle.Text = "";
                button_Nouveau.Text = "    Ajouter";
            }
            else if(button_Nouveau.Text == "    Ajouter")
            {
                var salle = new Salle
                {
                    NumS = int.Parse(Textbox_CodeSalle.Text),
                    NomS = Txtbx_NomSalle.Text,

                };
                cs.Salles.Add(salle);
                bs.EndEdit();
                cs.SaveChanges();
                DGV();
                MessageBox.Show("Bien Ajouter");
                button_Nouveau.Text = "    Nouveau";

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            cs.SaveChanges();
            DGV();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            cs.SaveChanges();
            DGV();
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

        private void Textbox_CodeSalle_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
