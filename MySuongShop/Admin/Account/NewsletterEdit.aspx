<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="NewsletterEdit.aspx.cs" Inherits="Admin_Account_NewsletterEdit" Title="Cập nhật newsletter" %>

<%@ Register Src="Control/AddEditNewsletter.ascx" TagName="AddEditNewsletter" TagPrefix="uc1" %>
<%@ Register Src="Control/NewsletterProduct.ascx" TagName="NewsletterProduct" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">

    <script type="text/javascript">
        $(function() {
            $('#tabs').tabs({
                selected: $.cookie('tabs'),
                select: function(event, ui) {
                    $.cookie('tabs', ui.index, { path: "" });
                    return true;
                }
            });

            $(".view").click(function() {
                openwindown($("#url").val() + "/Admin/Account/NewsletterView.aspx?id=" + $(this).attr("id"), 750, 600);
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Cập nhật newsletter</h2>
    <div id="tabs">
        <ul>
            <li><a href="#nll">Cập nhật</a></li>
            <li><a href="#product">Thêm sản phẩm</a></li>
            <li><a href="#view">Xem và gửi thử</a></li>
        </ul>
        <div id="nll">
            <uc1:AddEditNewsletter ID="AddEditNewsletter1" runat="server" />
        </div>
        <div id="product">
            <uc2:NewsletterProduct ID="NewsletterProduct1" runat="server" />
        </div>
        <div id="view">
            <input type="hidden" id="url" value="<%= Library.Tools.UrlBuilder.RootUrl %>" />
            <input id="<%= Request["id"] %>" type="button" value="Xem trước" class="view" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
