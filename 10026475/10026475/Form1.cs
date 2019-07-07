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

namespace _10026475
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = true;
           
            if(textBox1.Text == "")
            {
                check = false;
                MessageBox.Show("Please Fill Required Fields");
            }
            else if(textBox2.Text == "" || textBox3.Text == "")
            {
                check = false;
                MessageBox.Show("Please Fill The Details");
            }
            if(check == true)
            {
                SqlConnection x = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\10026475\Library.mdf;Integrated Security=True;Connect Timeout=30");
                x.Open();
                try
                {
                    string qry = "INSERT INTO Book VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    SqlCommand ab = new SqlCommand(qry, x);
                    ab.ExecuteNonQuery();
                    MessageBox.Show("Book Added");
                }

                catch (Exception)
                {
                    MessageBox.Show("This book was already added");
                }
            }
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (textBox1.Text == "")
            {
                check = false;
                MessageBox.Show("Please Fill Required Fields");
            }
            else if (textBox2.Text == "" || textBox3.Text == "")
            {
                check = false;
                MessageBox.Show("Please Fill The Details");
            }
            if (check == true)
            {
                SqlConnection x = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\10026475\Library.mdf;Integrated Security=True;Connect Timeout=30");
                x.Open();
                string qry = "UPDATE Book SET ISBN = '" + textBox1.Text + "', Name = '" + textBox2.Text + "' , Author = '" + textBox3.Text + "'  WHERE ISBN = '" + textBox1.Text + "'";
                SqlCommand cd = new SqlCommand(qry, x);
                cd.ExecuteNonQuery();
                MessageBox.Show("Book Updated");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (textBox1.Text == "")
            {
                check = false;
                MessageBox.Show("Please Fill Required Fields");
            }
            if (check == true)
            {
                SqlConnection x = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\10026475\Library.mdf;Integrated Security=True;Connect Timeout=30");
                x.Open();
                string qry = "DELETE FROM Book WHERE  ISBN = '" + textBox1.Text + "'";
                SqlCommand ef = new SqlCommand(qry, x);
                ef.ExecuteNonQuery();
                MessageBox.Show("Book Deleted");
            }
        }
    }
}
