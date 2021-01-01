using System;

namespace HarithmaSalesAppv2
{
    public class InvoiceItem : Item
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
            this.ItemDiscount = item.ItemDiscount.GetValueOrDefault(0);
        }

        public void setInvoiceItemQuantity(int quantity)
        {
            this.invoiceItemQuantity = quantity;
            this.invoiceItemAmount = this.ItemSellingPrice * invoiceItemQuantity;
            this.invoiceItemDiscountAmount = Convert.ToDecimal(this.invoiceItemAmount * this.ItemDiscount);
        }

        public int invoiceItemQuantity { get; set; }
        public decimal invoiceItemAmount { get; set; }
        public decimal invoiceItemDiscountAmount { get; set; }
    }
}
