<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="NewsletterAdd.aspx.cs" Inherits="Admin_Account_NewsletterAdd" Title="Thêm newsletter" %>

<%@ Register src="Control/AddEditNewsletter.ascx" tagname="AddEditNewsletter" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <h2>Thêm newsletter</h2>
    <uc1:AddEditNewsletter ID="AddEditNewsletter1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

