<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsletterProduct.ascx.cs"
    Inherits="Admin_Account_Control_NewsletterProduct" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>
<style type="text/css">
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
        margin-right: 4px;
    }
    .pl2
    {
        width: 640px;
    }
</style>

<script type="text/javascript">
    $(function() {
        $(".btnDel").click(function() {
            var f = 0;
            $(".pl1 input[type=checkbox]:checked").each(function() {
                f = 1;
            });
            if (f == 0) {
                alert("Chọn sản phẩm để xóa.");
                return false;
            }
        });

        $(".btnAdd").click(function() {
            var f = 0;
            $(".pl2 input[type=checkbox]:checked").each(function() {
                f = 1;
            });
            if (f == 0) {
                alert("Chọn sản phẩm để thêm vào.");
                return false;
            }
        });
    });
</script>

<div id="form">
    <div class="row">
        <span class="label">Tên sản phẩm</span>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <span class="label">Tên loại sản phẩm</span>
        <asp:TextBox ID="txtCatName" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <span class="label">Số tiền</span>
        <asp:TextBox ID="txtPriceFrom" runat="server" Width="50px"></asp:TextBox>
        -
        <asp:TextBox ID="txtPriceTo" runat="server" Width="50px"></asp:TextBox>
    </div>
    <div class="button">
        <asp:Button ID="btnSearch" runat="server" Text="Tìm" OnClick="btnSearch_Click" />
    </div>
</div>
<div class="pl">
    <div class="pl1">
        <h3>
            Sản phẩm gửi</h3>
        <asp:Button ID="btnDel" runat="server" Text="Xóa" CssClass="btnDel" OnClick="btnDel_Click" />
        <cc1:CGridView ID="cgridInGroup" runat="server">
            <Columns>
                <asp:TemplateField HeaderStyle-Width="10px">
                    <ItemTemplate>
                        <asp:CheckBox ID="chk" runat="server" ProductId='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    <HeaderStyle Width="10px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên sản phẩm" SortExpression="ProductName">
                    <ItemTemplate>
                        <%# Eval("ProductName")%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </cc1:CGridView>
    </div>
    <div class="pl2">
        <h3>
            Danh sách sản phẩm</h3>
        <asp:Button ID="btnAdd" runat="server" Text="Thêm" CssClass="btnAdd" OnClick="btnAdd_Click" />
        <cc1:CGridView ID="cgridProduct" runat="server">
            <Columns>
                <asp:TemplateField HeaderStyle-Width="10px">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkProduct" runat="server" ProductId='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="STT" HeaderStyle-Width="10px" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    <HeaderStyle Width="10px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên sản phẩm" SortExpression="ProductName">
                    <ItemTemplate>
                        <%# Eval("ProductName")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Loại sản phẩm" SortExpression="CatalogName">
                    <ItemTemplate>
                        <%# Eval("CatName")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Giá tiền" HeaderStyle-Width="60px" ItemStyle-HorizontalAlign="Right"
                    SortExpression="Price">
                    <ItemTemplate>
                        <%# Library.Tools.FNumber.FormatNumber(Eval("Price"))%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </cc1:CGridView>
    </div>
    <div class="clear">
    </div>
</div>
