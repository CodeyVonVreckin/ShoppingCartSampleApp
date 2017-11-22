<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainShoppingPage.aspx.cs" Inherits="Final_Project_411.ShoppingPages.MainShoppingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Shopping Page</title>
    <link rel="stylesheet" href="../Styles/ShoppingPlazaStyle.css" type="text/css"? />
    <link rel="stylesheet" href="../Styles/styles.css" type="text/css" />
    <style type="text/css">
        .auto-style8 {
            width: 124px;
        }
    </style>
</head>
<body class="font">
    <form id="form1" runat="server" class ="border">
        <div class="MainPageMargin"><h2>Here you make your selections. You can select one book title and one DVD title.</h2></div>
        <table class="auto-style1MP MainPageMargin">
            <tr>
                <td class="auto-style2MP ">Books</td>
                <td class="auto-style3MP">
                    <asp:DropDownList ID="BooksDropDown" runat="server" Width="508px" AutoPostBack="True" OnSelectedIndexChanged="BooksDropDown_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style5MP">Quantity</td>
                <td class="auto-style6MP">
                    <asp:TextBox ID="BookQuantityTB" runat="server" Width="204px"></asp:TextBox>
                </td>
                <td class="auto-style8">Price of Book:</td>
                <td>
                    <asp:Label ID="BookPriceValueLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2MP">DVDs</td>
                <td class="auto-style3MP">
                    <asp:DropDownList ID="DvdDropDown" runat="server" Width="508px" AutoPostBack="True" OnSelectedIndexChanged="DvdDropDown_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style5MP">Quantity</td>
                <td class="auto-style6MP">
                    <asp:TextBox ID="DvdQuantityTB" runat="server" Width="204px"></asp:TextBox>
                </td>
                <td class="auto-style8">Price of DVD:</td>
                <td>
                    <asp:Label ID="DVDPriceValueLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2MP ">&nbsp;</td>
                <td class="auto-style3MP">
                    <asp:Label ID="Label" runat="server"></asp:Label>
                </td>
                <td class="auto-style5MP">&nbsp;</td>
                <td class="auto-style6MP">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2MP ">&nbsp;</td>
                <td class="auto-style3MP">
                    <asp:Label ID="MessageLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style5MP">&nbsp;</td>
                <td class="auto-style6MP">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2MP ">&nbsp;</td>
                <td class="auto-style3MP">
                   <center><asp:Button ID="AddButton" runat="server" Text="Add" Width="124px" class="font" OnClick="AddButton_Click"/></center> 
                </td>
                <td class="auto-style5MP">
                    <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" Width="124px" class="font" OnClick="CheckoutButton_Click"/>
                </td>
                <td class="auto-style6MP">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="ExitButton" runat="server" Text="Exit" Width="124px" class="exitButton font" OnClick="ExitButton_Click"/>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2MP ">&nbsp;</td>
                <td class="auto-style3MP">&nbsp;</td>
                <td class="auto-style5MP">&nbsp;</td>
                <td class="auto-style6MP">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
