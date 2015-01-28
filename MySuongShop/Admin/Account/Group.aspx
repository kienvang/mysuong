<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootStrap.master" AutoEventWireup="true"
    CodeFile="Group.aspx.cs" Inherits="Admin_Account_Group" Title="Quản lý nhóm" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Quản lý nhóm</h3>
                </div>
                <div class="box-body">
                    <div class="row">
                        <div class="col-sm-6">
                            <div class="form-group">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error callout callout-danger" />
                                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                            </div>
                            <div class="form-group">
                                <label>
                                    Tên nhóm
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ControlToValidate="txtName" ErrorMessage="Nhập tên nhóm">*</asp:RequiredFieldValidator>
                                </label>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>

                            </div>
                            <div class="form-group">
                                <asp:CheckBox ID="chkEnable" runat="server" Text="Kích hoạt" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="box-footer">
                    <asp:HiddenField ID="hidId" runat="server" />
                    <asp:Button ID="btnSave" runat="server" Text="Thêm" OnClick="btnSave_Click" CssClass="btn btn-primary" />
                    <asp:Button ID="btnCancel" runat="server" Text="Thoát" Visible="false" ValidationGroup="cancel" CssClass="btn btn-default"
                        OnClick="btnCancel_Click" />
                </div>
            </div>
            <cc1:CGridViewBootstrap ID="CGridView1" runat="server"
                OnRowCommand="CGridView1_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="STT" HeaderStyle-Width="3%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                        <HeaderStyle Width="3%"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên nhóm" SortExpression="UserName">
                        <ItemTemplate>
                            <%# Eval("Name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tình trạng" HeaderStyle-Width="12%">
                        <ItemTemplate>
                            <%#  (Boolean)Eval("IsEnable") ? "Đã kích hoạt" : "Chưa kích hoạt" %>
                        </ItemTemplate>
                        <HeaderStyle Width="12%"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tổng số khách hàng" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <%# Eval("total") %>
                        </ItemTemplate>
                        <HeaderStyle Width="10%"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <a href="GroupInCustomer.aspx?id=<%# Eval("Id") %>">Thêm khách vào nhóm</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="link0" runat="server" CommandName="eedit" CommandArgument='<%# Eval("Id") %>' ValidationGroup="cmd">
                                                <img src="/img/button/properties.png" />
                            </asp:LinkButton>
                        </ItemTemplate>
                        <HeaderStyle Width="4%"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderStyle Width="4%"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:LinkButton OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server" ValidationGroup="cmd"
                                CommandName="ddel" CommandArgument='<%# Eval("Id") %>'>
                                                    <img src="/img/button/exit.png" />
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </cc1:CGridViewBootstrap>
        </div>
    </div>


</asp:Content>
