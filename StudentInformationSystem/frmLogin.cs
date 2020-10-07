using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  //Used for connection/command to  database server
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Ronan Almeida
//Jan 2019
//Program- Assignment 4.5/5: Student Information System 
//Purpose: The purpose of this program is to  extract the students information from the Acess Database file and to display/calculate various different statistics 
// The program has three Forms: Login(Everyone), View(Student), Admin(Instructor)
// In the login, the user has to input their username/password. If They are a normal student they will just get to view their current info/grade level/Avg
// If the user is an admin, this user will be able to edit the information  and enter new data

// Admin login: Username: admin | Password: 1

// - Designed the Forms to make it more user friendly, compact and appealing
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

namespace StudentInformationSystem
{

    public partial class frmLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public frmLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb;
Persist Security Info=False";

            //Connecting to acess file

        }

        //When user clicks login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open(); //Open connection
            OleDbCommand command = new OleDbCommand();

            //linking command object to connection
            command.Connection = connection;

            command.CommandText = "SELECT * FROM tblStudents WHERE UserName='" + txtUserName.Text + "' AND Password ='" + txtPassword.Text + "'"; //Selecting username/pass from acess file 

            OleDbDataReader reader = command.ExecuteReader(); //executes 

            int counter = 0;
            string pass = "";//firstname
            string pass2 = "";//lastname

            while (reader.Read()) //While it reads the request
            {
                counter++;
                pass = reader["FirstName"].ToString();
                pass2 = reader["LastName"].ToString();


            }
            if (counter == 1) //if there is no duplicates 
            {
                MessageBox.Show("Welcome " + pass + " " + pass2);

                this.Hide(); //hides current form

                if (txtUserName.Text == "admin") //if user is admin go into admin frm view 
                {
                    frmAdmin frmAdmin = new frmAdmin(pass, pass2);
                    frmAdmin.ShowDialog();
                }
                else //else user is student go into frm view 
                {
                      frmView frmView = new frmView(pass, pass2);
                      frmView.ShowDialog();

                }
            }
            else if (counter > 1) //if there is duplicates 
            {
                MessageBox.Show("Error 2 | Please contact your current admin"); //contact admin
            }
            else//else  user input is wrong 
            {
                MessageBox.Show("Username/Password not recognized Please try again "); 

            }
            //close reader/connection
            reader.Close(); 
            connection.Close();
        }

        //Upon frm load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try //try catch statement 
            {
                // connect to acess file 
                connection.Open(); 
                lblStatus.Text = "Connected";
                connection.Close();
            }
            catch// if it doesnt connect then inform user
            {
                MessageBox.Show("Error 1: Not connected to server");
                btnLogin.Enabled = false;
            }
        }
    }
}
