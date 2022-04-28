using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit the game?";
            string title = "Exit message box";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            Application.Exit();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmRules frmRules = new frmRules();
            frmRules.BackToMainForm = this;
            frmRules.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.BackToMainForm = this;
            Form3.Show();
            this.Visible = false;
        }
    }
}
