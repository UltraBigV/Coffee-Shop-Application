using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_CShrpSA
{
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String password = textBox2.Text;
            Boolean check = true;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LIUUGOS;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            SqlCommand command = new SqlCommand("select Username, Password from ManagerTable",con);
            
            con.Open();
           
                
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    String dbUsername = reader["Username"].ToString();
                    //MessageBox.Show(dbUsername);
                    String dbPassword = reader["Password"].ToString();
                    //MessageBox.Show(dbPassword);
                    if (userName == dbUsername && password == dbPassword)
                    {
                        reader.Close();
                        this.Hide();
                        MainWindow f1 = new MainWindow();
                        f1.ShowDialog();
                        this.Close();
                        break;
                                              
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password try again");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                        break;
                        
                      
                    }
                }
                
            
           

        }
    }
}
