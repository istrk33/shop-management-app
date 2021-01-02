using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleDBApp
{
    public partial class DialogBox : Form
    {
        public DialogBox(string label, string cancel, string confirm)
        {
            InitializeComponent();
            this.info.Text = label;
            this.cancel.Text = cancel;
            this.agree.Text = confirm;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agree_Click(object sender, EventArgs e)
        {

        }
    }
}
