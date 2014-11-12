<%@ Page Title="Thay đổi mật khẩu" Language="C#" MasterPageFile="~/manage/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="manage_ChangePassword" %>

<%@ Register src="../Admin/Profile/Controls/ChangePassword.ascx" tagname="ChangePassword" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h1>Cá nhân</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <uc1:ChangePassword ID="ChangePassword1" runat="server" />
</asp:Content>

