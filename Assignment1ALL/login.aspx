<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PracticeApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>

            <asp:Label colspan="2"  runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="loginusername" type="text" runat="server" />
                
            </div>
            <div>
            <asp:Label  runat="server"  Text="PassWord" TextMode="Password"></asp:Label>
            <asp:TextBox ID="loginpass" type="text" runat="server"/>

            </div>
        </div>
        <asp:Button ID="submit" runat="server" Text="Login" OnClick="submit_Click" runat="server" />
        <asp:Label ID="ErrorMessage" Text="" ForeColor="Red" runat="server" ></asp:Label>
    </form>
</body>
</html>
