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
        Functions perform = new Functions();
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm f3 = new SettingsForm();
            f3.Show();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountForm f4 = new DiscountForm();
            f4.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm f5 = new InvoiceForm();
            f5.Show();
        }

    }
}
