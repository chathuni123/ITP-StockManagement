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
    public partial class Stock_Details : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sports;Integrated Security=True");
        DBConnection dbConnection = new DBConnection();
        DataTable dtItems = new DataTable();
        public Stock_Details()
        {
            InitializeComponent();
        }


        // Load data
        private void Stock_Details_Load(object sender, EventArgs e)
        {
             //this.ActiveControl = dateTimePicker1;
             comboBox1.SelectedIndex = 0;

             /*string query = " Select RecordID,ItemCode,ItemName,InitialQuantity,StockIn,StockOut,FinalQuantity,Status,Date from Stock_InOut";

             dbConnection.readDatathroughAdapter(query, dtItems);

             dataGridView1.DataSource = dtItems;
             dbConnection.closeConn();*/

            dis_data();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox1.TextLength > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox1.Focus();
                }
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox2.TextLength > 0)
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox3.TextLength > 0)
                {
                    textBox4.Focus();
                }
                else
                {
                    textBox3.Focus();
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox4.TextLength > 0)
                {
                    textBox5.Focus();
                }
                else
                {
                    textBox4.Focus();
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox5.TextLength > 0)
                {
                    textBox6.Focus();
                }
                else
                {
                    textBox5.Focus();
                }
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox6.TextLength > 0)
                {
                    textBox7.Focus();
                }
                else
                {
                    textBox6.Focus();
                }
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keys.KeyCode == Keys.Enter)
            {
                if (textBox7.TextLength > 0)
                {
                    comboBox1.Focus();
                }
                else
                {
                    textBox7.Focus();
                }
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keys.KeyCode == Keys.Enter)
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    button1.Focus();
                }
                else
                {
                    comboBox1.Focus();
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = false;
            }
            else
            {

                MessageBox.Show("Please enter only numbers !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = false;
            }
            else
            {

                MessageBox.Show("Please enter only numbers !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }*/

            if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = false;
            }
            else
            {

                MessageBox.Show("Please enter only numbers !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.' )
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter only numbers !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

          /* if(char.IsNumber(e.KeyChar) || e.KeyChar >= 30)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter only numbers !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }*/

          
        }


        // Reset Data
        public void resetRecords()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            button1.Text = "ADD";
            //dateTimePicker1.Focus();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetRecords();
        }


        // insert data
        private void button1_Click(object sender, EventArgs e)
        {
            

            int initialStock, stockIn, stockOut, finalStock;
            String RecordID, itemCode, itemName, status, date;

            initialStock = int.Parse(textBox4.Text);
            stockIn = int.Parse(textBox5.Text);
            stockOut = int.Parse(textBox6.Text);
            //finalStock = int.Parse(textBox7.Text);

            RecordID = (textBox1.Text);
            itemCode = (textBox2.Text);
            itemName = (textBox3.Text);
            status = comboBox1.Text;
            date = dateTimePicker1.Text;

            finalStock = ((initialStock + stockIn) - stockOut);
            textBox7.Text = " " + finalStock;


                if (RecordID.Equals(""))
                {

                    MessageBox.Show("Please Enter the Record ID!!");
                    
                }
                
                else if (itemCode.Equals(""))
                {
                    MessageBox.Show("Please Select the Item Code!!");
                   
                }


                else if (itemName.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Name!!");
                }


                else if (initialStock.Equals(""))
                {
                    MessageBox.Show("Please Enter the Initial Stock!!");
                }


                else if (stockIn.Equals(""))
                {
                    MessageBox.Show("Please Enter how many items come to the stock!!");
                }


                else if (stockOut.Equals(""))
                {
                    MessageBox.Show("Please Enter how many items out from the stock!!");
                }


               /* else if (finalStock.Equals(""))
                {
                    MessageBox.Show("Please Enter the final stock!!");
                }*/

               /* else if(finalStock.Equals("<=30"))
                {
                    MessageBox.Show("Stock is reduced!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }*/


                else if (status.Equals(""))
                {
                    MessageBox.Show("Please Enter the current status!!");
                }

                else if (date.Equals(""))
                {
                    MessageBox.Show("Please Enter the date!!");
                }


                else
                {


                    SqlCommand insertCommand = new SqlCommand("insert into Stock_InOut(RecordID,ItemCode,ItemName,InitialQuantity,StockIn,StockOut,FinalQuantity,Status,Date) values(@RecordID,@itemCode,@itemName,@initialStock,@stockIn,@stockOut,@finalStock,@status,@date)");



                    insertCommand.Parameters.AddWithValue("@RecordID", RecordID);
                    insertCommand.Parameters.AddWithValue("@itemCode", itemCode);
                    insertCommand.Parameters.AddWithValue("@itemName", itemName);
                    insertCommand.Parameters.AddWithValue("@initialStock", initialStock);
                    insertCommand.Parameters.AddWithValue("@stockIn", stockIn);
                    insertCommand.Parameters.AddWithValue("@stockOut", stockOut);
                    insertCommand.Parameters.AddWithValue("@finalStock", finalStock);
                    insertCommand.Parameters.AddWithValue("@status", status);
                    insertCommand.Parameters.AddWithValue("@date", date);

                    int row = dbConnection.executeQuery(insertCommand);

                    if (row == 1)
                    {
                        MessageBox.Show("Details Successfully Added!!" + RecordID);
                        /*Stock_Details stck = new Stock_Details();
                        stck.Show();
                        this.Hide();*/
                        dis_data();

                    }
                    else
                    {
                        MessageBox.Show("Error Occured.. Try Again!!");
                    }

                      button4_Click( sender, e);
                }

          
        }


        public void dis_data()
        {
            con.Open();
           

            SqlDataAdapter sda = new SqlDataAdapter("Select RecordID,Date,ItemCode,ItemName,InitialQuantity,StockIn,StockOut,FinalQuantity,Status from Stock_InOut", con);

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
                dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();

            }
            con.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Sports;Integrated Security=True");
            connection.Open();

            if (textBox1.Text != "")
            {
                SqlCommand command = new SqlCommand("select Date,ItemCode,ItemName,InitialQuantity,StockIn,StockOut,FinalQuantity,Status from Stock_InOut where RecordID = @RecordID", connection);
                command.Parameters.AddWithValue("@RecordID", textBox1.Text);
                SqlDataReader DbReader = command.ExecuteReader();
                while (DbReader.Read())
                {
                    dateTimePicker1.Text = DbReader.GetValue(0).ToString();
                    textBox2.Text = DbReader.GetValue(1).ToString();
                    textBox3.Text = DbReader.GetValue(2).ToString();
                    textBox4.Text = DbReader.GetValue(3).ToString();
                    textBox5.Text = DbReader.GetValue(4).ToString();
                    textBox6.Text = DbReader.GetValue(5).ToString();
                    textBox7.Text = DbReader.GetValue(6).ToString();

                    comboBox1.Text = DbReader.GetValue(7).ToString();
                    //dateTimePicker1.Text = DbReader.GetValue(7).ToString();

                }
                connection.Close();
            }
        }


        // update data

        private void button2_Click(object sender, EventArgs e)
        {
            // try
            //  {


            /* string newRecordID = textBox1.Text;
             string newItemCode = textBox2.Text;
             string newItemName = textBox3.Text;
             string newInitialQuantity = textBox4.Text;
             string newStockIn = textBox5.Text;
             string newStockOut = textBox6.Text;
             string newFinalQuantity = textBox7.Text;
             string newStatus = comboBox1.Text;
             string newDate = dateTimePicker1.Text;*/


            int newInitialQuantity, newStockIn, newStockOut, newFinalQuantity;
            String newRecordID, newItemCode, newItemName, newStatus, newDate;

            newInitialQuantity = int.Parse(textBox4.Text);
            newStockIn = int.Parse(textBox5.Text);
            newStockOut = int.Parse(textBox6.Text);
            //finalStock = int.Parse(textBox7.Text);

            newRecordID = (textBox1.Text);
            newItemCode = (textBox2.Text);
            newItemName = (textBox3.Text);
            newStatus = comboBox1.Text;
            newDate = dateTimePicker1.Text;

            newFinalQuantity = ((newInitialQuantity + newStockIn) - newStockOut);
            textBox7.Text = " " + newFinalQuantity;



            if (newItemCode.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Code!!");
                }


                else if (newItemName.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item Name!!");
                }


                else if (newInitialQuantity.Equals(""))
                {
                    MessageBox.Show("Please Enter the initial stock!!");
                }


                else if (newStockIn.Equals(""))
                {
                    MessageBox.Show("Please Enter the item in to the stock!!");
                }


                else if (newStockOut.Equals(""))
                {
                    MessageBox.Show("Please Enter the Item out from the stock!!");
                }


                else if (newFinalQuantity.Equals(""))
                {
                    MessageBox.Show("Please Enter the final item stock!!");
                }


                else if (newStatus.Equals(""))
                {
                    MessageBox.Show("Please Select the status!!");
                }


                else if (newDate.Equals(""))
                {
                    MessageBox.Show("Please Enter the correct date!!");
                }
                else
                {
                    string query = "update Stock_InOut set ItemCode='" + @newItemCode + "', ItemName='" + @newItemName + "',InitialQuantity='" + @newInitialQuantity + "',StockIn='" + @newStockIn + "',StockOut='" + @newStockOut + "',FinalQuantity = '" + @newFinalQuantity + "',Status = '" + @newStatus + "',Date = '" + @newDate + "' where RecordID='" + @newRecordID + "'";

                    SqlCommand updateCommand = new SqlCommand(query);

                    updateCommand.Parameters.AddWithValue("@RecordID", @newRecordID);
                    updateCommand.Parameters.AddWithValue("@itemCode", @newItemCode);
                    updateCommand.Parameters.AddWithValue("@itemName", @newItemName);
                    updateCommand.Parameters.AddWithValue("@InitialQuantity", @newInitialQuantity);
                    updateCommand.Parameters.AddWithValue("@StockIn", @newStockIn);
                    updateCommand.Parameters.AddWithValue("@StockOut", @newStockOut);
                    updateCommand.Parameters.AddWithValue("@FinalQuantity", @newFinalQuantity);
                    updateCommand.Parameters.AddWithValue("@Status", @newStatus);
                    updateCommand.Parameters.AddWithValue("@Date", @newDate);


                    int row = dbConnection.executeQuery(updateCommand);

                    if (row == 1)
                    {
                        MessageBox.Show("Details Successfully Updated!!");
                        /*Stock_Details stck = new Stock_Details();
                        stck.Show();
                        this.Hide();*/
                        dis_data();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured.. Try Again!!");
                    }

                    button4_Click(sender, e);

                }
            //}catch(System.Exception exp)
            //{
              //  MessageBox.Show("Error is: " + exp.ToString());
            //}
        }


        // delete data

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure??", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string recordID = textBox1.Text;
                string query = " delete from Stock_InOut where RecordID ='" + recordID + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = dbConnection.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Details Successfully Deleted!!");
                    /*Stock_Details stck = new Stock_Details();
                    stck.Show();
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
              

            }
            else
            {
                MessageBox.Show("Please click fetch");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter("Select RecordID,Date,ItemCode,ItemName,InitialQuantity,StockIn,StockOut,FinalQuantity,Status from Stock_InOut where ItemName like '%"+textBox9.Text.ToString()+"%'", con);

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
                dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();

            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "R007";
            textBox2.Text = "C007";
            textBox3.Text = "Basketball";
            textBox4.Text = "40";
            textBox5.Text = "10";
            textBox6.Text = "5";
            textBox7.Text = "45";
            //comboBox1.Text 
            //dateTimePicker1.Text;
        }

        /* private void button5_Click(object sender, EventArgs e)
         {
             SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Sport;Integrated Security=True");
             connection.Open();

             if (textBox1.Text != "")
             {
                 SqlCommand command = new SqlCommand("select Date,ItemCode,ItemName,InitialQuantity,StockIn,StockOut,FinalQuantity,Status from Stock_InOut where RecordID = @RecordID", connection);
                 command.Parameters.AddWithValue("@RecordID", textBox1.Text);
                 SqlDataReader DbReader = command.ExecuteReader();
                 while (DbReader.Read())
                 {
                     dateTimePicker1.Text = DbReader.GetValue(0).ToString();
                     textBox2.Text = DbReader.GetValue(1).ToString();
                     textBox3.Text = DbReader.GetValue(2).ToString();
                     textBox4.Text = DbReader.GetValue(3).ToString();
                     textBox5.Text = DbReader.GetValue(4).ToString();
                     textBox6.Text = DbReader.GetValue(5).ToString();
                     textBox7.Text = DbReader.GetValue(6).ToString();

                     comboBox1.Text = DbReader.GetValue(7).ToString();
                     //dateTimePicker1.Text = DbReader.GetValue(7).ToString();

                 }
                 connection.Close();
             }
         }*/
    }
}


       
     
       