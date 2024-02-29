$("#NotificationAllListUl").on("click", ".NotificationRemove", function () {
    var btn = $(this);
    var id = btn.data("id");

    $.ajax({
        url: "/Member/Notification/NotificationAloneDelete/" + id,
        type: "post",
        data: id,
        success: function (func) {

            btn.parent().remove();
        }
    });
});