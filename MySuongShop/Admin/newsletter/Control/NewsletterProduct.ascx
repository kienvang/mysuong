<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsletterProduct.ascx.cs"
    Inherits="Admin_Account_Control_NewsletterProduct" %>
<%@ Register Namespace="CommonClassLibrary" TagPrefix="cc1" %>

<script type="text/javascript">
    $(function () {
        $(".btnDel").click(function () {
            var f = 0;
            $(".pl1 input[type=checkbox]:checked").each(function () {
                f = 1;
            });
            if (f == 0) {
                alert("Chọn sản phẩm để xóa.");
                return false;
            }
        });

        $(".btnAdd").click(function () {
            var f = 0;
            $(".pl2 input[type=checkbox]:checked").each(function () {
                f = 1;
            });
            if (f == 0) {
                alert("Chọn sản phẩm để thêm vào.");
                return false;
            }
        });
    });
</script>
<div class="row">
    <div class="col-xs-12 col-sm-8 col-lg-5">
        <div class="form-group">
            <label>Tên sản phẩm</label>
            <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Loại sản phẩm</label>
            <asp:TextBox ID="txtCatName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="btnSearch" runat="server" Text="Tìm" OnClick="btnSearch_Click" CssClass="btn btn-primary" />
        </div>
    </div>
</div>

<div class="row">
    <div class="col-xs-8">
        <div class="pl2">
            <h3>Danh sách sản phẩm</h3>
            <asp:Button ID="btnAdd" runat="server" Text="Thêm" CssClass="btn btn-primary btnAdd" OnClick="btnAdd_Click" />
            <cc1:CGridViewBootstrap ID="cgridProduct" runat="server">
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
            </cc1:CGridViewBootstrap>
        </div>
    </div>
    <div class="col-xs-4">
        <div class="pl1">
            <h3>Sản phẩm gửi</h3>
            <asp:Button ID="btnDel" runat="server" Text="Xóa" CssClass="btn btn-primary btnDel" OnClick="btnDel_Click" />
            <cc1:CGridViewBootstrap ID="cgridInGroup" runat="server">
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
            </cc1:CGridViewBootstrap>
        </div>
    </div>
</div>
