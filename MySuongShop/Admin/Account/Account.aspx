<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true"
    CodeFile="Account.aspx.cs" Inherits="Admin_Account_Account" Title="Tài khoản" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h3>Danh sách tài khoản</h3>
    <cc1:CGridViewBootstrap ID="CGridView1" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <HeaderStyle Width="10px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên đăng nhập" HeaderStyle-Width="80px" SortExpression="Username">
                <ItemTemplate>
                    <%# Eval("Username") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" HeaderStyle-Width="80px">
                <ItemTemplate>
                    <%# Eval("Email") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lần đăng nhập cuối" HeaderStyle-Width="80px" SortExpression="LastLoginDate">
                <ItemTemplate>
                    <%# DateTime.Parse(Eval("LastLoginDate").ToString()).ToString("dd/MM/yyyy HH:mm") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
        </Columns>
    </cc1:CGridViewBootstrap>
</asp:Content>
