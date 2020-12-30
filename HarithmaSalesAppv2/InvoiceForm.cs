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

        double total, grandTotal, discount;
        Functions perform = new Functions();
        Item itemModel = new Item();
        ClassInvoiceItem invoiceItemModel = new ClassInvoiceItem();
        BindingList<ClassInvoiceItem> listInvoiceItem = new BindingList<ClassInvoiceItem>();

        void ItemSelect()
        {
            itemModel = perform.ItemList(Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value), "").First();
            lblName.Text = itemModel.ItemName;
            lblCode.Text = itemModel.ItemID.ToString();
            lblDescription.Text = itemModel.ItemDescription;
            lblPrice.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", itemModel.ItemSellingPrice);

            invoiceItemModel.addItemAttributes(itemModel);
            this.ActiveControl = nupQuantity;
        }

        void UpdateInvoice()
        {
            total = listInvoiceItem.Sum(invoiceItem => invoiceItem.invoiceItemAmount);
            discount = listInvoiceItem.Sum(invoiceItem => invoiceItem.invoiceItemDiscountAmount);
            grandTotal = total - discount;

            lblTotal.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", total);
            lblDiscount.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", discount);
            lblGrandTotal.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", grandTotal);
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCode;
            dgvInvoice.AutoGenerateColumns = false;
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.DataSource = listInvoiceItem;
        }

        private void txtCode_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && int.TryParse(txtCode.Text, out _))
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
            invoiceItemModel.setInvoiceItemQuantity(Convert.ToInt32(nupQuantity.Value));
            listInvoiceItem.Add(invoiceItemModel);
            
            this.ActiveControl = txtCode;
            invoiceItemModel = new ClassInvoiceItem();
            itemModel = new Item();

            UpdateInvoice();
        }

        private void nupQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.ActiveControl = btnAdd;
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassInvoiceItem tempInvoiceItemModel = new ClassInvoiceItem();

            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex.Equals(2))
                {
                    tempInvoiceItemModel = listInvoiceItem[e.RowIndex];
                    tempInvoiceItemModel.setInvoiceItemQuantity(tempInvoiceItemModel.invoiceItemQuantity - 1);
                    listInvoiceItem[e.RowIndex] = tempInvoiceItemModel;
                }
                else if (e.ColumnIndex.Equals(4))
                {
                    tempInvoiceItemModel = listInvoiceItem[e.RowIndex];
                    tempInvoiceItemModel.setInvoiceItemQuantity(tempInvoiceItemModel.invoiceItemQuantity + 1);
                    listInvoiceItem[e.RowIndex] = tempInvoiceItemModel;
                }
                else if (e.ColumnIndex.Equals(7))
                {
                    listInvoiceItem.RemoveAt(e.RowIndex);
                }
            }
            UpdateInvoice();
        }
    }
}
