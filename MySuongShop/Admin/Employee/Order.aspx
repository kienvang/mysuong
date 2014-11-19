<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageBootstrap_2col.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Admin_Employee_Order" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<%@ Import Namespace="Library.Tools" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <h1>Nhân viên</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_menu" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h3>Bán hàng</h3>
    <div class="row">
        <div class="col-sm-6 form-group">
            <label>Tên khách hàng</label>
            <asp:TextBox ID="txtCustomer" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-6 form-group">
            <label>Sản phẩm</label>
            <asp:TextBox ID="txtProduct" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-4 col-sm-3 form-group">
            <label>Ngày bán</label>
            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSave" runat="server" Text="Tìm" CssClass="btn btn-primary" />
    </div>
    <br />
    <div class="row">
        <div class="col-sm-12">
            <cc1:CGridViewBootstrap ID="CGridView1" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="STT" HeaderStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                        <HeaderStyle Width="3%"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên sản phẩm">
                        <ItemTemplate>
                            <%# Eval("ProductName")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Khách hàng" HeaderStyle-Width="15%">
                        <ItemTemplate>
                            <%# Eval("CustomerName")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tiền hóa đơn" HeaderStyle-Width="5%">
                        <ItemTemplate>
                            <%# FNumber.FormatNumber(Eval("Amount")) %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Giảm giá" HeaderStyle-Width="5%">
                        <ItemTemplate>
                            <%# FNumber.FormatNumber(Eval("Discount")) %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nhân viên" HeaderStyle-Width="15%">
                        <ItemTemplate>
                            <%# Eval("EmployeeName")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cửa hàng" HeaderStyle-Width="15%">
                        <ItemTemplate>
                            <%# Eval("BranchName")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ngày đặt hàng" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <%# DateTime.Parse(Eval("OrderDate").ToString()).ToString("dd/MM/yyyy HH:mm") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </cc1:CGridViewBootstrap>
        </div>
    </div>
</asp:Content>

