let LayoutCatalogDiv = document.querySelector(".LayoutCatalogDiv");
let LayoutCatalogShowIcon = document.querySelector(".LayoutCatalogShowIcon");
var LayoutNotification=document.querySelector(".LayoutNotification");
var LayoutBarsIcon=document.querySelector(".LayoutBarsIcon");



LayoutCatalogShowIcon.addEventListener('click',function(){
if(LayoutCatalogDiv.style.display=="block"){
  LayoutCatalogDiv.style.display="none";
}else{
  LayoutCatalogDiv.style.display="block";
if( LayoutBarsIcon.className=="fa fa-bars-staggered LayoutBarsIcon"){
    LayoutBarsIcon.click();
    if(window.innerWidth >= 600){
        LayoutCatalogDiv.style.top="20px";

    }else if(window.innerWidth <=600){
        LayoutCatalogDiv.style.top="-10px";

    }
} 
document.querySelector(".LayoutMemberBellCommentDiv").style.display="none";
}
});
var RenderBody = document.querySelector(".RenderBody");

RenderBody.addEventListener('click',function(){
    LayoutCatalogDiv.style.display="none"
});

const LayoutCatalogAll = document.querySelector(".LayoutCatalogAll"),
firstImg = LayoutCatalogAll.querySelectorAll(".LayoutCatalogImg")[0],
arrowIcons = document.querySelectorAll(".LayoutCatalogDiv i");

let isDragStart = false, isDragging = false, prevPageX, prevScrollLeft, positionDiff;

const showHideIcons = () => {
    // showing and hiding prev/next icon according to carousel scroll left value
    let scrollWidth = LayoutCatalogAll.scrollWidth - LayoutCatalogAll.clientWidth; // getting max scrollable width
    arrowIcons[0].style.display = LayoutCatalogAll.scrollLeft == 0 ? "none" : "block";
    arrowIcons[1].style.display = LayoutCatalogAll.scrollLeft == scrollWidth ? "none" : "block";
}

arrowIcons.forEach(icon => {
    icon.addEventListener("click", () => {
        let firstImgWidth = firstImg.clientWidth + 14; // getting first img width & adding 14 margin value
        // if clicked icon is left, reduce width value from the carousel scroll left else add to it
        LayoutCatalogAll.scrollLeft += icon.id == "left" ? -firstImgWidth : firstImgWidth;
        setTimeout(() => showHideIcons(), 60); // calling showHideIcons after 60ms
    });
});

const autoSlide = () => {
    // if there is no image left to scroll then return from here
    if(LayoutCatalogAll.scrollLeft - (LayoutCatalogAll.scrollWidth - LayoutCatalogAll.clientWidth) > -1 || LayoutCatalogAll.scrollLeft <= 0) return;

    positionDiff = Math.abs(positionDiff); // making positionDiff value to positive
    let firstImgWidth = firstImg.clientWidth + 14;
    // getting difference value that needs to add or reduce from carousel left to take middle img center
    let valDifference = firstImgWidth - positionDiff;

    if(LayoutCatalogAll.scrollLeft > prevScrollLeft) { // if user is scrolling to the right
        return LayoutCatalogAll.scrollLeft += positionDiff > firstImgWidth / 3 ? valDifference : -positionDiff;
    }
    // if user is scrolling to the left
    LayoutCatalogAll.scrollLeft -= positionDiff > firstImgWidth / 3 ? valDifference : -positionDiff;
}

const dragStart = (e) => {
    // updatating global variables value on mouse down event
    isDragStart = true;
    prevPageX = e.pageX || e.touches[0].pageX;
    prevScrollLeft = LayoutCatalogAll.scrollLeft;
}

const dragging = (e) => {
    // scrolling images/carousel to left according to mouse pointer
    if(!isDragStart) return;
    e.preventDefault();
    isDragging = true;
    LayoutCatalogAll.classList.add("dragging");
    positionDiff = (e.pageX || e.touches[0].pageX) - prevPageX;
    LayoutCatalogAll.scrollLeft = prevScrollLeft - positionDiff;
    showHideIcons();
}

const dragStop = () => {
    isDragStart = false;
    LayoutCatalogAll.classList.remove("dragging");

    if(!isDragging) return;
    isDragging = false;
    autoSlide();
}

LayoutCatalogAll.addEventListener("mousedown", dragStart);
LayoutCatalogAll.addEventListener("touchstart", dragStart);

document.addEventListener("mousemove", dragging);
LayoutCatalogAll.addEventListener("touchmove", dragging);

document.addEventListener("mouseup", dragStop);
LayoutCatalogAll.addEventListener("touchend", dragStop);