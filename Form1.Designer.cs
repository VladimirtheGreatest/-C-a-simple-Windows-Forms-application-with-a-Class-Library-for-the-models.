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
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(476, 55);
            this.headerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(413, 36);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Welcome to Vladimir`s shop";
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Location = new System.Drawing.Point(226, 181);
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
            this.itemsListbox.Location = new System.Drawing.Point(229, 201);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(278, 244);
            this.itemsListbox.TabIndex = 2;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(598, 290);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(154, 52);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart  >>>";
            this.addToCart.UseVisualStyleBackColor = true;
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(831, 201);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(278, 244);
            this.shoppingCartListbox.TabIndex = 5;
            // 
            // ShoppingCartListboxLabel
            // 
            this.ShoppingCartListboxLabel.AutoSize = true;
            this.ShoppingCartListboxLabel.Location = new System.Drawing.Point(828, 181);
            this.ShoppingCartListboxLabel.Name = "ShoppingCartListboxLabel";
            this.ShoppingCartListboxLabel.Size = new System.Drawing.Size(110, 17);
            this.ShoppingCartListboxLabel.TabIndex = 4;
            this.ShoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(955, 451);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(154, 52);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 769);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.ShoppingCartListboxLabel);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

