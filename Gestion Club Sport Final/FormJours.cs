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
    public partial class FormJours : Form
    {
        public FormJours()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();


        public void Actualiser_dgv()
        {
            string req = "select * from jours";
            DataGrid_Jours.DataSource = Program.execute_select(req);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormJours_Load(object sender, EventArgs e)
        {
            Actualiser_dgv();
            bs.DataSource = Program.execute_select("select * from jours");
            Textbox_NumJ.DataBindings.Add("text", bs, "NumJ");
            Txtbx_NomJ.DataBindings.Add("text", bs, "NomJ");
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            Textbox_NumJ.Text = "";
            Txtbx_NomJ.Text = "";
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format("insert into jours values ({0},'{1}')", Textbox_NumJ.Text, Txtbx_NomJ.Text);
                Program.Execute_MAJ(req);
                MessageBox.Show("bien ajoute");
                Actualiser_dgv();
            }
            catch { }
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            string req = string.Format(@"update jours set NomJ='{0}' where NumJ ={1}", Txtbx_NomJ.Text, Textbox_NumJ.Text);
            Program.Execute_MAJ(req);
            Actualiser_dgv();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string NumJ = Textbox_NumJ.Text;
                string req = "delete jours where NumJ=" + NumJ;
                Program.Execute_MAJ(req);
                Actualiser_dgv();
            }
            catch (Exception)
            {
                MessageBox.Show("bien supprime");
            }
        }

        private void button_Rech_Jour_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string req = string.Format(@"string * from jours where NumJ= {0}", Textbox_NumJ.Text);
            dt = Program.execute_select(req);
            Textbox_NumJ.Text = dt.Rows[0][0].ToString();
            Txtbx_NomJ.Text = dt.Rows[0][1].ToString();
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

        private void DataGrid_Jours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
