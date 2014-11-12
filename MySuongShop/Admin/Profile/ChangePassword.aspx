<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Admin_Profile_ChangePassword" %>

<%@ Register src="Controls/ChangePassword.ascx" tagname="ChangePassword" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
    <h1>Tài khoản cá nhân</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">

    <uc1:ChangePassword ID="ChangePassword1" runat="server" />

</asp:Content>

