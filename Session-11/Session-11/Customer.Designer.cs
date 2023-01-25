namespace Session_11
{
    partial class Customer
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
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.chkFood = new System.Windows.Forms.CheckBox();
            this.chkBeverages = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.addToCart = new System.Windows.Forms.Button();
            this.gridSales = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(101, 62);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(83, 23);
            this.cmbMenu.TabIndex = 34;
            // 
            // chkFood
            // 
            this.chkFood.AutoSize = true;
            this.chkFood.Location = new System.Drawing.Point(210, 29);
            this.chkFood.Name = "chkFood";
            this.chkFood.Size = new System.Drawing.Size(53, 19);
            this.chkFood.TabIndex = 33;
            this.chkFood.Text = "Food";
            this.chkFood.UseVisualStyleBackColor = true;
            this.chkFood.Click += new System.EventHandler(this.chkFood_Checked);
            // 
            // chkBeverages
            // 
            this.chkBeverages.AutoSize = true;
            this.chkBeverages.Location = new System.Drawing.Point(121, 29);
            this.chkBeverages.Name = "chkBeverages";
            this.chkBeverages.Size = new System.Drawing.Size(79, 19);
            this.chkBeverages.TabIndex = 32;
            this.chkBeverages.Text = "Beverages";
            this.chkBeverages.UseVisualStyleBackColor = true;
            this.chkBeverages.Click += new System.EventHandler(this.chkBevarages_Checked);
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(32, 29);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(61, 19);
            this.chkCoffee.TabIndex = 31;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            this.chkCoffee.Click += new System.EventHandler(this.chkCofee_Checked);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(80, 91);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 23);
            this.numQuantity.TabIndex = 35;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(351, 68);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(203, 32);
            this.addToCart.TabIndex = 36;
            this.addToCart.Text = "Add";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // gridSales
            // 
            this.gridSales.Location = new System.Drawing.Point(90, 197);
            this.gridSales.MainView = this.gridView1;
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(622, 208);
            this.gridSales.TabIndex = 37;
            this.gridSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmDescription,
            this.clmQuantity,
            this.clmPrice,
            this.clmTotal});
            this.gridView1.GridControl = this.gridSales;
            this.gridView1.Name = "gridView1";
            // 
            // clmDescription
            // 
            this.clmDescription.Caption = "Description";
            this.clmDescription.FieldName = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Visible = true;
            this.clmDescription.VisibleIndex = 0;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Caption = "Quantity";
            this.clmQuantity.FieldName = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Visible = true;
            this.clmQuantity.VisibleIndex = 2;
            // 
            // clmPrice
            // 
            this.clmPrice.Caption = "Price";
            this.clmPrice.FieldName = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Visible = true;
            this.clmPrice.VisibleIndex = 1;
            // 
            // clmTotal
            // 
            this.clmTotal.Caption = "Total Price";
            this.clmTotal.FieldName = "TotalPrice";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Visible = true;
            this.clmTotal.VisibleIndex = 3;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridSales);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.chkFood);
            this.Controls.Add(this.chkBeverages);
            this.Controls.Add(this.chkCoffee);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbMenu;
        private CheckBox chkFood;
        private CheckBox chkBeverages;
        private CheckBox chkCoffee;
        private NumericUpDown numQuantity;
        private Button addToCart;
        private DevExpress.XtraGrid.GridControl gridSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clmQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn clmDescription;
        private DevExpress.XtraGrid.Columns.GridColumn clmPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotal;
        //private Button btnAddCart;
    }
}