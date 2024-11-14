using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BillCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if this is the first time the page is loading
        if (!IsPostBack)
        {
            // Initialize any default values (if necessary)
            txtQuantity.Text = ""; // Reset Quantity TextBox
            txtUnitPrice.Text = ""; // Reset UnitPrice TextBox
            lblTotalAmount.Text = "Total Amount: ";
            lblDiscount.Text = "Discount: ";
            lblFinalAmount.Text = "Final Amount: ";
        }
    }

    // Add the event handler for the button click if it's not added
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        // Parse input values
        int quantity;
        decimal unitPrice;

        // Validate quantity input (only numbers)
        if (int.TryParse(txtQuantity.Text, out quantity) && decimal.TryParse(txtUnitPrice.Text, out unitPrice))
        {
            // Calculate total amount before discount
            decimal totalAmount = quantity * unitPrice;
            decimal discount = 0;

            // Apply discount based on quantity
            if (quantity >= 5 && quantity < 25)
            {
                discount = totalAmount * 0.05m; // 5% discount
            }
            else if (quantity >= 25 && quantity < 50)
            {
                discount = totalAmount * 0.15m; // 15% discount
            }
            else if (quantity >= 50)
            {
                discount = totalAmount * 0.20m; // 20% discount
            }

            // Calculate final amount after discount
            decimal finalAmount = totalAmount - discount;

            // Display results
            lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString("C");
            lblDiscount.Text = "Discount: " + discount.ToString("C");
            lblFinalAmount.Text = "Final Amount: " + finalAmount.ToString("C");
        }
        else
        {
            // If invalid input, show error message
            lblTotalAmount.Text = "Please enter valid values for Quantity and Unit Price.";
        }
    }
}
