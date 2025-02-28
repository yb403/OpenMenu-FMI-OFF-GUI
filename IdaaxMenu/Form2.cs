using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idaaxopenmenu
{
    public partial class Form2 : Form
    {
        public string Password { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                changebtn.Enabled = true;
            } else
            {
                changebtn.Enabled = false;
            }
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            Password = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
