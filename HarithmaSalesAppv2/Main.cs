using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarithmaSalesAppv2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemMenu f1 = new ItemMenu();
            f1.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm f2 = new InventoryForm();
            f2.Show();
        }
    }
}
