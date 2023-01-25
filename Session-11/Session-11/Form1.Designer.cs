namespace Session_11 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSaveEmployees = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.chkFredo = new System.Windows.Forms.CheckBox();
            this.chkCap = new System.Windows.Forms.CheckBox();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numFredo = new System.Windows.Forms.NumericUpDown();
            this.numCap = new System.Windows.Forms.NumericUpDown();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridclmID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridProClmID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmProID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cmbProType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFredo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(184, 35);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(112, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(420, 35);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(112, 23);
            this.txtSalary.TabIndex = 5;
            // 
            // btnSaveEmployees
            // 
            this.btnSaveEmployees.Location = new System.Drawing.Point(160, 64);
            this.btnSaveEmployees.Name = "btnSaveEmployees";
            this.btnSaveEmployees.Size = new System.Drawing.Size(163, 35);
            this.btnSaveEmployees.TabIndex = 7;
            this.btnSaveEmployees.Text = "Save";
            this.btnSaveEmployees.UseVisualStyleBackColor = true;
            this.btnSaveEmployees.Click += new System.EventHandler(this.btnSaveEmployeesClick);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Barista",
            "Waiter"});
            this.cmbType.Location = new System.Drawing.Point(301, 35);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(114, 23);
            this.cmbType.TabIndex = 8;
            // 
            // chkFredo
            // 
            this.chkFredo.AutoSize = true;
            this.chkFredo.Location = new System.Drawing.Point(900, 40);
            this.chkFredo.Name = "chkFredo";
            this.chkFredo.Size = new System.Drawing.Size(56, 19);
            this.chkFredo.TabIndex = 9;
            this.chkFredo.Text = "Fredo";
            this.chkFredo.UseVisualStyleBackColor = true;
            this.chkFredo.CheckedChanged += new System.EventHandler(this.chkFredo_CheckedChanged);
            // 
            // chkCap
            // 
            this.chkCap.AutoSize = true;
            this.chkCap.Location = new System.Drawing.Point(900, 69);
            this.chkCap.Name = "chkCap";
            this.chkCap.Size = new System.Drawing.Size(90, 19);
            this.chkCap.TabIndex = 10;
            this.chkCap.Text = "Cappuccino";
            this.chkCap.UseVisualStyleBackColor = true;
            this.chkCap.CheckedChanged += new System.EventHandler(this.chkCap_CheckedChanged);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(339, 64);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(163, 35);
            this.btnShowEmployees.TabIndex = 13;
            this.btnShowEmployees.Text = "Show";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnLoadEmployeesClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPrice);
            // 
            // numFredo
            // 
            this.numFredo.Location = new System.Drawing.Point(996, 35);
            this.numFredo.Name = "numFredo";
            this.numFredo.Size = new System.Drawing.Size(86, 23);
            this.numFredo.TabIndex = 15;
            // 
            // numCap
            // 
            this.numCap.Location = new System.Drawing.Point(996, 64);
            this.numCap.Name = "numCap";
            this.numCap.Size = new System.Drawing.Size(86, 23);
            this.numCap.TabIndex = 16;
            // 
            // gridEmployee
            // 
            this.gridEmployee.Location = new System.Drawing.Point(46, 428);
            this.gridEmployee.MainView = this.gridView1;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(758, 131);
            this.gridEmployee.TabIndex = 17;
            this.gridEmployee.UseEmbeddedNavigator = true;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridclmID,
            this.gridclmName,
            this.gridclmSurname,
            this.gridclmEmployeeType,
            this.gridclmSalary});
            this.gridView1.GridControl = this.gridEmployee;
            this.gridView1.Name = "gridView1";
            // 
            // gridclmID
            // 
            this.gridclmID.Caption = "ID";
            this.gridclmID.FieldName = "ID";
            this.gridclmID.Name = "gridclmID";
            this.gridclmID.Visible = true;
            this.gridclmID.VisibleIndex = 0;
            // 
            // gridclmName
            // 
            this.gridclmName.Caption = "Name";
            this.gridclmName.FieldName = "Name";
            this.gridclmName.Name = "gridclmName";
            this.gridclmName.Visible = true;
            this.gridclmName.VisibleIndex = 1;
            // 
            // gridclmSurname
            // 
            this.gridclmSurname.Caption = "Surname";
            this.gridclmSurname.FieldName = "Surname";
            this.gridclmSurname.Name = "gridclmSurname";
            this.gridclmSurname.Visible = true;
            this.gridclmSurname.VisibleIndex = 2;
            // 
            // gridclmEmployeeType
            // 
            this.gridclmEmployeeType.Caption = "EmployeeType";
            this.gridclmEmployeeType.FieldName = "TypeOfEmployee";
            this.gridclmEmployeeType.Name = "gridclmEmployeeType";
            this.gridclmEmployeeType.Visible = true;
            this.gridclmEmployeeType.VisibleIndex = 3;
            // 
            // gridclmSalary
            // 
            this.gridclmSalary.Caption = "Salary";
            this.gridclmSalary.FieldName = "SalaryPerMonth";
            this.gridclmSalary.Name = "gridclmSalary";
            this.gridclmSalary.Visible = true;
            this.gridclmSalary.VisibleIndex = 4;
            // 
            // gridProducts
            // 
            this.gridProducts.Location = new System.Drawing.Point(46, 293);
            this.gridProducts.MainView = this.gridView2;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(750, 129);
            this.gridProducts.TabIndex = 18;
            this.gridProducts.UseEmbeddedNavigator = true;
            this.gridProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridProClmID,
            this.gridProClmCode,
            this.gridProClmDesc,
            this.gridProClmProID,
            this.gridProClmType,
            this.gridProClmPrice,
            this.gridProClmCost});
            this.gridView2.GridControl = this.gridProducts;
            this.gridView2.Name = "gridView2";
            // 
            // gridProClmID
            // 
            this.gridProClmID.Caption = "ID";
            this.gridProClmID.FieldName = "ID";
            this.gridProClmID.Name = "gridProClmID";
            this.gridProClmID.Visible = true;
            this.gridProClmID.VisibleIndex = 0;
            // 
            // gridProClmCode
            // 
            this.gridProClmCode.Caption = "Code";
            this.gridProClmCode.FieldName = "Code";
            this.gridProClmCode.Name = "gridProClmCode";
            this.gridProClmCode.Visible = true;
            this.gridProClmCode.VisibleIndex = 1;
            // 
            // gridProClmDesc
            // 
            this.gridProClmDesc.Caption = "Description";
            this.gridProClmDesc.FieldName = "Description";
            this.gridProClmDesc.Name = "gridProClmDesc";
            this.gridProClmDesc.Visible = true;
            this.gridProClmDesc.VisibleIndex = 2;
            // 
            // gridProClmProID
            // 
            this.gridProClmProID.Caption = "ProductID";
            this.gridProClmProID.FieldName = "ProductCategoryID";
            this.gridProClmProID.Name = "gridProClmProID";
            this.gridProClmProID.Visible = true;
            this.gridProClmProID.VisibleIndex = 3;
            // 
            // gridProClmType
            // 
            this.gridProClmType.Caption = "Type";
            this.gridProClmType.FieldName = "TypeOfProduct";
            this.gridProClmType.Name = "gridProClmType";
            this.gridProClmType.Visible = true;
            this.gridProClmType.VisibleIndex = 4;
            // 
            // gridProClmPrice
            // 
            this.gridProClmPrice.Caption = "Price";
            this.gridProClmPrice.FieldName = "Price";
            this.gridProClmPrice.Name = "gridProClmPrice";
            this.gridProClmPrice.Visible = true;
            this.gridProClmPrice.VisibleIndex = 5;
            // 
            // gridProClmCost
            // 
            this.gridProClmCost.Caption = "Cost";
            this.gridProClmCost.FieldName = "Cost";
            this.gridProClmCost.Name = "gridProClmCost";
            this.gridProClmCost.Visible = true;
            this.gridProClmCost.VisibleIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(46, 216);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(112, 23);
            this.txtDesc.TabIndex = 19;
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Location = new System.Drawing.Point(160, 252);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(163, 35);
            this.btnSaveProducts.TabIndex = 20;
            this.btnSaveProducts.Text = "Save";
            this.btnSaveProducts.UseVisualStyleBackColor = true;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProductsClick);
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.Location = new System.Drawing.Point(339, 252);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(163, 35);
            this.btnLoadProducts.TabIndex = 21;
            this.btnLoadProducts.Text = "Show";
            this.btnLoadProducts.UseVisualStyleBackColor = true;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProductsClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(301, 216);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 23);
            this.txtPrice.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "desc-type-price-cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(433, 216);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(112, 23);
            this.txtCost.TabIndex = 24;
            // 
            // cmbProType
            // 
            this.cmbProType.FormattingEnabled = true;
            this.cmbProType.Items.AddRange(new object[] {
            "Coffee",
            "Beverages",
            "Food"});
            this.cmbProType.Location = new System.Drawing.Point(181, 216);
            this.cmbProType.Name = "cmbProType";
            this.cmbProType.Size = new System.Drawing.Size(114, 23);
            this.cmbProType.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbProType);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnLoadProducts);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.numCap);
            this.Controls.Add(this.numFredo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.chkCap);
            this.Controls.Add(this.chkFredo);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSaveEmployees);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFredo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtSalary;
        private Button btnSaveEmployees;
        private ComboBox cmbType;
        private CheckBox chkFredo;
        private CheckBox chkCap;
        private Button btnShowEmployees;
        private Button button1;
        private NumericUpDown numFredo;
        private NumericUpDown numCap;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmID;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmName;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmSalary;
        private DevExpress.XtraGrid.GridControl gridProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmID;
        private TextBox txtDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmProID;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmType;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmCost;
        private Button btnSaveProducts;
        private Button btnLoadProducts;
        private TextBox txtPrice;
        private Label label1;
        private TextBox txtCost;
        private ComboBox cmbProType;
        private Button button2;
    }
}