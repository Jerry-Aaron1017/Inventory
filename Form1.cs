using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BindSource = System.Windows.Forms.BindingSource;
using System.Threading.Tasks;

namespace Inventory;

public partial class frmAddProduct : Form
{
    private string _ProductName = string.Empty, _Category = string.Empty, _MfgDate = string.Empty, _ExpDate = string.Empty, _Description = string.Empty;
    private int _Quantity;
    private double _SellPrice;
    private static readonly string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };
    private BindSource showProductList;

    public frmAddProduct()
    {
        InitializeComponent();
        Load += frmAddProduct_Load;
        showProductList = new BindSource();
    }

    private void frmAddProduct_Load(object? sender, EventArgs e)
    {
        foreach (string category in ListOfProductCategory)
        {
            cbCategory.Items.Add(category);
        }
    }

    private void btnAddProduct_Click(object sender, EventArgs e)
    {
        try
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);

            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in Input: \"{ex.Message}\"");
        }
        finally
        {
            txtProductName.Clear();
            cbCategory.SelectedIndex = -1;
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now;
            txtQuantity.Clear();
            txtSellPrice.Clear();
            richTxtDescription.Clear();
        }
    }

    public static string Product_Name(string name)
    {
        if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            throw new CostumExceptions.StringFormatException(name);
        return name;
    }

    public int Quantity(string qty)
    {
        if (!Regex.IsMatch(qty, @"^[0-9]+$"))
            throw new CostumExceptions.NumberFormatException(qty);
        return Convert.ToInt32(qty);
    }

    public double SellingPrice(string price)
    {
        if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            throw new CostumExceptions.NumberFormatException(price);
        return Convert.ToDouble(price);
    }
}
