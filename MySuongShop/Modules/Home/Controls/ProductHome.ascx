﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductHome.ascx.cs" Inherits="Modules_Home_Controls_ProductHome" %>
<%@ Import Namespace="Modules" %>
<asp:Repeater ID="repCatHome" runat="server">
    <ItemTemplate>
        <div class="listProducts">
            <h2>
                <%# Eval("CatalogName") %></h2>
            <div class="productsInfo">
                <asp:Repeater ID="dltProductHome" runat="server" DataSource='<%#GetProductHome(int.Parse(Eval("Id").ToString())) %>'>
                    <ItemTemplate>
                        <%# Container.ItemIndex % 3 == 0 ? "<div class='items'>" : "" %>
                        <div class="item">
                            <script type="text/javascript">
                                $(function() {
                                    $('.thumb-<%# Container.ItemIndex.ToString() + "-" + Container.ClientID %>').lightBox();
                                });
                            </script>

                            <div class="thumbnail">
                                <a class="thumb-<%# Container.ItemIndex.ToString() + "-" + Container.ClientID %>" href='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=500&c=1" : "/images/no_img.gif" %>'
                                    title='<%# Eval("ProductName").ToString() + " " + Library.Tools.Util.TrimString(Eval("Abstract").ToString(), 150) %>'>
                                    <img src='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=180&h=180&c=0" : "/images/no_img.gif" %>'
                                        alt='<%# Eval("ProductName") %>' title='<%# Eval("ProductName") %>' /></a>
                            </div>
                            <div class="info">
                                <h3>
                                    <p class="cat" style="font-weight: bold">
                                        <%# Eval("ProductCode").ToString()%>
                                        <% if (Modules.Role.CheckRoles.CreateInstant().IsRoles(Modules.Role.EnumsRoles.Administrator))
                                           { %>
                                        <a href='/Admin/Products/Detail.aspx?Id=<%# Eval("Id") %>'>
                                            <img src="/img/button/properties.png" />
                                        </a>
                                        <%} %>
                                    </p>
                                    <a href='<%# Modules.Products.UrlBuilder.ViewDetail(int.Parse(Eval("CatId").ToString()),Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString()) %>'
                                        title='<%# Eval("ProductName") %>'>
                                        <%# Eval("ProductName") %></a></h3>
                                <p>
                                    <span>Giá: <span class="orange">
                                        <%# Convert.ToDecimal(Eval("Price")) >0 ? Library.Tools.FNumber.FormatNumber(Eval("Price")) + " VND" : "Liên hệ sau" %>
                                    </span></span>
                                </p>
                            </div>
                        </div>
                        <%# ((Container.ItemIndex + 1) % 3 == 0 || ((Container.ItemIndex + 1) % 3 != 0 && Container.ItemIndex == last && Container.ItemIndex > 0)) ? "</div>" : "" %>
                    </ItemTemplate>
                    <SeparatorTemplate>
                    <div style="width:50px; margin:0">&nbsp;</div>
                    </SeparatorTemplate>
                </asp:Repeater>
            </div>
            <p class="more">
                <a href='<%# Modules.Catalogs.UrlBuilder.GetCatsByIdTextId(int.Parse(Eval("Id").ToString()), Eval("TextId").ToString()) %>'
                    title="Xem thêm">Xem thêm</a></p>
        </div>
    </ItemTemplate>
</asp:Repeater>
