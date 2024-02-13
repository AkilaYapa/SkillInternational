using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillInternationalWinFormApp
{
    public partial class RegisterForm : Form
    {

        DBAccess objDBAccess = new DBAccess();
        DataTable regNoDtTable = new DataTable();
        DataTable regDtTable = new DataTable();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxRegNo.SelectedIndexChanged -= comboBoxRegNo_SelectedIndexChanged;
            string query = "Select regNo from Registration";
            objDBAccess.readDatathroughAdapter(query, regNoDtTable);

            if (regNoDtTable.Rows.Count > 0)
            {
                comboBoxRegNo.DataSource = regNoDtTable;
                comboBoxRegNo.DisplayMember = "regNo";
                comboBoxRegNo.SelectedItem = null;
                comboBoxRegNo.SelectedIndex = -1;
                comboBoxRegNo.SelectedText = "--Select a RegNo--";
            }
            comboBoxRegNo.SelectedIndexChanged += comboBoxRegNo_SelectedIndexChanged;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fName = txtFname.Text;
            string lName = txtLname.Text;
            string birthDate = dateTimePickerBirth.Value.ToString();
            string gender = "";
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string mobileNo = txtMobile.Text;
            string homeNo =txtHome.Text;
            string parentName = txtParentName.Text;
            string nic = txtParentNIC.Text;
            string contact = txtParentContact.Text;
           
            if (radiobtnMale.Checked == true)
            {
                gender = radiobtnMale.Text;
            }
            if (radiobtnFemale.Checked == true)
            {
                gender = radiobtnFemale.Text;
            }

            if (fName.Equals(""))
            {
                MessageBox.Show("Please Enter your First Name.");
            }
            else if (lName.Equals(""))
            {
                MessageBox.Show("Please Enter your Last Name.");
            }
            else if (mobileNo.Equals(""))
            {
                MessageBox.Show("Please Enter Mobile Number");
            }
            else if (homeNo.Equals(""))
            {
                MessageBox.Show("Please Enter Home Number");
            }
            else if (contact.Equals(""))
            {
                MessageBox.Show("Please Enter Parent Contact");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Registration(firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo) values(@fName,@lName,@birthDate,@gender,@address,@email,@mobileNo,@homeNo,@parentName,@nic,@contact)");

                insertCommand.Parameters.AddWithValue("@fName",fName);
                insertCommand.Parameters.AddWithValue("@lName", lName);
                insertCommand.Parameters.AddWithValue("@birthDate", birthDate);
                insertCommand.Parameters.AddWithValue("@gender", gender);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@mobileNo", Convert.ToInt64(mobileNo));
                insertCommand.Parameters.AddWithValue("@homeNo", Convert.ToInt64(homeNo));
                insertCommand.Parameters.AddWithValue("@parentName", parentName);
                insertCommand.Parameters.AddWithValue("@nic", nic);
                insertCommand.Parameters.AddWithValue("@contact", Convert.ToInt64(contact));

                int row = objDBAccess.executeQuery(insertCommand);

                if (row > 0)
                {
                    MessageBox.Show("Record Added Succesfully","Register Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Error occured, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegNo.SelectedIndex > -1)
            {
                regDtTable.Clear();
                int regNo = Convert.ToInt32(regNoDtTable.Rows[comboBoxRegNo.SelectedIndex]["regNo"]);
                string query = "Select * from Registration Where regNo ="+regNo+"";
                objDBAccess.readDatathroughAdapter(query, regDtTable);

                if(regDtTable.Rows.Count > 0)
                {
                    txtFname.Text = regDtTable.Rows[0]["firstName"].ToString();
                    txtLname.Text = regDtTable.Rows[0]["lastName"].ToString();
                    dateTimePickerBirth.Value = Convert.ToDateTime(regDtTable.Rows[0]["dateOfBirth"]);
                    txtAddress.Text = regDtTable.Rows[0]["address"].ToString();
                    txtEmail.Text = regDtTable.Rows[0]["email"].ToString();
                    txtMobile.Text = regDtTable.Rows[0]["mobilePhone"].ToString();
                    txtHome.Text = regDtTable.Rows[0]["homePhone"].ToString();
                    txtParentName.Text = regDtTable.Rows[0]["parentName"].ToString();
                    txtParentNIC.Text = regDtTable.Rows[0]["nic"].ToString();
                    txtParentContact.Text = regDtTable.Rows[0]["contactNo"].ToString();

                    if (regDtTable.Rows[0]["gender"].ToString().Equals("Male"))
                    {
                        radiobtnMale.Checked = true;
                    }
                    else if (regDtTable.Rows[0]["gender"].ToString().Equals( "Female"))
                    {
                        radiobtnFemale.Checked = true;
                    }
                    else
                    {
                        radiobtnMale.Checked = false;
                        radiobtnFemale.Checked = false;
                    }
                }
            }           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (regDtTable.Rows.Count > 0)
            {
                string fName = txtFname.Text;
                string lName = txtLname.Text;
                string birthDate = dateTimePickerBirth.Value.ToString();
                string gender = "";
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                int mobileNo = Convert.ToInt32(txtMobile.Text);
                int homeNo = Convert.ToInt32(txtHome.Text);
                string parentName = txtParentName.Text;
                string nic = txtParentNIC.Text;
                int contact = Convert.ToInt32(txtParentContact.Text);

                if (radiobtnMale.Checked == true)
                {
                    gender = radiobtnMale.Text;
                }
                if (radiobtnFemale.Checked == true)
                {
                    gender = radiobtnFemale.Text;
                }

                if (fName.Equals(""))
                {
                    MessageBox.Show("Please Enter your First Name.");
                }
                else if (lName.Equals(""))
                {
                    MessageBox.Show("Please Enter your Last Name.");
                }
                int regNo = Convert.ToInt32(regNoDtTable.Rows[comboBoxRegNo.SelectedIndex]["regNo"]);
                string query = "Update Registration SET firstName = '" + @fName + "', lastName = '" + @lName + "',dateOfBirth= '" + @birthDate + "',address= '" + @address + "',email= '" + @email + "',mobilePhone=" + @mobileNo + ",homePhone=" + @homeNo + ",parentName='" + @parentName + "',nic='" + @nic + "',contactNo=" + @contact + ",gender='" + @gender + "' where regNo =" + @regNo + "";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@fName", fName);
                updateCommand.Parameters.AddWithValue("@lName", lName);
                updateCommand.Parameters.AddWithValue("@birthDate", birthDate);
                updateCommand.Parameters.AddWithValue("@gender", gender);
                updateCommand.Parameters.AddWithValue("@address", address);
                updateCommand.Parameters.AddWithValue("@email", email);
                updateCommand.Parameters.AddWithValue("@mobileNo", mobileNo);
                updateCommand.Parameters.AddWithValue("@homeNo", homeNo);
                updateCommand.Parameters.AddWithValue("@parentName", parentName);
                updateCommand.Parameters.AddWithValue("@nic", nic);
                updateCommand.Parameters.AddWithValue("@contact", contact);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row > 0)
                {
                    MessageBox.Show("Record Updated Succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Error occured, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            dateTimePickerBirth.Value = DateTime.Now;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtHome.Text = "";
            txtParentName.Text = "";
            txtParentNIC.Text = "";
            txtParentContact.Text = "";

            radiobtnMale.Checked = false;
            radiobtnFemale.Checked = false;

            comboBoxRegNo.SelectedItem = null;
            comboBoxRegNo.SelectedText = "--Select a RegNo--";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int regNo = Convert.ToInt32(regNoDtTable.Rows[comboBoxRegNo.SelectedIndex]["regNo"]);
            if (regDtTable.Rows.Count>0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure, Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE from Registration where regNo = "+ regNo + "";

                    SqlCommand deleteCommand = new SqlCommand(query);

                    int row = objDBAccess.executeQuery(deleteCommand);

                    if (row > 0)
                    {
                        MessageBox.Show("Record Deleted Succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Error occured, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
