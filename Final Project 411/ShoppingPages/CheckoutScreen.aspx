<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutScreen.aspx.cs" Inherits="Final_Project_411.ShoppingPages.CheckoutScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Checkout Page</title>
    <link rel="stylesheet" href="../Styles/styles.css" type="text/css" />
    <link rel="stylesheet" href="../Styles/checkoutStyle.css" type="text/css" />
    <style type="text/css">
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 688px;
        }
        .auto-style9 {
            margin-left: 18px;
            width: 873px;
        }
        .auto-style10 {
            width: 500px;
        }
    </style>
</head>
<body style="width: 904px; height: 401px" class="font border">
    <form id="form1" runat="server">
      <div class="auto-style9">
          <asp:ListBox ID="ListBox" runat="server" Height="235px" Width="858px" CssClass="listBoxMargin" OnSelectedIndexChanged="ListBox_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
          <table class="auto-style7">
              <tr>
                  <td class="auto-style10">Change Quantity:<asp:TextBox ID="QuantityTB" runat="server" Class="textBoxMargin" Width="217px"></asp:TextBox>
                  </td>
                  <td class="auto-style8">
                      <center><asp:Button ID="AcceptChangeButton" runat="server" Text="Accept Change" Class="font buttonTxt" OnClick="AcceptChangeButton_Click" /></center>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style10">&nbsp;</td>
                  <td class="auto-style8">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style10">
                      <asp:Button ID="PayButton" runat="server" Text="Pay" Width="114px" class="font buttonTxt buttonMargin" OnClick="PayButton_Click"/>
                  </td>
                  <td class="auto-style8">
                      <center><asp:Button ID="ExitButton" runat="server" Text="Exit" Width="114px" class="exitButton font buttonTxt" OnClick="ExitButton_Click"/></center>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style10">
                      <asp:Label ID="TotalLabel" runat="server" Text="Total:"></asp:Label>
                  </td>
                  <td class="auto-style8">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style10">&nbsp;</td>
                  <td class="auto-style8">&nbsp;</td>
              </tr>
          </table>
        </div>
    </form>
</body>
</html>
