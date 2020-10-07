using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //used for connection to acess file 

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Ronan Almeida
//Jan/Dec 2019
//Program: Student Information System 
//Purpose: The purpose of this program is to  extract the students information from the Acess Database file and to display/calculate various different statistics 
// The program has three Forms: Login(Everyone), View(Student), Admin(Instructor)
// In the login, the user has to input their username/password. If They are a normal student they will just get to view their current info/grade level/Avg
// If the user is an admin, this user will be able to edit the information  and enter new data

// Admin login: Username: admin | Password: 1

// - Designed to make it fool proof for inputs txt boxes, buttons etc
//  - Added logout button for all forms to make it easier to acess them
// - Designed the Forms to make it more user friendly, compact and appealing
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


namespace StudentInformationSystem
{
    public partial class frmAdmin : Form
    {
        private OleDbConnection connection = new OleDbConnection(); //connect to acess file

           StudentDatabase db = new StudentDatabase(); //calling instance of  database class 
         
        public frmAdmin(string received, string received2)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students.accdb;
Persist Security Info=False";
            db.FirstName = received; //fistname
            db.LastName = received2; //lastname

        }

        //Frm load
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            PopulateCmbName(); //Populate the combo box with names
            disableUpdate(); //Disable update - disable a few buttons so things wont break
            
        }

        //Starting Methods 
        public void PopulateCmbName()
        {
            //Try catch statement 
            try
            {
                connection.Open(); //connect to database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                //sorting guery into string called query
                string query = "SELECT LastName, FirstName FROM tblStudents";

                //passing into command text
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    cmbNames.Items.Add(reader[0].ToString() + "," + reader[1].ToString()); //Add the names to  combo box 
                }
                reader.Close(); //close reader
                connection.Close(); //clos econnection
            }
            catch (Exception ex) //if theres an error notify user
            {
                MessageBox.Show("Error In Loading Please Ensure that Data is Loaded Correctly  \n \n " + ex, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
        private static double AvgCalcuator(int[] Marks) //Method for calcuating average 
        {
            int sum = 0;

            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }


            return sum / Marks.Length; //return the sum of all marks divided by number of marks 
        }

        private static string lvlCal(double avg) //method for determining level
        {
            if (avg >= 90)
            {
                return "4+";

            }
            if (avg >= 80 && avg < 90)
            {
                return "4";
            }
            if (avg < 80 && avg >=75)
            {
                return "3+";
            }
            if (avg < 75 && avg >= 70)
            {
                return "3";
            }
            if (avg < 70 && avg >= 65)
            {
                return "2+";
            }
            if (avg < 65 && avg >= 60)
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
            return null; //retun null if nothing else 
        }

        public void enableUpdate() //enable update method for enabling btns/txt boxes
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            dtpPickDate.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnSave.Enabled = true;
             btnNew.Enabled = false;
            btnDelete.Enabled = true;
        
            txtMark1.Enabled = true;
            txtMark2.Enabled = true;
            txtMark3.Enabled = true;
            txtMark4.Enabled = true;
            txtMark5.Enabled = true;

        }

        public void disableUpdate() //disable update method for disabling  btns/txt boxes
        {
            txtFirstName.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtStuID.Enabled = false;
            txtLastName.Enabled = false;
            dtpPickDate.Enabled = false;
            btnSave.Enabled = false;
            btnSaveNew.Enabled = false;
           // btnDelete.Enabled = false;
            cmbNames.Enabled = true;
            btnChart.Enabled = false;
            btnClearChart.Enabled = false;
            btnDelete.Enabled = false;
            txtMark1.Enabled = false;
            txtMark2.Enabled = false;
            txtMark3.Enabled = false;
            txtMark4.Enabled = false;
            txtMark5.Enabled = false;
            btnEdit.Enabled = false;
            btnLogOut.Enabled = true;

        }

        private void enableNew() //enable update method for enabling btns/txt boxes
        {
            txtMark1.Enabled = true;
            txtMark2.Enabled = true;
            txtMark3.Enabled = true;
            txtMark4.Enabled =true;
            txtMark5.Enabled =true;
            txtFirstName.Enabled = true;
            dtpPickDate.Enabled = true;
            txtLastName.Enabled = true;
            btnSaveNew.Enabled = true;
            cmbNames.Enabled = false;
            btnEdit.Enabled = false;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;

        }
        private void clearText() //Clears all text 
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMark1.Text = "";
            txtMark2.Text = "";
            txtMark3.Text = "";
            txtMark4.Text = "";
            txtMark5.Text = "";
            dtpPickDate.Text = "";
            cmbNames.Text = "";
            txtStuID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e) //When a name is selected in combo box 
        {
            try
            {
                //wipe the marks txt 
                txtMark1.Text = "";
                txtMark2.Text = "";
                txtMark3.Text = "";
                txtMark4.Text = "";
                txtMark5.Text = "";

                btnEdit.Enabled = true;
                connection.Open(); //open connection 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                clearChart(); //clear chart

                //Query for splitting items into txt t boxe s
                // string query = "SELECT tblStudents.FirstName, tblStudents.LastName, tblStudents.DOB, tblMarks.Mark1, tblMarks.Mark2, tblMarks.Mark3, tblMarks.Mark4, tblMarks.Mark5, tblMarks.StuID FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE LastName + ',' + FirstName='" + cmbNames.Text + "'";           
                string query = "SELECT tblStudents.FirstName, tblStudents.LastName, tblStudents.DOB, tblMarks.Mark1, tblMarks.Mark2, tblMarks.Mark3, tblMarks.Mark4, tblMarks.Mark5, tblMarks.StuID, tblStudents.UserName, tblStudents.Password FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE LastName + ',' + FirstName='" + cmbNames.Text + "'";

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();


                reader.Read();
                //Split items into their own catergories and display them
                txtFirstName.Text = reader["FirstName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtStuID.Text = reader["StuID"].ToString();
                txtUserName.Text = reader["UserName"].ToString();
                txtPassword.Text = reader["Password"].ToString();

                dtpPickDate.Text = Convert.ToDateTime(reader["DOB"].ToString()).ToString("dd/MMM/yy");

                for (int i = 0; i < 5; i++)
                {
                    db.Marks[i] = int.Parse((reader[i + 3].ToString())); //put the marks into an array 
                 
                }
                //display marks 
                txtMark1.Text =""+  db.Marks[0];
                txtMark2.Text = "" + db.Marks[1];
                txtMark3.Text = "" + db.Marks[2];
                txtMark4.Text = "" + db.Marks[3];
                txtMark5.Text = "" + db.Marks[4];

                btnChart.Enabled = true;
                btnClearChart.Enabled = true;

                //Display average and level
                double Avg = Math.Round(AvgCalcuator(db.Marks), 2);
                lblLevel.Text = "Average: " + Avg + "% | Level: " + lvlCal(Avg);

                //close connection
                reader.Close();
                connection.Close();
                displayChart();
            }
            catch (Exception ex) //catch statement if something goes wrong 
            {
                MessageBox.Show("Error In Loading Please Ensure that Data is Loaded Correctly  \n \n " + ex, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
        
        private void clearChart() //method for clearing chart 
        {
            foreach (var series in chartMarks.Series) //clear each series  foreach statement
            {
                series.Points.Clear();
            }
        }
        private void btnClearChart_Click(object sender, EventArgs e)
        {
            clearChart(); //clear chart method
        }
   
        //when the chart button is clicked 
        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open(); //open connection 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                
                //select query from tbl marks to enter data
                string query = "SELECT tblMarks.Mark1, tblMarks.Mark2, tblMarks.Mark3, tblMarks.Mark4, tblMarks.Mark5, tblMarks.StuID FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE LastName + ',' + FirstName='" + cmbNames.Text + "'";

                command.CommandText = query; //execute query
                OleDbDataReader reader = command.ExecuteReader();

                chartMarks.ChartAreas[0].AxisY.Maximum = 100; //chart can be a max of 100

                chartMarks.Series["Marks"].YValuesPerPoint = 5; //5 values 

                //enter the marks into the chart and display
                while (reader.Read())
                {
                    foreach (var series in chartMarks.Series)
                    {
                        series.Points.Clear();
                    }

                    for (int x = 0; x < 5; x++)
                    {
                        this.chartMarks.Series["Marks"].Points.AddXY("" + Convert.ToString(x + 1), reader[x].ToString());
                    }

                }
                connection.Close(); //close the conenction
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Loading Chart | Please Ensure that File is Loaded Correctly \n " + ex, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        //method for displaying chart 
        private void displayChart()
        {
            try
            {
                connection.Open(); //open connection 
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                //query for chart marks data
                string query = "SELECT tblMarks.Mark1, tblMarks.Mark2, tblMarks.Mark3, tblMarks.Mark4, tblMarks.Mark5, tblMarks.StuID FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE LastName + ',' + FirstName='" + cmbNames.Text + "'";

                //execute query
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                chartMarks.ChartAreas[0].AxisY.Maximum = 100; //limit chart to 100%

                chartMarks.Series["Marks"].YValuesPerPoint = 5; //5 values 

                //display chart by entering the marks 
                while (reader.Read())
                {
                    foreach (var series in chartMarks.Series)
                    {
                        series.Points.Clear();
                    }

                    for (int x = 0; x < 5; x++)
                    {
                        this.chartMarks.Series["Marks"].Points.AddXY("" + Convert.ToString(x + 1), reader[x].ToString());
                    }

                }
                connection.Close(); //close connection
            }
            catch (Exception ex)
            {
                connection.Close();
            }
        }
        //button edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to enter Edit mode, make your changes and hit save", "Notice"); 
            enableUpdate();//enable edit buttons 
        }

        //button for saving edits 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkError() == true) //if there is an error in inputs 
            {
                MessageBox.Show("Please Ensure that all the information is correctly entered!" , "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (checkError() == false)//if there is no error 
            {
                try
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection;

                    // string query = "UPDATE tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID SET tblStudents.FirstName='" + txtFirstName.Text + "', tblStudents.LastName='" + txtLastName.Text + "', tblStudents.DOB='" + DateTime.ParseExact(dtpPickDate.Text, @"dd/MMM/yy", System.Globalization.CultureInfo.InvariantCulture) + "', tblMarks.Mark1=" + int.Parse(txtMark1.Text) + ", tblMarks.Mark2=" + int.Parse(txtMark2.Text) + ", tblMarks.Mark3 = " + int.Parse(txtMark3.Text) + ", tblMarks.Mark4=" + int.Parse(txtMark4.Text) + ", tblMarks.Mark5=" + int.Parse(txtMark5.Text) + " WHERE tblStudents.StuID=" + int.Parse(txtStuID.Text);
                   string query = "UPDATE tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID SET tblStudents.FirstName='" + txtFirstName.Text + "', tblStudents.LastName='" + txtLastName.Text + "', tblStudents.DOB='" + DateTime.ParseExact(dtpPickDate.Text, @"dd/MMM/yy", System.Globalization.CultureInfo.InvariantCulture) + "', tblStudents.UserName='" + txtUserName.Text + "', tblStudents.Password='" + txtPassword.Text + "', tblMarks.Mark1=" + int.Parse(txtMark1.Text) + ", tblMarks.Mark2=" + int.Parse(txtMark2.Text) + ", tblMarks.Mark3 = " + int.Parse(txtMark3.Text) + ", tblMarks.Mark4=" + int.Parse(txtMark4.Text) + ", tblMarks.Mark5=" + int.Parse(txtMark5.Text) + " WHERE tblStudents.StuID=" + int.Parse(txtStuID.Text);

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data Edited!","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    disableUpdate();
                    cmbNames.Items.Clear();
                    btnEdit.Enabled = true;
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnChart.Enabled = true;
                    btnClearChart.Enabled = true;
                    PopulateCmbName();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error In Saving Edits Please Ensure that Data is Inputted Correctly  \n \n "+ ex,"Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }

              
        }
        // button for deletion 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open(); //connect to database 
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;
                //query for deletion 
                string query = "DELETE tblStudents.*, tblMarks.* FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE tblStudents.StuID=" + int.Parse(txtStuID.Text) ;
                // string query = "DELETE * from tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE tblStudents.StuID='" + txtStuID.Text + "'";
                command.CommandText = query;


                command.ExecuteNonQuery(); //execute query 

                 query = "DELETE * from tblMarks WHERE tblMarks.MarkID=" + int.Parse(txtStuID.Text); //execute query for tbl marks 
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Deleted " + cmbNames.Text + " From Database" ,"Deletion Notice", MessageBoxButtons.OK, MessageBoxIcon.Information); //messagebox showing name of person which is deleted 

                connection.Close(); //close connection 
                disableUpdate(); //enable/disable buttons 
                cmbNames.Items.Clear();
                btnEdit.Enabled = true;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnChart.Enabled = true;
                btnClearChart.Enabled = true;
                btnDelete.Enabled = false;
                cmbNames.Text = "DELETED: " + cmbNames.Text;
                PopulateCmbName(); //populate combo box 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in deletion, try again " + ex, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);

                connection.Close();
                PopulateCmbName();
            }
        }

        //New info button
        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Enter new data?", "Entering Data", MessageBoxButtons.YesNo); //ask user yes or no
            if (dialogresult == DialogResult.Yes) //if yes then enable those buttons 
            {
                enableNew();
                clearText();
            }
            else if (dialogresult == DialogResult.No) //if user input no then do nothing
            {

            }
        }

        //Button for saving new records 
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if( checkError() == true) //if there is an error 
            {
                MessageBox.Show("Please Ensure that all the information is correctly entered!","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (checkError() == false) //if the error reutrns false then proceed 
            {
                try
                {
                    connection.Open(); //connecton 
                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection; //connection 
                  //  string que2ry = "DELETE tblStudents.*, tblMarks.* FROM tblStudents INNER JOIN tblMarks ON tblStudents.StuID=tblMarks.StuID WHERE tblStudents.StuID=" + int.Parse(txtStuID.Text);
                    string query = "insert into tblStudents (FirstName,LastName,UserName,Password,DOB) values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','"+ dtpPickDate.Text+ "')";

                 //   command.CommandText = query; 
                  //  command.ExecuteNonQuery(); //execute the query
                    //string query2 = "insert into tblMarks (Mark1,Mark2,Mark3,Mark4,Mark5) values('" +int.Parse(txtMark1.Text)  + "','" + int.Parse(txtMark2.Text) + "','" + int.Parse(txtMark3.Text) + "','" + int.Parse(txtMark4.Text) + "','" + int.Parse(txtMark5.Text) + "')";

                      command.CommandText = query;
                       command.ExecuteNonQuery();

                    MessageBox.Show("Data Saved");
                    connection.Close(); //close database 
                    disableUpdate();
                }
                catch (Exception ex) //if error was found 
                {
                    MessageBox.Show("Error In Saving Edits Please Ensure that Data is Inputted Correctly  \n \n " + ex, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }        
            }
            
        }

        private bool checkError() //method for checking if txt boxes are inputted correct info
        {
            try
            {
                if (true == txtFirstName.Text.Any(Char.IsDigit) | true == txtLastName.Text.Any(Char.IsDigit)) //if there is a number in firstname/lastname
                {
                    return true;
                }

                //if any of the db.Marks does not contain a number
                if (false == txtMark1.Text.All(Char.IsDigit) | false == txtMark2.Text.All(Char.IsDigit) | false == txtMark3.Text.All(Char.IsDigit) | false == txtMark4.Text.All(Char.IsDigit) | false == txtMark5.Text.All(Char.IsDigit))
                {
                    return true; //return error
                }

                //if the marks are valid - less than 100 and more than 0 
                if (int.Parse(txtMark1.Text) > 100 | int.Parse(txtMark1.Text) < 0 | int.Parse(txtMark2.Text) > 100 | int.Parse(txtMark2.Text) < 0 | int.Parse(txtMark3.Text) > 100 | int.Parse(txtMark3.Text) < 0 | int.Parse(txtMark4.Text) > 100 | int.Parse(txtMark4.Text) < 0 | int.Parse(txtMark5.Text) > 100 | int.Parse(txtMark5.Text) < 0)
                {
                    return true; //return error 
                }
                else
                {
                    return false; //return no error
                }
            }
            catch
            {
         
                return true; //return error 
            }
          

           
        }
  

         //logout button 
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide this form
            
            frmLogin frmview = new frmLogin(); //create new login form and show that one
            frmview.Show();
        }
    }
}
