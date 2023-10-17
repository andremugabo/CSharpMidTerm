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
using System.Security.Cryptography;
using System.Net.Mail;


namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=stock_f;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }


        // VALIDATE EMAIL

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        

        

        private void lklb_to_login_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String names = txtB_names.Text;
            String email = txtB_email.Text;
            String password = txtB_password.Text;
            String role = cBox_role.Text;
            con.Open();

            if (names != "" && email != "" && password != "" && role != "")
            {
                password = MD5Hash(password);
                //MessageBox.Show(password);
                bool isValidEmail = IsValidEmail(email);
                // MessageBox.Show(isValidEmail.ToString());

                if (isValidEmail)
                {
                    String checkIfExistEmail = "SELECT count(*) FROM users where u_email = '" + email + "' ";
                    SqlCommand cmdCheckmail = new SqlCommand(checkIfExistEmail, con);
                    int howManyTimeEmail = Convert.ToInt32(cmdCheckmail.ExecuteScalar());

                    if (howManyTimeEmail == 0)
                    {
                        try
                        {
                            String query = "INSERT INTO users(u_name,u_email,u_password,u_role) VALUES('" + names + "','" + email + "','" + password + "','" + role + "')";
                            SqlCommand cmdCreate_st = new SqlCommand(query, con);
                            cmdCreate_st.ExecuteNonQuery();
                            MessageBox.Show("User with  " + email + " Created");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        lbl_error_message.Text = "Sorry User WITH " + email + " Allready Exist !! Login";
                    }
                }
                else
                {
                    lbl_error_message.Text = "Wrong email format !!";
                }
            }
            else
            {
                lbl_error_message.Text = "Fill out the above text field !!";
            }
            con.Close();

        }

        private void chB_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chB_showPassword.Checked == true)
            {
                txtB_password.UseSystemPasswordChar = false;
            }
            else
            {

                txtB_password.UseSystemPasswordChar = true;
            }
        }
    }
}
