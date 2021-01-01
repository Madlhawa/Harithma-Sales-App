using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HarithmaSalesAppv2.Classes
{
    public class CurrentInvoice : Invoice
    {
        public CurrentInvoice(){
            this.itemList = new BindingList<InvoiceItem>();
        }

        public BindingList<InvoiceItem> itemList { get; set; }
        public decimal total { get; set; }

        private void updateInvoice()
        {
            this.total = this.itemList.Sum(tot => tot.invoiceItemAmount);
            this.InvoiceDiscount = this.itemList.Sum(dis => dis.invoiceItemDiscountAmount);
            this.InvoiceAmount = (decimal)(this.total - this.InvoiceDiscount);
        }

        public void addItem(InvoiceItem item)
        {
            this.itemList.Add(item);
            updateInvoice();
        }

        public void setRecievedAmount(decimal amount)
        {
            this.InvoiceAmountRecieved = amount;
            this.InvoiceBalance = this.InvoiceAmountRecieved - this.InvoiceAmount;
        }

        public void updateItem(int column, int row)
        {
            InvoiceItem tempInvoiceItemModel = new InvoiceItem();

            if (column.Equals(2))
            {
                tempInvoiceItemModel = this.itemList[row];
                tempInvoiceItemModel.setInvoiceItemQuantity(tempInvoiceItemModel.invoiceItemQuantity - 1);
                this.itemList[row] = tempInvoiceItemModel;
            }
            else if (column.Equals(4))
            {
                tempInvoiceItemModel = this.itemList[row];
                tempInvoiceItemModel.setInvoiceItemQuantity(tempInvoiceItemModel.invoiceItemQuantity + 1);
                this.itemList[row] = tempInvoiceItemModel;
            }
            else if (column.Equals(7))
            {
                this.itemList.RemoveAt(row);
            }
            updateInvoice();
        }
    }
}
