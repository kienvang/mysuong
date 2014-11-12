<%@ Page Title="Danh sách nhân viên" Language="C#" MasterPageFile="~/Admin/MasterPageBootstrap_2col.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Employee_Default" %>

<%@ Register src="Controls/Menu.ascx" tagname="Menu" tagprefix="uc1" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
    <h1>Nhân viên</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_menu" Runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <h3>Danh sách nhân viên</h3>
    <div class="row">
        <div class="col-sm-12">
            <cc1:CGridViewBootstrap ID="CGridView1" runat="server" OnRowCommand="CGridView1_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="STT" HeaderStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                        <HeaderStyle Width="3%"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên đăng nhập" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <%# Eval("Username")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên nhân viên">
                        <ItemTemplate>
                            <%# Eval("Name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Địa chỉ" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <%# Eval("Address")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cửa hàng" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <%# BranchName(Library.Tools.FGuid.ToGuid(Eval("BranchId"))) %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-CssClass="columns">
                        <ItemTemplate>
                            <a title="Chỉnh sửa" class="btn btn-success btn-xs" href="Add.aspx?id=<%# Eval("Id") %>"><i class="fa fa-edit"></i></a>
                            <asp:LinkButton ToolTip="Xóa" CssClass="btn btn-danger btn-xs" OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server" ValidationGroup="cmd"
                                CommandName="ddel" CommandArgument='<%# Eval("Id") %>'><i class="fa fa-trash-o"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </cc1:CGridViewBootstrap>
        </div>
    </div>
</asp:Content>

