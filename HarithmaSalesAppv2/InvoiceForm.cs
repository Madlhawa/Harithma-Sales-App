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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        Functions perform = new Functions();
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            dgvItems.AutoGenerateColumns = false;
            dgvItems.DataSource = perform.ItemList(0,"");
        }

        private void txtCode_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != "")
            {
                dgvItem.AutoGenerateColumns = false;
                dgvItem.DataSource = perform.ItemList(Convert.ToInt32(txtCode.Text), "");
            }
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            
            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = perform.ItemList(0, txtName.Text.Trim());

        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
