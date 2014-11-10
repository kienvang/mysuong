<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Newsletter.aspx.cs" Inherits="Admin_Account_Newsletter" Title="Newsletter" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>Quản lý newsletter</h2>
    <a href="NewsletterAdd.aspx">Thêm newsletter</a>
    <cc1:CGridView ID="cgridNewsletter" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <HeaderStyle Width="10px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tiêu đề" SortExpression="Subject">
                <ItemTemplate>
                    <%# Eval("Subject")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ngày gửi" HeaderStyle-Width="110px">
                <ItemTemplate>
                    <%# Library.Tools.FDateTime.FormatDate((DateTime)Eval("SendDate"))%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tổng email gửi" HeaderStyle-Width="80px" ItemStyle-HorizontalAlign="Right">
                <ItemTemplate>
                    <%# Eval("EmailSend").ToString().Split(',').Length %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tình trạng gửi" HeaderStyle-Width="110px">
                <ItemTemplate>
                    <%# getState(Eval("State").ToString()) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="30px">
                <ItemTemplate>
                    <a href="NewsletterEdit.aspx?id=<%# Eval("id").ToString() %>"><img src="/img/button/Properties.png" /></a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </cc1:CGridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
