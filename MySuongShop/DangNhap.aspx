<%@ Page Language="C#" MasterPageFile="~/MasterPage-login.master" AutoEventWireup="true"
    CodeFile="DangNhap.aspx.cs" Inherits="DangNhap" Title="Đăng nhập" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div style="width: 300px; margin: 0 auto">
        <asp:Login ID="Login1" runat="server" 
            FailureText="Đăng nhập không thành công. Vui lòng thử đăng nhập lại" 
            LoginButtonText="Đăng Nhập" onloggedin="Login1_LoggedIn" 
            PasswordLabelText="Mật Khẩu :" PasswordRequiredErrorMessage="Nhập mật khẩu" 
            RememberMeText="Nhớ cho lần đăng nhập tiếp" UserNameLabelText="Tên đăng nhập :" 
            UserNameRequiredErrorMessage="Nhập tên đăng nhập." Width="300px">
            <LayoutTemplate>
                <div id="login">
                    <h2>Đăng nhập</h2>
                    <div>
                        <span class="label">Tên đăng nhập</span>
                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                            ControlToValidate="UserName" ErrorMessage="Nhập tên đăng nhập." 
                            ToolTip="Nhập tên đăng nhập." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                    </div>
                    <div>
                        <span class="label">Mật khẩu</span>
                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                            ControlToValidate="Password" ErrorMessage="Nhập mật khẩu" 
                            ToolTip="Nhập mật khẩu" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                    </div>
                    <div>
                        <asp:CheckBox ID="RememberMe" runat="server" Text="Nhớ cho lần đăng nhập tiếp" Visible="false" />
                    </div>
                    <div class="error1">
                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                    </div>
                    <div>
                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Đăng Nhập" ValidationGroup="Login1" />
                    </div>
                </div>
            </LayoutTemplate>
        </asp:Login>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
