using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarithmaSalesAppv2.Forms
{
    public partial class RecieptForm : Form
    {
        public Classes.CurrentInvoice invoice { get; set;}

        public RecieptForm()
        {
            InitializeComponent();
        }

        private void RecieptForm_Load(object sender, EventArgs e)
        {
            Reports.crptInvoice cr = new Reports.crptInvoice();

            cr.SetDataSource(this.invoice.itemList);
            cr.SetParameterValue("total", this.invoice.total);
            cr.SetParameterValue("InvoiceDiscount", this.invoice.InvoiceDiscount);
            cr.SetParameterValue("InvoiceAmount", this.invoice.InvoiceAmount);
            cr.SetParameterValue("InvoiceAmountRecieved", this.invoice.InvoiceAmountRecieved);
            cr.SetParameterValue("InvoiceBalance", this.invoice.InvoiceBalance);

            crptv.ReportSource = cr;
            crptv.Refresh();
        }
    }
}
