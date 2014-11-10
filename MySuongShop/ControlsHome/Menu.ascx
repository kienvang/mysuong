<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="ControlsHome_Menu" %>
<%@ Import Namespace="Library.Tools" %>

<script src="/js/jquery.urlEncode.js" type="text/javascript"></script>

<script src="/js/jquery.watermarkinput.js" type="text/javascript"></script>

<div class="jqueryslidemenu" id="myslidemenu">
    <ul>
        <li><a href="/" class="menulevel0" title="Trang chủ">Trang chủ</a></li>
        <li><a href="<%= UrlBuilder.RootUrl %>" class="menulevel0" title="Sản phẩm">Sản phẩm</a></li>
        <li><a href="<%= Modules.Videos.UrlBuilder.Videos() %>" class="menulevel0" title="Videos">Videos</a></li>
        <li><a href="<%= Modules.News.UrlBuilder.News() %>" class="menulevel0" title="Tin tức">Tin tức</a></li>
        <li><a href="<%= Modules.UrlBuilder.Contact() %>" title="Liên hệ">Giới thiệu</a></li>
        <li class="last"><a href="<%= Modules.UrlBuilder.FeedBack() %>" title="Liên hệ">Liên hệ</a></li>
    </ul>
</div>
<%--<fieldset>
    <input type="text" name="search" id="search" />
    <input type="image" src="/images/btn_search.gif" name="btnSearch" id="btnSearch"
        class="btnSearch" />
    
</fieldset>--%>

<script type="text/javascript">
    $(document).ready(function() {
        /*
        $("input.btnSearch").click(function(){
        var search = $("#search").val();
            
        if (search != "")
        {
        //alert($.URLEncode(search));
                
        var jsonStr = "{val:'" + search + "'}";
                    
        $.ajax({
        type: "POST",
        url: "/Admin/Webservices/WebService.asmx/Encoding",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: jsonStr,
        success: function(msg) {
        window.location = msg.d;
        return true;
        },
        error: function() {
        return false;
        }
        });
        }
            
        return false;
        });
        */
    });
    
</script>

