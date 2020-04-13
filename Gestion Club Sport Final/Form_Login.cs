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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        //club_sportEntities cse = new club_sportEntities();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            // Requete For LoginEntr
            string reqEnt = string.Format(@"select * from LoginEntr where Username='{0}' and Password = '{1}'", Textbox_user.Text.Trim(), Textbox_pass.Text.Trim());
            Program.da_LoginEntr = new SqlDataAdapter(reqEnt, Program.con);
            DataTable dtEnt = new DataTable();
            Program.da_LoginEntr.Fill(dtEnt);
            //

            // Requete For LoginAdh
            string req = string.Format(@"select * from LoginAdh where Username='{0}' and Password = '{1}'", Textbox_user.Text.Trim(), Textbox_pass.Text.Trim());
            Program.da_loginAdh = new SqlDataAdapter(req, Program.con);
            DataTable dtAdh = new DataTable();
            Program.da_loginAdh.Fill(dtAdh);

            // Requete For LoginAdmin
            string reqAdmin = string.Format(@"select * from LoginAdmin where Username='{0}' and Password = '{1}'", Textbox_user.Text.Trim(), Textbox_pass.Text.Trim());
            Program.da_LoginAdmin = new SqlDataAdapter(reqAdmin, Program.con);
            DataTable dtAdmin = new DataTable();
            Program.da_LoginAdmin.Fill(dtAdmin);

            // Login For LoginAdmin
            if (dtAdmin.Rows.Count == 1)
            {
                Dashboard fh = new Dashboard();
                this.Visible = false;
                fh.Show();
            }

            // Login For Form Adhérent
            else if (dtAdh.Rows.Count == 1)
            {
                string UserT = dtAdh.Rows[0][3].ToString().Trim();
                if (dtAdh.Rows[0][3].ToString().Trim() == @"adhérent")
                {
                    FormAdherent fh = new FormAdherent();
                    this.Visible = false;
                    fh.Show();
                }
            }
            // Login For Form Entraineur
            else if (dtEnt.Rows.Count == 1)
            {
                string UserTEnt = dtEnt.Rows[0][3].ToString().Trim();
                if (UserTEnt == @"Entraineur")
                {
                    FormEntraineur fh = new FormEntraineur();
                    this.Visible = false;
                    fh.Show();
                }
            }
            // finally Erreur
            else
                MessageBox.Show("Check Your Username And Password");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {

        }

        private void Textbox_pass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Tbx_pass_Enter(object sender, DragEventArgs e)
        {

        }

        private void Tbx_pass_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_username_Enter(object sender, DragEventArgs e)
        {

        }

        private void txtbx_username_Leave(object sender, EventArgs e)
        {

        }

        private void button_fermer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
