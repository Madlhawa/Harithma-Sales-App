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

        private void updateInvoice()
        {
            this.InvoiceAmount = this.itemList.Sum(tot => tot.invoiceItemAmount);
            this.InvoiceDiscount = this.itemList.Sum(dis => dis.invoiceItemDiscountAmount);
            this.InvoiceTotalDiscount = this.InvoiceManualDiscount.GetValueOrDefault(0) + this.InvoiceDiscount;
            this.InvoiceAmountPayable = (decimal)(this.InvoiceAmount - this.InvoiceTotalDiscount);
            this.InvoiceBalance = this.InvoiceAmountRecieved.GetValueOrDefault(0) - this.InvoiceAmountPayable;
        }


        public void addItem(InvoiceItem item)
        {
            this.itemList.Add(item);
            updateInvoice();
        }

        public void setRecievedAmount(decimal amount, decimal discount, string paymentMethod, string remarks)
        {
            this.InvoiceAmountRecieved = amount;
            this.InvoiceManualDiscount = discount;
            this.InvoicePaymentMethod = paymentMethod;
            this.InvoiceRemarks = remarks;
            updateInvoice();
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
