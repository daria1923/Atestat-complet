using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Picture_puzzle
{
    public partial class frmRules : Form
    {
        public Form BackToMainForm { get; set; }
        public frmRules()
        {
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.BackToMainForm.Visible = true;
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
