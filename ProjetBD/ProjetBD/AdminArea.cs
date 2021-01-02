using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBD
{
    public partial class AdminArea : Form
    {
        MusicSQLEntities music;
        public AdminArea()
        {
            InitializeComponent();
            listBox1.HorizontalScrollbar = true;
            music = new MusicSQLEntities();
            top10();
            yearInactivity();
            tenDaysLate();
            AlbumBorrowed();
            WindowState = FormWindowState.Maximized;
        }

        private void top10()
        {
            var top10 = (from t in (from e in music.Emprunter
                                    join a in music.Album
                                    on e.Code_Album equals a.Code_Album
                                    where e.Date_Emprunt.Value.Year == DateTime.Now.Year
                                    select new { a.Titre_Album, e.Code_Album } into x
                                    group x by new { x.Titre_Album } into g
                                    select new
                                    {
                                        Album = g.Key.Titre_Album,
                                        Count = g.Select(x => x.Code_Album).Count()
                                    })
                         orderby t.Count descending
                         select new
                         {
                             Album = t.Album,
                             Count = t.Count
                         }).Take(10);
            int i = 1;
            foreach (var t in top10)
            {
                String s = "";
                if (t.Count > 1)
                    s = "s";
                String a = i + ": " + t.Count + " emprunt" + s + " - " + t.Album;
                listBox1.Items.Add(a);
                i++;
            }
        }

        private void yearInactivity()
        {
            var activeSub = (from a in music.Abonné
                             join em in music.Emprunter on a.Code_Abonné equals em.Code_Abonné
                             where DbFunctions.AddYears(em.Date_Emprunt.Value, 1).Value.CompareTo(DateTime.Now) >= 0
                             select a).ToList().Distinct();
            var sub = (from a in music.Abonné
                       join em in music.Emprunter on a.Code_Abonné equals em.Code_Abonné
                       select a).ToList().Distinct();
            foreach (Abonné a in sub)
            {
                if (!activeSub.Contains(a))
                {
                    listBox4.Items.Add(a);
                }

            }
        }

        private void tenDaysLate()
        {
            listBox2.Items.Clear();
            var lateSub = (from a in music.Abonné
                           join em in music.Emprunter on a.Code_Abonné equals em.Code_Abonné
                           where DbFunctions.AddMonths(em.Date_Emprunt.Value, 1).Value.CompareTo(DateTime.Now) <= 0
                           where !em.Date_Retour.HasValue
                           select a).ToList().Distinct();
            foreach (Abonné a in lateSub)
            {
                listBox2.Items.Add(a);
            }
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

        private void DeleteSub_Click_1(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                Abonné a = (Abonné)listBox4.SelectedItem;
                var rows = (from empr in music.Emprunter
                            where empr.Code_Abonné == a.Code_Abonné
                            select empr).ToList();
                foreach (var row in rows)
                {
                    if (!row.Date_Retour.HasValue)
                    {
                        DialogBox db = new DialogBox("Voulez-vous supprimer un abonné qui possède un ou plusieurs album(s) qui n'a(ont) pas été rendu(s) ?", "Annuler", "Confirmer");
                        DialogResult dbrs = db.ShowDialog();
                        if (dbrs == System.Windows.Forms.DialogResult.OK)
                        {
                            deleteAllAlbumsAndSubs(a, rows);
                        }
                        break;
                    }
                    else
                    {
                        deleteAllAlbumsAndSubs(a,rows);
                    }
                }
                tenDaysLate();
            }
        }

        private void deleteAllAlbumsAndSubs(Abonné a, List<Emprunter> rows)
        {
            foreach (var deleRow in rows)
            {
                music.Emprunter.Remove(deleRow);
            }
            music.Abonné.Remove(a);
            music.SaveChanges();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            yearInactivity();
            top10();
            tenDaysLate();
            AlbumBorrowed();
        }


        private void AlbumBorrowed()
        {
            var borrowed = (from em in music.Emprunter
                            where !em.Date_Retour.HasValue
                            orderby em.Code_Abonné
                            select em).ToList();

            foreach (Emprunter em in borrowed)
            {
                listBox3.Items.Add(em.Abonné.Prénom_Abonné.Trim() + " " + em.Abonné.Nom_Abonné.Trim() + " empreunte " + em.Album.Titre_Album);
            }
        }

    }
}
