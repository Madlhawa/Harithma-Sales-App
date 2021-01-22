
namespace HarithmaSalesAppv2.Forms
{
    partial class UIElementsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIElementsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomTextbox1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.InvoiceItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minus = new System.Windows.Forms.DataGridViewImageColumn();
            this.InvoiceItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus = new System.Windows.Forms.DataGridViewImageColumn();
            this.InvoiceItemSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMinus = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPlus = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(156)))));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(209, 37);
            this.bunifuCustomTextbox1.TabIndex = 0;
            this.bunifuCustomTextbox1.Text = "1234566";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.bunifuCustomTextbox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(55, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 41);
            this.panel1.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.ElipseRadius = 7;
            this.textBox.TargetControl = this.panel1;
            // 
            // dgvInvoice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(67)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.ColumnHeadersHeight = 40;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceItemID,
            this.InvoiceItemName,
            this.Minus,
            this.InvoiceItemQuantity,
            this.plus,
            this.InvoiceItemSellingPrice,
            this.InvoiceItemAmount,
            this.Delete});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInvoice.DoubleBuffered = true;
            this.dgvInvoice.EnableHeadersVisualStyles = false;
            this.dgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInvoice.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(67)))), ((int)(((byte)(166)))));
            this.dgvInvoice.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInvoice.Location = new System.Drawing.Point(1086, 12);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoice.RowHeadersVisible = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInvoice.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInvoice.RowTemplate.Height = 60;
            this.dgvInvoice.RowTemplate.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(288, 230);
            this.dgvInvoice.TabIndex = 27;
            // 
            // InvoiceItemID
            // 
            this.InvoiceItemID.DataPropertyName = "ItemID";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.InvoiceItemID.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceItemID.FillWeight = 44.67756F;
            this.InvoiceItemID.HeaderText = "Code";
            this.InvoiceItemID.Name = "InvoiceItemID";
            this.InvoiceItemID.ReadOnly = true;
            this.InvoiceItemID.Width = 60;
            // 
            // InvoiceItemName
            // 
            this.InvoiceItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceItemName.DataPropertyName = "itemName";
            this.InvoiceItemName.FillWeight = 246.6008F;
            this.InvoiceItemName.HeaderText = "Name";
            this.InvoiceItemName.Name = "InvoiceItemName";
            this.InvoiceItemName.ReadOnly = true;
            // 
            // Minus
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.Minus.DefaultCellStyle = dataGridViewCellStyle4;
            this.Minus.FillWeight = 44.67756F;
            this.Minus.HeaderText = "";
            this.Minus.Image = global::HarithmaSalesAppv2.Properties.Resources.minus;
            this.Minus.Name = "Minus";
            this.Minus.ReadOnly = true;
            this.Minus.Width = 25;
            // 
            // InvoiceItemQuantity
            // 
            this.InvoiceItemQuantity.DataPropertyName = "invoiceItemQuantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.InvoiceItemQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.InvoiceItemQuantity.FillWeight = 162.4366F;
            this.InvoiceItemQuantity.HeaderText = "Qty";
            this.InvoiceItemQuantity.Name = "InvoiceItemQuantity";
            this.InvoiceItemQuantity.ReadOnly = true;
            this.InvoiceItemQuantity.Width = 40;
            // 
            // plus
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.plus.DefaultCellStyle = dataGridViewCellStyle6;
            this.plus.FillWeight = 44.67756F;
            this.plus.HeaderText = "";
            this.plus.Image = global::HarithmaSalesAppv2.Properties.Resources.plus;
            this.plus.Name = "plus";
            this.plus.ReadOnly = true;
            this.plus.Width = 25;
            // 
            // InvoiceItemSellingPrice
            // 
            this.InvoiceItemSellingPrice.DataPropertyName = "ItemSellingPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.InvoiceItemSellingPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.InvoiceItemSellingPrice.FillWeight = 101.0617F;
            this.InvoiceItemSellingPrice.HeaderText = "Price";
            this.InvoiceItemSellingPrice.Name = "InvoiceItemSellingPrice";
            this.InvoiceItemSellingPrice.ReadOnly = true;
            this.InvoiceItemSellingPrice.Width = 200;
            // 
            // InvoiceItemAmount
            // 
            this.InvoiceItemAmount.DataPropertyName = "invoiceItemAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.InvoiceItemAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.InvoiceItemAmount.FillWeight = 111.1906F;
            this.InvoiceItemAmount.HeaderText = "Total";
            this.InvoiceItemAmount.Name = "InvoiceItemAmount";
            this.InvoiceItemAmount.ReadOnly = true;
            this.InvoiceItemAmount.Width = 120;
            // 
            // Delete
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 6, 0);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.Delete.FillWeight = 44.67756F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::HarithmaSalesAppv2.Properties.Resources.remove;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 35;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemMinus,
            this.ItemAvailableQuantity,
            this.ItemPlus,
            this.ItemSellingPrice,
            this.ItemTotal,
            this.ItemRemove});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(635, 579);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(842, 231);
            this.bunifuCustomDataGrid1.TabIndex = 28;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Code";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemMinus
            // 
            this.ItemMinus.HeaderText = "";
            this.ItemMinus.Name = "ItemMinus";
            this.ItemMinus.ReadOnly = true;
            this.ItemMinus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemMinus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItemAvailableQuantity
            // 
            this.ItemAvailableQuantity.DataPropertyName = "InvoiceItemQuantity";
            this.ItemAvailableQuantity.HeaderText = "Qty";
            this.ItemAvailableQuantity.Name = "ItemAvailableQuantity";
            this.ItemAvailableQuantity.ReadOnly = true;
            // 
            // ItemPlus
            // 
            this.ItemPlus.HeaderText = "";
            this.ItemPlus.Name = "ItemPlus";
            this.ItemPlus.ReadOnly = true;
            this.ItemPlus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemPlus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItemSellingPrice
            // 
            this.ItemSellingPrice.DataPropertyName = "ItemSellingPrice";
            this.ItemSellingPrice.HeaderText = "Price";
            this.ItemSellingPrice.Name = "ItemSellingPrice";
            this.ItemSellingPrice.ReadOnly = true;
            // 
            // ItemTotal
            // 
            this.ItemTotal.DataPropertyName = "InvoiceItemAmount";
            this.ItemTotal.HeaderText = "Total";
            this.ItemTotal.Name = "ItemTotal";
            this.ItemTotal.ReadOnly = true;
            // 
            // ItemRemove
            // 
            this.ItemRemove.HeaderText = "";
            this.ItemRemove.Name = "ItemRemove";
            this.ItemRemove.ReadOnly = true;
            // 
            // UIElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIElementsForm";
            this.Text = "UIElementsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse textBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceItemName;
        private System.Windows.Forms.DataGridViewImageColumn Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceItemQuantity;
        private System.Windows.Forms.DataGridViewImageColumn plus;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceItemSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceItemAmount;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewImageColumn ItemMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAvailableQuantity;
        private System.Windows.Forms.DataGridViewImageColumn ItemPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTotal;
        private System.Windows.Forms.DataGridViewImageColumn ItemRemove;
    }
}