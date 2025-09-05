
namespace DatabaseConfiguration
{
    partial class SalesInvoice
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlForm2 = new System.Windows.Forms.Panel();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtDiscountAmt = new System.Windows.Forms.TextBox();
            this.lblNetAmt = new System.Windows.Forms.Label();
            this.txtRoundOffDiscount = new System.Windows.Forms.TextBox();
            this.pnlAllBtn = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInvoiceDetail = new System.Windows.Forms.Label();
            this.lblRoundOff = new System.Windows.Forms.Label();
            this.SalesInvoiceDetailDGV = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductFreeQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_DiscountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAvailableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.SearchProductDGV = new System.Windows.Forms.DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_SalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_FreeQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_AvailableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxStock = new System.Windows.Forms.GroupBox();
            this.lblAvailableQty = new System.Windows.Forms.Label();
            this.lblStkAvlQty = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lblFinalDiscount = new System.Windows.Forms.Label();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.txtGrossAmount = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblGrossAmt = new System.Windows.Forms.Label();
            this.txtProductDiscount = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductFreeQty = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblFreeQty = new System.Windows.Forms.Label();
            this.rbProductName = new System.Windows.Forms.RadioButton();
            this.txtProductQty = new System.Windows.Forms.TextBox();
            this.rbProductCode = new System.Windows.Forms.RadioButton();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSerachProduct = new System.Windows.Forms.Label();
            this.txtProductRate = new System.Windows.Forms.TextBox();
            this.lblSaleRate = new System.Windows.Forms.Label();
            this.lblMblNo = new System.Windows.Forms.Label();
            this.CustomerDetailDGV = new System.Windows.Forms.DataGridView();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaleInvoiceHeader = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSerchByNameMblNo = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtSalesInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SalesDate = new System.Windows.Forms.DateTimePicker();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlForm2.SuspendLayout();
            this.pnlAllBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesInvoiceDetailDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchProductDGV)).BeginInit();
            this.groupBoxStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlForm2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(927, 656);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlForm2
            // 
            this.pnlForm2.Controls.Add(this.txtNetAmount);
            this.pnlForm2.Controls.Add(this.txtDiscountAmt);
            this.pnlForm2.Controls.Add(this.lblNetAmt);
            this.pnlForm2.Controls.Add(this.txtRoundOffDiscount);
            this.pnlForm2.Controls.Add(this.pnlAllBtn);
            this.pnlForm2.Controls.Add(this.lblInvoiceDetail);
            this.pnlForm2.Controls.Add(this.lblRoundOff);
            this.pnlForm2.Controls.Add(this.SalesInvoiceDetailDGV);
            this.pnlForm2.Controls.Add(this.txtDiscountValue);
            this.pnlForm2.Controls.Add(this.SearchProductDGV);
            this.pnlForm2.Controls.Add(this.groupBoxStock);
            this.pnlForm2.Controls.Add(this.btnProductAdd);
            this.pnlForm2.Controls.Add(this.lblFinalDiscount);
            this.pnlForm2.Controls.Add(this.lblFilterType);
            this.pnlForm2.Controls.Add(this.txtGrossAmount);
            this.pnlForm2.Controls.Add(this.lblProductName);
            this.pnlForm2.Controls.Add(this.lblGrossAmt);
            this.pnlForm2.Controls.Add(this.txtProductDiscount);
            this.pnlForm2.Controls.Add(this.lblProductCode);
            this.pnlForm2.Controls.Add(this.lblDiscount);
            this.pnlForm2.Controls.Add(this.txtProductCode);
            this.pnlForm2.Controls.Add(this.txtProductFreeQty);
            this.pnlForm2.Controls.Add(this.txtProductName);
            this.pnlForm2.Controls.Add(this.lblFreeQty);
            this.pnlForm2.Controls.Add(this.rbProductName);
            this.pnlForm2.Controls.Add(this.txtProductQty);
            this.pnlForm2.Controls.Add(this.rbProductCode);
            this.pnlForm2.Controls.Add(this.lblQty);
            this.pnlForm2.Controls.Add(this.lblSerachProduct);
            this.pnlForm2.Controls.Add(this.txtProductRate);
            this.pnlForm2.Controls.Add(this.lblSaleRate);
            this.pnlForm2.Controls.Add(this.lblMblNo);
            this.pnlForm2.Controls.Add(this.CustomerDetailDGV);
            this.pnlForm2.Controls.Add(this.lblSaleInvoiceHeader);
            this.pnlForm2.Controls.Add(this.txtCustomerName);
            this.pnlForm2.Controls.Add(this.lblInvoiceNo);
            this.pnlForm2.Controls.Add(this.txtCustomerMobileNo);
            this.pnlForm2.Controls.Add(this.lblDate);
            this.pnlForm2.Controls.Add(this.lblSerchByNameMblNo);
            this.pnlForm2.Controls.Add(this.txtCustomerAddress);
            this.pnlForm2.Controls.Add(this.lblState);
            this.pnlForm2.Controls.Add(this.txtSalesInvoiceNo);
            this.pnlForm2.Controls.Add(this.lblAddress);
            this.pnlForm2.Controls.Add(this.SalesDate);
            this.pnlForm2.Controls.Add(this.cmbState);
            this.pnlForm2.Location = new System.Drawing.Point(0, 0);
            this.pnlForm2.Name = "pnlForm2";
            this.pnlForm2.Size = new System.Drawing.Size(926, 708);
            this.pnlForm2.TabIndex = 42;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(750, 615);
            this.txtNetAmount.Multiline = true;
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(155, 26);
            this.txtNetAmount.TabIndex = 7;
            // 
            // txtDiscountAmt
            // 
            this.txtDiscountAmt.Location = new System.Drawing.Point(816, 553);
            this.txtDiscountAmt.Multiline = true;
            this.txtDiscountAmt.Name = "txtDiscountAmt";
            this.txtDiscountAmt.ReadOnly = true;
            this.txtDiscountAmt.Size = new System.Drawing.Size(89, 26);
            this.txtDiscountAmt.TabIndex = 8;
            this.txtDiscountAmt.Text = "0.00";
            // 
            // lblNetAmt
            // 
            this.lblNetAmt.AutoSize = true;
            this.lblNetAmt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmt.Location = new System.Drawing.Point(642, 622);
            this.lblNetAmt.Name = "lblNetAmt";
            this.lblNetAmt.Size = new System.Drawing.Size(102, 19);
            this.lblNetAmt.TabIndex = 4;
            this.lblNetAmt.Text = "Net Amount:";
            // 
            // txtRoundOffDiscount
            // 
            this.txtRoundOffDiscount.Location = new System.Drawing.Point(750, 584);
            this.txtRoundOffDiscount.Multiline = true;
            this.txtRoundOffDiscount.Name = "txtRoundOffDiscount";
            this.txtRoundOffDiscount.ReadOnly = true;
            this.txtRoundOffDiscount.Size = new System.Drawing.Size(155, 26);
            this.txtRoundOffDiscount.TabIndex = 6;
            this.txtRoundOffDiscount.TextChanged += new System.EventHandler(this.txtRoundOffDiscount_TextChanged);
            // 
            // pnlAllBtn
            // 
            this.pnlAllBtn.Controls.Add(this.btnBack);
            this.pnlAllBtn.Controls.Add(this.btnClear);
            this.pnlAllBtn.Controls.Add(this.btnSave);
            this.pnlAllBtn.Location = new System.Drawing.Point(7, 579);
            this.pnlAllBtn.Name = "pnlAllBtn";
            this.pnlAllBtn.Size = new System.Drawing.Size(470, 62);
            this.pnlAllBtn.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(198, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(109, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(20, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInvoiceDetail
            // 
            this.lblInvoiceDetail.AutoSize = true;
            this.lblInvoiceDetail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDetail.Location = new System.Drawing.Point(3, 351);
            this.lblInvoiceDetail.Name = "lblInvoiceDetail";
            this.lblInvoiceDetail.Size = new System.Drawing.Size(171, 22);
            this.lblInvoiceDetail.TabIndex = 2;
            this.lblInvoiceDetail.Text = "Sales Invoice Detail";
            // 
            // lblRoundOff
            // 
            this.lblRoundOff.AutoSize = true;
            this.lblRoundOff.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundOff.Location = new System.Drawing.Point(617, 591);
            this.lblRoundOff.Name = "lblRoundOff";
            this.lblRoundOff.Size = new System.Drawing.Size(127, 19);
            this.lblRoundOff.TabIndex = 3;
            this.lblRoundOff.Text = "Round Off(+/-) :";
            // 
            // SalesInvoiceDetailDGV
            // 
            this.SalesInvoiceDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesInvoiceDetailDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductCode,
            this.ProductSalesRate,
            this.ProductQty,
            this.ProductFreeQty,
            this.Product_DiscountPercentage,
            this.ProductDiscount,
            this.ProductAvailableQty,
            this.ProductSubTotal,
            this.ProductNetAmount});
            this.SalesInvoiceDetailDGV.Location = new System.Drawing.Point(3, 388);
            this.SalesInvoiceDetailDGV.Name = "SalesInvoiceDetailDGV";
            this.SalesInvoiceDetailDGV.Size = new System.Drawing.Size(899, 121);
            this.SalesInvoiceDetailDGV.TabIndex = 3;
            this.SalesInvoiceDetailDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            this.SalesInvoiceDetailDGV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SalesInvoiceDetailDGV_CellValidating);
            this.SalesInvoiceDetailDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            this.SalesInvoiceDetailDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SalesInvoiceDetailDGV_EditingControlShowing);
            this.SalesInvoiceDetailDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesInvoiceDetailDGV_KeyDown);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductSalesRate
            // 
            this.ProductSalesRate.DataPropertyName = "ProductSalesRate";
            this.ProductSalesRate.HeaderText = "Product SalesRate";
            this.ProductSalesRate.Name = "ProductSalesRate";
            this.ProductSalesRate.ReadOnly = true;
            // 
            // ProductQty
            // 
            this.ProductQty.DataPropertyName = "ProductQty";
            this.ProductQty.HeaderText = "Product Qty";
            this.ProductQty.Name = "ProductQty";
            // 
            // ProductFreeQty
            // 
            this.ProductFreeQty.DataPropertyName = "ProductFreeQty";
            this.ProductFreeQty.HeaderText = "Product FreeQty";
            this.ProductFreeQty.Name = "ProductFreeQty";
            // 
            // Product_DiscountPercentage
            // 
            this.Product_DiscountPercentage.DataPropertyName = "Product_DiscountPercentage";
            this.Product_DiscountPercentage.HeaderText = "Product_DiscountPercentage";
            this.Product_DiscountPercentage.Name = "Product_DiscountPercentage";
            // 
            // ProductDiscount
            // 
            this.ProductDiscount.DataPropertyName = "ProductDiscount";
            this.ProductDiscount.HeaderText = "Product Discount";
            this.ProductDiscount.Name = "ProductDiscount";
            this.ProductDiscount.ReadOnly = true;
            // 
            // ProductAvailableQty
            // 
            this.ProductAvailableQty.DataPropertyName = "ProductAvailableQty";
            this.ProductAvailableQty.HeaderText = "Product AvailableQty";
            this.ProductAvailableQty.Name = "ProductAvailableQty";
            this.ProductAvailableQty.ReadOnly = true;
            // 
            // ProductSubTotal
            // 
            this.ProductSubTotal.DataPropertyName = "ProductSubTotal";
            this.ProductSubTotal.HeaderText = "Product SubTotal";
            this.ProductSubTotal.Name = "ProductSubTotal";
            this.ProductSubTotal.ReadOnly = true;
            // 
            // ProductNetAmount
            // 
            this.ProductNetAmount.DataPropertyName = "ProductNetAmount";
            this.ProductNetAmount.HeaderText = "Product NetAmount";
            this.ProductNetAmount.Name = "ProductNetAmount";
            this.ProductNetAmount.ReadOnly = true;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Location = new System.Drawing.Point(750, 554);
            this.txtDiscountValue.Multiline = true;
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(60, 26);
            this.txtDiscountValue.TabIndex = 5;
            this.txtDiscountValue.Text = "0.00";
            this.txtDiscountValue.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscountValue.Enter += new System.EventHandler(this.txtDiscountValue_Enter);
            this.txtDiscountValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscountValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiscount_Validating);
            // 
            // SearchProductDGV
            // 
            this.SearchProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchProductDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Product_Name,
            this.Product_Code,
            this.Product_SalesRate,
            this.Product_Qty,
            this.Product_FreeQty,
            this.Product_AvailableQty});
            this.SearchProductDGV.Location = new System.Drawing.Point(3, 302);
            this.SearchProductDGV.Name = "SearchProductDGV";
            this.SearchProductDGV.Size = new System.Drawing.Size(900, 80);
            this.SearchProductDGV.TabIndex = 3;
            this.SearchProductDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Product_Id
            // 
            this.Product_Id.DataPropertyName = "Product_Id";
            this.Product_Id.HeaderText = "Product Id";
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Visible = false;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Code
            // 
            this.Product_Code.DataPropertyName = "Product_Code";
            this.Product_Code.HeaderText = "Product_Code";
            this.Product_Code.Name = "Product_Code";
            this.Product_Code.ReadOnly = true;
            // 
            // Product_SalesRate
            // 
            this.Product_SalesRate.DataPropertyName = "Product_SalesRate";
            this.Product_SalesRate.HeaderText = "Product_SalesRate";
            this.Product_SalesRate.Name = "Product_SalesRate";
            this.Product_SalesRate.ReadOnly = true;
            // 
            // Product_Qty
            // 
            this.Product_Qty.DataPropertyName = "Product_Qty";
            this.Product_Qty.HeaderText = "Product Qty";
            this.Product_Qty.Name = "Product_Qty";
            this.Product_Qty.ReadOnly = true;
            this.Product_Qty.Visible = false;
            // 
            // Product_FreeQty
            // 
            this.Product_FreeQty.DataPropertyName = "Product_FreeQty";
            this.Product_FreeQty.HeaderText = "Product_FreeQty";
            this.Product_FreeQty.Name = "Product_FreeQty";
            this.Product_FreeQty.ReadOnly = true;
            this.Product_FreeQty.Visible = false;
            // 
            // Product_AvailableQty
            // 
            this.Product_AvailableQty.DataPropertyName = "Product_AvailableQty";
            this.Product_AvailableQty.HeaderText = "Product AvailableQty";
            this.Product_AvailableQty.Name = "Product_AvailableQty";
            this.Product_AvailableQty.ReadOnly = true;
            // 
            // groupBoxStock
            // 
            this.groupBoxStock.Controls.Add(this.lblAvailableQty);
            this.groupBoxStock.Controls.Add(this.lblStkAvlQty);
            this.groupBoxStock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStock.Location = new System.Drawing.Point(667, 202);
            this.groupBoxStock.Name = "groupBoxStock";
            this.groupBoxStock.Size = new System.Drawing.Size(200, 84);
            this.groupBoxStock.TabIndex = 32;
            this.groupBoxStock.TabStop = false;
            this.groupBoxStock.Text = "Stock";
            // 
            // lblAvailableQty
            // 
            this.lblAvailableQty.AutoSize = true;
            this.lblAvailableQty.Location = new System.Drawing.Point(118, 30);
            this.lblAvailableQty.Name = "lblAvailableQty";
            this.lblAvailableQty.Size = new System.Drawing.Size(0, 17);
            this.lblAvailableQty.TabIndex = 1;
            // 
            // lblStkAvlQty
            // 
            this.lblStkAvlQty.AutoSize = true;
            this.lblStkAvlQty.Location = new System.Drawing.Point(6, 32);
            this.lblStkAvlQty.Name = "lblStkAvlQty";
            this.lblStkAvlQty.Size = new System.Drawing.Size(105, 17);
            this.lblStkAvlQty.TabIndex = 0;
            this.lblStkAvlQty.Text = "Available Qty :";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.Location = new System.Drawing.Point(558, 248);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(103, 38);
            this.btnProductAdd.TabIndex = 35;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFinalDiscount
            // 
            this.lblFinalDiscount.AutoSize = true;
            this.lblFinalDiscount.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDiscount.Location = new System.Drawing.Point(656, 560);
            this.lblFinalDiscount.Name = "lblFinalDiscount";
            this.lblFinalDiscount.Size = new System.Drawing.Size(88, 19);
            this.lblFinalDiscount.TabIndex = 2;
            this.lblFinalDiscount.Text = "Disc. (%) :";
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterType.Location = new System.Drawing.Point(8, 207);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(102, 19);
            this.lblFilterType.TabIndex = 12;
            this.lblFilterType.Text = "Filter Type :";
            // 
            // txtGrossAmount
            // 
            this.txtGrossAmount.Location = new System.Drawing.Point(750, 522);
            this.txtGrossAmount.Multiline = true;
            this.txtGrossAmount.Name = "txtGrossAmount";
            this.txtGrossAmount.ReadOnly = true;
            this.txtGrossAmount.Size = new System.Drawing.Size(155, 26);
            this.txtGrossAmount.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(7, 244);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(107, 19);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Product Name";
            // 
            // lblGrossAmt
            // 
            this.lblGrossAmt.AutoSize = true;
            this.lblGrossAmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossAmt.Location = new System.Drawing.Point(631, 529);
            this.lblGrossAmt.Name = "lblGrossAmt";
            this.lblGrossAmt.Size = new System.Drawing.Size(113, 19);
            this.lblGrossAmt.TabIndex = 0;
            this.lblGrossAmt.Text = "Gross Amount :";
            // 
            // txtProductDiscount
            // 
            this.txtProductDiscount.Location = new System.Drawing.Point(459, 266);
            this.txtProductDiscount.Name = "txtProductDiscount";
            this.txtProductDiscount.Size = new System.Drawing.Size(83, 20);
            this.txtProductDiscount.TabIndex = 30;
            this.txtProductDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductDiscount_KeyPress);
            this.txtProductDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductDiscount_Validating);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(144, 244);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(45, 19);
            this.lblProductCode.TabIndex = 17;
            this.lblProductCode.Text = "Code";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(455, 244);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 19);
            this.lblDiscount.TabIndex = 29;
            this.lblDiscount.Text = "Discount";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(144, 266);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(73, 30);
            this.txtProductCode.TabIndex = 18;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // txtProductFreeQty
            // 
            this.txtProductFreeQty.Location = new System.Drawing.Point(378, 266);
            this.txtProductFreeQty.Name = "txtProductFreeQty";
            this.txtProductFreeQty.Size = new System.Drawing.Size(75, 20);
            this.txtProductFreeQty.TabIndex = 28;
            this.txtProductFreeQty.TextChanged += new System.EventHandler(this.txtProductFreeQty_TextChanged);
            this.txtProductFreeQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductFreeQty_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(7, 266);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(131, 30);
            this.txtProductName.TabIndex = 16;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // lblFreeQty
            // 
            this.lblFreeQty.AutoSize = true;
            this.lblFreeQty.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeQty.Location = new System.Drawing.Point(374, 244);
            this.lblFreeQty.Name = "lblFreeQty";
            this.lblFreeQty.Size = new System.Drawing.Size(69, 19);
            this.lblFreeQty.TabIndex = 27;
            this.lblFreeQty.Text = "Free Qty";
            // 
            // rbProductName
            // 
            this.rbProductName.AutoSize = true;
            this.rbProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProductName.Location = new System.Drawing.Point(242, 207);
            this.rbProductName.Name = "rbProductName";
            this.rbProductName.Size = new System.Drawing.Size(116, 23);
            this.rbProductName.TabIndex = 14;
            this.rbProductName.TabStop = true;
            this.rbProductName.Text = "Product Name";
            this.rbProductName.UseVisualStyleBackColor = true;
            this.rbProductName.CheckedChanged += new System.EventHandler(this.rbProductName_CheckedChanged);
            // 
            // txtProductQty
            // 
            this.txtProductQty.Location = new System.Drawing.Point(306, 266);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Size = new System.Drawing.Size(63, 20);
            this.txtProductQty.TabIndex = 26;
            this.txtProductQty.TextChanged += new System.EventHandler(this.txtProductQty_TextChanged);
            this.txtProductQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductQty_KeyPress);
            // 
            // rbProductCode
            // 
            this.rbProductCode.AutoSize = true;
            this.rbProductCode.Checked = true;
            this.rbProductCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProductCode.Location = new System.Drawing.Point(121, 207);
            this.rbProductCode.Name = "rbProductCode";
            this.rbProductCode.Size = new System.Drawing.Size(113, 23);
            this.rbProductCode.TabIndex = 13;
            this.rbProductCode.TabStop = true;
            this.rbProductCode.Text = "Product Code";
            this.rbProductCode.UseVisualStyleBackColor = true;
            this.rbProductCode.CheckedChanged += new System.EventHandler(this.rbProductCode_CheckedChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(309, 244);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(34, 19);
            this.lblQty.TabIndex = 25;
            this.lblQty.Text = "Qty";
            // 
            // lblSerachProduct
            // 
            this.lblSerachProduct.AutoSize = true;
            this.lblSerachProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerachProduct.Location = new System.Drawing.Point(8, 173);
            this.lblSerachProduct.Name = "lblSerachProduct";
            this.lblSerachProduct.Size = new System.Drawing.Size(137, 22);
            this.lblSerachProduct.TabIndex = 1;
            this.lblSerachProduct.Text = "Search Product";
            // 
            // txtProductRate
            // 
            this.txtProductRate.Location = new System.Drawing.Point(223, 266);
            this.txtProductRate.Multiline = true;
            this.txtProductRate.Name = "txtProductRate";
            this.txtProductRate.ReadOnly = true;
            this.txtProductRate.Size = new System.Drawing.Size(77, 30);
            this.txtProductRate.TabIndex = 24;
            // 
            // lblSaleRate
            // 
            this.lblSaleRate.AutoSize = true;
            this.lblSaleRate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleRate.Location = new System.Drawing.Point(219, 244);
            this.lblSaleRate.Name = "lblSaleRate";
            this.lblSaleRate.Size = new System.Drawing.Size(73, 19);
            this.lblSaleRate.TabIndex = 23;
            this.lblSaleRate.Text = "Sale Rate";
            // 
            // lblMblNo
            // 
            this.lblMblNo.AutoSize = true;
            this.lblMblNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMblNo.Location = new System.Drawing.Point(620, 83);
            this.lblMblNo.Name = "lblMblNo";
            this.lblMblNo.Size = new System.Drawing.Size(124, 19);
            this.lblMblNo.TabIndex = 38;
            this.lblMblNo.Text = "Mobile Number :";
            // 
            // CustomerDetailDGV
            // 
            this.CustomerDetailDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerDetailDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDetailDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_Name,
            this.Customer_PhoneNumber,
            this.StateName,
            this.Customer_Address});
            this.CustomerDetailDGV.Location = new System.Drawing.Point(7, 111);
            this.CustomerDetailDGV.Name = "CustomerDetailDGV";
            this.CustomerDetailDGV.Size = new System.Drawing.Size(351, 89);
            this.CustomerDetailDGV.TabIndex = 36;
            this.CustomerDetailDGV.Visible = false;
            this.CustomerDetailDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDetailDGV_CellClick);
            this.CustomerDetailDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.CustomerDetailDGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerDetailDGV_KeyPress);
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            // 
            // Customer_PhoneNumber
            // 
            this.Customer_PhoneNumber.DataPropertyName = "Customer_PhoneNumber";
            this.Customer_PhoneNumber.HeaderText = "Phone Number";
            this.Customer_PhoneNumber.Name = "Customer_PhoneNumber";
            this.Customer_PhoneNumber.ReadOnly = true;
            // 
            // StateName
            // 
            this.StateName.DataPropertyName = "StateName";
            this.StateName.HeaderText = "State";
            this.StateName.Name = "StateName";
            this.StateName.ReadOnly = true;
            // 
            // Customer_Address
            // 
            this.Customer_Address.DataPropertyName = "Customer_Address";
            this.Customer_Address.HeaderText = "Address";
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.ReadOnly = true;
            // 
            // lblSaleInvoiceHeader
            // 
            this.lblSaleInvoiceHeader.AutoSize = true;
            this.lblSaleInvoiceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleInvoiceHeader.Location = new System.Drawing.Point(7, 14);
            this.lblSaleInvoiceHeader.Name = "lblSaleInvoiceHeader";
            this.lblSaleInvoiceHeader.Size = new System.Drawing.Size(182, 22);
            this.lblSaleInvoiceHeader.TabIndex = 0;
            this.lblSaleInvoiceHeader.Text = "Sales Invoice Header";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(119, 84);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(135, 30);
            this.txtCustomerName.TabIndex = 41;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            this.txtCustomerName.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(8, 51);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(102, 19);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "Invoice No. :";
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(768, 83);
            this.txtCustomerMobileNo.Multiline = true;
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(135, 30);
            this.txtCustomerMobileNo.TabIndex = 40;
            this.txtCustomerMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerMobileNo_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(305, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // lblSerchByNameMblNo
            // 
            this.lblSerchByNameMblNo.AutoSize = true;
            this.lblSerchByNameMblNo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerchByNameMblNo.Location = new System.Drawing.Point(7, 86);
            this.lblSerchByNameMblNo.Name = "lblSerchByNameMblNo";
            this.lblSerchByNameMblNo.Size = new System.Drawing.Size(116, 19);
            this.lblSerchByNameMblNo.TabIndex = 3;
            this.lblSerchByNameMblNo.Text = "Search/Name :";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(768, 47);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(135, 30);
            this.txtCustomerAddress.TabIndex = 39;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(303, 86);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(53, 19);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State :";
            // 
            // txtSalesInvoiceNo
            // 
            this.txtSalesInvoiceNo.Enabled = false;
            this.txtSalesInvoiceNo.Location = new System.Drawing.Point(119, 49);
            this.txtSalesInvoiceNo.Multiline = true;
            this.txtSalesInvoiceNo.Name = "txtSalesInvoiceNo";
            this.txtSalesInvoiceNo.Size = new System.Drawing.Size(135, 30);
            this.txtSalesInvoiceNo.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(620, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 19);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address :";
            // 
            // SalesDate
            // 
            this.SalesDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDate.Enabled = false;
            this.SalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDate.Location = new System.Drawing.Point(363, 49);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(200, 20);
            this.SalesDate.TabIndex = 9;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(363, 84);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(200, 21);
            this.cmbState.TabIndex = 10;
            // 
            // SalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 656);
            this.Controls.Add(this.pnlMain);
            this.Name = "SalesInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesInvoice";
            this.Load += new System.EventHandler(this.SalesInvoice_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlForm2.ResumeLayout(false);
            this.pnlForm2.PerformLayout();
            this.pnlAllBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesInvoiceDetailDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchProductDGV)).EndInit();
            this.groupBoxStock.ResumeLayout(false);
            this.groupBoxStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSerchByNameMblNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblSaleInvoiceHeader;
        private System.Windows.Forms.TextBox txtSalesInvoiceNo;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.DateTimePicker SalesDate;
        private System.Windows.Forms.DataGridView CustomerDetailDGV;
        private System.Windows.Forms.TextBox txtCustomerMobileNo;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblMblNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Panel pnlForm2;
        private System.Windows.Forms.DataGridView SalesInvoiceDetailDGV;
        private System.Windows.Forms.Label lblInvoiceDetail;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtRoundOffDiscount;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label lblNetAmt;
        private System.Windows.Forms.Label lblRoundOff;
        private System.Windows.Forms.Label lblFinalDiscount;
        private System.Windows.Forms.TextBox txtGrossAmount;
        private System.Windows.Forms.Label lblGrossAmt;
        private System.Windows.Forms.TextBox txtDiscountAmt;
        private System.Windows.Forms.Panel pnlAllBtn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView SearchProductDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_SalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_FreeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_AvailableQty;
        private System.Windows.Forms.Label lblSerachProduct;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.RadioButton rbProductCode;
        private System.Windows.Forms.RadioButton rbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.Label lblAvailableQty;
        private System.Windows.Forms.Label lblStkAvlQty;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductDiscount;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtProductFreeQty;
        private System.Windows.Forms.Label lblFreeQty;
        private System.Windows.Forms.TextBox txtProductQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSaleRate;
        private System.Windows.Forms.TextBox txtProductRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductFreeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_DiscountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAvailableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNetAmount;
    }
}
