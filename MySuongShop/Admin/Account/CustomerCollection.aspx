<%@ Page Title="Khách hàng" Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true" CodeFile="CustomerCollection.aspx.cs" Inherits="Admin_Account_CustomerCollection" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <h3>Danh sách khách hàng</h3>
    <asp:Button ID="btnExport" runat="server" Text="Excel" CssClass="btn btn-primary" OnClick="btnExport_Click" />
    <cc1:CGridViewBootstrap ID="CGridView1" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <HeaderStyle Width="10px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên khách hàng" HeaderStyle-Width="80px" SortExpression="Name">
                <ItemTemplate>
                    <%# Eval("Name") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" HeaderStyle-Width="80px" SortExpression="Email">
                <ItemTemplate>
                    <%# Eval("Email")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Phone" HeaderStyle-Width="80px" SortExpression="Phone">
                <ItemTemplate>
                    <%# Eval("Phone")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Địa chỉ" HeaderStyle-Width="210px" SortExpression="Address">
                <ItemTemplate>
                    <%# Eval("Address")%>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nhân viên" HeaderStyle-Width="210px">
                <ItemTemplate>
                    <%# LayerHelper.ShopCake.BLL.EmployeeManager.CreateInstant().getName(Library.Tools.FGuid.ToGuid(Eval("EmployeeId"))) %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
        </Columns>
    </cc1:CGridViewBootstrap>
</asp:Content>

