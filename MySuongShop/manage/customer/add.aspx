<%@ Page Title="Khách hàng" Language="C#" MasterPageFile="~/manage/MasterPage.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="manage_customer_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <h3>Thông tin khách hàng</h3>
    <div class="row">
        <div class="col-sm-6 col-lg-4">
            <div class="form-group">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" Display="None"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label>
                    Tên khách hàng
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtName" ErrorMessage="Nhập tên khách hàng">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Số điện thoại</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Email<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email không hợp lệ" ControlToValidate="txtEmail" Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Ngày sinh</label>
                <div class="input-group">
                    <asp:TextBox ID="txtBirthday" runat="server" CssClass="form-control fdate"></asp:TextBox>
                    <div class="input-group-addon">
                        <i class="fa fa-calendar"></i>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <label>Quận</label>
                <asp:DropDownList ID="ddlDistrict" runat="server" AppendDataBoundItems="true" CssClass="form-control">
                    <asp:ListItem Value="">--- Chọn Quận ---</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label>Địa chỉ</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Góp ý</label>
                <asp:TextBox ID="txtInformation" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSave" runat="server" Text="Thêm" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(function () {
            //Datemask dd/mm/yyyy
            $(".fdate").inputmask("dd/mm/yyyy", { "placeholder": "dd/mm/yyyy" });

            if ($.cookie('state') != undefined && $.cookie('state') == '1') {
                $.jalert('Thêm thành công');
                $.removeCookie('state', { path: '/' });
            }
        });
    </script>
</asp:Content>

