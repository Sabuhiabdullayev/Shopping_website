$(function () {
    $("#Catalog").change(function () {
        $("#Category2").empty();
        $("#Category3").empty();
        $.ajax({
            url: '/Product/Category2json',

            dataType: 'json',
            data: { id: $("#Catalog").val() },


            success: function (data) {

                $("#Category2").append('<option>Kategoriya seçiniz...</option>');


                $.each(data, (Category2json, deger) => {

                    $("#Category2").append('<option value="' + deger.value + '">' + deger.text + '</option>');

                });

            }
        });

    });
});

$(function () {
    $("#Category2").change(function () {
        $("#Category3").empty();
        $.ajax({
            url: '/Product/Category1json',

            dataType: 'json',
            data: { id: $("#Category2").val() },


            success: function (data) {

                $("#Category3").append('<option>Kategoriya seçiniz...</option>');


                $.each(data, (Category1json, deger2) => {

                    $("#Category3").append('<option value="' + deger2.value + '">' + deger2.text + '</option>');

                });

            }
        });

    });
});


$(document).ready(function () {
    $("#Catalog").on("change", function () {
        $("#CatalogText").val($(this).find("option:selected").text());
    });
    $("#Category3").on("change", function () {
        $("#Category3Text").val($(this).find("option:selected").text());
    });
});