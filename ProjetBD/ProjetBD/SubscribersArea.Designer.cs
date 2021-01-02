namespace ProjetBD
{
    partial class SubscribersArea
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
            this.button1 = new System.Windows.Forms.Button();
            this.AlbumDispo = new System.Windows.Forms.Button();
            this.DelayAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.disconnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 119);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mes Albums";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AlbumDispo
            // 
            this.AlbumDispo.BackColor = System.Drawing.Color.SteelBlue;
            this.AlbumDispo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumDispo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.AlbumDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumDispo.ForeColor = System.Drawing.Color.White;
            this.AlbumDispo.Location = new System.Drawing.Point(3, 253);
            this.AlbumDispo.Name = "AlbumDispo";
            this.AlbumDispo.Size = new System.Drawing.Size(293, 119);
            this.AlbumDispo.TabIndex = 2;
            this.AlbumDispo.Text = "Albums Disponibles";
            this.AlbumDispo.UseVisualStyleBackColor = false;
            this.AlbumDispo.Click += new System.EventHandler(this.albumDispo_Click);
            // 
            // DelayAll
            // 
            this.DelayAll.BackColor = System.Drawing.Color.SteelBlue;
            this.DelayAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelayAll.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.DelayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayAll.ForeColor = System.Drawing.Color.White;
            this.DelayAll.Location = new System.Drawing.Point(3, 128);
            this.DelayAll.Name = "DelayAll";
            this.DelayAll.Size = new System.Drawing.Size(293, 119);
            this.DelayAll.TabIndex = 1;
            this.DelayAll.Text = "Repousser tous mes emprunts";
            this.DelayAll.UseVisualStyleBackColor = false;
            this.DelayAll.Click += new System.EventHandler(this.DelayAll_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.08394F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.91606F));
            this.tableLayoutPanel1.Controls.Add(this.viewBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewBox
            // 
            this.viewBox.BackColor = System.Drawing.Color.LightCyan;
            this.viewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.viewBox.FormattingEnabled = true;
            this.viewBox.HorizontalScrollbar = true;
            this.viewBox.ItemHeight = 25;
            this.viewBox.Location = new System.Drawing.Point(308, 3);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(1011, 503);
            this.viewBox.TabIndex = 1;
            this.viewBox.SelectedIndexChanged += new System.EventHandler(this.viewBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.disconnect, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AlbumDispo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DelayAll, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 503);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.Color.DarkRed;
            this.disconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.disconnect.Location = new System.Drawing.Point(3, 378);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(293, 122);
            this.disconnect.TabIndex = 10;
            this.disconnect.Text = "Se déconnecter";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 509);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1322, 47);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1316, 47);
            this.label.TabIndex = 0;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubscribersArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1322, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "SubscribersArea";
            this.Text = "Espace Abonné";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlbumDispo;
        private System.Windows.Forms.Button DelayAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox viewBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button disconnect;
    }
}