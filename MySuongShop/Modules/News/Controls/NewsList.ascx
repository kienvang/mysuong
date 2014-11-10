<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsList.ascx.cs" Inherits="Modules_News_Controls_NewsList" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<div>
    <h2>
        Tin tức
    </h2>
    <div class="news">
        <asp:Repeater ID="repNews" runat="server">
            <ItemTemplate>
                <div class="items">
                    <h2 class="title">
                        <a title="<%# Eval("Subject") %>" href="<%# Modules.UrlBuilder.GetNews(Eval("TextId").ToString()) %>">
                            <%# Eval("Subject") %></a></h2>
                    <p>
                        <%# Eval("Description") %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <avg:SmartPager ID="smartPager" runat="server" Visible="false" />
</div>
