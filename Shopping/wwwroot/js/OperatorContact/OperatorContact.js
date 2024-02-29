var MessageMenuDiv = document.querySelector(".MessageMenuDiv");
var MessageTopMenuIcon = document.querySelector(".MessageTopMenuIcon");


MessageTopMenuIcon.addEventListener('click',function(){
if(MessageTopMenuIcon.className=='fa-solid fa-bars MessageTopMenuIcon'){
    MessageMenuDiv.style.left="770px"
    MessageTopMenuIcon.className="fa fa-bars-staggered MessageTopMenuIcon"
    MessageMenuDiv.style.transition="0.5s"
}else{
   
    MessageMenuDiv.style.left="1050px"
    MessageTopMenuIcon.className="fa-solid fa-bars MessageTopMenuIcon"
    MessageMenuDiv.style.transition="0.5s"
}
});
