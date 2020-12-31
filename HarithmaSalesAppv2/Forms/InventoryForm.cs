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
    public partial class InventoryForm : Form
    {
        Item itemModel = new Item();
        Inventory inventoryModel = new Inventory();

        public InventoryForm()
        {
            InitializeComponent();
        }

        void Reset()
        {
            lblItemID.Text = "";
            txtStockPrice.Text = "";
            txtSellingPrice.Text = "";
            txtQuantity.Value = 0;
            txtRemarks.Text = "";
            itemModel = new Item();
            inventoryModel = new Inventory();
        }

        void Populate(int ItemID)
        {
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if(ItemID > 0)
                    dgvItem.DataSource = db.Items.Where(i => i.ItemID.Equals(ItemID)).ToList();
                else
                    dgvItem.DataSource = db.Items.ToList();
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

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                dgvItem.DataSource = db.Items.Where(i => i.ItemID.ToString().Contains(txtSearchCode.Text)).ToList();
            }
        }

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItem.CurrentRow.Index != -1)
            {
                itemModel.ItemID = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value);
                using (HarithmaSalesEntities db = new HarithmaSalesEntities())
                {
                    itemModel = db.Items.Where(x => x.ItemID == itemModel.ItemID).FirstOrDefault();
                    lblItemID.Text = itemModel.ItemName;
                    txtStockPrice.Text = itemModel.ItemStockPrice.ToString();
                    txtSellingPrice.Text = itemModel.ItemSellingPrice.ToString();
                    //xtQuantity.Value = itemModel.ItemAvailableQuantity;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if (lblItemID.Text != "")
                {
                    inventoryModel.ItemID = itemModel.ItemID;
                    inventoryModel.StockPrice = Decimal.Parse(txtStockPrice.Text);
                    inventoryModel.SellingPrice = Decimal.Parse(txtSellingPrice.Text);
                    inventoryModel.Quantity = Convert.ToInt32(txtQuantity.Value);
                    inventoryModel.Remarks = txtRemarks.Text.Trim();
                    db.Inventories.Add(inventoryModel);
                    db.SaveChanges();

                    itemModel.ItemAvailableQuantity = itemModel.ItemAvailableQuantity + inventoryModel.Quantity;
                    itemModel.ItemStockPrice = inventoryModel.StockPrice;
                    itemModel.ItemSellingPrice = inventoryModel.SellingPrice;
                    db.Entry(itemModel).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    lblStatus.Text = "Stock added.";

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

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            Reset();
            Populate(0);
        }
    }
}
