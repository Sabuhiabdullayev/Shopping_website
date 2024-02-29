$(function () {
  $("#Catalog2").change(function () {
    $("#Category22").empty();

    $.ajax({
      url: '/Admin/CatalogWithCategory/Category2json/',

      dataType: 'json',
      data: { id: $("#Catalog2").val() },


      success: function (data) {

        $("#Category22").append('<option> seçiniz...</option>');


        $.each(data, (Category2json, deger) => {

          $("#Category22").append('<option value="' + deger.value + '">' + deger.text + '</option>');

        });

      }
    });

  });
});


$(function () {
  $("#Catalog").change(function () {
    $("#Category2").empty();
    $("#Category3").empty();
    $.ajax({
      url: '/Admin/CatalogWithCategory/Category2json/',

      dataType: 'json',
      data: { id: $("#Catalog").val() },


      success: function (data) {

        $("#Category2").append('<option> seçiniz...</option>');


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
      url: '/Admin/CatalogWithCategory/Category1json/',

      dataType: 'json',
      data: { id: $("#Category2").val() },


      success: function (data) {

        $("#Category3").append('<option> seçiniz...</option>');


        $.each(data, (Category1json, deger2) => {

          $("#Category3").append('<option value="' + deger2.value + '">' + deger2.text + '</option>');

        });

      }
    });

  });
});

$("#btnNewCatalog").click(function () {
  let catalog = {
    CatalogName: $("#txtNewCatalog").val()
  };
  $.ajax({
    url: "/Admin/CatalogWithCategory/CatalogAdd/",
    type: "post",
    data: catalog,
    success: function () {
      $("#txtNewCatalog").val("");
      alert("Katalog Elave Olundu");
    }
  });
});
$("#btnNewCategory1").click(function () {
  let Category2 = {
    CatalogId: $("#Catalog2").val(),
    Category2Name: $("#txtNewCategory1").val()
  };
  $.ajax({
    url: "/Admin/CatalogWithCategory/Category2Add/",
    type: "post",
    data: Category2,
    success: function () {
      $("#txtNewCategory1").val("");
      alert("Kategoriya Elave Olundu");
    }
  });
});

$("#btnNewCategory2").click(function () {
  let category = {
    Category2Id: $("#Category2").val(),
    CategoryName: $("#txtNewCategory2").val()
  };
  $.ajax({
    url: "/Admin/CatalogWithCategory/CategoryAdd/",
    type: "post",
    data: category,
    success: function () {
      $("#txtNewCategory2").val("");
      alert("Kategoriya Əlave Olundu");
    }
  });
});
