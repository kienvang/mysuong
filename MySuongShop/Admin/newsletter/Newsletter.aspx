<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true"
    CodeFile="Newsletter.aspx.cs" Inherits="Admin_Account_Newsletter" Title="Newsletter" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <h1>Newsletter</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>Quản lý newsletter</h2>
    <div class="row">
        <div class="col-sm-12 form-group">
            <a href="NewsletterAdd.aspx" class="btn btn-primary">Thêm</a>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <cc1:CGridViewBootstrap ID="CGridView1" runat="server">
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
            <asp:TemplateField HeaderText="Ngày gửi" HeaderStyle-Width="10%">
                <ItemTemplate>
                    <%# Library.Tools.FDateTime.FormatDate((DateTime)Eval("SendDate"))%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tổng email gửi" HeaderStyle-Width="5%" ItemStyle-HorizontalAlign="Right">
                <ItemTemplate>
                    <%# Eval("EmailSend").ToString().Split(',').Length %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tình trạng gửi" HeaderStyle-Width="10%">
                <ItemTemplate>
                    <%# getState(Eval("State").ToString()) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ItemStyle-CssClass="columns">
                <ItemTemplate>
                    <a class="btn btn-success btn-xs" href="NewsletterEdit.aspx?id=<%# Eval("id").ToString() %>"><i class="fa fa-edit"></i></a>
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
