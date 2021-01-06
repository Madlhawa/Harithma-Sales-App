using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HarithmaSalesAppv2
{
    public class Functions
    {
        public List<Item> ItemList(int ItemID,string ItemName)
        {

            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if (ItemID > 0)
                    return db.Items.Where(i => i.ItemID.Equals(ItemID)).ToList();
                else if (ItemName != "")
                    return db.Items.Where(i => i.ItemName.Contains(ItemName)).ToList();
                else
                    return db.Items.ToList();

            }
        }

        public void submitInvoice(Classes.CurrentInvoice currentInvoice)
        {
            Invoice invoice = new Invoice();

            foreach(InvoiceItem currentItem in currentInvoice.itemList)
            {
                Item_Invoice itemInvoice = new Item_Invoice();
                itemInvoice.ItemID = currentItem.ItemID;
                itemInvoice.Quantity = currentItem.invoiceItemQuantity;
                itemInvoice.Amount = currentItem.invoiceItemAmount;
                itemInvoice.Discount = currentItem.invoiceItemDiscountAmount;

                invoice.Item_Invoice.Add(itemInvoice);
            }

            invoice.InvoiceAmount = currentInvoice.InvoiceAmount;
            invoice.InvoiceAmountPayable = currentInvoice.InvoiceAmountPayable;
            invoice.InvoiceAmountRecieved = currentInvoice.InvoiceAmountRecieved;
            invoice.InvoiceBalance = currentInvoice.InvoiceBalance;
            invoice.InvoiceDiscount = currentInvoice.InvoiceDiscount;
            invoice.InvoicePaymentMethod = currentInvoice.InvoicePaymentMethod;
            invoice.InvoiceRemarks = currentInvoice.InvoiceRemarks;

            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                db.Invoices.Add(invoice);
                db.SaveChanges();
            }
        }
    }
}
