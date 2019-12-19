namespace WindowsFormsApp1
{
    partial class Shop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.ShoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.supplierListbox = new System.Windows.Forms.ListBox();
            this.supplierListboxLabel = new System.Windows.Forms.Label();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(472, 27);
            this.headerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(413, 36);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Welcome to Vladimir`s shop";
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Location = new System.Drawing.Point(226, 120);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(90, 17);
            this.itemsListboxLabel.TabIndex = 1;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // itemsListbox
            // 
            this.itemsListbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 20;
            this.itemsListbox.Location = new System.Drawing.Point(229, 140);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(278, 244);
            this.itemsListbox.TabIndex = 2;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(600, 227);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(154, 52);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart  >>>";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(820, 140);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(278, 244);
            this.shoppingCartListbox.TabIndex = 5;
            // 
            // ShoppingCartListboxLabel
            // 
            this.ShoppingCartListboxLabel.AutoSize = true;
            this.ShoppingCartListboxLabel.Location = new System.Drawing.Point(828, 120);
            this.ShoppingCartListboxLabel.Name = "ShoppingCartListboxLabel";
            this.ShoppingCartListboxLabel.Size = new System.Drawing.Size(110, 17);
            this.ShoppingCartListboxLabel.TabIndex = 4;
            this.ShoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(884, 390);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(154, 52);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // supplierListbox
            // 
            this.supplierListbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListbox.FormattingEnabled = true;
            this.supplierListbox.ItemHeight = 20;
            this.supplierListbox.Location = new System.Drawing.Point(229, 498);
            this.supplierListbox.Name = "supplierListbox";
            this.supplierListbox.Size = new System.Drawing.Size(278, 244);
            this.supplierListbox.TabIndex = 8;
            // 
            // supplierListboxLabel
            // 
            this.supplierListboxLabel.AutoSize = true;
            this.supplierListboxLabel.Location = new System.Drawing.Point(226, 478);
            this.supplierListboxLabel.Name = "supplierListboxLabel";
            this.supplierListboxLabel.Size = new System.Drawing.Size(83, 17);
            this.supplierListboxLabel.TabIndex = 7;
            this.supplierListboxLabel.Text = "Producers";
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutLabel.Location = new System.Drawing.Point(774, 573);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(179, 36);
            this.storePayoutLabel.TabIndex = 9;
            this.storePayoutLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(994, 573);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(104, 36);
            this.storeProfitValue.TabIndex = 11;
            this.storeProfitValue.Text = "£0.00";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 769);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.supplierListbox);
            this.Controls.Add(this.supplierListboxLabel);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.ShoppingCartListboxLabel);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Label ShoppingCartListboxLabel;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox supplierListbox;
        private System.Windows.Forms.Label supplierListboxLabel;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

