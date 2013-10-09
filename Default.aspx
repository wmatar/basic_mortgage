<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Loan Amount:&nbsp;&nbsp;
        <asp:TextBox ID="LoanAmount" runat="server"></asp:TextBox>
        <br />
        <br />
        Interest Rate:&nbsp;&nbsp;
        <asp:TextBox ID="Rate" runat="server"></asp:TextBox>
        <br />
        <br />
        Length of Loan:&nbsp;&nbsp;
        <asp:TextBox ID="MortgageLength" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="PerformCalcButton" runat="server" Text="Compute Monthly Costs" />
        <br />
        <br />
        <br />
        <asp:Label ID="Results" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
