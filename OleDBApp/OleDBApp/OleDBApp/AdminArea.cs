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
    public partial class AdminArea : Form
    {
        OleDbConnection dbConnection;
        public AdminArea()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(Source.ChaineBD);
            dbConnection.Open();
            listBox1.HorizontalScrollbar = true;
            top10();
            yearInactivity();
            tenDaysLate();
            AlbumBorrowed();
            WindowState = FormWindowState.Maximized;
        }

        private void top10()
        {
            string top10 = "select Titre_Album,Count(*) as nb from Emprunter inner join Album on Emprunter.Code_Album = Album.Code_Album where YEAR(Date_Emprunt) = YEAR(GETDATE()) group by Titre_Album,Emprunter.Code_Album order by nb desc";
            OleDbCommand cmd = new OleDbCommand(top10, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                if (i < 11)
                {
                    string titre = reader.GetString(0);
                    int nb = Convert.ToInt32(reader.GetInt32(1));
                    String s = "";
                    if (nb > 1)
                        s = "s";
                    String a = i + ": " + nb + " emprunt" + s + " - " + titre;
                    listBox1.Items.Add(a);
                    i++;
                }
                else
                {
                    break;
                }
            }
            reader.Close();
        }

        private void yearInactivity()
        {
            string sql = "(Select Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné, Login, Password, Code_Pays " +
                "from Abonné Inner join Emprunter on Emprunter.Code_Abonné = Abonné.Code_Abonné) " +
                "EXCEPT " +
                "(select Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné, Login, Password, Code_Pays from Abonné " +
                "Inner join Emprunter on Emprunter.Code_Abonné = Abonné.Code_Abonné " +
                "where DATEADD(year, 1, Emprunter.Date_Emprunt) >= GETDATE()) ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Abonné> activeSub = new List<Abonné>();
            while (reader.Read())
            {
                int Code_Abonné = Convert.ToInt32(reader.GetInt32(0));
                string Nom_Abonné = reader.GetString(1);
                string Prenom_Abonné = reader.GetString(2);
                string Login = reader.GetString(3);
                string Password = reader.GetString(4);
                int Code_Pays = Convert.ToInt32(reader.GetInt32(0));
                listBox4.Items.Add(new Abonné(Code_Abonné, Nom_Abonné, Prenom_Abonné, Login, Password, Code_Pays));
            }
            reader.Close();
        }

        private void tenDaysLate()
        {
            string sql = "Select Abonné.Code_Abonné, Nom_Abonné, Prénom_Abonné, Login, Password, Code_Pays " +
                         "From Abonné Inner join Emprunter on Emprunter.Code_Abonné = Abonné.Code_Abonné " +
                         "where DATEADD(MONTH, 1, Emprunter.Date_Emprunt) <= GETDATE() AND Emprunter.Date_Retour IS NULL ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Abonné> activeSub = new List<Abonné>();
            while (reader.Read())
            {
                int Code_Abonné = Convert.ToInt32(reader.GetInt32(0));
                string Nom_Abonné = reader.GetString(1);
                string Prenom_Abonné = reader.GetString(2);
                string Login = reader.GetString(3);
                string Password = reader.GetString(4);
                int Code_Pays = Convert.ToInt32(reader.GetInt32(0));
                listBox2.Items.Add(new Abonné(Code_Abonné, Nom_Abonné, Prenom_Abonné, Login, Password, Code_Pays));
            }
            reader.Close();
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous déconnecter de l'espace admin ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void deleteSubs()
        {
            string delete = "delete from Abonné where Code_Abonné=" + ((Abonné)listBox4.SelectedItem).Code_Abonné;
            OleDbCommand cmdDele = new OleDbCommand(delete, dbConnection);
            cmdDele.ExecuteNonQuery();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            yearInactivity();
            tenDaysLate();
            AlbumBorrowed();
            top10();
        }

        private void deleteBorrows()
        {
            string sql = "delete from Emprunter where Code_Abonné=" + ((Abonné)listBox4.SelectedItem).Code_Abonné;
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
        }

        private void DeleteSub_Click_1(object sender, EventArgs e)
        {
            if ((Abonné)listBox4.SelectedItem!=null) {
                string sql = "select * from Emprunter " +
                    "where Code_Abonné=" + ((Abonné)listBox4.SelectedItem).Code_Abonné + " and Date_Retour is null";
                OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    DialogBox db = new DialogBox("Voulez-vous supprimer cet abonné qui a encore des emprunts en cours ?", "Annuler", "Confirmer");
                    DialogResult dbrs = db.ShowDialog();
                    if (dbrs == System.Windows.Forms.DialogResult.OK)
                    {
                        deleteBorrows();
                        deleteSubs();
                    }
                }
                else
                {
                    deleteBorrows();
                    deleteSubs();
                }
                reader.Close();
            }
        }

        private void AlbumBorrowed()
        {
            string sql = "SELECT Titre_Album, Prénom_Abonné, Nom_Abonné from Album inner join Emprunter on Album.Code_Album = Emprunter.Code_Album inner join Abonné on Emprunter.Code_Abonné = Abonné.Code_Abonné where Date_Retour IS NULL";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox3.Items.Add(reader.GetString(1).Trim()+" "+ reader.GetString(2).Trim()+" emprunte : "+reader.GetString(0));
            }
            reader.Close();
        }
    }
}
