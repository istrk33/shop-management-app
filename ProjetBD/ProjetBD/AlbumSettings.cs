using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBD
{
    public partial class AlbumSetting : Form
    {
        Album albm;
        MusicSQLEntities music;
        Emprunter empr;
        public AlbumSetting(Album a)
        {
            InitializeComponent();
            music = new MusicSQLEntities();
            albm = a;
            Title.Text = albm.Titre_Album;
            var emprunt = (from em in music.Emprunter
                           where em.Code_Album == albm.Code_Album && em.Code_Abonné == Form1.currentSubscriber.Code_Abonné
                           select em);
            empr = emprunt.First();
            updateFutureReturnDate();
        }

        private void delay_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous prolonger l'emprunt d'un mois ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                empr.Date_Emprunt = empr.Date_Emprunt.Value.AddMonths(1);
                music.SaveChanges();
                updateFutureReturnDate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox("Voulez-vous vous rendre l'album ?", "Annuler", "Confirmer");
            DialogResult dbrs = db.ShowDialog();
            if (dbrs == System.Windows.Forms.DialogResult.OK)
            {
                empr.Date_Retour = DateTime.Now;
                music.SaveChanges();
                this.Close();
            }
        }

        private void updateFutureReturnDate()
        {
            label1.Text = "À Rendre le : " + empr.Date_Emprunt.Value.AddMonths(1).ToShortDateString();
        }
    }
}
