using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBD
{
    public partial class SubscribeScreen : Form
    {
        MusicSQLEntities sqlMusic = new MusicSQLEntities();
        string userLastName, userName, userLogin, userPass;
        int countryCode, sec;
        bool goodLogin;
        public SubscribeScreen()
        {
            InitializeComponent();
            updateCombobox();
            goodLogin = false;
            sec = 0;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            countryCombobox.Text = "Choisir pays";
        }

        private void updateCombobox()
        {
            var pays = from p in sqlMusic.Pays orderby p.Nom_Pays select p;
            foreach (Pays p in pays)
            {
                countryCombobox.Items.Add(p);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            lastName.Text = "Nom";
            lastName.ForeColor = SystemColors.WindowFrame;
            name.Text = "Prénom";
            name.ForeColor = SystemColors.WindowFrame;
            login.Text = "Login";
            login.ForeColor = SystemColors.WindowFrame;
            pass.Text = "Mot de passe";
            pass.ForeColor = SystemColors.WindowFrame;
            vpass.Text = "Confirmer mot de passe";
            vpass.ForeColor = SystemColors.WindowFrame;
            countryCombobox.SelectedItem = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (lastName.Text.Length > 0 && name.Text.Length > 0 && login.Text.Length > 0 && pass.Text.Length > 0
                && vpass.Text.Equals(pass.Text) && countryCombobox.SelectedItem != null && goodLogin)
            {
                emptyFields.Text = "";
                userLastName = lastName.Text;
                userName = name.Text;
                userLogin = login.Text;
                userPass = pass.Text;
                Pays p = (Pays)countryCombobox.SelectedItem;
                countryCode = p.Code_Pays;
                addSubscriber();

                Form1 f1 = new Form1("Compte créé avec succès !!");
                this.Hide();
                f1.ShowDialog();
            }
            else if (login.Text == "admin") {
                emptyFields.ForeColor = Color.DarkRed;
                emptyFields.Text = "Remplacez le login !";
                emptyFields.Text = "";
                timer1.Start();
                emptyFields.Text = "Remplacez le login !";
            }
            else
            {
                emptyFields.ForeColor = Color.DarkRed;
                emptyFields.Text = "Remplissez tout les champs !";
                emptyFields.Text = "";
                timer1.Start();
                emptyFields.Text = "Remplissez tout les champs !";
            }
        }

        public void addSubscriber()
        {
            var newSubscriber = new Abonné { Nom_Abonné = userLastName, Prénom_Abonné = userName, Login = userLogin, Password = userPass, Code_Pays = countryCode };
            sqlMusic.Abonné.Add(newSubscriber);
            sqlMusic.SaveChanges();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text.Length < 5)
            {
                passwordStrong.Text = "Mauvais";
                passwordStrong.ForeColor = Color.Red;
            }
            else if (pass.Text.Length >= 5 && pass.Text.Length < 8)
            {
                passwordStrong.Text = "Moyen";
                passwordStrong.ForeColor = Color.Orange;
            }
            else if (pass.Text.Length >= 8)
            {
                passwordStrong.Text = "Fort";
                passwordStrong.ForeColor = Color.Green;
            }
        }

        private void lastName_Enter(object sender, EventArgs e)
        {
            if (lastName.ForeColor== SystemColors.WindowFrame)
            {
                lastName.Text = "";
                lastName.ForeColor = Color.Black;
            }else
            {
                lastName.SelectAll();
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.ForeColor == SystemColors.WindowFrame)
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
            else
            {
                name.SelectAll();
            }
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.ForeColor == SystemColors.WindowFrame)
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
            else
            {
                login.SelectAll();
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            if (pass.ForeColor == SystemColors.WindowFrame)
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.PasswordChar = '*';
            }
            else
            {
                pass.SelectAll();
            }
        }

        private void vpass_Enter(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
            checkBox1.Enabled = true;
            if (vpass.ForeColor == SystemColors.WindowFrame)
            {
                vpass.Text = "";
                vpass.ForeColor = Color.Black;
                vpass.PasswordChar = '*';
            }
            else
            {
                vpass.SelectAll();
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text.Equals(""))
            {
                lastName.Text = "Nom";
                lastName.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text.Equals(""))
            {
                name.Text = "Prénom";
                name.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text.Equals(""))
            {
                login.Text = "Login";
                login.ForeColor = SystemColors.WindowFrame;
                usedLogin.Text = "";
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text.Equals(""))
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                pass.PasswordChar = '\0';
                pass.Text = "Mot de passe";
                pass.ForeColor = SystemColors.WindowFrame;
                passwordStrong.Text = "";
            }
            passwordStrong.Text = "";
        }

        private void vpass_Leave(object sender, EventArgs e)
        {
            if (vpass.Text.Equals(""))
            {
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                vpass.PasswordChar = '\0';
                vpass.Text = "Confirmer mot de passe";
                vpass.ForeColor = SystemColors.WindowFrame;
                samePass.Text = "";
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            var logins = from a in sqlMusic.Abonné select a.Login;
            foreach (String s in logins)
            {
                if (login.Text.Equals(s))
                {
                    usedLogin.ForeColor = Color.DarkRed;
                    usedLogin.Text = "Login déja utilisé par un autre abonné";
                    goodLogin = false;
                    break;
                }
                else if (login.Text.Contains(' '))
                {
                    usedLogin.ForeColor = Color.DarkRed;
                    usedLogin.Text = "Caractère(s) non autorisé présent(s)";
                    goodLogin = false;
                }
                else if (login.Text == "" || login.Text == "admin")
                {
                    usedLogin.ForeColor = Color.DarkRed;
                    usedLogin.Text = "Login indisponible";
                    goodLogin = false;
                }
                else
                {
                    usedLogin.ForeColor = Color.DarkGreen;
                    usedLogin.Text = "Login valide";
                    goodLogin = true;
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 2)
            {
                sec = 0;
                timer1.Stop();
            }
        }

        private void vpass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text.Equals(vpass.Text))
            {
                samePass.Text = "Mot de passe correct";
                samePass.ForeColor = Color.Green;
            }
            else
            {
                samePass.Text = "Mot de passe incorrect";
                samePass.ForeColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!pass.Text.Equals("Mot de passe"))
            {
                checkBox1.Enabled = true;
                if (checkBox1.Checked)
                {
                    pass.PasswordChar = '\0';
                }
                else
                {
                    pass.PasswordChar = '*';
                }
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!vpass.Text.Equals("Mot de passe"))
            {
                checkBox2.Enabled = true;
                if (checkBox2.Checked)
                {
                    vpass.PasswordChar = '\0';
                }
                else
                {
                    vpass.PasswordChar = '*';
                }
            }
        }

    }


}
