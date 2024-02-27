<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditUser.aspx.cs" Inherits="reg_form.EditUser" %>
 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2>Edit Details</h2>
<div>
<asp:Label ID="lblUserId" runat="server" Visible="false"></asp:Label>
<asp:TextBox ID="txtFirstName" runat="server" placeholder="FirstName" CssClass="form-control"></asp:TextBox>
<br />
<asp:TextBox ID="txtLastname" runat="server" placeholder="Lastname" CssClass="form-control"></asp:TextBox>
<br />
<asp:TextBox ID="txtContact" runat="server" placeholder="Contact" CssClass="form-control"></asp:TextBox>
<br />
<asp:DropDownList ID="txtGender" runat="server" CssClass="form-control">
<asp:ListItem Text="Male" Value="Male"></asp:ListItem>
<asp:ListItem Text="Female" Value="Female"></asp:ListItem>
</asp:DropDownList>
    <br />
<asp:TextBox ID="txtAddress" runat="server" placeholder="Address" CssClass="form-control"></asp:TextBox>
<br />
<asp:TextBox ID="txtUserName" runat="server" placeholder="UserName" CssClass="form-control"></asp:TextBox>
<br />
<asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="btnUpdate_Click" />
<asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
</div>
</asp:Content>