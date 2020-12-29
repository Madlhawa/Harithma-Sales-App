using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        Item itemModel = new Item();
        //List<Item> listItem = new List<Item>();
        BindingList<Item> listItem = new BindingList<Item>();
        
        void ItemSelect()
        {
            itemModel = perform.ItemList(Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value), "").First();
            lblName.Text = itemModel.ItemName;
            lblCode.Text = itemModel.ItemID.ToString();
            lblDescription.Text = itemModel.ItemDescription;
            lblPrice.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", itemModel.ItemSellingPrice);
            this.ActiveControl = nupQuantity;
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCode;
            dgvInvoice.AutoGenerateColumns = false;
            dgvInvoice.DataSource = listItem;
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
            if(txtName.Text != "")
            {
                dgvItem.AutoGenerateColumns = false;
                dgvItem.DataSource = perform.ItemList(0, txtName.Text.Trim());
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItem.CurrentCell != null)
                ItemSelect();
        }

        private void dgvItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvItem.CurrentCell != null && e.KeyData == Keys.Enter)
                    ItemSelect();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.ActiveControl = dgvItem;
                dgvItem.CurrentCell = dgvItem.FirstDisplayedCell;

            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.ActiveControl = dgvItem;
                dgvItem.CurrentCell = dgvItem.FirstDisplayedCell;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemModel.ItemAvailableQuantity = Convert.ToInt32(nupQuantity.Value);
            listItem.Add(itemModel);
            
            this.ActiveControl = txtCode;
            itemModel = new Item();
        }

        private void nupQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.ActiveControl = btnAdd;

            }
        }
    }
}
