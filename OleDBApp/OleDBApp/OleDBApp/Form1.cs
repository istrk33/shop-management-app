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
    public partial class Form1 : Form
    {
        OleDbConnection dbConnection;
        public static Abonné currentSubscriber;
        public Form1()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(Source.ChaineBD);
            dbConnection.Open();
            checkBox1.Enabled = false;
            label1.ForeColor = Color.Black;
            label1.Text = "Connectez vous";
        }

        public Form1(string msg)
        {
            dbConnection = new OleDbConnection(Source.ChaineBD);
            dbConnection.Open();
            InitializeComponent();
            label1.ForeColor = Color.DarkGreen;
            label1.Text = msg;
            checkBox1.Enabled = false;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string inputedLogin, inputedPassword;
            if (login.Text.Length != 0 && password.Text.Length != 0 && !login.Text.Equals("Login") && !password.Text.Equals("Mot de passe"))
            {
                inputedLogin = login.Text;
                inputedPassword = password.Text;
                string logins = "select Code_Abonné,Nom_Abonné,Prénom_Abonné,Login,Password,Code_Pays from Abonné";
                OleDbCommand cmd = new OleDbCommand(logins, dbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();

                bool errorLogin = true;
                while (reader.Read())
                {
                    Abonné a = new Abonné(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                    if (a.Login != null && a.Password != null && a.Login.Trim().Equals(inputedLogin) && a.Password.Trim().Equals(inputedPassword))
                    {
                        currentSubscriber = a;
                        this.Hide();
                        SubscribersArea ea = new SubscribersArea();
                        ea.ShowDialog();
                        currentSubscriber = a;
                        errorLogin = false;
                        this.Show();
                        password.PasswordChar = '\0';
                        password.ForeColor = SystemColors.WindowFrame;
                        login.ForeColor = SystemColors.WindowFrame;
                        password.Text = "Mot de passe";
                        login.Text = "Login";
                        label1.ForeColor = Color.Black;
                        label1.Text = "Connectez vous";

                    }
                }
                reader.Close();
                if (errorLogin)
                {
                    label1.ForeColor = Color.DarkRed;
                    label1.Text = "Erreur de Login ou Mot de passe";
                }
                if (login.Text.Equals("admin") && password.Text.Equals("admin"))
                {
                    this.Hide();
                    AdminArea b = new AdminArea();
                    b.ShowDialog();
                    this.Show();
                    label1.ForeColor = Color.Black;
                    label1.Text = "Connectez vous";
                    password.PasswordChar = '\0';
                    password.ForeColor = SystemColors.WindowFrame;
                    login.ForeColor = SystemColors.WindowFrame;
                    password.Text = "Mot de passe";
                    login.Text = "Login";
                }
            }
            else if (login.Text.Equals("Login") || password.Text.Equals("Mot de passe") || login.Text.Length == 0 || password.Text.Length == 0)
            {
                label1.ForeColor = Color.DarkRed;
                label1.Text = "Remplissez tous les champs !";
            }
        }

        private void subscribe_Click(object sender, EventArgs e)
        {
            SubscribeScreen s = new SubscribeScreen();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!password.Text.Equals("Mot de passe"))
            {
                checkBox1.Enabled = true;
                if (checkBox1.Checked)
                {
                    password.PasswordChar = '\0';
                }
                else
                {
                    password.PasswordChar = '*';
                }
            }
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.ForeColor == SystemColors.WindowFrame)
            {
                login.Text = "";
            }
            else
            {
                login.SelectAll();
            }
            login.ForeColor = Color.Black;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.ForeColor == SystemColors.WindowFrame)
            {
                password.Text = "";
            }
            else
            {
                password.SelectAll();
            }
            checkBox1.Enabled = true;
            password.ForeColor = Color.Black;
            password.PasswordChar = '*';
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Login";
                login.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                checkBox1.Enabled = false;
                password.PasswordChar = '\0';
                password.Text = "Mot de passe";
                password.ForeColor = SystemColors.WindowFrame;
            }
        }
    }
}
