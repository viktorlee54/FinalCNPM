namespace Final_CNPM_Winform
{
    partial class MainForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ImportTab = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgImport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PaymentTab = new System.Windows.Forms.TabPage();
            this.dtgPayment = new System.Windows.Forms.DataGridView();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtPaymentName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AgentSTab = new System.Windows.Forms.TabPage();
            this.txtAgentPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgentAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgentEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgAgent = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MainPage = new System.Windows.Forms.TabControl();
            this.ExportPage = new System.Windows.Forms.TabPage();
            this.btnAddEx = new System.Windows.Forms.Button();
            this.dtgExport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReportPage = new System.Windows.Forms.TabPage();
            this.ColPayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayDel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ImportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).BeginInit();
            this.PaymentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayment)).BeginInit();
            this.AgentSTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgent)).BeginInit();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.MainPage.SuspendLayout();
            this.ExportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExport)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ImportTab
            // 
            this.ImportTab.Controls.Add(this.btnAdd);
            this.ImportTab.Controls.Add(this.dtgImport);
            this.ImportTab.Location = new System.Drawing.Point(4, 25);
            this.ImportTab.Name = "ImportTab";
            this.ImportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportTab.Size = new System.Drawing.Size(1034, 650);
            this.ImportTab.TabIndex = 3;
            this.ImportTab.Text = "Imports";
            this.ImportTab.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 35);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add Import Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtgImport
            // 
            this.dtgImport.AllowUserToAddRows = false;
            this.dtgImport.AllowUserToDeleteRows = false;
            this.dtgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.colPayment,
            this.colDate,
            this.colStatus,
            this.colDetail});
            this.dtgImport.Location = new System.Drawing.Point(16, 87);
            this.dtgImport.Margin = new System.Windows.Forms.Padding(4);
            this.dtgImport.Name = "dtgImport";
            this.dtgImport.ReadOnly = true;
            this.dtgImport.RowHeadersWidth = 51;
            this.dtgImport.Size = new System.Drawing.Size(1034, 567);
            this.dtgImport.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IM_OR_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // colPayment
            // 
            this.colPayment.DataPropertyName = "IMPORT_DATE";
            this.colPayment.HeaderText = "Date";
            this.colPayment.MinimumWidth = 6;
            this.colPayment.Name = "colPayment";
            this.colPayment.ReadOnly = true;
            this.colPayment.Width = 125;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "PAYMENT_ID";
            this.colDate.HeaderText = "Payment ID";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IMPORT_STATUS";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = "Details";
            this.colDetail.MinimumWidth = 6;
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Text = "Detail";
            this.colDetail.UseColumnTextForButtonValue = true;
            this.colDetail.Width = 125;
            // 
            // PaymentTab
            // 
            this.PaymentTab.Controls.Add(this.dtgPayment);
            this.PaymentTab.Controls.Add(this.txtPaymentId);
            this.PaymentTab.Controls.Add(this.label8);
            this.PaymentTab.Controls.Add(this.btnAddPayment);
            this.PaymentTab.Controls.Add(this.txtPaymentName);
            this.PaymentTab.Controls.Add(this.label10);
            this.PaymentTab.Location = new System.Drawing.Point(4, 25);
            this.PaymentTab.Name = "PaymentTab";
            this.PaymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentTab.Size = new System.Drawing.Size(1034, 650);
            this.PaymentTab.TabIndex = 2;
            this.PaymentTab.Text = "Payment Methods";
            this.PaymentTab.UseVisualStyleBackColor = true;
            // 
            // dtgPayment
            // 
            this.dtgPayment.AllowUserToAddRows = false;
            this.dtgPayment.AllowUserToDeleteRows = false;
            this.dtgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPayId,
            this.dataGridViewTextBoxColumn4,
            this.colPayDel});
            this.dtgPayment.Location = new System.Drawing.Point(0, 117);
            this.dtgPayment.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPayment.Name = "dtgPayment";
            this.dtgPayment.ReadOnly = true;
            this.dtgPayment.RowHeadersWidth = 51;
            this.dtgPayment.Size = new System.Drawing.Size(1034, 533);
            this.dtgPayment.TabIndex = 26;
            this.dtgPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPayment_CellClick);
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(129, 33);
            this.txtPaymentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(115, 22);
            this.txtPaymentId.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID:";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(828, 30);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(100, 28);
            this.btnAddPayment.TabIndex = 21;
            this.btnAddPayment.Text = "Add";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtPaymentName
            // 
            this.txtPaymentName.Location = new System.Drawing.Point(531, 33);
            this.txtPaymentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentName.Name = "txtPaymentName";
            this.txtPaymentName.Size = new System.Drawing.Size(235, 22);
            this.txtPaymentName.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Payment Methods Name";
            // 
            // AgentSTab
            // 
            this.AgentSTab.Controls.Add(this.txtAgentPhone);
            this.AgentSTab.Controls.Add(this.label6);
            this.AgentSTab.Controls.Add(this.txtAgentAddress);
            this.AgentSTab.Controls.Add(this.label7);
            this.AgentSTab.Controls.Add(this.txtAgentId);
            this.AgentSTab.Controls.Add(this.label3);
            this.AgentSTab.Controls.Add(this.txtAgentEmail);
            this.AgentSTab.Controls.Add(this.label4);
            this.AgentSTab.Controls.Add(this.btnAddAgent);
            this.AgentSTab.Controls.Add(this.txtAgentName);
            this.AgentSTab.Controls.Add(this.label5);
            this.AgentSTab.Controls.Add(this.dtgAgent);
            this.AgentSTab.Location = new System.Drawing.Point(4, 25);
            this.AgentSTab.Name = "AgentSTab";
            this.AgentSTab.Padding = new System.Windows.Forms.Padding(3);
            this.AgentSTab.Size = new System.Drawing.Size(1034, 650);
            this.AgentSTab.TabIndex = 1;
            this.AgentSTab.Text = "Agents";
            this.AgentSTab.UseVisualStyleBackColor = true;
            // 
            // txtAgentPhone
            // 
            this.txtAgentPhone.Location = new System.Drawing.Point(655, 97);
            this.txtAgentPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentPhone.Name = "txtAgentPhone";
            this.txtAgentPhone.Size = new System.Drawing.Size(235, 22);
            this.txtAgentPhone.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone";
            // 
            // txtAgentAddress
            // 
            this.txtAgentAddress.Location = new System.Drawing.Point(331, 91);
            this.txtAgentAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentAddress.Name = "txtAgentAddress";
            this.txtAgentAddress.Size = new System.Drawing.Size(235, 22);
            this.txtAgentAddress.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Agent Address";
            // 
            // txtAgentId
            // 
            this.txtAgentId.Location = new System.Drawing.Point(44, 32);
            this.txtAgentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.Size = new System.Drawing.Size(115, 22);
            this.txtAgentId.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID:";
            // 
            // txtAgentEmail
            // 
            this.txtAgentEmail.Location = new System.Drawing.Point(655, 26);
            this.txtAgentEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentEmail.Name = "txtAgentEmail";
            this.txtAgentEmail.Size = new System.Drawing.Size(235, 22);
            this.txtAgentEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.Location = new System.Drawing.Point(913, 23);
            this.btnAddAgent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(100, 28);
            this.btnAddAgent.TabIndex = 14;
            this.btnAddAgent.Text = "Add";
            this.btnAddAgent.UseVisualStyleBackColor = true;
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click);
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(331, 32);
            this.txtAgentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(235, 22);
            this.txtAgentName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Agent Name";
            // 
            // dtgAgent
            // 
            this.dtgAgent.AllowUserToAddRows = false;
            this.dtgAgent.AllowUserToDeleteRows = false;
            this.dtgAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.col,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.dtgAgent.Location = new System.Drawing.Point(0, 158);
            this.dtgAgent.Margin = new System.Windows.Forms.Padding(4);
            this.dtgAgent.Name = "dtgAgent";
            this.dtgAgent.ReadOnly = true;
            this.dtgAgent.RowHeadersWidth = 51;
            this.dtgAgent.Size = new System.Drawing.Size(1034, 492);
            this.dtgAgent.TabIndex = 4;
            this.dtgAgent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgent_CellClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "AGENT_ID";
            this.colID.HeaderText = "Id";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "AGENT_NAME";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // col
            // 
            this.col.DataPropertyName = "AGENT_EMAIL";
            this.col.HeaderText = "Email";
            this.col.MinimumWidth = 6;
            this.col.Name = "col";
            this.col.ReadOnly = true;
            this.col.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AGENT_ADDRESS";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AGENT_PHONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Delete";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.txtID);
            this.ProductsTab.Controls.Add(this.lbl3);
            this.ProductsTab.Controls.Add(this.txtPrice);
            this.ProductsTab.Controls.Add(this.label2);
            this.ProductsTab.Controls.Add(this.btnAddProduct);
            this.ProductsTab.Controls.Add(this.txtName);
            this.ProductsTab.Controls.Add(this.label1);
            this.ProductsTab.Controls.Add(this.dtgProduct);
            this.ProductsTab.Location = new System.Drawing.Point(4, 25);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(1034, 650);
            this.ProductsTab.TabIndex = 0;
            this.ProductsTab.Text = "Products";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(67, 26);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(115, 22);
            this.txtID.TabIndex = 11;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(27, 35);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(23, 16);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "ID:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(674, 29);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(235, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(927, 26);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 22);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // dtgProduct
            // 
            this.dtgProduct.AllowUserToAddRows = false;
            this.dtgProduct.AllowUserToDeleteRows = false;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProId,
            this.ProName,
            this.ProPrice,
            this.colDelete});
            this.dtgProduct.Location = new System.Drawing.Point(7, 63);
            this.dtgProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.ReadOnly = true;
            this.dtgProduct.RowHeadersWidth = 51;
            this.dtgProduct.Size = new System.Drawing.Size(1034, 583);
            this.dtgProduct.TabIndex = 3;
            this.dtgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellClick);
            // 
            // ProId
            // 
            this.ProId.DataPropertyName = "PRODUCT_ID";
            this.ProId.HeaderText = "Id";
            this.ProId.MinimumWidth = 6;
            this.ProId.Name = "ProId";
            this.ProId.ReadOnly = true;
            this.ProId.Width = 125;
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "PRODUCT_NAME";
            this.ProName.HeaderText = "Name";
            this.ProName.MinimumWidth = 6;
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            this.ProName.Width = 125;
            // 
            // ProPrice
            // 
            this.ProPrice.DataPropertyName = "PRODUCT_PRICE";
            this.ProPrice.HeaderText = "Price";
            this.ProPrice.MinimumWidth = 6;
            this.ProPrice.Name = "ProPrice";
            this.ProPrice.ReadOnly = true;
            this.ProPrice.Width = 125;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 125;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.ProductsTab);
            this.MainPage.Controls.Add(this.AgentSTab);
            this.MainPage.Controls.Add(this.PaymentTab);
            this.MainPage.Controls.Add(this.ImportTab);
            this.MainPage.Controls.Add(this.ExportPage);
            this.MainPage.Controls.Add(this.ReportPage);
            this.MainPage.Location = new System.Drawing.Point(2, 3);
            this.MainPage.Name = "MainPage";
            this.MainPage.SelectedIndex = 0;
            this.MainPage.Size = new System.Drawing.Size(1042, 679);
            this.MainPage.TabIndex = 0;
            // 
            // ExportPage
            // 
            this.ExportPage.Controls.Add(this.btnAddEx);
            this.ExportPage.Controls.Add(this.dtgExport);
            this.ExportPage.Location = new System.Drawing.Point(4, 25);
            this.ExportPage.Name = "ExportPage";
            this.ExportPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExportPage.Size = new System.Drawing.Size(1034, 650);
            this.ExportPage.TabIndex = 4;
            this.ExportPage.Text = "Exports";
            this.ExportPage.UseVisualStyleBackColor = true;
            // 
            // btnAddEx
            // 
            this.btnAddEx.Location = new System.Drawing.Point(22, 31);
            this.btnAddEx.Name = "btnAddEx";
            this.btnAddEx.Size = new System.Drawing.Size(159, 35);
            this.btnAddEx.TabIndex = 29;
            this.btnAddEx.Text = "Add Export Order";
            this.btnAddEx.UseVisualStyleBackColor = true;
            // 
            // dtgExport
            // 
            this.dtgExport.AllowUserToAddRows = false;
            this.dtgExport.AllowUserToDeleteRows = false;
            this.dtgExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.colExStatus,
            this.colExDetail});
            this.dtgExport.Location = new System.Drawing.Point(0, 114);
            this.dtgExport.Margin = new System.Windows.Forms.Padding(4);
            this.dtgExport.Name = "dtgExport";
            this.dtgExport.ReadOnly = true;
            this.dtgExport.RowHeadersWidth = 51;
            this.dtgExport.Size = new System.Drawing.Size(1034, 536);
            this.dtgExport.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EXPORT_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AGENT_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Agent ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EXPORT_DATE";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PAYMENT_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // colExStatus
            // 
            this.colExStatus.DataPropertyName = "ORDER_STATUS";
            this.colExStatus.HeaderText = "Status";
            this.colExStatus.MinimumWidth = 6;
            this.colExStatus.Name = "colExStatus";
            this.colExStatus.ReadOnly = true;
            this.colExStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExStatus.Width = 125;
            // 
            // colExDetail
            // 
            this.colExDetail.HeaderText = "Details";
            this.colExDetail.MinimumWidth = 6;
            this.colExDetail.Name = "colExDetail";
            this.colExDetail.ReadOnly = true;
            this.colExDetail.Text = "Detail";
            this.colExDetail.UseColumnTextForButtonValue = true;
            this.colExDetail.Width = 125;
            // 
            // ReportPage
            // 
            this.ReportPage.Location = new System.Drawing.Point(4, 25);
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportPage.Size = new System.Drawing.Size(1034, 650);
            this.ReportPage.TabIndex = 5;
            this.ReportPage.Text = "Reports";
            this.ReportPage.UseVisualStyleBackColor = true;
            // 
            // ColPayId
            // 
            this.ColPayId.DataPropertyName = "PAYMENT_ID";
            this.ColPayId.HeaderText = "Id";
            this.ColPayId.MinimumWidth = 6;
            this.ColPayId.Name = "ColPayId";
            this.ColPayId.ReadOnly = true;
            this.ColPayId.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PAYMENT_NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // colPayDel
            // 
            this.colPayDel.HeaderText = "Delete";
            this.colPayDel.MinimumWidth = 6;
            this.colPayDel.Name = "colPayDel";
            this.colPayDel.ReadOnly = true;
            this.colPayDel.Text = "Delete";
            this.colPayDel.UseColumnTextForButtonValue = true;
            this.colPayDel.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 685);
            this.Controls.Add(this.MainPage);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ImportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).EndInit();
            this.PaymentTab.ResumeLayout(false);
            this.PaymentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayment)).EndInit();
            this.AgentSTab.ResumeLayout(false);
            this.AgentSTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgent)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            this.ProductsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.MainPage.ResumeLayout(false);
            this.ExportPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl MainPage;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.TabPage AgentSTab;
        private System.Windows.Forms.TabPage PaymentTab;
        private System.Windows.Forms.TabPage ImportTab;
        private System.Windows.Forms.TabPage ExportPage;
        private System.Windows.Forms.TabPage ReportPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAgentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgentEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgAgent;
        private System.Windows.Forms.TextBox txtAgentPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAgentAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox txtPaymentName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgPayment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgImport;
        private System.Windows.Forms.DataGridView dtgExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
        private System.Windows.Forms.Button btnAddEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colExDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn colPayDel;
    }
}

