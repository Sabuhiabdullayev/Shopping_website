/*Product Select Start*/
$(".row").on("click", ".ProductListSelectBtn", function () {
	var btn = $(this);
	var id = btn.attr('data-id');


	let cart = {
		ProductId: id
	};
	$.ajax({
		type: "post",
		url: "/Member/Cart/CartAdd/",
		data: cart,
		success: function (func) {
			btn.removeClass().addClass("ProductListDeSelectBtn");
			btn.html('<i class="fa-regular fa-heart ProductListSelectIcon"><i class="fa fa-heart AddProductListSelectIcon"></i></i>');
			let cart = {
				id: id
			};
			$.ajax({
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				type: "Get",
				url: "/Member/Cart/CartList/",
				data: cart,
				success: function (func4) {
					let result = jQuery.parseJSON(func4);

					$.each(result, (index, value) => {

						var cartId = value.CartId;
						btn.attr('data-id', cartId);
						AllcartList();

					});
					$(".row").on("click", ".ProductListDeSelectBtn", function () {
						var btndelete = $(this);
						var deleteid = btndelete.attr('data-id');


						let cartdelete = {
							id: deleteid
						};
						$.ajax({
							contentType: "application/json; charset=utf-8",
							dataType: "json",
							type: "Get",
							url: "/Member/Cart/DeSelectCartList/",
							data: cartdelete,
							success: function (func4) {
								let result = jQuery.parseJSON(func4);

								$.each(result, (index, value) => {
									var ProductId = value.ProductId;
									$.ajax({
										type: "delete",
										url: "/Member/Cart/ProductDeSelect/" + deleteid,
										success: function (func) {
											btndelete.removeClass().addClass("ProductListSelectBtn");
											btndelete.html('<i class="fa-regular fa-heart ProductListSelectIcon"></i>');

											btndelete.attr('data-id', ProductId);
											AllcartList();

										}

									});
								});
							}
						});

					});

				}

			});

		}
	});
});
$(".row").on("click", ".ProductListDeSelectBtn", function () {
	var btndelete = $(this);
	var deleteid = btndelete.data("id");
	let cartdelete = {
		id: deleteid
	};
	$.ajax({
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "Get",
		url: "/Member/Cart/DeSelectCartList/",
		data: cartdelete,
		success: function (func4) {
			let result = jQuery.parseJSON(func4);

			$.each(result, (index, value) => {
				var ProductId = value.ProductId;
				$.ajax({
					type: "delete",
					url: "/Member/Cart/ProductDeSelect/" + deleteid,
					success: function (func) {
						btndelete.removeClass().addClass("ProductListSelectBtn");
						btndelete.html('<i class="fa-regular fa-heart ProductListSelectIcon"></i>');

						btndelete.attr('data-id', ProductId);
						AllcartList();

					}

				});
			});
		}
	});


});

function AllcartList() {
	$.ajax({
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "Get",
		url: "/Member/Cart/MyAllCartList/",
		success: function (func4) {
			let result = jQuery.parseJSON(func4);
			$(".ProductSelectCount").html(result.length);

		}
	});
};
/*Product Select Stop*/
/*My Cart List Start*/
$("#SelectTable").on("click", ".SelectProduct", function () {
	var btn = $(this);
	var id = btn.data("id");
	$.ajax({

		url: "/Member/Cart/MyCartDelete/" + id,
		type: "post",
		success: function () {
			$.ajax({
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				type: "Get",
				url: "/Member/Cart/MyAllCartList/",
				success: function (func4) {
					let result = jQuery.parseJSON(func4);
					$(".ProductSelectCount").html(result.length);

					if (result.length != 0) {
						$("#MyCartCount").html(result.length);
					} else {
						$("#MyCartDiv").html('<h4 style="text-align:center; justify-items:center; top:50px">Heç bir seçilmiş elan yoxdur</h4>');
					}
				}
			});
			btn.parent().remove();


		}
	});

});
/*My Cart List Stop*/