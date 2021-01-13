﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_ItemStock
{
    public partial class ItemReport : Form
    {
        public ItemReport()
        {
            InitializeComponent();
        }

        private void ItemReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDataSet.Sport_Item' table. You can move, or remove it, as needed.
            this.sport_ItemTableAdapter.Fill(this.sportsDataSet.Sport_Item);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ItemDetails";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "itemdetails";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, 
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    
    }
}
