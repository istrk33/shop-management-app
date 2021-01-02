using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleDBApp
{
    public partial class AlbumSettings : Form
    {
        Album albm;
        Emprunter empr;
        OleDbConnection dbConnection;
        public AlbumSettings(Album a)
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(Source.ChaineBD);
            dbConnection.Open();

            albm = a;
            Title.Text = albm.Titre_Album; 
            updateFutureReturnDate();
        }

        private void delay_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous prolonger l'emprunt d'un mois ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "UPDATE Emprunter " +
                             "SET Date_Emprunt = " + " DATEADD(month, 1, Emprunter.Date_Emprunt) " +
                             "WHERE Code_Abonné="+empr.Code_Abonné+" AND Code_Album="+empr.Code_Album;
                OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                cmd.ExecuteNonQuery();
                updateFutureReturnDate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous rendre l'album ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "UPDATE Emprunter " +
                            "SET Date_Retour = " + "GETDATE() " +
                            "WHERE Code_Abonné=" + empr.Code_Abonné + " AND Code_Album=" + empr.Code_Album;
                OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }

        private void updateFutureReturnDate()
        {
            string sql = "select Date_Emprunt from Emprunter " +
                        "where Code_Album = " + albm.Code_Album + " AND Code_Abonné = " + Form1.currentSubscriber.Code_Abonné;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Abonné> activeSub = new List<Abonné>();
            reader.Read();
            DateTime Date_Emprunt = reader.GetDateTime(0);
            empr = new Emprunter(Form1.currentSubscriber.Code_Abonné, albm.Code_Album, Date_Emprunt, null);
            label1.Text = "À Rendre le : " + empr.Date_Emprunt.AddMonths(1).ToShortDateString();
        }
    }
}
