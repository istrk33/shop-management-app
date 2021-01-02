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
    public partial class SubscribersArea : Form
    {
        private List<Album> myBorrows;
        private int sec;
        bool inLoan;
        bool inMyAlbums;
        OleDbConnection dbConnection;
        public SubscribersArea()
        {
            InitializeComponent();
            myBorrows = new List<Album>();
            dbConnection = new OleDbConnection(Source.ChaineBD);
            dbConnection.Open();
            sec = 0;
            inLoan = false;
            inMyAlbums = false;
        }

        private void albumDispo_Click(object sender, EventArgs e)
        {
            viewBox.Items.Clear();
            string sql = "(select Code_Album, Titre_Album, Année_Album " +
                         "from Album) " +
                         "EXCEPT " +
                         "(select Album.Code_Album, Titre_Album, Année_Album " +
                         "from Album Inner join Emprunter on Album.Code_Album = Emprunter.Code_Album " +
                         "where Date_Retour IS NULL)";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Code_Album = Convert.ToInt32(reader.GetInt32(0));
                string Titre_Album = reader.GetString(1);
                int Année_Album = Convert.ToInt32(reader.GetInt32(0));
                viewBox.Items.Add(new Album(Code_Album, Titre_Album, Année_Album));
            }
            reader.Close();
            label.ForeColor = Color.Black;
            label.Text = "Choisissez un album à emprunter";
            inLoan = true;
        }


        private void viewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewBox.SelectedItem != null)
            {
                if (inLoan)
                {
                    Album albm = (Album)viewBox.SelectedItem;
                    var newLoan = new Emprunter(Form1.currentSubscriber.Code_Abonné, albm.Code_Album, DateTime.Now, null);
                    string sql = "select * from Emprunter " +
                                 "where Code_Abonné = " + newLoan.Code_Abonné + " AND Code_Album = " + newLoan.Code_Album;
                    OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        string delete = "delete from Emprunter where Code_Abonné=" + reader.GetInt32(0) + " and Code_Album=" + reader.GetInt32(1);
                        OleDbCommand cmdDele = new OleDbCommand(delete, dbConnection);
                        cmdDele.ExecuteNonQuery();
                    }
                    reader.Close();
                    string addBorrow = "insert into Emprunter(Code_Abonné,Code_Album,Date_Emprunt) values (" + Form1.currentSubscriber.Code_Abonné + "," + albm.Code_Album + "," + "GETDATE())";
                    OleDbCommand cmdAddBorrow = new OleDbCommand(addBorrow, dbConnection);
                    cmdAddBorrow.ExecuteNonQuery();
                    viewBox.Items.Clear();
                    viewBox.Items.Add("Album emprunté !");

                    albumDispo_Click(sender, e);
                    label.ForeColor = Color.DarkGreen;
                    label.Text = "Album emprunté !!!";
                    timer1.Start();
                    Cursor.Current = Cursors.Default;
                }
                else if (inMyAlbums)
                {
                    AlbumSettings a = new AlbumSettings((Album)viewBox.SelectedItem);
                    a.ShowDialog();
                    viewBox.Items.Clear();
                    button1_Click_1(sender, e);
                }
            }
            else
            {
                label.ForeColor = Color.DarkRed;
                label.Text = "Sélectionnez une oeuvre";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inLoan)
            {
                Cursor.Current = Cursors.WaitCursor;
                sec++;
                if (sec == 5)
                {
                    label.ForeColor = Color.Black;
                    label.Text = "Choisissez un album à emprunter";
                    timer1.Stop();
                    sec = 0;
                }
            }
        }

        private void fillBorrowsList()
        {
            myBorrows.Clear();
            string nbBorrow = "select Emprunter.Code_Album,Titre_Album,Année_Album from Emprunter " +
                    "inner join Album on Emprunter.Code_Album=Album.Code_Album " +
                    "where Code_Abonné=" + Form1.currentSubscriber.Code_Abonné + " and Date_Retour is null";
            OleDbCommand cmd = new OleDbCommand(nbBorrow, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int codeAlb = reader.GetInt32(0);
                    string titleAlb = reader.GetString(1);
                    int dt = reader.GetInt32(2);
                    myBorrows.Add(new Album(codeAlb, titleAlb, dt));
                }
                label.Text = "Vous avez emprunté " + (myBorrows.Count) + " albums.";
            }
            else
            {
                label.Text = "Vous n'avez aucun album emprunté.";
            }
            reader.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inMyAlbums = true;
            inLoan = false;
            label.Text = "";

            if (Form1.currentSubscriber != null)
            {
                viewBox.Items.Clear();
                label.Text = "";
                fillBorrowsList();
                foreach (Album a in myBorrows)
                {
                    viewBox.Items.Add(a);
                }
            }
            else
            {
                label.Text = "Erreur lors de votre connection en tant qu'abonné.";
            }
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 5)
            {
                label.ForeColor = Color.Black;
                label.Text = "Choisissez un album";
                timer1.Stop();
                sec = 0;
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous déconnecter de votre espace abonné ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void DelayAll_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous prolonger tous les emprunts d'un mois ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            fillBorrowsList();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                foreach (Album a in myBorrows)
                {
                    string sql = "UPDATE Emprunter " +
                             "SET Date_Emprunt = " + " DATEADD(month, 1, Emprunter.Date_Emprunt) " +
                             "WHERE Code_Abonné=" + Form1.currentSubscriber.Code_Abonné + " AND Code_Album=" + a.Code_Album;
                    OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                    cmd.ExecuteNonQuery();
                }
                label.ForeColor = Color.DarkGreen;
                label.Text = "Tous les emprunts ont été prolongé d'un mois.";
                timer2.Start();
            }
        }
    }
}
