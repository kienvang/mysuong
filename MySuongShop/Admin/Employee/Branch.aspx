<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true" CodeFile="Branch.aspx.cs" Inherits="Admin_Employee_Branch" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <h1>Cửa hàng</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div class="row">
        <div class="col-sm-6">
            <h3>Thêm cửa hàng</h3>
            <div class="form-group">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" />
            </div>
            <div class="form-group">
                <label>
                    Tên cửa hàng
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtName" ErrorMessage="Nhập tên nhóm">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Địa chỉ</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:HiddenField ID="hidId" runat="server" />
                <asp:Button ID="btnSave" runat="server" Text="Thêm" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Thoát" Visible="false" ValidationGroup="cancel" CssClass="btn btn-default" OnClick="btnCancel_Click" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <cc1:CGridViewBootstrap ID="CGridView1" runat="server" OnRowCommand="CGridView1_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="STT" HeaderStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                        <HeaderStyle Width="3%"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên cửa hàng">
                        <ItemTemplate>
                            <%# Eval("Name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Địa chỉ" HeaderStyle-Width="40%">
                        <ItemTemplate>
                            <%# Eval("Address")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-CssClass="columns">
                        <ItemTemplate>
                            <asp:LinkButton ToolTip="Chỉnh sửa" CssClass="btn btn-success btn-xs" ID="link0" runat="server" CommandName="eedit" CommandArgument='<%# Eval("Id") %>' ValidationGroup="cmd">
                                <i class="fa fa-edit"></i>
                            </asp:LinkButton>
                            <asp:LinkButton ToolTip="Xóa" CssClass="btn btn-danger btn-xs" OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server" ValidationGroup="cmd" CommandName="ddel" CommandArgument='<%# Eval("Id") %>'>
                                <i class="fa fa-trash-o"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </cc1:CGridViewBootstrap>
        </div>
    </div>
</asp:Content>

