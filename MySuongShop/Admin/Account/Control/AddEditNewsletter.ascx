<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEditNewsletter.ascx.cs"
    Inherits="Admin_Account_Control_AddEditNewsletter" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<div id="form">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="nll"
        CssClass="error" />
    <div class="row">
        <span class="label">Tiêu đề
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập tiêu đề gửi"
                ControlToValidate="txtSubject" ValidationGroup="nll">*</asp:RequiredFieldValidator></span>
        <asp:TextBox ID="txtSubject" runat="server" ValidationGroup="nll"></asp:TextBox>
    </div>
    <div class="row">
        <span class="label">Ngày gửi
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Chọn ngày gửi"
                ControlToValidate="txtSendDate" ValidationGroup="nll">*</asp:RequiredFieldValidator></span>
        <asp:TextBox ID="txtSendDate" runat="server" CssClass="date" ValidationGroup="nll"></asp:TextBox>
    </div>
    <div class="row">
        <span class="label">Loại gửi</span>
        <div style="display: inline-block">
            <div>
                <asp:RadioButton ID="rdoSendAll" runat="server" GroupName="type" Text="Tất cả" Checked="true" />
            </div>
            <div>
                <asp:RadioButton ID="rdoSendGroup" runat="server" GroupName="type" Text="Theo nhóm" />
                <div style="margin-left:10px">
                    <cc1:CCheckBoxList ID="chklGroup" runat="server">
                    </cc1:CCheckBoxList>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <span class="label">Tình trạng</span>
        <asp:CheckBox ID="chkIsEnable" runat="server" Text="Kích hoạt" />
    </div>
    <div class="row">
        <span class="label">Nội dung</span>
        <div style="display: inline-block">
            <FCKeditorV2:FCKeditor ID="txtBody" runat="server" ToolbarSet="MyToolbar" Width="600px"
                Height="350px">
            </FCKeditorV2:FCKeditor>
        </div>
    </div>
    <div class="button">
        <asp:HiddenField ID="hidId" runat="server" />
        <asp:Button ID="btnUpdate" runat="server" Text="Thêm" OnClick="btnUpdate_Click" ValidationGroup="nll" />
    </div>
</div>
