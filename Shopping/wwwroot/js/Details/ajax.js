$(document).ready(function () {
	ViewList();
	CartList();
	CommentList();
	LikeList();

});
var userId = $(".OwnerName").data("id");
var memberId = $("#btnLike").data("id");

function ViewList() {
	let viewList = {
		id: $("#productId").html()
	};
	$.ajax({
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "Get",
		url: "/ProductView/ViewList/",
		data: viewList,
		success: function (func7) {
			let result = jQuery.parseJSON(func7);

			$.each(result, (index, value) => {
				$("#ProductViewDinamic").attr('data-id', value.ViewId);
				$("#ProductViewDinamic").html(value.NumberOfProductViews);
				$("#productId").attr('data-id', value.ProductId);

			});
			if ($("#productId").data("id") == null || $("#productId").data("id") != $("#productId").html()) {
				ViewAdd();
			} else {
				$("#ProductViewDinamic").html(function (i, val) {
					return val * 1 + 1
				});
				ViewUpdate();
			}

		}
	});
};
function ViewUpdate() {
	let viewUpdate = {
		ViewId: $("#ProductViewDinamic").data("id"),
		ProductId: $("#productId").html(),
		NumberOfProductViews: $("#ProductViewDinamic").html()

	};
	$.ajax({
		type: "post",
		url: "/ProductView/ViewUpdate/",
		data: viewUpdate,
		success: function (func) {
			let result = jQuery.parseJSON(func);

		}
	});
};
function ViewAdd() {
	let viewAdd = {
		ProductId: $("#productId").html()

	};
	$.ajax({
		type: "post",
		url: "/ProductView/ViewAdd/",
		data: viewAdd,
		success: function (func) {
			let result = jQuery.parseJSON(func);

		}
	});
};

$("#btnSelectProduct").click(function () {
	let cart = {
		ProductId: $("#productId").html()
	};
	$.ajax({
		type: "post",
		url: "/Member/Cart/CartAdd/",
		data: cart,
		success: function (func) {
			let result = jQuery.parseJSON(func);
			CartList();
			AllcartList();
		}
	});
});

$("#btnComment").click(function () {
	let comment = {
		ProductId: $("#productId").html(),
		ProductCommentContent: $("#textComment").val()
	};
	$.ajax({
		type: "post",
		url: "/ProductComment/CommentAdd/",
		data: comment,
		success: function (func) {
			let result = jQuery.parseJSON(func);
			CommentList();
			NotificationCommentAdd();
		}
	});

});

function CommentList() {
	let c = {
		id: $("#productId").html()
	};
	$.ajax({
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "Get",
		url: "/ProductComment/CommentList/",
		data: c,
		success: function (func2) {
			let result = jQuery.parseJSON(func2);
			let tablehtml = '<li class=Commentli>';
			$.each(result, (index, value) => {
				tablehtml += '<span class=CommentSendDate><i class=fa fa-solid fa-clock></i>' + value.ProductCommentDate + '</span><label class=CommentOwnerName>' + value.CommentOwnerName + '<i class=fa fa-check-circle CommentOwnerConfirmed></i><span class=CommentOwnerTooltip>Təsdiqləndi</span></label><p class=CommentContent>' + value.ProductCommentContent + '</p>'
				$(".CommentCountLi").html('<span class="CommentCount">Reyler(' + result.length + ')</span>');

			});

			tablehtml += '</li>';

			$(".CommentUl").html(tablehtml);
		}
	});
};

function CartList() {
	let cart = {
		id: $("#productId").html()
	};
	$.ajax({
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "Get",
		url: "/Member/Cart/CartList/",
		data: cart,
		success: function (func4) {
			let result = jQuery.parseJSON(func4);
			let tablehtml2 = '<tr>';
			$.each(result, (index, value) => {
				AllcartList();
				if (value.ProductId == $("#productId").html()) {
					$("#SelectedDiv").html('<button type="button" class="SelectProduct" id="btnDeSelectProduct"><i class="fa fa-heart HeartWarning" id="SelectIcon"></i> Elani Secilmislerin arasina elave et !</button>');
					var cartid = value.CartId;
					$("#btnDeSelectProduct").click(function () {

						$.ajax({
							type: "post",
							url: "/Member/Cart/MyCartDelete/" + cartid,
							success: function (func) {
								AllcartList();
								$("#SelectedDiv").html('<button type="button" class="SelectProduct" id="btnSelectProduct"><i class="fa-regular fa-heart HeartWarning" id="SelectIcon"></i> Elani Secilmislerin arasina elave et !</button>');
								$("#btnSelectProduct").click(function () {
									let cart = {
										ProductId: $("#productId").html()
									};
									$.ajax({
										type: "post",
										url: "/Member/Cart/CartAdd/",
										data: cart,
										success: function (func) {
											let result = jQuery.parseJSON(func);
											CartList();
											AllcartList();
											$("#SelectedDiv").html('<button type="button" class="DeSelectProduct" id="btnSelectProduct"><i class="fa fa-heart HeartWarning" id="SelectIcon"></i> Elani Secilmislerin arasina elave et !</button>');
										}
									});
								});
							}
						});
					});
				}

				tablehtml2 += '<td>' + value.CartId + '</td>'
			});
			tablehtml2 += '</tr>';
			$("#cartList").html(tablehtml2);

		}
	});

};


$("#btnLike").click(function () {
	let like = {
		ProductId: $("#productId").html(),
		AppUserId: userId
	};
	$.ajax({
		type: "post",
		url: "/ProductLike/LikeAdd/",
		data: like,
		success: function (func) {
			let result = jQuery.parseJSON(func);
			LikeList();
			NotificationLike();
		}
	});
});


function LikeList() {
	let like = {
		id: $("#productId").html(),

	};
	$.ajax({
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "Get",
		url: "/ProductLike/LikeList/",
		data: like,
		success: function (func5) {
			let result = jQuery.parseJSON(func5);
			$.each(result, (index, value) => {
				$("#likeSpan").html(result.length);
				if (value.ProductId == $("#productId").html() && value.MemberId == memberId) {
					$("#likeBtnDiv").html('<button class="SelectProduct LikeButton" id="btnLikeDel"  > <i class="fas fa-thumbs-up" style="color:blue"></i>  Bəyən</button>');

				}
			});


		}
	});

};


function NotificationLike() {
	let notification = {
		ProductId: $("#productId").html(),
		ProductName: $("#ProductName").html(),
		MemberId: userId
	};
	$.ajax({
		type: "post",
		url: "/Member/Notification/DetailLikeAdd/",
		data: notification,
		success: function (func) {
			let result = jQuery.parseJSON(func);
		}
	});
};
function NotificationCommentAdd() {
	let notification = {
		ProductId: $("#productId").html(),
		ProductName: $("#ProductName").html(),
		MemberId: userId,
		Content: $("#textComment").val()
	};
	$.ajax({
		type: "post",
		url: "/Member/Notification/DetailCommentAdd/",
		data: notification,
		success: function (func) {
			let result = jQuery.parseJSON(func);
		}
	});
};


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