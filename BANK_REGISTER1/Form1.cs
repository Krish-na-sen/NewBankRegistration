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

namespace BANK_REGISTER1
{
    public partial class REGISTER1 : Form
    {

        dbAccess objDbAccess = new dbAccess();
        public REGISTER1()
        {
            InitializeComponent();
        }

        private void REGISTER1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string customerName = txtCustomerName.Text;
            string age = txtAge.Text;
            string gender = txtGender.Text;
            string address = txtAddress.Text;
            string phoneNo = txtPhoneNo.Text;
            string accountType = txtAccountType.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string pincode = txtPincode.Text;
            string password = txtPassword.Text;
            string confirmPassword =txtConfirmPassword.Text;



            if (customerName.Equals(""))
                {
                MessageBox.Show("please enter customer name");
                    }

           else if (age.Equals(""))
            {
                MessageBox.Show("please enter age");
            }
           else if (gender.Equals(""))
            {
                MessageBox.Show("please enter gender");
            }
           else if (address.Equals(""))
            {
                MessageBox.Show("please enter address");
            }
         else  if (phoneNo.Equals(""))
            {
                MessageBox.Show("please enter phone no");
            }
            else if (accountType.Equals(""))
            {
                MessageBox.Show("please enter account type");
            }

            else if (city.Equals(""))
            {
                MessageBox.Show("please enter city");
            }
            else if (state.Equals(""))
            {
                MessageBox.Show("please enter state");
            }
            else if (pincode.Equals(""))
            {
                MessageBox.Show("please enter pincode");
            }
           else if (password.Equals(""))
            {
                MessageBox.Show("please enter password");
            }
           else if(confirmPassword.Equals(""))
            {
                MessageBox.Show("please enter confirm password");
            
            }

            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("password do not match");
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into CUSSTOMER_REGISTRATION1(CUSTOMER_NAME,AGE,GENDER,ADDRESS,PHONE_NO,ACCOUNT_TYPE,CITY,STATE,PINCODE,PASSWORD) values(@customerName,@age,@gender,@address,@phoneNo,@accountType,@city,@state,@pincode,@password)");

                insertCommand.Parameters.AddWithValue("@customerName", customerName);
                insertCommand.Parameters.AddWithValue("@age", age);
                insertCommand.Parameters.AddWithValue("@gender", gender);
                insertCommand.Parameters.AddWithValue("@address",address ); 
                insertCommand.Parameters.AddWithValue("@phoneNo", phoneNo); ;
                insertCommand.Parameters.AddWithValue("@accountType", accountType);
                insertCommand.Parameters.AddWithValue("@city", city);
                insertCommand.Parameters.AddWithValue("@state", state);
                insertCommand.Parameters.AddWithValue("@pincode", pincode);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@confirmPassword", confirmPassword);


                int row = objDbAccess.executeQuery(insertCommand);
                if(row==1)
                {
                    MessageBox.Show("Account created successfully");

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();


                }
                else
                {
                    MessageBox.Show("Error Occured.Try Again!!");
                }

            }
            
        }
    }
}
