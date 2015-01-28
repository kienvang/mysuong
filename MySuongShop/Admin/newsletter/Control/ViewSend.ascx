<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewSend.ascx.cs" Inherits="Admin_newsletter_Control_ViewSend" %>
<%@ Register Src="EmailNewsletter.ascx" TagName="EmailNewsletter" TagPrefix="uc1" %>

<div class="row">
    <div class="col-sm-12">
        <div class="form-group">
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" CssClass="error callout callout-danger" ValidationGroup="test" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" ValidationGroup="send" />
        </div>

        <div class="form-group" id="divTest" runat="server" visible="false">
            <label>
                Email test
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập email test"
                    ControlToValidate="txtEmail" ValidationGroup="test">*</asp:RequiredFieldValidator></label>
            <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="test" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group" id="divEmail" runat="server" visible="false">
            <label>
                Danh sách email gửi
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Chưa có email trong danh sách, vui lòng quay ra cập nhật để thêm email"
                    ControlToValidate="txtEmailQueue" ValidationGroup="send">*</asp:RequiredFieldValidator></label>
            <asp:TextBox ID="txtEmailQueue" runat="server" ValidationGroup="send" CssClass="form-control" TextMode="MultiLine" Enabled="false"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnView" runat="server" Text="Xem trước" CssClass="btn btn-success" OnClick="btnView_Click" />
            <asp:Button ID="btnSendTest" runat="server" Text="Send thử" ValidationGroup="test" CssClass="btn btn-success" Visible="false" OnClick="btnSendTest_Click"/>
            <asp:Button ID="btnSend" runat="server" Text="Send mail" ValidationGroup="send" CssClass="btn btn-primary" Visible="false" OnClick="btnSend_Click"/>
        </div>
        <div class="mask" style="width: 100%; background-color: rgba(0, 0, 0, 0.3); top: 0px; position: absolute; height: 100%; display:none">
            <span style="display: inline-block; position: absolute; font-weight: bold; font-size: 20px; top: 45%; left: 44%; color: rgb(255, 255, 255);">Đang gửi mail, xin vui lòng chờ.....</span>
        </div>
    </div>
</div>

<hr />
<div>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</div>

<uc1:EmailNewsletter ID="EmailNewsletter1" runat="server" Visible="false" />

<script type="text/javascript">
    function loading() {
        $('.mask').show();
    }

    $(function () {
        if ($.cookie('state') != undefined && $.cookie('state') == '1') {
            $.jalert('Gửi mail hoàn tất.');
            $.removeCookie('state', { path: '/' });
        }
    });
</script>