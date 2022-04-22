using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup newForm = new Signup();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signin newForm = new Signin();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }
    }
}
