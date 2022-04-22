using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Homepage : Form
    {
        const string dbase = @"Data Source=DESKTOP-4KCM5E5;Initial Catalog=notes;Integrated Security=True;MultipleActiveResultSets=true";

        SqlConnection con = new SqlConnection(dbase);
        public int userid
        {
            get;
            set;
        }
        public string usermail
        {
            get;
            set;
        }
        public string username
        {
            get;
            set;
        }
        public Homepage()
        {
            InitializeComponent();
        }

        private void writenote_Click(object sender, EventArgs e)
        {
            Newnotes newForm = new Newnotes();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.umail = usermail;
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }
        

      
        

       

        private void Homepage_Load(object sender, EventArgs e)
        {
            string message, uname;
            int uid;
            try
            {

                //open connection
                con.Open();
                //check if there are records
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT userID, userName, email, password FROM dbo.userInfo WHERE email='" + usermail + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    while (dtr.Read())
                    {
                        uid = dtr.GetInt32(0);
                        uname = dtr.GetString(1);
                        label1.Text ="Welcome " +uname;
                    }
                    
                }
                else
                {
                    
                }

                //close data reader
                dtr.Close();

            }
            catch (SqlException t)
            {
                message = "Error: " + t.ToString();
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }

        
        }

        

        private void signout_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }

        private void editnotes_Click(object sender, EventArgs e)
        {
            Reader newForm = new Reader();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.usmail = usermail;
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }
    }
    
}
