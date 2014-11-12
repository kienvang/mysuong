<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.ascx.cs" Inherits="Admin_Profile_Controls_ChangePassword" %>
<h3>Thay đổi mật khẩu</h3>
<div class="row">
    <div class="col-sm-6 col-lg-3">
        <div class="form-group">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" Display="None" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        </div>
        <div class="form-group">
            <label>
                Mật khẩu hiện tại
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtPassCurrent" ErrorMessage="Nhập mật khẩu hiện tại">*</asp:RequiredFieldValidator>
            </label>
            <asp:TextBox ID="txtPassCurrent" runat="server" CssClass="form-control" AutoCompleteType="Disabled"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>
                Mật khẩu mới
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtPass" ErrorMessage="Nhập mật khẩu mới">*</asp:RequiredFieldValidator>
            </label>
            <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" AutoCompleteType="Disabled"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>
                Xác nhận mật khẩu mới
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtPassConfirm" ErrorMessage="Nhập xác nhận mật khẩu mới">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Xác nhận mật khẩu không chính xác" ControlToValidate="txtPassConfirm" ControlToCompare="txtPass"></asp:CompareValidator>
            </label>
            <asp:TextBox ID="txtPassConfirm" runat="server" CssClass="form-control" AutoCompleteType="Disabled"></asp:TextBox>

        </div>
        <div class="form-group">
            <asp:Button ID="btnSave" runat="server" Text="Cập nhật" CssClass="btn btn-primary" OnClick="btnSave_Click" />
        </div>
    </div>
</div>
