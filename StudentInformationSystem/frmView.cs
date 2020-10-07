using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Ronan Almeida
//Jan 2019
//Program- Assignment 4.5/5: Student Information System 
//Purpose: The purpose of this program is to  extract the students information from the Access Database file and to display/calculate various different statistics 
// The program has three Forms: Login(Everyone), View(Student), Admin(Instructor)
// In the login, the user has to input their username/password. If They are a normal student they will just get to view their current info/grade level/Avg
// If the user is an admin, this user will be able to edit the information  and enter new data

// Admin login: Username: admin | Password: 1

// - Designed the Forms to make it more user friendly, compact and appealing
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


namespace StudentInformationSystem
{
    public partial class frmView : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private int[] marks = new int[5];
        private string FirstName, LastName;

        public frmView(string received, string received2)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb;
Persist Security Info=False";
            FirstName = received;
            LastName = received2;
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
      
            try
            {
                txtMarks.Text = "";
                txtVisible();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "SELECT tblStudents.FirstName, tblStudents.LastName, tblStudents.DOB, tblMarks.Mark1, tblMarks.Mark2, tblMarks.Mark3, tblMarks.Mark4, tblMarks.Mark5, tblMarks.StuID FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE LastName+FirstName='" + LastName+FirstName + "'";
                //  string query = "SELECT * FROM (tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID) LastName + ',' + FirstName='" + cmbNames.Text + "'"; //"SELECT Mark1, Mark2 FROM tblMarks";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();


                reader.Read();
                txtFirstName.Text = reader["FirstName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtStuID.Text = reader["StuID"].ToString();
                txtDob.Text = Convert.ToDateTime(reader["DOB"].ToString()).ToString("dd/MMM/yy");
       


                for (int i = 0; i < 5; i++)
                {
                    marks[i] = int.Parse((reader[i + 3].ToString())) ;
                    txtMarks.Text += marks[i] + Environment.NewLine;
                }
                double Avg = Math.Round(AvgCalcuator(marks), 2);
                txtAvg.Text =Avg.ToString() + " %";
                txtLevel.Text = lvlCal(Avg);
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
       
        private static double AvgCalcuator(int[] Marks)
        {
            int sum = 0;
        
            for (int i =0;i<Marks.Length;i++)
            {
                sum += Marks[i];
            }
            
           
            return  sum/Marks.Length;
        }

        private static string lvlCal(double avg)
        {
            if(avg>=90)
            {
                return "4+";

            }
            if( avg>=80 && avg<90)
            {
                return "4";
            }
            if( avg<80 && avg>75)
            {
                return "3+";
            }
            if (avg < 75 && avg > 70)
            {
                return "3";
            }
            if (avg < 70 && avg > 65)
            {
                return "2+";
            }
            if (avg < 65 && avg > 60)
            {
                return "2";
            }
            if (avg < 60 && avg >= 50)
            {
                return "1";
            }
            if (avg < 50)
            {
                return "R (Failure)";
            }
            return null;
        }

        private void txtVisible()
        {
            txtDob.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtMarks.Enabled = false;
            txtStuID.Enabled = false;
            txtAvg.Enabled = false;
            txtLevel.Enabled = false;
        
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmview = new frmLogin();
            frmview.Show();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "SELECT tblMarks.Mark1, tblMarks.Mark2, tblMarks.Mark3, tblMarks.Mark4, tblMarks.Mark5, tblMarks.StuID FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE LastName+FirstName='" + txtLastName.Text + txtFirstName.Text + "'";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                chartMarks.Series["Marks"].YValuesPerPoint = 5;

                while (reader.Read())
                {
                    foreach (var series in chartMarks.Series)
                    {
                        series.Points.Clear();
                    }

                    for (int x = 0; x < 5; x++)
                    {
                        this.chartMarks.Series["Marks"].Points.AddXY("Mark" + Convert.ToString(x + 1), reader[x].ToString());
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                connection.Close();
            }
        }
    }
}
