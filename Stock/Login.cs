using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=stock_f;Integrated Security=True");


        private void Login_Load(object sender, EventArgs e)
        {

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


        // CRYPT PASSWORD
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

        private void lklb_to_signup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 sg = new Form1();
            sg.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            String email = txtB_LEmail.Text;
            String password = txtB_LPassword.Text;
            if (email != "" && password != "")
            {
                bool validEmail = IsValidEmail(email);
                if (validEmail)
                {
                    password = MD5Hash(password);
                    String query = "SELECT count(*) FROM users  WHERE u_email = '" + email + "' AND u_password = '" + password + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int countLog = Convert.ToInt32(cmd.ExecuteScalar());

                    if (countLog == 1)
                    {
                        try
                        {

                            //MessageBox.Show(countLog.ToString());
                            String selectLog = "SELECT u_id,u_role,u_name FROM users WHERE u_email ='" + email + "' ";
                            SqlCommand cmdLog = new SqlCommand(selectLog, con);
                            SqlDataReader results = cmdLog.ExecuteReader();
                            results.Read();
                            String uId = results["u_id"].ToString();
                            String uRole = results["u_role"].ToString();
                            String uName = results["u_name"].ToString();
                            //MessageBox.Show(uId+" "+uRole);
                            Loginfo.logId = uId;
                            Loginfo.logRole = uRole;
                            Loginfo.logName = uName;

                            if (Loginfo.logRole.Equals("Admin") || Loginfo.logRole.Equals("Manager"))
                            {
                                Dashboard std = new Dashboard();
                                std.Show();
                                this.Hide();
                            }
                            else
                            {
                                DashboardS dhs = new DashboardS();
                                dhs.Show();
                                this.Hide();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("User not found!!!");
                    }


                }
                else
                {
                    lbl_errorMessage.Text = "Wrong email Format";
                }
            }
            else
            {
                lbl_errorMessage.Text = "Fillout all the above textfield !!";
            }

            con.Close();
        }

        private void chB_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_showPassword.Checked == true)
            {
                txtB_LPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtB_LPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
