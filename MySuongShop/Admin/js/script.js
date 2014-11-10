function openwindown(path, width, height) {
    window.open(path, "_blank", "toolbar=no, scrollbars=yes, resizable=yes, top=200, left=100, width=" + width + ", height=" + height);
}

$(function() {
    $(".date").datepicker({
        showOn: 'both'
        , buttonImage: '/img/button/calendar-up.gif'
        , buttonImageOnly: true
        , dateFormat: 'dd/mm/yy'
        , clearText: ''
        , firstDay: 1
    });
});