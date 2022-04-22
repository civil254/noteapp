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
    public partial class Newnotes : Form
    {
        const string dbase = @"Data Source=DESKTOP-4KCM5E5;Initial Catalog=notes;Integrated Security=True;MultipleActiveResultSets=true";

        SqlConnection con = new SqlConnection(dbase);
        public string umail
        {
            get;
            set;
        }
        public Newnotes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage newForm = new Homepage();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.usermail = umail;
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string ntitle = title.Text;
            string notem = note.Text;
            string message;
            int uid;
            string uname;
            if (title.Text is null)
            {
                message = "Kindly Enter Note Title";
                const string caption = "Alert";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                
            }
            if (note.Text is null)
            {
                message = "Kindly Enter Note Title";
                const string caption = "Alert";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
            }

            try
            {

                //open connection
                con.Open();
                //check if there are records
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT userID, userName, email, password FROM dbo.userInfo WHERE email='" + umail + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    while (dt.Read())
                    {
                        uid = dt.GetInt32(0);
                        uname = dt.GetString(1);
                        try
                        {
                            SqlCommand cmd1 = con.CreateCommand();
                            cmd1.Connection = con;
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "INSERT INTO[notes] ([userID], [notes], [noteTitle]) VALUES('" + uid + "', '" + notem + "', '" + ntitle + "')";
                            cmd1.ExecuteNonQuery();
                            message = "Note saved successesfully. Want to Add another note";

                            const string caption = "Success";
                            var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,                                            MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                // cancel the closure of the form.
                                Newnotes newForm = new Newnotes();    //Create the New Form Object



                                newForm.umail = umail;
                                this.Hide();    //Hide the Old Form
                                newForm.ShowDialog();    //Show the New Form
                                this.Close();    //Close the Old Form
                            }
                            if (result == DialogResult.No)
                            {
                                // cancel the closure of the form.
                                Homepage newForm = new Homepage();    //Create the New Form Object
                                newForm.usermail = umail;
                                this.Hide();    //Hide the Old Form
                                newForm.ShowDialog();    //Show the New Form
                                this.Close();    //Close the Old Form
                            }
                        }
                        catch (SqlException p )
                        {
                            message = "Error: " + p.ToString();
                            const string caption = "Error";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                        MessageBoxIcon.Error);
                            if (result==DialogResult.OK)
                            {
                                //
                                Newnotes newForm = new Newnotes();    //Create the New Form Object



                                newForm.umail = umail;
                                this.Hide();    //Hide the Old Form
                                newForm.ShowDialog();    //Show the New Form
                                this.Close();    //Close the Old Form

                            }

                        }
                    }
                }
                else
                {
                    message = "Try again";
                    const string caption = "Login Failed";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning);
                }

                //close data reader
                dt.Close();

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
                con.Close();
            }

            // If the yes button was pressed ...
        }
    }
}
