namespace Inventory;

partial class frmAddProduct
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.gridViewProductList = new System.Windows.Forms.DataGridView();
        this.btnAddProduct = new System.Windows.Forms.Button();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
        components = new System.ComponentModel.Container();
        this.addProduct = new System.Windows.Forms.Label();
        this.product = new System.Windows.Forms.Label();
        this.Category = new System.Windows.Forms.Label();
        this.mfgDate = new System.Windows.Forms.Label();
        this.expDate = new System.Windows.Forms.Label();
        this.quantity = new System.Windows.Forms.Label();
        this.sellPrice = new System.Windows.Forms.Label();
        this.description = new System.Windows.Forms.Label();
        this.txtProductName = new System.Windows.Forms.TextBox();
        this.txtQuantity = new System.Windows.Forms.TextBox();
        this.txtSellPrice = new System.Windows.Forms.TextBox();
        this.cbCategory = new System.Windows.Forms.ComboBox();
        this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
        this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
        this.richTxtDescription = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // addProduct
        // 
        this.addProduct.AutoSize = true;
        this.addProduct.Location = new System.Drawing.Point(38, 23);
        this.addProduct.Name = "addProduct";
        this.addProduct.Size = new System.Drawing.Size(72, 15);
        this.addProduct.TabIndex = 3;
        this.addProduct.Text = "Add Product";
        this.addProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        // 
        // product
        // 
        this.product.AutoSize = true;
        this.product.Location = new System.Drawing.Point(38, 69);
        this.product.Name = "product";
        this.product.Size = new System.Drawing.Size(38, 15);
        this.product.TabIndex = 4;
        this.product.Text = "Product";
        this.product.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // Category
        // 
        this.Category.AutoSize = true;
        this.Category.Location = new System.Drawing.Point(38, 104);
        this.Category.Name = "Category";
        this.Category.Size = new System.Drawing.Size(52, 15);
        this.Category.TabIndex = 5;
        this.Category.Text = "Category";
        this.Category.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // mfgDate
        // 
        this.mfgDate.AutoSize = true;
        this.mfgDate.Location = new System.Drawing.Point(38, 142);
        this.mfgDate.Name = "mfgDate";
        this.mfgDate.Size = new System.Drawing.Size(38, 15);
        this.mfgDate.TabIndex = 6;
        this.mfgDate.Text = "Mfg Date";
        this.mfgDate.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // expDate
        // 
        this.expDate.AutoSize = true;
        this.expDate.Location = new System.Drawing.Point(38, 179);
        this.expDate.Name = "expDate";
        this.expDate.Size = new System.Drawing.Size(38, 15);
        this.expDate.TabIndex = 4;
        this.expDate.Text = "Exp Date";
        this.expDate.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // quantity
        // 
        this.quantity.AutoSize = true;
        this.quantity.Location = new System.Drawing.Point(38, 213);
        this.quantity.Name = "quantity";
        this.quantity.Size = new System.Drawing.Size(38, 15);
        this.quantity.TabIndex = 5;
        this.quantity.Text = "Quantity";
        this.quantity.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // sellPrice
        // 
        this.sellPrice.AutoSize = true;
        this.sellPrice.Location = new System.Drawing.Point(38, 246);
        this.sellPrice.Name = "sellPrice";
        this.sellPrice.Size = new System.Drawing.Size(38, 15);
        this.sellPrice.TabIndex = 6;
        this.sellPrice.Text = "Sell Price";
        this.sellPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // description
        // 
        this.description.AutoSize = true;
        this.description.Location = new System.Drawing.Point(484, 69);
        this.description.Name = "description";
        this.description.Size = new System.Drawing.Size(38, 15);
        this.description.TabIndex = 7;
        this.description.Text = "Description";
        this.description.Font = new System.Drawing.Font("Segoe UI", 11F);
        // 
        // txtProductName
        // 
        this.txtProductName.Location = new System.Drawing.Point(112, 69);
        this.txtProductName.Name = "txtProductName";
        this.txtProductName.Size = new System.Drawing.Size(326, 25);
        this.txtProductName.TabIndex = 8;
        // 
        // txtQuantity
        // 
        this.txtQuantity.Location = new System.Drawing.Point(112, 246);
        this.txtQuantity.Name = "txtQuantity";
        this.txtQuantity.Size = new System.Drawing.Size(324, 25);
        this.txtQuantity.TabIndex = 9;
        // 
        // txtSellPrice
        // 
        this.txtSellPrice.Location = new System.Drawing.Point(112, 213);
        this.txtSellPrice.Name = "txtSellPrice";
        this.txtSellPrice.Size = new System.Drawing.Size(324, 25);
        this.txtSellPrice.TabIndex = 10;
        // 
        // cbCategory
        // 
        this.cbCategory.Location = new System.Drawing.Point(112, 104);
        this.cbCategory.Name = "cbCategory";
        this.cbCategory.Size = new System.Drawing.Size(324, 25);
        this.cbCategory.TabIndex = 11;
        // 
        // dtPickerMfgDate
        // 
        this.dtPickerMfgDate.Location = new System.Drawing.Point(112, 140);
        this.dtPickerMfgDate.Name = "dtPickerMfgDate";
        this.dtPickerMfgDate.TabIndex = 12;
        this.dtPickerMfgDate.Size = new System.Drawing.Size(324, 25);
        // 
        // dtPickerExpDate
        // 
        this.dtPickerExpDate.Location = new System.Drawing.Point(112, 177);
        this.dtPickerExpDate.Name = "dtPickerExpDate";
        this.dtPickerExpDate.TabIndex = 13;
        this.dtPickerExpDate.Size = new System.Drawing.Size(324, 25);
        // 
        // richTxtDescription
        // 
        this.richTxtDescription.Location = new System.Drawing.Point(484, 93);
        this.richTxtDescription.Name = "richTxtDescription";
        this.richTxtDescription.TabIndex = 14;
        this.richTxtDescription.Size = new System.Drawing.Size(413, 178);
        // 
        // gridViewProductList
        // 
        this.gridViewProductList.Location = new System.Drawing.Point(38, 332);
        this.gridViewProductList.Name = "gridViewProductList";
        this.gridViewProductList.TabIndex = 15;
        this.gridViewProductList.Size = new System.Drawing.Size(859, 240);
        // 
        // btnAddProduct
        // 
        this.btnAddProduct.Location = new System.Drawing.Point(789, 285);
        this.btnAddProduct.Name = "btnAddProduct";
        this.btnAddProduct.Size = new System.Drawing.Size(108, 32);
        this.btnAddProduct.TabIndex = 16;
        this.btnAddProduct.Text = "Add Product";
        this.btnAddProduct.UseVisualStyleBackColor = true;
        this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
        // 
        // Inventory
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(927, 586);
        CenterToScreen();
        this.Controls.Add(this.btnAddProduct);
        this.Controls.Add(this.gridViewProductList);
        this.Controls.Add(this.richTxtDescription);
        this.Controls.Add(this.dtPickerExpDate);
        this.Controls.Add(this.dtPickerMfgDate);
        this.Controls.Add(this.cbCategory);
        this.Controls.Add(this.txtSellPrice);
        this.Controls.Add(this.txtQuantity);
        this.Controls.Add(this.txtProductName);
        this.Controls.Add(this.description);
        this.Controls.Add(this.sellPrice);
        this.Controls.Add(this.quantity);
        this.Controls.Add(this.expDate);
        this.Controls.Add(this.mfgDate);
        this.Controls.Add(this.Category);
        this.Controls.Add(this.product);
        this.Controls.Add(this.addProduct);
        this.Name = "Inventory";
        Text = "Inventory";
        this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
        this.AutoSize = false;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.HelpButton = false;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label addProduct;
    private System.Windows.Forms.Label product;
    private System.Windows.Forms.Label Category;
    private System.Windows.Forms.Label mfgDate;
    private System.Windows.Forms.Label expDate;
    private System.Windows.Forms.Label quantity;
    private System.Windows.Forms.Label sellPrice;
    private System.Windows.Forms.Label description;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.TextBox txtSellPrice;
    private System.Windows.Forms.ComboBox cbCategory;
    private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
    private System.Windows.Forms.DateTimePicker dtPickerExpDate;
    private System.Windows.Forms.RichTextBox richTxtDescription;
    private System.Windows.Forms.DataGridView gridViewProductList;
    private System.Windows.Forms.Button btnAddProduct;
}
