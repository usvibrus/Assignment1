<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userReg.aspx.cs" Inherits="PracticeApp.userReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registeration Form</title>
   <style>
       {
           width:auto
       }
       th, td {
            padding: 8px 12px;
            border-bottom: 1px solid ;
            text-align: left;
        }
   </style>
</head>
<body style="display: flex;
            justify-content: center;
            align-items: center;   height: 100vh; margin:0">

   <div style="width: 50%;
            max-width: 800px;
            margin: 0 auto;
            border:solid
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);">
    <form style="" id="form1" runat="server">
   
           <asp:HiddenField ID="hfID" runat="server" />
            <table style="  width: 100%;
">
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="First Name" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="firstname" runat="server" />
                    </td>

                </tr>        
                 <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Last Name" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="lastname" runat="server" />
                         
                    </td>

                </tr>
                 <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Contact"  runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="contact" runat="server" />
                    </td>

                </tr>
                 <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Gender" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="gender" runat="server" style="width: 69px" ViewStateMode="Enabled">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>

                </tr>
                 <tr>
                    <td class="auto-style1"> 
                        <asp:Label Text="Address" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="address" TextMode="MultiLine" runat="server"  />
                    </td>

                </tr>

                     
                 <tr>
                    <td class="auto-style1">
                        <asp:Label Text="UserName" runat="server" />
                        <asp:Label Text="*" runat="server" ForeColor="Red" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="username" runat="server"  />
                    </td>

                </tr>
                 <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Password" runat="server" TextMode="Password" />
                        <asp:Label Text="*" runat="server" ForeColor="Red" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="password" runat="server" />
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Confirm Password" runat="server" TextMode="Password" />
                        <asp:Label Text="*" runat="server" ForeColor="Red" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="confirmpassword"  runat="server" />
                    </td>

                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Button CssClass="btn btn-danger" Text="Submit" ID="submit" runat="server" OnClick="sumbit_Click"  />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1"> 
                        <asp:Label Text="Success" ForeColor="DarkGreen" ID="successmessage" runat="server" />
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1"> 
                        <asp:Label Text="Fail" ForeColor="Red" ID="failmessage" runat="server" />
                    </td>

                </tr>
              

            </table>

       
    </form>
           </div>
       </div>
</body>
</html>
