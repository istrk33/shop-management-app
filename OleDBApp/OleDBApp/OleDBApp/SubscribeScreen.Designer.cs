namespace OleDBApp
{
    partial class SubscribeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscribeScreen));
            this.lastName = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.vpass = new System.Windows.Forms.TextBox();
            this.passwordStrong = new System.Windows.Forms.Label();
            this.samePass = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.usedLogin = new System.Windows.Forms.Label();
            this.emptyFields = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.countryCombobox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.LightCyan;
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lastName.Location = new System.Drawing.Point(3, 3);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(498, 24);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Nom";
            this.lastName.Enter += new System.EventHandler(this.lastName_Enter);
            this.lastName.Leave += new System.EventHandler(this.lastName_Leave);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.LightCyan;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pass.Location = new System.Drawing.Point(3, 3);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(382, 24);
            this.pass.TabIndex = 0;
            this.pass.Text = "Mot de passe";
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightCyan;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.login.Location = new System.Drawing.Point(3, 67);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(498, 24);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.LightCyan;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name.Location = new System.Drawing.Point(3, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(498, 24);
            this.name.TabIndex = 1;
            this.name.Text = "Prénom";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.DarkGreen;
            this.confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.confirm.Location = new System.Drawing.Point(335, 3);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(160, 62);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.DarkRed;
            this.cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(3, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(160, 62);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Retour";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.SteelBlue;
            this.reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.Control;
            this.reset.Location = new System.Drawing.Point(169, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(160, 62);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // vpass
            // 
            this.vpass.BackColor = System.Drawing.Color.LightCyan;
            this.vpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vpass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.vpass.Location = new System.Drawing.Point(3, 3);
            this.vpass.Name = "vpass";
            this.vpass.Size = new System.Drawing.Size(383, 24);
            this.vpass.TabIndex = 0;
            this.vpass.Text = "Confirmer mot de passe";
            this.vpass.TextChanged += new System.EventHandler(this.vpass_TextChanged);
            this.vpass.Enter += new System.EventHandler(this.vpass_Enter);
            this.vpass.Leave += new System.EventHandler(this.vpass_Leave);
            // 
            // passwordStrong
            // 
            this.passwordStrong.AutoSize = true;
            this.passwordStrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordStrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordStrong.Location = new System.Drawing.Point(3, 164);
            this.passwordStrong.Name = "passwordStrong";
            this.passwordStrong.Size = new System.Drawing.Size(498, 32);
            this.passwordStrong.TabIndex = 8;
            // 
            // samePass
            // 
            this.samePass.AutoSize = true;
            this.samePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samePass.Location = new System.Drawing.Point(3, 232);
            this.samePass.Name = "samePass";
            this.samePass.Size = new System.Drawing.Size(498, 32);
            this.samePass.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(391, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.TabStop = false;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.Location = new System.Drawing.Point(392, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 24);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.TabStop = false;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // usedLogin
            // 
            this.usedLogin.AutoSize = true;
            this.usedLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usedLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedLogin.Location = new System.Drawing.Point(3, 96);
            this.usedLogin.Name = "usedLogin";
            this.usedLogin.Size = new System.Drawing.Size(498, 32);
            this.usedLogin.TabIndex = 14;
            // 
            // emptyFields
            // 
            this.emptyFields.AutoSize = true;
            this.emptyFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyFields.Location = new System.Drawing.Point(3, 305);
            this.emptyFields.Name = "emptyFields";
            this.emptyFields.Size = new System.Drawing.Size(498, 32);
            this.emptyFields.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lastName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emptyFields, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usedLogin, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.samePass, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.login, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.passwordStrong, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.91164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.08835F));
            this.tableLayoutPanel2.Controls.Add(this.pass, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.17259F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.82741F));
            this.tableLayoutPanel3.Controls.Add(this.vpass, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(498, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68021F));
            this.tableLayoutPanel4.Controls.Add(this.countryCombobox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(498, 35);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // countryCombobox
            // 
            this.countryCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryCombobox.BackColor = System.Drawing.Color.SteelBlue;
            this.countryCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countryCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countryCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryCombobox.ForeColor = System.Drawing.Color.White;
            this.countryCombobox.FormattingEnabled = true;
            this.countryCombobox.IntegralHeight = false;
            this.countryCombobox.Items.AddRange(new object[] {
            ""});
            this.countryCombobox.Location = new System.Drawing.Point(3, 3);
            this.countryCombobox.MaxDropDownItems = 10;
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(492, 33);
            this.countryCombobox.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.confirm, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cancel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.reset, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 340);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(498, 68);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // SubscribeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubscribeScreen";
            this.Text = "S\'abonner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox vpass;
        private System.Windows.Forms.Label passwordStrong;
        private System.Windows.Forms.Label samePass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label usedLogin;
        private System.Windows.Forms.Label emptyFields;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox countryCombobox;
    }
}