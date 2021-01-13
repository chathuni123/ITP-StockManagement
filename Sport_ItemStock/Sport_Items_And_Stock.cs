using System;
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
    public partial class Sport_Items_And_Stock : Form
    {
       

        public Sport_Items_And_Stock()
        {
            InitializeComponent();
        }

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemDetails item = new ItemDetails();
            item.MdiParent = this;
            item.StartPosition = FormStartPosition.CenterScreen;
            item.Show();

        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Details stck = new Stock_Details();
            stck.MdiParent = this;
            stck.StartPosition = FormStartPosition.CenterScreen;
            stck.Show();

        }

        private void reoderRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reorder reorder = new Reorder();
            reorder.MdiParent = this;
            reorder.StartPosition = FormStartPosition.CenterScreen;
            reorder.Show();
        }

        private void itemDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemReport itemReport = new ItemReport();
            itemReport.MdiParent = this;
            itemReport.StartPosition = FormStartPosition.CenterScreen;
            itemReport.Show();
        }

       
    }
}
