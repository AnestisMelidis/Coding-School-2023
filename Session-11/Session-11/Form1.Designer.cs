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
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grvEmployee
            // 
            this.grvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEmployeeID,
            this.clmName,
            this.clmSurname,
            this.clmEmployeeType,
            this.clmSalary});
            this.grvEmployee.Location = new System.Drawing.Point(69, 104);
            this.grvEmployee.Name = "grvEmployee";
            this.grvEmployee.RowTemplate.Height = 25;
            this.grvEmployee.Size = new System.Drawing.Size(564, 135);
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
            this.grvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPropertyID,
            this.clmPropertyCode,
            this.clmPropertyDescription,
            this.clmPCID,
            this.clmTypeOfProduct,
            this.clmPrice,
            this.clmCost});
            this.grvProducts.Location = new System.Drawing.Point(69, 284);
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.RowTemplate.Height = 25;
            this.grvProducts.Size = new System.Drawing.Size(700, 118);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grvProducts);
            this.Controls.Add(this.grvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            this.ResumeLayout(false);

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
    }
}