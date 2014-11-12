<%@ Page Title="Thêm nhân viên" Language="C#" MasterPageFile="~/Admin/MasterPageBootstrap_2col.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Admin_Employee_Add" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <h1>Nhân viên</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_menu" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h3><%= hidId.Value == "" ? "Thêm" : "Cập nhật" %> nhân viên</h3>
    <div class="row">
        <div class="col-sm-8 col-lg-5">
            <div class="form-group">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" Display="None" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label>
                    Tên đăng nhập
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="txtUsername" ErrorMessage="Nhập tên đăng nhập">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Tên nhân viên
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtName" ErrorMessage="Nhập tên nhân viên">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Số điện thoại</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Địa chỉ</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Cửa hàng<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                        ControlToValidate="ddlBranch" ErrorMessage="Chọn cửa hàng">*</asp:RequiredFieldValidator></label>
                <asp:DropDownList ID="ddlBranch" runat="server" AppendDataBoundItems="true" CssClass="form-control">
                    <asp:ListItem Value=""> --- Chọn cửa hàng --- </asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:HiddenField ID="hidId" runat="server" />
                <asp:Button ID="btnSave" runat="server" Text="Thêm" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            </div>
        </div>
    </div>
</asp:Content>

