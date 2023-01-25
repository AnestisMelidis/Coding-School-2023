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
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.chkFood);
            this.Controls.Add(this.chkBeverages);
            this.Controls.Add(this.chkCoffee);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
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
        //private Button btnAddCart;
    }
}