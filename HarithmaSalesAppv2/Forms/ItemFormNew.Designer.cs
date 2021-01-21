
namespace HarithmaSalesAppv2.Forms
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SearchBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.Framework.BunifuCustomTextbox();
            this.dgvItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtSellingPrice = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtStockPrice = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtName = new Bunifu.Framework.BunifuCustomTextbox();
            this.QuantityLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SellingPriceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StockPriceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DecriptionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ItemNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.SearchBtn);
            this.bunifuGradientPanel1.Controls.Add(this.txtSearch);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(334, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(642, 61);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.AllowToggling = false;
            this.SearchBtn.AnimationSpeed = 200;
            this.SearchBtn.AutoGenerateColors = false;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(89)))), ((int)(((byte)(186)))));
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SearchBtn.ButtonText = "Search";
            this.SearchBtn.ButtonTextMarginLeft = 0;
            this.SearchBtn.ColorContrastOnClick = 45;
            this.SearchBtn.ColorContrastOnHover = 45;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SearchBtn.CustomizableEdges = borderEdges1;
            this.SearchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SearchBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SearchBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.IconMarginLeft = 11;
            this.SearchBtn.IconPadding = 10;
            this.SearchBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchBtn.IdleBorderRadius = 3;
            this.SearchBtn.IdleBorderThickness = 1;
            this.SearchBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(89)))), ((int)(((byte)(186)))));
            this.SearchBtn.IdleIconLeftImage = null;
            this.SearchBtn.IdleIconRightImage = null;
            this.SearchBtn.IndicateFocus = false;
            this.SearchBtn.Location = new System.Drawing.Point(487, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchBtn.onHoverState.BorderRadius = 3;
            this.SearchBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SearchBtn.onHoverState.BorderThickness = 1;
            this.SearchBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.onHoverState.IconLeftImage = null;
            this.SearchBtn.onHoverState.IconRightImage = null;
            this.SearchBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchBtn.OnIdleState.BorderRadius = 3;
            this.SearchBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SearchBtn.OnIdleState.BorderThickness = 1;
            this.SearchBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(89)))), ((int)(((byte)(186)))));
            this.SearchBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.OnIdleState.IconLeftImage = null;
            this.SearchBtn.OnIdleState.IconRightImage = null;
            this.SearchBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SearchBtn.OnPressedState.BorderRadius = 3;
            this.SearchBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SearchBtn.OnPressedState.BorderThickness = 1;
            this.SearchBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SearchBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.OnPressedState.IconLeftImage = null;
            this.SearchBtn.OnPressedState.IconRightImage = null;
            this.SearchBtn.Size = new System.Drawing.Size(152, 28);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchBtn.TextMarginLeft = 0;
            this.SearchBtn.UseDefaultRadiusAndThickness = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.txtSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(89)))), ((int)(((byte)(186)))));
            this.txtSearch.Location = new System.Drawing.Point(26, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search Item";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.ColumnHeadersHeight = 40;
            this.dgvItem.DoubleBuffered = true;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvItem.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvItem.Location = new System.Drawing.Point(334, 79);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItem.Size = new System.Drawing.Size(642, 395);
            this.dgvItem.TabIndex = 1;
            this.dgvItem.DoubleClick += new System.EventHandler(this.dgvItem_DoubleClick);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lblStatus);
            this.bunifuGradientPanel2.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel2.Controls.Add(this.btnAdd);
            this.bunifuGradientPanel2.Controls.Add(this.txtQuantity);
            this.bunifuGradientPanel2.Controls.Add(this.txtDescription);
            this.bunifuGradientPanel2.Controls.Add(this.txtSellingPrice);
            this.bunifuGradientPanel2.Controls.Add(this.txtStockPrice);
            this.bunifuGradientPanel2.Controls.Add(this.txtName);
            this.bunifuGradientPanel2.Controls.Add(this.QuantityLabel);
            this.bunifuGradientPanel2.Controls.Add(this.SellingPriceLabel);
            this.bunifuGradientPanel2.Controls.Add(this.StockPriceLabel);
            this.bunifuGradientPanel2.Controls.Add(this.DecriptionLabel);
            this.bunifuGradientPanel2.Controls.Add(this.ItemNameLabel);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(12, 12);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(316, 462);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.lblStatus.Location = new System.Drawing.Point(127, 336);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges2;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDelete.IdleBorderRadius = 3;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(168, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDelete.onHoverState.BorderRadius = 3;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDelete.OnIdleState.BorderRadius = 3;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDelete.OnPressedState.BorderRadius = 3;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges3;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.btnAdd.IdleBorderRadius = 3;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(21, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.BorderRadius = 3;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.btnAdd.OnIdleState.BorderRadius = 3;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.BorderRadius = 3;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(130, 215);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(167, 18);
            this.txtQuantity.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(130, 62);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(167, 57);
            this.txtDescription.TabIndex = 11;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSellingPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(130, 169);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(167, 19);
            this.txtSellingPrice.TabIndex = 10;
            this.txtSellingPrice.Leave += new System.EventHandler(this.txtSellingPrice_Leave);
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtStockPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtStockPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPrice.Location = new System.Drawing.Point(130, 125);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(167, 19);
            this.txtStockPrice.TabIndex = 9;
            this.txtStockPrice.Leave += new System.EventHandler(this.txtStockPrice_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(130, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 19);
            this.txtName.TabIndex = 8;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.QuantityLabel.Location = new System.Drawing.Point(17, 215);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(70, 21);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "Quantity";
            // 
            // SellingPriceLabel
            // 
            this.SellingPriceLabel.AutoSize = true;
            this.SellingPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.SellingPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.SellingPriceLabel.Location = new System.Drawing.Point(17, 169);
            this.SellingPriceLabel.Name = "SellingPriceLabel";
            this.SellingPriceLabel.Size = new System.Drawing.Size(95, 21);
            this.SellingPriceLabel.TabIndex = 6;
            this.SellingPriceLabel.Text = "Selling Price";
            // 
            // StockPriceLabel
            // 
            this.StockPriceLabel.AutoSize = true;
            this.StockPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.StockPriceLabel.Location = new System.Drawing.Point(17, 125);
            this.StockPriceLabel.Name = "StockPriceLabel";
            this.StockPriceLabel.Size = new System.Drawing.Size(85, 21);
            this.StockPriceLabel.TabIndex = 5;
            this.StockPriceLabel.Text = "Stock Price";
            // 
            // DecriptionLabel
            // 
            this.DecriptionLabel.AutoSize = true;
            this.DecriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DecriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.DecriptionLabel.Location = new System.Drawing.Point(17, 61);
            this.DecriptionLabel.Name = "DecriptionLabel";
            this.DecriptionLabel.Size = new System.Drawing.Size(89, 21);
            this.DecriptionLabel.TabIndex = 4;
            this.DecriptionLabel.Text = "Description";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ItemNameLabel.Location = new System.Drawing.Point(17, 24);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(52, 21);
            this.ItemNameLabel.TabIndex = 3;
            this.ItemNameLabel.Text = "Name";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 486);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.BunifuCustomTextbox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SearchBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItem;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.BunifuCustomTextbox txtSellingPrice;
        private Bunifu.Framework.BunifuCustomTextbox txtStockPrice;
        private Bunifu.Framework.BunifuCustomTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel QuantityLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel SellingPriceLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel StockPriceLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel DecriptionLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel ItemNameLabel;
        private Bunifu.Framework.BunifuCustomTextbox txtDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lblStatus;
    }
}