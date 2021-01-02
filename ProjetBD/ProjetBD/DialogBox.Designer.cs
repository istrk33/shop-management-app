namespace ProjetBD
{
    partial class DialogBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.info = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancel = new System.Windows.Forms.Button();
            this.agree = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 113);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.info.Location = new System.Drawing.Point(3, 3);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(507, 50);
            this.info.TabIndex = 5;
            this.info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.agree, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(507, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.cancel.FlatAppearance.BorderSize = 3;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel.Location = new System.Drawing.Point(3, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(247, 45);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Annuler";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // agree
            // 
            this.agree.BackColor = System.Drawing.Color.SteelBlue;
            this.agree.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.agree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agree.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.agree.FlatAppearance.BorderSize = 3;
            this.agree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agree.ForeColor = System.Drawing.Color.DarkGreen;
            this.agree.Location = new System.Drawing.Point(256, 3);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(248, 45);
            this.agree.TabIndex = 1;
            this.agree.Text = "Continuer";
            this.agree.UseVisualStyleBackColor = false;
            this.agree.Click += new System.EventHandler(this.agree_Click);
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 113);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button agree;
        public System.Windows.Forms.TextBox info;
    }
}