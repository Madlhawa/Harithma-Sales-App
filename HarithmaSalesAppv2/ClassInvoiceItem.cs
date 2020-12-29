using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarithmaSalesAppv2
{
    class ClassInvoiceItem : Item
    {
        protected int invoiceItemQuantity;
        protected double invoiceItemAmount;

        public ClassInvoiceItem(Item item, int invoiceItemQuantity, double invoiceItemAmount)
        {
            this.ItemID = item.ItemID;
            this.ItemName = item.ItemName;
            this.invoiceItemQuantity = invoiceItemQuantity;
            this.ItemSellingPrice = item.ItemSellingPrice;
            this.invoiceItemAmount = invoiceItemAmount;
            //this.ItemDiscount = item.Discounts
        }
    }
}
