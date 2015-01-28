<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEditNewsletter.ascx.cs"
    Inherits="Admin_Account_Control_AddEditNewsletter" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>

<div class="row">
    <div class="col-xs-12 col-sm-8">
        <div class="form-group">
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" CssClass="error callout callout-danger" ValidationGroup="nll" />
        </div>

        <div class="form-group">
            <label>Tiêu đề
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập tiêu đề gửi"
                    ControlToValidate="txtSubject" ValidationGroup="nll">*</asp:RequiredFieldValidator></label>
            <asp:TextBox ID="txtSubject" runat="server" ValidationGroup="nll" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Banner</label>
            <asp:Image ID="imgBanner" runat="server" Visible="false" />
            <asp:FileUpload ID="fileBanner" runat="server" />
        </div>

        <div class="form-group">
            <label>Loại gửi</label>
            <div>
                <asp:RadioButton ID="rdoSendAll" runat="server" GroupName="type" Text="Tất cả" Enabled="false" />
            </div>
            <div>
                <asp:RadioButton ID="rdoSendGroup" runat="server" GroupName="type" Text="Theo nhóm" Enabled="false" />
                <div style="margin-left: 20px">
                    <cc1:CCheckBoxList ID="chklGroup" runat="server">
                    </cc1:CCheckBoxList>
                </div>
            </div>
            <div>
                <asp:RadioButton ID="rdoSendEmail" runat="server" GroupName="type" Text="Email" Checked="true" />
                <div style="margin-left: 20px">
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    <p class="text-red">Danh sách email cách nhau bởi dấu phẩy <b>,</b></p>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label>Tình trạng</label>
            <asp:CheckBox ID="chkIsEnable" runat="server" Text="Kích hoạt" />
        </div>

        <div class="form-group">
            <label>Nội dung</label>
            <FCKeditorV2:FCKeditor ID="txtBody" runat="server" ToolbarSet="MyToolbar" Width="100%"
                Height="350px">
            </FCKeditorV2:FCKeditor>
        </div>

        <div class="form-group">
            <asp:HiddenField ID="hidId" runat="server" />
        <asp:Button ID="btnUpdate" runat="server" Text="Thêm" OnClick="btnUpdate_Click" ValidationGroup="nll" />
        </div>
    </div>
</div>
