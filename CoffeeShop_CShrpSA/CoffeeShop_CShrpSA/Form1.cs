using DotLiquid.Tags;
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
using System.IO;

namespace CoffeeShop_CShrpSA
{
   

    public partial class MainWindow : Form
    {
        String typeOfCoffee;
        int quantity;
        String addedIngredients;
        String sizeOfCoffee;
        double price;
        String strPrice;
        DataTable dbdataset;
        int numRows;
        class Order
        {
            String coffeeType = "";
            float price = 0;
            String sizeOfCoffee = "";
            int quantity = 0;
            String addedIngredients = "";
            Order(String coffeeType, float price, String sizeOfCoffee, int quantity, String addedIngredients)
            {
                this.coffeeType = coffeeType;
                this.price = price;
                this.sizeOfCoffee = sizeOfCoffee;
                this.quantity = quantity;
                this.addedIngredients = addedIngredients;
            }
            public virtual double TotalOrderSummary(double price, int quantity)
            {
                return price * quantity;
            }
            public virtual String TotalOrderSummary()
            {
                String text = quantity + " | " + coffeeType + ", " + sizeOfCoffee + ", " + addedIngredients + " | " + price + " | " + TotalOrderSummary(price, quantity);
                return text;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDBDataSet.SalesTable' table. You can move, or remove it, as needed.
            this.salesTableTableAdapter.Fill(this.coffeeShopDBDataSet.SalesTable);
            numRows = dataGridView1.Rows.Count;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdBtn_Small_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfCoffee = "Small";
        }

        private void rdBtn_Medium_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfCoffee = "Medium";
        }

        private void rdBtn_Large_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfCoffee = "Large";
        }

        private void chkBox_Sugar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            typeOfCoffee = comboBox_SelectCoffee.Text;
            quantity = Convert.ToInt32(comboBox_SelectQuantity.Text);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LIUUGOS;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            if (sizeOfCoffee == "Small")
            {
                SqlCommand command = new SqlCommand("select Small_Price from CoffeePriceTable where Coffee_Type = '"+typeOfCoffee+"'", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    strPrice = reader["Small_Price"].ToString();
                    price = Convert.ToDouble(strPrice);                   
                    strPrice = price.ToString();
                    
                }
                reader.Close();
            }
            else if (sizeOfCoffee == "Medium")
            {
                SqlCommand command = new SqlCommand("select Medium_Price from CoffeePriceTable where Coffee_Type = '" + typeOfCoffee + "'", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    strPrice = reader["Medium_Price"].ToString();
                    price = Convert.ToDouble(strPrice);
                    strPrice = price.ToString();
                    
                }
                reader.Close();
            }
            else if (sizeOfCoffee == "Large")
            {
                SqlCommand command = new SqlCommand("select Large_Price from CoffeePriceTable where Coffee_Type = '" + typeOfCoffee + "'", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    strPrice = reader["Large_Price"].ToString();
                    price = Convert.ToDouble(strPrice);
                    strPrice = price.ToString();
                    
                }
                reader.Close();
            }


            if (chkBox_Sugar.Checked && chkBox_Cream.Checked)
            {
                addedIngredients = "Sugar and Cream";
            }
            else if (chkBox_Sugar.Checked)
            {
                addedIngredients = "Sugar";
            }
            else if (chkBox_Cream.Checked)
            {
                addedIngredients = "Cream";
            }
            
            txt_OrderSummary.Text = DTPick_managementTab.Value+"   \t\t\t\t  Qtitiy    | Description                     | Price     | Total         \t  "+ quantity + "            " + typeOfCoffee +"          \t       "+ price + "            "+(price*quantity);
            
        }

        private void DTPick_managementTab_ValueChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LIUUGOS;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from SalesTable where date = '"+DTPick_managementTab.Value.ToString("yyyy/MM/dd")+"'", con);
            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            //DataView DV = new DataView(dbdataset);
            //DV.RowFilter = string.Format("Date LIKE '%{0}%'", DTPick_managementTab.Text);
            //dataGridView1.DataSource = DV;
        }

        private void btn_b3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LIUUGOS;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from SalesTable",con);
            this.Hide();
            Validation f2 = new Validation();
            f2.ShowDialog();
            this.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //save data to database
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LIUUGOS;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            con.Open();
                   
            String maxId = Convert.ToString(numRows);
 
            SqlCommand command = new SqlCommand("insert into SalesTable(Id_Sale, Quantity, Description, Price, Total, date) values (@Id_Sale, @Quantity, @Description, @Price, @Total, @date)", con);
            command.Parameters.AddWithValue("@Id_Sale", numRows);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Description", typeOfCoffee);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Total", price * quantity);
            command.Parameters.AddWithValue("@date", DTPick_managementTab.Value.ToString("yyyy/MM/dd"));
            command.ExecuteNonQuery();
            MessageBox.Show("Info Saved Successfully");
            con.Close();
        }

        private void printDataGridView_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printDataGridViewDocumentBitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(printDataGridViewDocumentBitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(printDataGridViewDocumentBitmap, 0, 0);          
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount < 2)
            {
                MessageBox.Show("Cannot print a blank page");
            }
            else
            {
                PrintDialog printDataGridViewDocumentPrintDialog = new PrintDialog();
                printDataGridViewDocumentPrintDialog.Document = printDataGridView;
                DialogResult printDataGridViewDialogResult = printDataGridViewDocumentPrintDialog.ShowDialog();
            }
            
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("C:/Users/Vidor/source/repos/CoffeeShop_CShrpSA/CoffeeShop_CShrpSA/Resources/BackUpSale.txt"))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dataGridView1.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
            this.Hide();
            Validation f2 = new Validation();
            f2.ShowDialog();
            this.Close();
        }
    }
}
