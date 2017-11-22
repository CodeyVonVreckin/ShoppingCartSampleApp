<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Final_Project_411.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the Shopping Plaza</title>
    <link rel="stylesheet" href ="Styles/styles.css" type="text/css" />
</head>
<body class="font">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1WP border" >
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2WP"><h2 class="auto-style6">&nbsp; Welcome&nbsp; to&nbsp; the&nbsp; Shopping&nbsp; Plaza!!!!</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp; Here you can purchase books and DVDs. Simplay follow the instructions provided below</td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4WP">&nbsp; Instructions:<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp; 1. Select the book and enter the quantity. Click Add.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp; 2. Select the DVD and enter the quantity. Click Add.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp; 3. To check out, click Check-out.&nbsp;<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2WP">&nbsp; 4. To close the application, click Exit. You will lose your selections.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3WP">&nbsp; 5. In the check out screen revise the quantities if you wish to. If you do, click Edit.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp; 6. To place final order, click Pay.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5WP">&nbsp; 7. To close the application, click Exit. You will lose your selections. 
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="PlazaButton" runat="server" Text="Go To Shopping Plaza" Width="232px" class="space font" OnClick="PlazaButton_Click"/>
                        <asp:Button ID="ExitButton" runat="server" Text="Exit" Width="114px" class="space exitButton font" OnClick="ExitButton_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
