<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="NewsletterView.aspx.cs" Inherits="Admin_Account_NewsletterView" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div id="control" runat="server">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" ItemStyle-HorizontalAlign="Center"
            HorizontalAlign="Center" Width="100%">
            <ItemTemplate>
                <p style="padding: 10px 0">
                    <a href='<%# Modules.Products.UrlBuilder.ViewDetail(int.Parse(Eval("CatId").ToString()),Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString()) %>'
                        title='<%# Eval("ProductName").ToString() + " " + Library.Tools.Util.TrimString(Eval("Abstract").ToString(), 150) %>'
                        target="_blank">
                        <img src='<%# Library.Tools.UrlBuilder.RootUrl + (!string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=180&h=180&c=0" : "/images/no_img.gif") %>'
                            alt='<%# Eval("ProductName") %>' title='<%# Eval("ProductName") %>' />
                    </a>
                    <br />
                    <span>
                        <%# Eval("ProductCode") %></span>
                    <br />
                    <span>
                        <%# Eval("ProductName") %></span>
                </p>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
