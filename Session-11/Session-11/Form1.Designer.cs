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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvEmployee = new System.Windows.Forms.DataGridView();
            this.clmEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProducts = new System.Windows.Forms.DataGridView();
            this.clmPropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPropertyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPropertyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.chkFredo = new System.Windows.Forms.CheckBox();
            this.chkCap = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFredo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvEmployee
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEmployeeID,
            this.clmName,
            this.clmSurname,
            this.clmEmployeeType,
            this.clmSalary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvEmployee.Location = new System.Drawing.Point(69, 104);
            this.grvEmployee.Name = "grvEmployee";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvEmployee.RowTemplate.Height = 25;
            this.grvEmployee.Size = new System.Drawing.Size(564, 55);
            this.grvEmployee.TabIndex = 0;
            // 
            // clmEmployeeID
            // 
            this.clmEmployeeID.DataPropertyName = "ID";
            this.clmEmployeeID.HeaderText = "ID";
            this.clmEmployeeID.Name = "clmEmployeeID";
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmSurname
            // 
            this.clmSurname.DataPropertyName = "Surname";
            this.clmSurname.HeaderText = "Surname";
            this.clmSurname.Name = "clmSurname";
            // 
            // clmEmployeeType
            // 
            this.clmEmployeeType.DataPropertyName = "TypeOfEmployee";
            this.clmEmployeeType.HeaderText = "EmployeeType";
            this.clmEmployeeType.Name = "clmEmployeeType";
            // 
            // clmSalary
            // 
            this.clmSalary.DataPropertyName = "SalaryPerMonth";
            this.clmSalary.HeaderText = "Salary";
            this.clmSalary.Name = "clmSalary";
            // 
            // grvProducts
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPropertyID,
            this.clmPropertyCode,
            this.clmPropertyDescription,
            this.clmPCID,
            this.clmTypeOfProduct,
            this.clmPrice,
            this.clmCost});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvProducts.Location = new System.Drawing.Point(66, 174);
            this.grvProducts.Name = "grvProducts";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvProducts.RowTemplate.Height = 25;
            this.grvProducts.Size = new System.Drawing.Size(713, 118);
            this.grvProducts.TabIndex = 1;
            // 
            // clmPropertyID
            // 
            this.clmPropertyID.DataPropertyName = "ID";
            this.clmPropertyID.HeaderText = "ID";
            this.clmPropertyID.Name = "clmPropertyID";
            // 
            // clmPropertyCode
            // 
            this.clmPropertyCode.DataPropertyName = "Code";
            this.clmPropertyCode.HeaderText = "Code";
            this.clmPropertyCode.Name = "clmPropertyCode";
            // 
            // clmPropertyDescription
            // 
            this.clmPropertyDescription.DataPropertyName = "Description";
            this.clmPropertyDescription.HeaderText = "Description";
            this.clmPropertyDescription.Name = "clmPropertyDescription";
            // 
            // clmPCID
            // 
            this.clmPCID.DataPropertyName = "ProductCategoryID";
            this.clmPCID.HeaderText = "ProductCategoryID";
            this.clmPCID.Name = "clmPCID";
            // 
            // clmTypeOfProduct
            // 
            this.clmTypeOfProduct.DataPropertyName = "TypeOfProduct";
            this.clmTypeOfProduct.HeaderText = "TypeOfProduct";
            this.clmTypeOfProduct.Name = "clmTypeOfProduct";
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "Price";
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            // 
            // clmCost
            // 
            this.clmCost.DataPropertyName = "Cost";
            this.clmCost.HeaderText = "Cost";
            this.clmCost.Name = "clmCost";
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
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
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(339, 64);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(163, 35);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnLoadClick);
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
            this.gridEmployee.Location = new System.Drawing.Point(66, 322);
            this.gridEmployee.MainView = this.gridView1;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(758, 200);
            this.gridEmployee.TabIndex = 17;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 582);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.numCap);
            this.Controls.Add(this.numFredo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkCap);
            this.Controls.Add(this.chkFredo);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grvProducts);
            this.Controls.Add(this.grvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFredo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvEmployee;
        private DataGridView grvProducts;
        private DataGridViewTextBoxColumn clmEmployeeID;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmEmployeeType;
        private DataGridViewTextBoxColumn clmSalary;
        private DataGridViewTextBoxColumn clmPropertyID;
        private DataGridViewTextBoxColumn clmPropertyCode;
        private DataGridViewTextBoxColumn clmPropertyDescription;
        private DataGridViewTextBoxColumn clmPCID;
        private DataGridViewTextBoxColumn clmTypeOfProduct;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmCost;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtSalary;
        private Button btnSave;
        private ComboBox cmbType;
        private CheckBox chkFredo;
        private CheckBox chkCap;
        private Button btnShow;
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
    }
}