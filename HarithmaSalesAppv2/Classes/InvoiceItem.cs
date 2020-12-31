using System;

namespace HarithmaSalesAppv2
{
    class InvoiceItem : Item
    {
        public InvoiceItem()
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

        public void calculateInvoice()
        {

        }

        public int invoiceItemQuantity { get; set; }
        public double invoiceItemAmount { get; set; }
        public double invoiceItemDiscountAmount { get; set; }
    }
}
