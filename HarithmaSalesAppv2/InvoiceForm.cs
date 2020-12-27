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
        void Reset()
        {
        }

        void Populate(int ItemID)
        {
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if (ItemID > 0)
                    dgvItem.DataSource = db.Items.Where(i => i.ItemID.Equals(ItemID)).ToList();
                else
                    dgvItem.DataSource = db.Items.ToList();
            }
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                dgvItem.DataSource = db.Items.Where(i => i.ItemID.ToString().Contains(txtSearchCode.Text)).ToList();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                dgvItem.DataSource = db.Items.Where(i => i.ItemName.Contains(txtSearchName.Text)).ToList();
            }
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            Populate(0);
        }
    }
}
