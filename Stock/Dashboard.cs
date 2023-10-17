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

namespace Stock
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=stock_f;Integrated Security=True");


        public void fetchProducts()
        {
            // create a tunnel to the db
            String query = "SELECT * from foods";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //create dataset to store your data
            DataSet ds = new DataSet();
            sda.Fill(ds, "foods");
            // display data
            dataGridV_products.AutoGenerateColumns = false;
            dataGridV_products.DataSource = ds.Tables["foods"];

        }





        private void btn_product_Click(object sender, EventArgs e)
        {
            String p_name = txt_pname.Text;
            int p_qty = Convert.ToInt32(txt_pqty.Text);
            double p_price =Convert.ToDouble(txt_price.Text);
            String dateEx = date_expir.Text;

            if(p_name != "" && p_qty != 0 && p_price != 0 && dateEx != null)
            {
                con.Open();
                String query = "select * from foods where p_name = '" + p_name + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                //MessageBox.Show(dateEx);
                if (count == 0)
                {
                   String insert =  "INSERT INTO foods(p_name,p_qty,p_price) VALUES('" + p_name + "','" + p_qty + "','" + p_price + "')";
                    SqlCommand insr = new SqlCommand(insert,con);
                    insr.ExecuteNonQuery();
                    MessageBox.Show("Product named  " +p_name + " Created");
                    fetchProducts();

                }
                else
                {
                    MessageBox.Show("Product already exist !!");

                }


            }


            




        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            fetchProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
