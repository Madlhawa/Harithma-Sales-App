using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarithmaSalesAppv2
{
    class ClassInvoiceItem : Item
    {
        public ClassInvoiceItem()
        {
            
        }
        
        public void addItemAttributes(Item item)
        {
            this.ItemID = item.ItemID;
            this.ItemName = item.ItemName;
            this.ItemSellingPrice = item.ItemSellingPrice;
            this.ItemAvailableQuantity = item.ItemAvailableQuantity;
            this.ItemDiscount = item.ItemDiscount;
        }

        public void setInvoiceItemQuantity(int quantity)
        {
            this.invoiceItemQuantity = quantity;
            this.invoiceItemAmount = Convert.ToDouble(this.ItemSellingPrice) * invoiceItemQuantity;
            this.invoiceItemDiscountAmount = this.invoiceItemAmount * Convert.ToDouble(this.ItemDiscount);

        }

        public int invoiceItemQuantity { get; set; }
        public double invoiceItemAmount { get; set; }
        public double invoiceItemDiscountAmount { get; set; }
    }
}
