<%@ Page Title="Bán Hàng" Language="C#" MasterPageFile="~/manage/MasterPage.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="manage_customer_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <h3>Bán hàng</h3>
    <div class="row">
        <div class="col-sm-6 col-lg-4">
            <div class="form-group">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" Display="None"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label>
                    Sản phẩm
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="txtProductName" ErrorMessage="Nhập sản phẩm">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Tên khách hàng
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="ddlCustomerId" ErrorMessage="Nhập tên khách hàng">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="ddlCustomerId" runat="server" Width="100%"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Tổng đơn hàng
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                        ControlToValidate="txtAmount" ErrorMessage="Nhập tổng đơn hàng">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control numeric" AutoCompleteType="Disabled"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Giảm giá
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                        ControlToValidate="txtDiscount" ErrorMessage="Nhập giảm giá">*</asp:RequiredFieldValidator>
                </label>
                <asp:TextBox ID="txtDiscount" runat="server" CssClass="form-control numeric" AutoCompleteType="Disabled"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Thông tin thêm
                </label>
                <asp:TextBox ID="txtDecription" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSave" runat="server" Text="Thêm" CssClass="btn btn-primary" OnClick="btnSave_Click"/>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(function () {
            $("input[id$=ddlCustomerId]").select2({
                placeholder: "Tên/số điện thoại khách hàng",
                minimumInputLength: 3,
                ajax: {
                    url: "order.aspx/Customers",
                    dataType: 'json',
                    type: "POST",
                    quietMillis: 250,
                    params: {
                        contentType: 'application/json; charset=utf-8'
                    },
                    data: function (term, page) {
                        return JSON.stringify({ keyword: term });
                    },
                    results: function (data, page) {
                        return { results: data.d };
                    }
                },
                formatResult: FormatResults,
                formatSelection: FormatResults,
                escapeMarkup: function (m) { return m; }
            });

            $('.numeric').autoNumeric({ mDec: 0 });

            if ($.cookie('state') != undefined && $.cookie('state') == '1') {
                $.jalert('Thêm thành công');
                $.removeCookie('state', { path: '/' });
            }
        });

        function FormatResults(result) {
            var markup = '<div>';
            markup += '<p>' + result.text + '</p>';
            markup += '<span>Điện thoại :' + result.phone + '</span>';
            markup += '</div>';

            return markup;
        }
    </script>
</asp:Content>

