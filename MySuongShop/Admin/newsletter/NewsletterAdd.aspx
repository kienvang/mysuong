<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true" CodeFile="NewsletterAdd.aspx.cs" Inherits="Admin_Account_NewsletterAdd" Title="Thêm newsletter" %>

<%@ Register src="Control/AddEditNewsletter.ascx" tagname="AddEditNewsletter" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
    <h2>Thêm newsletter</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:AddEditNewsletter ID="AddEditNewsletter1" runat="server" />
</asp:Content>

