<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BillCalculator.aspx.cs" Inherits="BillCalculator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bill Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bill Calculator</h2>
            <label for="txtQuantity">Enter Quantity:</label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox><br />
            
            <label for="txtUnitPrice">Enter Unit Price:</label>
            <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox><br />
            
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate Bill" OnClick="btnCalculate_Click" /><br /><br />
            
            <h3>Bill Summary:</h3>
            <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount: "></asp:Label><br />
            <asp:Label ID="lblDiscount" runat="server" Text="Discount: "></asp:Label><br />
            <asp:Label ID="lblFinalAmount" runat="server" Text="Final Amount: "></asp:Label>
        </div>
    </form>
</body>
</html>
