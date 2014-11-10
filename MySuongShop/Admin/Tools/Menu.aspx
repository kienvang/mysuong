<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Admin_Tools_Menu" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <style type="text/css">
        #form select
        {
            width:120px;
        }
    </style>
    <h2>Danh sách menu</h2>
    <div id="form">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
        <div class="row">
            <span class="label">Loại</span>
            <asp:DropDownList ID="ddlType" runat="server">
                <asp:ListItem Value="LINK">Link</asp:ListItem>
                <asp:ListItem Value="CATALOG">Catalog</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row">

        </div>
        <div class="row">
            <span class="label">Link</span>
            <asp:DropDownList ID="ddlLink" runat="server"></asp:DropDownList>
        </div>
        <div class="row">
            <span class="label">Danh mục</span>
            <asp:DropDownList ID="ddlCatalog" runat="server"></asp:DropDownList>
        </div>
        <div class="button">
            <asp:HiddenField ID="hidId" runat="server" />
            <asp:Button ID="btnSave" runat="server" Text="Thêm" OnClick="btnSave_Click"/>
            <asp:Button ID="btnCancel" runat="server" Text="Thoát" Visible="false" ValidationGroup="cancel"/>
        </div>
    </div>
    <cc1:CGridView ID="CGridView1" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <HeaderStyle Width="10px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên" HeaderStyle-Width="80px">
                <ItemTemplate>
                    <%# Eval("Name") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Loại" HeaderStyle-Width="80px">
                <ItemTemplate>
                    <%# Eval("MenuType") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thứ tự" HeaderStyle-Width="80px">
                <ItemTemplate>
                    <%# Eval("SortOrder") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
        </Columns>
    </cc1:CGridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

