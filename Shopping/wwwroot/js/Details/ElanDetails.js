$('.LikeButton').click(function() {
    $('.likecountspan').html(function(i, val) { 
      return val*1+1
   
    });
    
    document.querySelector(".LikeButton").style.color="blue";
});

