using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HarithmaSalesAppv2
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        //double total, grandTotal, discount;
        Functions perform = new Functions();
        Item itemModel = new Item();
        InvoiceItem invoiceItemModel = new InvoiceItem();
        Classes.CurrentInvoice invoiceModel = new Classes.CurrentInvoice();
        Reports.crptInvoice cr = new Reports.crptInvoice();

        //BindingList<InvoiceItem> listInvoiceItem = new BindingList<InvoiceItem>();

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
            lblTotal.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", invoiceModel.InvoiceAmount);
            lblDiscount.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", invoiceModel.InvoiceDiscount);
            lblGrandTotal.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", invoiceModel.InvoiceAmountPayable);
            lblRecieved.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", invoiceModel.InvoiceAmountRecieved);
            lblBalance.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", invoiceModel.InvoiceBalance);
        }

        void GenerateReciept()
        {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                dt.Columns.Add("ItemName", typeof(String));
                dt.Columns.Add("ItemSellingPrice", typeof(decimal));
                dt.Columns.Add("InvoiceItemQuantity", typeof(int));
                dt.Columns.Add("InvoiceItemAmount", typeof(decimal));

                foreach (InvoiceItem item in invoiceModel.itemList)
                {
                    dt.Rows.Add(item.ItemName, item.ItemSellingPrice, item.invoiceItemQuantity, item.invoiceItemAmount);
                }
                ds.Tables.Add(dt);

                cr = new Reports.crptInvoice();
                cr.SetDataSource(ds);
                cr.SetParameterValue("InvoiceAmount", invoiceModel.InvoiceAmount);
                cr.SetParameterValue("InvoiceDiscount", invoiceModel.InvoiceDiscount);
                cr.SetParameterValue("InvoiceAmountPayable", invoiceModel.InvoiceAmountPayable);
                cr.SetParameterValue("InvoiceAmountRecieved", invoiceModel.InvoiceAmountRecieved);
                cr.SetParameterValue("Invoicebalance", invoiceModel.InvoiceBalance);
        }

        void Clear()
        {
            lblCode.Text = lblName.Text = lblPrice.Text = lblDescription.Text = "_";
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCode;
            dgvInvoice.AutoGenerateColumns = false;
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.DataSource = invoiceModel.itemList;
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
            if (txtName.Text != "")
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
            if (invoiceItemModel.ItemID > 0) { 
                invoiceItemModel.setInvoiceItemQuantity(Convert.ToInt32(nupQuantity.Value));
                invoiceModel.addItem(invoiceItemModel);

                this.ActiveControl = txtCode;
                invoiceItemModel = new InvoiceItem();
                itemModel = new Item();

                UpdateInvoice();
                Clear();
            }
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
            if (e.RowIndex >= 0)
                invoiceModel.updateItem(e.ColumnIndex, e.RowIndex);
            UpdateInvoice();
        }

        private void btnRecievedAmount_Click(object sender, EventArgs e)
        {
            decimal value;
            if (decimal.TryParse(txtRecievedAmount.Text, NumberStyles.Currency, new CultureInfo("si-LK").NumberFormat, out value))
                invoiceModel.setRecievedAmount(value);
            UpdateInvoice();
        }

        private void txtRecievedAmount_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtRecievedAmount.Text, out value))
                txtRecievedAmount.Text = String.Format(new CultureInfo("si-LK"), "{0:C2}", value);
            else
                txtRecievedAmount.Text = String.Empty;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (invoiceModel.InvoiceAmountRecieved > 0)
            {
                GenerateReciept();
                cr.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cr.PrintToPrinter(1, false, 0, 0);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            if (invoiceModel.InvoiceAmountRecieved > 0)
            {
                GenerateReciept();
                Forms.RecieptForm f1 = new Forms.RecieptForm();
                f1.crptv.ReportSource = cr;
                f1.crptv.Refresh();
                f1.Show();
            }
        }
    }
}
