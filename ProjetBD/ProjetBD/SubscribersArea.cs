using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace ProjetBD
{
    public partial class SubscribersArea : Form
    {
        MusicSQLEntities music;
        private int sec;
        bool inLoan;
        bool inMyAlbums;
        public SubscribersArea()
        {
            InitializeComponent();
            music = new MusicSQLEntities();
            sec = 0;
            inLoan = false;
            inMyAlbums = false;
        }

        private void albumDispo_Click(object sender, EventArgs e)
        {
            viewBox.Items.Clear();
            var albumEmprunt = (from a in music.Album
                                join em in music.Emprunter on a.Code_Album equals em.Code_Album
                                where !em.Date_Retour.HasValue
                                select a).ToList();
            var album = (from a in music.Album
                         select a).ToList();
            // on crée les objets locaux et on remplit la listbox
            foreach (Album a in album)
            {
                if (!albumEmprunt.Contains(a))
                    viewBox.Items.Add(a);
            }
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
                    var newLoan = new Emprunter { Code_Abonné = Form1.currentSubscriber.Code_Abonné, Code_Album = albm.Code_Album, Date_Emprunt = DateTime.Now };
                    var existingLoan = (from em in music.Emprunter
                                        where em.Code_Abonné == newLoan.Code_Abonné
                                        where em.Code_Album == newLoan.Code_Album
                                        select em).ToList();
                    if (existingLoan.Count > 0)
                    {
                        music.Emprunter.Remove(existingLoan.First());
                        music.SaveChanges();
                    }
                    music.Emprunter.Add(newLoan);
                    music.SaveChanges();
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
                    AlbumSetting a = new AlbumSetting((Album)viewBox.SelectedItem);
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            inMyAlbums = true;
            inLoan = false;
            label.Text = "";

            if (Form1.currentSubscriber != null)
            {
                viewBox.Items.Clear();
                label.Text = "";

                var nbBorrow = (from em in music.Emprunter
                                where em.Code_Abonné == Form1.currentSubscriber.Code_Abonné
                                where !em.Date_Retour.HasValue
                                select em);
                if (nbBorrow.Count() > 0)
                {
                    foreach (Emprunter bo in nbBorrow)
                    {
                        viewBox.Items.Add(bo.Album);
                    }
                    label.Text = "Vous avez emprunté " + (nbBorrow.Count()) + " albums.";
                }
                else
                {
                    label.Text = "Vous n'avez aucun album emprunté.";
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
            var currentBorrow = (from em in music.Emprunter
                                 where em.Code_Abonné == Form1.currentSubscriber.Code_Abonné
                                 where !em.Date_Retour.HasValue
                                 select em).ToList().Distinct();
            foreach(Emprunter em in currentBorrow)
            {
                em.Date_Emprunt = em.Date_Emprunt.Value.AddMonths(1);
                music.SaveChanges();
            }
            label.ForeColor = Color.DarkGreen;
            label.Text = "Tous vos emprunts ont été prolongés d'un mois";
            timer2.Start();
        }
    }
}
