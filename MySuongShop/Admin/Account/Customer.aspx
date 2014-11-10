<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true"
    CodeFile="Customer.aspx.cs" Inherits="Admin_Account_Customer" Title="Khách hàng" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h3>Danh sách khách hàng</h3>
    <cc1:CGridViewBootstrap ID="CGridView1" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <HeaderStyle Width="10px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên đăng nhập" HeaderStyle-Width="80px" SortExpression="UserName">
                <ItemTemplate>
                    <%# Eval("UserName")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên khách hàng" HeaderStyle-Width="80px" SortExpression="FullName">
                <ItemTemplate>
                    <%# Eval("FullName") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" HeaderStyle-Width="80px" SortExpression="Email">
                <ItemTemplate>
                    <%# Eval("Email")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Phone" HeaderStyle-Width="80px" SortExpression="Mobi">
                <ItemTemplate>
                    <%# Eval("Mobi")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Địa chỉ" HeaderStyle-Width="210px" SortExpression="Address">
                <ItemTemplate>
                    <%# Eval("Address")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
        </Columns>
    </cc1:CGridViewBootstrap>
</asp:Content>

