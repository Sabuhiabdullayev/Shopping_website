$(function () {
  $("#Catalogs").change(function () {
    $("#txtNewCatalog").val($(this).find("option:selected").text());
    var btn = $(this);
    var catalogId = $("#Catalogs").val();
    $("#btnNewCatalog").click(function () {
      let catalog = {
        id: catalogId
      };
      $.ajax({
        url: "/Admin/CatalogWithCategory/CatalogRemove/",
        type: "post",
        data: catalog,
        success: function () {
          $("#txtNewCatalog").val("");
          
          alert("Katalog Silindi");
        }
      });
    });
  });
});


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
$(".Catalog").change(function () {
  $("#Category22").change(function () {
    $("#txtNewCategory1").val($(this).find("option:selected").text());
    var category2Id = $("#Category22").val();
    var btn = $(this);
    $("#btnNewCategory1").click(function () {
      let category2 = {
        id: category2Id

      };
      $.ajax({
        url: "/Admin/CatalogWithCategory/Category2Remove/",
        type: "post",
        data: category2,
        success: function () {
          $("#txtNewCategory1").val("");
        
          alert("Kategoriya Silindi");
        }
      });
    });
  });
});








$(function () {
  $("#Category3").change(function () {

    $("#txtNewCategory2").val($(this).find("option:selected").text());
    var categoryId = $("#Category3").val();
    $("#btnNewCategory2").click(function () {
      let category = {
        id: categoryId,

      };
      $.ajax({
        url: "/Admin/CatalogWithCategory/CategoryRemove/",
        type: "post",
        data: category,
        success: function () {
          $("#txtNewCategory2").val("");

          alert("Kategoriya Silindi");
        }
      });
    });
  });

});
