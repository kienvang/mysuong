<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPageBootstrap.master" AutoEventWireup="true"
    CodeFile="GroupInCustomer.aspx.cs" Inherits="Admin_Account_GroupInCustomer" Title="Add nhóm" %>

<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <style type="text/css">
        /*
        .pl
        {
            clear: both;
        }
        .pl1, .pl2
        {
            float: left;
        }
        .pl1
        {
            width: 280px;
            margin-right:4px;
        }
        .pl2
        {
        	width:668px
        }
        */
    </style>
    <script type="text/javascript">
        $(function () {
            $(".btnDel").click(function () {
                var f = 0;
                $(".pl1 input[type=checkbox]:checked").each(function () {
                    f = 1;
                });
                if (f == 0) {
                    alert("Chọn khách hàng để xóa.");
                    return false;
                }
            });

            $(".btnAdd").click(function () {
                var f = 0;
                $(".pl2 input[type=checkbox]:checked").each(function () {
                    f = 1;
                });
                if (f == 0) {
                    alert("Chọn khách hàng để thêm vào.");
                    return false;
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h3>Thêm khách hàng vào nhóm
        <asp:Label ID="lblGroupName" runat="server"></asp:Label></h3>
    <div class="row">
        <div class="col-sm-4">
            <div class="form-group">
                <label>Tên khách hàng</label>
                <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Email</label>
                <asp:TextBox ID="txtCustomerEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Số tiền</label>
                <div class="row">
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtTotalFrom" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtTotalTo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Tìm" OnClick="btnSearch_Click" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Khách hàng đã thêm</h3>
                </div>
                <div class="box-body pl1">
                    <div class="form-group">
                        <asp:Button ID="btnDel" runat="server" Text="Xóa" OnClick="btnDel_Click" CssClass="btn btn-primary btnDel" />
                    </div>
                    
                    <cc1:CGridViewBootstrap ID="cgridInGroup" runat="server">
                        <Columns>
                            <asp:TemplateField HeaderStyle-Width="10px">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chk" runat="server" CustomerId='<%# Eval("Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                                <HeaderStyle Width="10px"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên khách hàng" SortExpression="FullName">
                                <ItemTemplate>
                                    <%# Eval("FullName")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email" HeaderStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
                                <ItemTemplate>
                                    <%# Library.Tools.FNumber.FormatNumber(Eval("Total"))%>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </cc1:CGridViewBootstrap>
                </div>
            </div>
        </div>
        <div class="col-sm-8">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Danh sách khách hàng</h3>
                </div>
                <div class="box-body pl2">
                    <div class="form-group">
                        <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" CssClass="btn btn-primary btnAdd" />
                    </div>
                    
                    <cc1:CGridViewBootstrap ID="cgridCustomer" runat="server">
                        <Columns>
                            <asp:TemplateField HeaderStyle-Width="10px">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCustomer" runat="server" CustomerId='<%# Eval("Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                                <HeaderStyle Width="10px"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên khách hàng" SortExpression="FullName">
                                <ItemTemplate>
                                    <%# Eval("FullName")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email" SortExpression="Email">
                                <ItemTemplate>
                                    <%# Eval("Email")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email" HeaderStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
                                <ItemTemplate>
                                    <%# Library.Tools.FNumber.FormatNumber(Eval("Total"))%>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </cc1:CGridViewBootstrap>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
