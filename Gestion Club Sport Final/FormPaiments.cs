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
    public partial class FormPaiments : Form
    {
        public FormPaiments()
        {
            InitializeComponent();
        }
        GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        BindingSource bs = new BindingSource();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DGV()
        {
            DGV_Paiment.DataSource = cs.paiments.ToList();
        }

        private void FormPaiments_Load(object sender, EventArgs e)
        {
            //cs.Abonners.ToList();
            DGV();
            //bs.DataSource = Program.ds.Tables["paiment"];
            bs.DataSource = cs.paiments.Local;
            //cmbx_CodeAbonner.DataBindings.Add("text", bs, "CodeAb");
            Cmbbx_NumAdhérent.DataBindings.Add("text", bs, "NumA");
            comboBoxModePaiment.DataBindings.Add("text", bs, "ModeP");
            comboBoxMontant.DataBindings.Add("text", bs, "Montant");

            ////
            //cmbx_CodeAbonner.ValueMember = "CodeAb";
            //cmbx_CodeAbonner.DataSource = Program.ds.Tables["Abonner"];
            //
            Cmbbx_NumAdhérent.ValueMember = "NumA";
            //Cmbbx_NumAdhérent.DataSource = Program.ds.Tables["Adherent"];          
            Cmbbx_NumAdhérent.DataSource = cs.Adherents.ToList();

            //bs.PositionChanged += PositionChangedHandler;
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            var abo = Program.cs.Abonners.Find(int.Parse(cmbx_CodeAbonner.Text));
            var montant = abo.Type_abonnement.TarifTAb * abo.Type_abonnement.DureeTAb;
            comboBoxMontant.Text = montant.ToString();
            var pai = new paiment
            {
                CodeAb = (int)cmbx_CodeAbonner.SelectedValue,
                NumA = (int)Cmbbx_NumAdhérent.SelectedValue,
                Montant = montant,
                ModeP = comboBoxModePaiment.Text
            };
            if(pai!=null)
            {
                cs.paiments.Add(pai);
                bs.EndEdit();
                cs.SaveChanges();
                MessageBox.Show("Bien Ajouter");
            }
            else
                MessageBox.Show("Erreur");
        }

        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            DGV();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void PositionChangedHandler(object sender, EventArgs e)
        {
            paiment curr = bs.Current as paiment;
            cmbx_CodeAbonner.DataSource = curr.Adherent.Abonners.Select(abo => abo.codeAb).ToList();
            if (cmbx_CodeAbonner.DataSource == null)
                cmbx_CodeAbonner.Text = "";
            //cmbx_CodeAbonner.DataSource = Program.cs.Abonners.Where(abo => abo.Adherent == curr.Adherent.)
            //                                                     .Select(abo => abo.codeAb)
            //                                                     .ToList();
        }

        private void Cmbbx_NumAdhérent_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Cmbbx_NumAdhérent_TextChanged(object sender, EventArgs e)
        {
            int codeA = int.Parse(Cmbbx_NumAdhérent.Text);
            Adherent adh  = cs.Adherents.Where(a => a.NumA == codeA).First();
            var abos = adh.Abonners.Select(abo => abo.codeAb).ToList();
            cmbx_CodeAbonner.DataSource = abos;
            if (abos.Count == 0)
                cmbx_CodeAbonner.Text = "";

            //cmbx_CodeAbonner.ValueMember = "CodeAb";
            //cmbx_CodeAbonner.DataSource = cs.Abonners.ToList();
            ////adh.paiements.Select(p => p.Montant).ToList();
            ////adh.paiements.Select(p => p.ModePaiement).ToList();
            ////Adherent ad = bs.Current as Adherent;
            ////cmbx_CodeAbonner.Text= ad.Abonners.ToString();
            //// 
            //// Recherche Avec Combobox adherent pour visiter abonner pour chaque adherent
            //int numA = int.Parse(Cmbbx_NumAdhérent.Text);
            //var adh = cs.Adherents.Find(numA);
            //cmbx_CodeAbonner.DataSource = adh.paiments.Select(p => p.Abonner).ToList();
            //comboBoxMontant.DataSource= adh.paiments.Select(p => p.Montant).ToList();
            //comboBoxModePaiment.DataSource= adh.paiments.Select(p => p.ModeP).ToList();

            //Textbox_ModePaiment.Text = adh.paiments.ToString();
        }

        private void comboBoxMontant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
