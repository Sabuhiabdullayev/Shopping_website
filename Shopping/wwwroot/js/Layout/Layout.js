
var LayoutSidebar=document.querySelector(".LayoutSidebar");
var LayoutBarsIcon=document.querySelector(".LayoutBarsIcon");

LayoutBarsIcon.addEventListener('click',function(){
 if(LayoutBarsIcon.className=="fa-solid fa-bars LayoutBarsIcon"){
  if(window.innerWidth >= 800){
    document.querySelector(".LayoutCatalogDiv").style.display="none";
    LayoutTopbarWithFooter();
    LayoutSidebar.style.transition=".6s"
    LayoutSidebar.style.left="0px"
    LayoutBarsIcon.className="fa fa-bars-staggered LayoutBarsIcon"
    document.querySelector(".RenderBody").style.top="5px";
    document.querySelector(".RenderBody").style.opacity="0.3"
    document.querySelector(".RenderBody").style.padding="0 0 20px 0"
    document.querySelector(".RenderBody").style.overflow="hidden"
    LayoutMemberBellCommentDiv.style.display="none";
    LayoutFooterDiv.style.height="60px";
    LayoutFooterDiv.style.margin="10px 0 0 0";
    document.querySelector(".RenderBody").style.height="790px"

  }else{
    LayoutTopbarWithFooter();
    LayoutSidebar.style.transition=".6s"
    LayoutSidebar.style.left="0px"
    document.querySelector(".LayoutCatalogDiv").style.top="5px";
    LayoutBarsIcon.className="fa fa-bars-staggered LayoutBarsIcon"
    document.querySelector(".RenderBody").style.top="5px"
    document.querySelector(".RenderBody").style.opacity="0.3"
    document.querySelector(".RenderBody").style.height="920px"
    document.querySelector(".RenderBody").style.padding="0 0 20px 0"
    document.querySelector(".RenderBody").style.overflow="hidden"
    LayoutMemberBellCommentDiv.style.display="none";
    LayoutFooterDiv.style.height="60px";
    LayoutFooterDiv.style.margin="10px 0 0 0";
  }
 


 }else{
  LayoutSidebar.style.left="-300px"
  LayoutSidebar.style.transition=".6s"
  LayoutBarsIcon.className="fa-solid fa-bars LayoutBarsIcon"
  document.querySelector(".RenderBody").style.opacity="1"
  document.querySelector(".RenderBody").style.height="auto"
  document.querySelector(".RenderBody").style.top="5px"
  document.querySelector(".RenderBody").style.overflowY="auto"

  
 }
});
window.onwheel = e => {
  if(LayoutBarsIcon.className=="fa-solid fa-bars LayoutBarsIcon")
  {
    if(e.deltaY >= 0){
      // Scrolling Down with mouse
      LayoutTopbarWithFooter();
      RenderBody.style.top=("5px");
      LayoutMemberBellCommentDiv.style.top="auto";
      RenderBody.style.height=("auto");
      LayoutFooterDiv.style.margin="10px 0 0 0";
      LayoutFooterDiv.style.top="auto";
      if(window.innerWidth >= 800){
        document.querySelector(".LayoutCatalogDiv").style.top="20px";

      }else{
        document.querySelector(".LayoutCatalogDiv").style.top="-6px";

      }



    } else {
     // Scrolling Up with mouse
      LayoutFooterDiv.style.margin="140px 0 0 0";
    LayoutTopbarWithFooters();
      RenderBody.style.top=("135px");
      LayoutFooterDiv.style.top="auto";
      LayoutMemberBellCommentDiv.style.top="130px";

      if(window.innerWidth >= 800){
        document.querySelector(".LayoutCatalogDiv").style.top="148px";

      }else{
        document.querySelector(".LayoutCatalogDiv").style.top="125px";

      }


    }
  }
 
}

var LayoutMemberBellCommentDiv=document.querySelector(".LayoutMemberBellCommentDiv");
var LayoutNotification=document.querySelector(".LayoutNotification");

LayoutNotification.addEventListener('click',function(){
  if(LayoutMemberBellCommentDiv.style.display=="block"){
    LayoutMemberBellCommentDiv.style.display="none"
  }else{
    document.querySelector(".LayoutCatalogDiv").style.display="none";
    LayoutMemberBellCommentDiv.style.display="block"
    LayoutSidebar.style.transition=".6s"
    LayoutSidebar.style.left="-300px"
    LayoutBarsIcon.className="fa-solid fa-bars LayoutBarsIcon"
    document.querySelector(".RenderBody").style.opacity="1"
    document.querySelector(".RenderBody").style.height="auto"
    document.querySelector(".RenderBody").style.overflowY="auto"
  }
});

var LayoutFooterDiv = document.querySelector(".LayoutFooterDiv");
var LayoutMobileFooter = document.querySelector(".LayoutMobileFooter");
var TopbarDiv = document.querySelector(".TopbarDiv");

var RenderBody = document.querySelector(".RenderBody");

RenderBody.addEventListener('click',function(){
  LayoutSidebar.style.left="-300px"
  LayoutBarsIcon.className="fa-solid fa-bars LayoutBarsIcon"
  document.querySelector(".RenderBody").style.opacity="1"
LayoutMemberBellCommentDiv.style.display="none"
document.querySelector(".RenderBody").style.height="auto"
document.querySelector(".RenderBody").style.overflowY="auto"
});




function LayoutTopbarWithFooter(){
  TopbarDiv.classList.remove("TopbarDivs");
  TopbarDiv.classList.add("TopbarDiv");
  LayoutMobileFooter.classList.remove("LayoutMobileFooters");
  LayoutMobileFooter.classList.add("LayoutMobileFooter");
}
function LayoutTopbarWithFooters(){
  TopbarDiv.classList.remove("TopbarDiv");
      TopbarDiv.classList.add("TopbarDivs");
      LayoutMobileFooter.classList.remove("LayoutMobileFooter");
      LayoutMobileFooter.classList.add("LayoutMobileFooters");
}

if(window.innerWidth >= 800){
  var ProductAddShowBtn = document.querySelector(".ProductAdd");
  var PrivateWithShopBtnDiv=document.querySelector(".PrivateWithShopProductAddDiv");
  
  ProductAddShowBtn.addEventListener('click',function(){
  
      PrivateWithShopBtnDiv.style.display="block";
    
  });
  
}
