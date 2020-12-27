using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarithmaSalesAppv2
{
    public partial class ItemMenu : Form
    {
        Item model = new Item();

        public ItemMenu()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtName.Text = txtDescription.Text = txtSellingPrice.Text = txtStockPrice.Text = "";
            txtQuantity.Value = 0;
            model.ItemID = 0;
            btnAdd.Text = "Add";
            btnDelete.Enabled = false;
            lblStatus.Text = "";
        }

        void Populate()
        {
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                dgvItem.DataSource = db.Items.ToList();
            }
        }

        void Search()
        {
            Clear();
            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                dgvItem.DataSource = db.Items.Where(i => i.ItemName.Contains(txtSearch.Text)).ToList();
            }
        }



        private void ItemMenu_Load(object sender, EventArgs e)
        {
            Clear();
            Populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            model.ItemName = txtName.Text.Trim();
            model.ItemDescription = txtDescription.Text.Trim();

            decimal value;
            if (decimal.TryParse(txtStockPrice.Text, NumberStyles.Currency, new CultureInfo("si-LK").NumberFormat, out value))
                model.ItemStockPrice = value;
            if (decimal.TryParse(txtSellingPrice.Text, NumberStyles.Currency, new CultureInfo("si-LK").NumberFormat, out value))
                model.ItemSellingPrice = value;

            model.ItemAvailableQuantity = Convert.ToInt32(txtQuantity.Value);
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if (model.ItemID == 0)
                    db.Items.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            Populate();
            lblStatus.Text = "Item Added";
        }

        private void txtStockPrice_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtStockPrice.Text, out value))
                txtStockPrice.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", value);
            else
                txtStockPrice.Text = String.Empty;
        }

        private void txtSellingPrice_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtSellingPrice.Text, out value))
                txtSellingPrice.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", value);
            else
                txtSellingPrice.Text = String.Empty;
        }

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItem.CurrentRow.Index != -1)
            {
                model.ItemID = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value);
                using (HarithmaSalesEntities db = new HarithmaSalesEntities())
                {
                    model = db.Items.Where(x => x.ItemID == model.ItemID).FirstOrDefault();
                    txtName.Text = model.ItemName;
                    txtDescription.Text = model.ItemDescription;
                    txtStockPrice.Text = model.ItemStockPrice.ToString();
                    txtSellingPrice.Text = model.ItemSellingPrice.ToString();
                    txtQuantity.Value = model.ItemAvailableQuantity;
                    btnAdd.Text = "Edit";
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete "+model.ItemName+"?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (HarithmaSalesEntities db = new HarithmaSalesEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Items.Attach(model);
                    db.Items.Remove(model);
                    db.SaveChanges();
                    Clear();
                    Populate();
                    lblStatus.Text = "Item Deleted";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
    }
}
