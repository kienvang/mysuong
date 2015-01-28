<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true"
    CodeFile="NewsletterEdit.aspx.cs" Inherits="Admin_Account_NewsletterEdit" Title="Cập nhật newsletter" %>

<%@ Register Src="Control/AddEditNewsletter.ascx" TagName="AddEditNewsletter" TagPrefix="uc1" %>
<%@ Register Src="Control/NewsletterProduct.ascx" TagName="NewsletterProduct" TagPrefix="uc2" %>
<%@ Register src="Control/ViewSend.ascx" tagname="ViewSend" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <h2>
        Cập nhật newsletter</h2>
    <script type="text/javascript">
        $(function () {
            if ($('input[id$=hidTab]').val() != '') {
                $('#myTab .nav-tabs a[href="' + $('input[id$=hidTab]').val() + '"]').tab('show');
            }

            $(".view").click(function() {
                openwindown($("#url").val() + "/Admin/Account/NewsletterView.aspx?id=" + $(this).attr("id"), 750, 600);
            });

            $('#myTab .nav-tabs a').click(function (e) {
                e.preventDefault()
                $('input[id$=hidTab]').val($(this).attr('href'));
            })
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <asp:HiddenField ID="hidTab" runat="server" />
    <div id="myTab" class="nav-tabs-custom">
        <ul class="nav nav-tabs">
            <li class="active"><a href="#nll" data-toggle="tab">Cập nhật</a></li>
            <li><a href="#product" data-toggle="tab">Thêm sản phẩm</a></li>
            <li><a href="#view" data-toggle="tab">Xem và gửi</a></li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane active" id="nll">
                <uc1:AddEditNewsletter ID="AddEditNewsletter1" runat="server" />
                
            </div>
            <div class="tab-pane" id="product">
                <uc2:NewsletterProduct ID="NewsletterProduct1" runat="server" />
            </div>
            <div class="tab-pane" id="view">
                <uc3:ViewSend ID="ViewSend1" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
