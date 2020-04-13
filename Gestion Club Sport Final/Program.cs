using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Club_Sport_Final
{
    static class Program
    {
        public static GCS_FinalEntities1 cs = new GCS_FinalEntities1();
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8PDF6KH\SQLEXPRESS;
                          Initial Catalog=GCS_Final;
                          Integrated Security=True");
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter da_Adherent;
        public static SqlDataAdapter da_salle;
        public static SqlDataAdapter da_activite;
        public static SqlDataAdapter da_entraineur;
        public static SqlDataAdapter da_abonnement;
        public static SqlDataAdapter da_abonner;
        public static SqlDataAdapter da_groupe;
        public static SqlDataAdapter da_paiment;
        //public static SqlDataAdapter da_planifier;

        public static SqlDataAdapter da_loginAdh;
        public static SqlDataAdapter da_LoginEntr;
        public static SqlDataAdapter da_LoginAdmin;
        //public static SqlDataAdapter da_Login;

        //public static SqlDataAdapter da = new SqlDataAdapter("select * from Login_", con);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
            //Application.Run(new FormAbonnement());
            //Application.Run(new FormImprimers());
        }
        public static void chargerDS()
        {
            da_Adherent = new SqlDataAdapter("select * from Adherent", con);
            da_Adherent.Fill(ds, "Adherent");

            da_entraineur = new SqlDataAdapter("select * from Entraineur", con);
            da_entraineur.Fill(ds, "Entraineur");

            da_salle = new SqlDataAdapter("select * from salle", con);
            da_salle.Fill(ds, "salle");

            da_activite = new SqlDataAdapter("select * from activite", con);
            da_activite.Fill(ds, "activite");

            da_groupe = new SqlDataAdapter("select * from groupe", con);
            da_groupe.Fill(ds, "groupe");

            //da_planifier = new SqlDataAdapter("select * from planifier", con);
            //da_planifier.Fill(ds, "planifier");

            da_abonnement = new SqlDataAdapter("select * from Type_abonnement", con);
            da_abonnement.Fill(ds, "Type_abonnement");


            da_abonner = new SqlDataAdapter("select * from abonner", con);
            da_abonner.Fill(ds, "abonner");

            da_paiment = new SqlDataAdapter("select * from paiment", con);
            da_paiment.Fill(ds, "paiment");


            //
            ds.Tables["Entraineur"].PrimaryKey = new DataColumn[]
           { ds.Tables["Entraineur"].Columns[0] };
            //primarykey
            ds.Tables["Adherent"].PrimaryKey = new DataColumn[]
            { ds.Tables["Adherent"].Columns[0] };

            ds.Tables["groupe"].PrimaryKey = new DataColumn[]
            { ds.Tables["groupe"].Columns[0] };

            ds.Tables["Activite"].PrimaryKey = new DataColumn[]
            { ds.Tables["Activite"].Columns[0] };

            ds.Tables["Type_abonnement"].PrimaryKey = new DataColumn[]
           { ds.Tables["Type_abonnement"].Columns[0] };

            ds.Tables["abonner"].PrimaryKey = new DataColumn[]
           { ds.Tables["abonner"].Columns[0] };
            //Clé Etranger
            //DataRelation R_Adh = new DataRelation("R_Adh",
            //                                              ds.Tables["Adherent"].Columns[0],
            //                                              ds.Tables["groupe"].Columns[0]);
            //ds.Relations.Add(R_Adh);

            //DataRelation R_Adh2 = new DataRelation("R_Adh2",
            //                                  ds.Tables["Adherent"].Columns[0],
            //                                  ds.Tables["Activite"].Columns[0]);
            //ds.Relations.Add(R_Adh2);
        }
        // Mode Connecter
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader dr;

        //ajouter,supprimer,Modifier
        public static void Execute_MAJ(string req)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        //select, recherche(affichage)
        public static DataTable execute_select(string req)
        {
            //try
            //{
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}
            //cmd.CommandText = req;
            //dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dr.Close();


            SqlDataAdapter da = new SqlDataAdapter(req, Program.con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            return dt;
            //Close();
            //}
            //catch { throw; }
            //finally {  }

        }


        public static void CharGerDSS()
        {
            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "Adherent");

            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "groupe");

            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "Activite");

            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "entraineur");

            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "salle");

            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "planifier");



            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "abonner");

            da_abonnement.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da_abonnement.Fill(ds, "paiment");

        }
    }
}
