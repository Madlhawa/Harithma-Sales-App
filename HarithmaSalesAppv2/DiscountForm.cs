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
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        Item itemModel = new Item();
        Discount discountModel = new Discount();

        void Reset()
        {
            lblItemID.Text = "";
            nudDiscount.Value = 0;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            itemModel = new Item();
            discountModel = new Discount();
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
        private void DiscountForm_Load(object sender, EventArgs e)
        {
            Reset();
            Populate(0);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if (lblItemID.Text != "")
                {
                    discountModel.ItemID = itemModel.ItemID;
                    discountModel.DiscountValue = nudDiscount.Value;
                    discountModel.DiscountStartDate = dtpStartDate.Value;
                    discountModel.DiscountEndDate = dtpEndDate.Value;
                    MessageBox.Show(dtpStartDate.Value.ToString());
                    
                    db.Discounts.Add(discountModel);
                    db.SaveChanges();

                    itemModel.ItemDiscount = nudDiscount.Value;
                    db.Entry(itemModel).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    lblStatus.Text = "Discount added.";

                    Reset();
                    Populate(itemModel.ItemID);
                }
                else
                {
                    lblStatus.BackColor.Equals(Color.Red);
                    lblStatus.Text = "Item not selected";
                }

                Reset();
                Populate(0);
            }
        }

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItem.CurrentRow.Index != -1)
            {
                itemModel.ItemID = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value);
                lblStatus.Text = itemModel.ItemID.ToString();
                using (HarithmaSalesEntities db = new HarithmaSalesEntities())
                {
                    itemModel = db.Items.Where(x => x.ItemID == itemModel.ItemID).FirstOrDefault();
                    lblItemID.Text = itemModel.ItemName;
                }
            }
        }
    }
}
