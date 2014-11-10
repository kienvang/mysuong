<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Detail.aspx.cs" Inherits="Admin_Feedback_Detail" Title="Trả lời Feedback" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <style>
        .ss
        {
            display: block;
            height: 120px;
            overflow: auto;
            padding-left: 115px;
        }
    </style>
    <h2>Trả lời phản hồi</h2>
    <div id="form">
        <div>
            <span class="label">Câu hỏi</span>
            <asp:Label ID="lblContent" runat="server" CssClass="ss"></asp:Label>
        </div>
        <hr />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
        <div class="row">
            <span class="label">Người nhận</span>
            <asp:TextBox ID="txtReceiver" runat="server" Width="350px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtReceiver"
                ErrorMessage="Nhập email người nhận">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtReceiver"
                ErrorMessage="Định dạng email không hợp lệ" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        </div>
        <div class="row">
            <span class="label">Tiêu đề</span>
            <asp:TextBox ID="txtSubject" runat="server" Width="350px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSubject"
                ErrorMessage="Nhập tiêu đề">*</asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <span>Nội dung</span>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDetail"
                ErrorMessage="Nhập nội dung phản hồi">*</asp:RequiredFieldValidator>
            <FCKeditorV2:FCKeditor ID="txtDetail" runat="server" ToolbarSet="MyToolbar" Width="800px"
                Height="450px">
            </FCKeditorV2:FCKeditor>
        </div>
        <div class="button">
            <asp:Button ID="btnSend" runat="server" Text="Gửi thông tin" OnClick="btnSend_Click" />
        </div>
        <div>
            <span>Danh sách đã trả lời</span>
            <cc1:CGridView ID="CGridView1" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                        <HeaderStyle Width="10px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Người nhận" HeaderStyle-Width="80px">
                        <ItemTemplate>
                            <%# Eval("Receiver")%>
                        </ItemTemplate>
                        <HeaderStyle Width="80px"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tiêu đề" HeaderStyle-Width="180px">
                        <ItemTemplate>
                            <%# Eval("Subject") %>
                        </ItemTemplate>
                        <HeaderStyle Width="80px"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nội dung">
                        <ItemTemplate>
                            <div>
                                <%# Eval("Body")%>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle Width="80px"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Người gởi" HeaderStyle-Width="80px">
                        <ItemTemplate>
                            <%# Eval("CreatedBy")%>
                        </ItemTemplate>
                        <HeaderStyle Width="80px"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ngày gửi" HeaderStyle-Width="210px" SortExpression="Address">
                        <ItemTemplate>
                            <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToString("dd/MM/yy") %><br>
                            <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToString("HH:mm") %>
                        </ItemTemplate>
                        <HeaderStyle Width="80px"></HeaderStyle>
                    </asp:TemplateField>
                </Columns>
            </cc1:CGridView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
