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

        private Form ActiveForm = null;
        private void openForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.BringToFront();
            childForm.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            openForm(new ItemMenu());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openForm(new InventoryForm());
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            openForm(new DiscountForm());
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            openForm(new InvoiceForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openForm(new SettingsForm());
        }
    }
}
