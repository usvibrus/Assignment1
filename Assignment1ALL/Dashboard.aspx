<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.cs" Inherits="WebApplication2.Dashboard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:Title %>User Data</h2>


    <div>

            
    <asp:TextBox ID="txtSearch" runat="server" placeholder="Search users..." CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />

    </div>

    <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered" OnRowCommand="gridview_delete_user">

        <Columns>


            <asp:BoundField DataField="USERID" HeaderText="UserID" />
            <asp:BoundField DataField="FirstName" HeaderText="First name" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" />
            <asp:BoundField DataField="Contact" HeaderText="Contact" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="UserName" HeaderText="UserName" />
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
<asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-primary btn-sm" OnClick="btnEdit_Click" CommandArgument='<%# Eval("USERID") %>' />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm" OnClick="gridview_delete_user" CommandArgument='<%# Eval("USERID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

   


    </asp:GridView>



</asp:Content>



