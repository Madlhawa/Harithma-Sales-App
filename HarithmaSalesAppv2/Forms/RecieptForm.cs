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
        }
    }
}
