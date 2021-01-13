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

namespace Sport_ItemStock
{
    public partial class ItemDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sports;Integrated Security=True");
        //string connectionString = @"Data Source=(local);Initial Catalog=Sport;Integrated Security=True";
        DBConnection ObjdbConnection = new DBConnection();
        DataTable dtItems = new DataTable();
        DataSet ds = new DataSet();

        public ItemDetails()
        {
            InitializeComponent();
        }



        // Reset Button
        public void resetRecords()
        {

            textBox1.Clear();
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            button1.Text = "ADD";
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetRecords();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        // Load data
        private void ItemDetails_Load(object sender, EventArgs e)
        {
             comboBox2.SelectedIndex = 0;

             /*string query = " Select ItemCode,ItemName,Category,Brand,PurchasePrice,SellingPrice,Quantity,Description from Sport_Item";

             ObjdbConnection.readDatathroughAdapter(query,dtItems);

             dataGridView1.DataSource = dtItems;

             ObjdbConnection.closeConn();*/

            dis_data();

        }


        // This is for insert
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            String itemCode = textBox1.Text;
            String itemName = textBox2.Text;
            String category = comboBox2.Text;
            String brand = textBox4.Text;
            String purchasePrice = textBox5.Text;
            String sellingPrice = textBox6.Text;
            String quantity = textBox7.Text;
            String description = textBox8.Text;

                if (itemCode.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Code!!");
                }


                else if (itemName.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Name!!");
                }


                else if (category.Equals(""))
                {
                    MessageBox.Show("Please Select the Category!!");
                }


                else if (brand.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Brand!!");
                }


                else if (purchasePrice.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Purchasing Price!!");
                }


                else if (sellingPrice.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Selling Price!!");
                }


                else if (quantity.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Quantity!!");
                }


                else if (description.Equals(""))
                {
                    MessageBox.Show("Please Enter the brief description about Item !!");
                }

                else
                {
                    SqlCommand insertCommmand = new SqlCommand("insert into Sport_Item(ItemCode,ItemName,Category,Brand,PurchasePrice,SellingPrice,Quantity,Description) values(@itemCode,@itemName, @category, @brand, @purchasePrice, @sellingPrice, @quantity, @description)");

                    insertCommmand.Parameters.AddWithValue("@itemCode", itemCode);
                    insertCommmand.Parameters.AddWithValue("@itemName", itemName);
                    insertCommmand.Parameters.AddWithValue("@category", category);
                    insertCommmand.Parameters.AddWithValue("@brand", brand);
                    insertCommmand.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    insertCommmand.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                    insertCommmand.Parameters.AddWithValue("@quantity", quantity);
                    insertCommmand.Parameters.AddWithValue("@description", description);


                    int row = ObjdbConnection.executeQuery(insertCommmand);

                    //button4_Click(sender, e);

                    if (row == 1)
                    {
                        MessageBox.Show("Item Successfully Added!!:" + itemCode);

                        /*ItemDetails item = new ItemDetails();
                        item.Show();
                        this.Hide();*/
                        dis_data();


                        //button4_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error Occured.. Try Again!!");
                    }
                    button4_Click(sender, e);
                }

                //button4_Click(sender, e);
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error is: " + exp.ToString());
            }
        }

        public void dis_data()
        {
            con.Open();
            /*SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select ItemCode,ItemName,Category,Brand,PurchasePrice,SellingPrice,Quantity,Description from Sport_Item";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/

            SqlDataAdapter sda = new SqlDataAdapter("Select ItemCode, ItemName, Category, Brand, PurchasePrice, SellingPrice, Quantity, Description from Sport_Item", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();

            }
            con.Close();
        }





        // Read data
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Sports;Integrated Security=True");
            connection.Open();

            if (textBox1.Text != "")
            {
                SqlCommand command = new SqlCommand("select ItemName,Category,Brand,PurchasePrice,SellingPrice,Quantity,Description from Sport_Item where ItemCode = @ItemCode", connection);
                command.Parameters.AddWithValue("@ItemCode", textBox1.Text);
                SqlDataReader DbReader = command.ExecuteReader();
                while (DbReader.Read())
                {
                    textBox2.Text = DbReader.GetValue(0).ToString();
                    comboBox2.Text = DbReader.GetValue(1).ToString();
                    textBox4.Text = DbReader.GetValue(2).ToString();
                    textBox5.Text = DbReader.GetValue(3).ToString();
                    textBox6.Text = DbReader.GetValue(4).ToString();
                    textBox7.Text = DbReader.GetValue(5).ToString();
                    textBox8.Text = DbReader.GetValue(6).ToString();


                }
                connection.Close();
            }

        }


        // Update data
        private void button2_Click(object sender, EventArgs e)
        {
            try {

                string newItemCode = textBox1.Text;
                string newItemName = textBox2.Text;
                string newCategory = comboBox2.Text;
                string newBrand = textBox4.Text;
                string newPurchasePrice = textBox5.Text;
                string newSellingPrice = textBox6.Text;
                string newQuantity = textBox7.Text;
                string newDescription = textBox8.Text;

                /* if (newItemCode.Equals(""))
                 {
                     MessageBox.Show("Please Enter the Item Code!!");
                 }*/


                if (newItemName.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Name!!");
                }


                else if (newCategory.Equals(""))
                {
                    MessageBox.Show("Please Select the Category!!");
                }


                else if (newBrand.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Brand!!");
                }


                else if (newPurchasePrice.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Purchasing Price!!");
                }

                else if (newSellingPrice.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Selling Price!!");
                }


                else if (newQuantity.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Quantity!!");
                }


                else if (newDescription.Equals(""))
                {
                    MessageBox.Show("Please Enter the brief description about Item !!");
                }
                else
                {
                    string query = "update Sport_Item set ItemName='" + @newItemName + "', Category='" + @newCategory + "', Brand='" + @newBrand + "',PurchasePrice='" + @newPurchasePrice + "',SellingPrice='" + @newSellingPrice + "',Quantity='" + @newQuantity + "',Description = '" + @newDescription + "' where ItemCode='" + @newItemCode + "'";

                    SqlCommand updateCommand = new SqlCommand(query);

                    updateCommand.Parameters.AddWithValue("@itemCode", @newItemCode);
                    updateCommand.Parameters.AddWithValue("@itemName", @newItemName);
                    updateCommand.Parameters.AddWithValue("@category", @newCategory);
                    updateCommand.Parameters.AddWithValue("@brand", @newBrand);
                    updateCommand.Parameters.AddWithValue("@purchasePrice", @newPurchasePrice);
                    updateCommand.Parameters.AddWithValue("@sellingPrice", @newSellingPrice);
                    updateCommand.Parameters.AddWithValue("@quantity", @newQuantity);
                    updateCommand.Parameters.AddWithValue("@description", @newDescription);


                    int row = ObjdbConnection.executeQuery(updateCommand);

                    if (row == 1)
                    {
                        MessageBox.Show("Item Successfully Updated!!");
                        /*ItemDetails item = new ItemDetails();
                        item.Show();
                        this.Hide();*/
                        dis_data();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured.. Try Again!!");
                    }
                    button4_Click(sender, e);
                }
            } catch (System.Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }


    

        // Delete data
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure??", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog == DialogResult.Yes)
            {
                string itemCode = textBox1.Text;
                string query = " delete from Sport_Item where ItemCode ='" + itemCode + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = ObjdbConnection.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Item Successfully Deleted!!");
                    /*ItemDetails item = new ItemDetails();
                    item.Show();
                    this.Hide();*/
                    dis_data();

                }
                else
                {
                    MessageBox.Show("Error Occured.. Try Again!!");
                }

                button4_Click(sender, e);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
             {
                 e.Handled = false;
             }
             else
             {
                 MessageBox.Show("Please enter only numbers!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 e.Handled = true;
             }*/

            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }



        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
             {
                 e.Handled = true;
             }

           

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
             {
                 e.Handled = true;
             }*/


            if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter only numbers!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

       /*private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
                {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click fetch");
            }
        }*/

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please click fetch");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select ItemCode, ItemName, Category, Brand, PurchasePrice, SellingPrice, Quantity, Description from Sport_Item where Category like '%"+textBox3.Text.ToString()+"%'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();

            }
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "C007";
            textBox2.Text = "Basketball";
            //comboBox2.Text = 
            textBox4.Text = "Adidas";
            textBox5.Text = "1000.00";
            textBox6.Text = "1500.00";
            textBox7.Text = "20";
            textBox8.Text = "Good";
        }
    }

 }
    

